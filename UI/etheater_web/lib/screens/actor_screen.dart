import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:etheater_web/widgets/modals/actors/add_actor_modal.dart';
import 'package:etheater_web/widgets/modals/actors/edit_actor_modal.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ActorScreen extends StatefulWidget {
  const ActorScreen({super.key});

  @override
  State<ActorScreen> createState() => _ActorScreenState();
}

class _ActorScreenState extends State<ActorScreen> {
  ActorProvider? _actorProvider;
  List<Actor>? _actors;
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _actorProvider = context.read<ActorProvider>();
    loadData();
  }

  void loadData() async {
    var data = await _actorProvider!.get({'Name': _searchController.text});
    setState(() {
      _actors = data;
    });
  }

  void resetSearch() {
    _searchController.text = '';
  }

  void handleEdit(int id, String firstName, String lastName) async {
    await _actorProvider!
        .update(id, {'firstName': firstName, 'lastName': lastName});
    if (context.mounted) {
      Navigator.pop(context);
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          backgroundColor: Color.fromARGB(249, 21, 136, 38),
          content: Text('You have successfully modified the actor!'),
        ),
      );
    }
  }

  void openEditModal(Actor a) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return EditActorModal(
          actor: a,
          handleEdit: handleEdit,
        );
      },
    );
  }

  void openDeleteModal(Actor a) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Deleting an actor'),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text(
                'Are you sure you want to delete the actor?',
                style: TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              ),
            ],
          ),
          actions: [
            TextButton(
              onPressed: () {
                Navigator.pop(context);
              },
              child: const Text(
                'Cancel',
                style: TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              ),
            ),
            ElevatedButton(
              onPressed: () async {
                try {
                  await _actorProvider!.remove(a.actorId);
                  if (context.mounted) {
                    Navigator.pop(context);
                    loadData();
                  }
                } catch (e) {
                  if (context.mounted) {
                    Navigator.pop(context);
                    ScaffoldMessenger.of(context).showSnackBar(
                      const SnackBar(
                        backgroundColor: Colors.red,
                        content: Text(
                            'You cannot delete an actor because he is already participating in a play!'),
                      ),
                    );
                  }
                }
              },
              child: const Text(
                'Delete',
                style: TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              ),
            ),
          ],
        );
      },
    );
  }

  void handleAdd(String firstName, String lastName) async {
    await _actorProvider!
        .insert({'firstName': firstName, 'lastName': lastName});
    if (context.mounted) {
      Navigator.pop(context);
      resetSearch();
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          backgroundColor: Color.fromARGB(249, 21, 136, 38),
          content: Text('You have successfully added a new actor!'),
        ),
      );
    }
  }

  void openAddModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AddActorModal(handleAdd: handleAdd);
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_actors == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      body: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 16),
        child: Column(
          children: [
            Row(
              children: [
                const SizedBox(width: 16.0),
                Expanded(
                  child: TextFormField(
                    controller: _searchController,
                    style: const TextStyle(
                        color: Color.fromARGB(255, 250, 250, 250)),
                    decoration: const InputDecoration(
                      labelText: 'Actor',
                      hintText: 'Enter the name of the actor',
                    ),
                  ),
                ),
                const SizedBox(width: 16.0),
                ElevatedButton(
                  onPressed: () {
                    loadData();
                  },
                  child: const Text('Search'),
                ),
                const SizedBox(width: 16.0),
                ElevatedButton(
                  onPressed: () {
                    openAddModal();
                  },
                  child: const Text('+'),
                ),
                const SizedBox(width: 16.0),
              ],
            ),
            const SizedBox(height: 16),
            SizedBox(
              height: 520,
              width: double.infinity,
              child: SingleChildScrollView(
                child: DataTable(
                  columns: const [
                    DataColumn(label: Text('Fist name')),
                    DataColumn(label: Text('Last name')),
                    DataColumn(label: Text('Edit')),
                    DataColumn(label: Text('Delete')),
                  ],
                  rows: _actors!.isNotEmpty
                      ? _actors!.map((actor) {
                          return DataRow(cells: [
                            DataCell(Text(actor.firstName)),
                            DataCell(Text(actor.lastName)),
                            DataCell(IconButton(
                              icon: Icon(Icons.edit,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                openEditModal(actor);
                              },
                            )),
                            DataCell(IconButton(
                              icon: const Icon(Icons.delete, color: Colors.red),
                              onPressed: () {
                                openDeleteModal(actor);
                              },
                            )),
                          ]);
                        }).toList()
                      : [
                          const DataRow(cells: [
                            DataCell(Text('')),
                            DataCell(Center(child: Text('No search results'))),
                            DataCell(Text('')),
                            DataCell(Text('')),
                          ])
                        ],
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
