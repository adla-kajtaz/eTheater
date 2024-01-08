import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ActorListScreen extends StatefulWidget {
  static const routeName = '/actor-list';
  final int showId;
  final String name;
  const ActorListScreen({
    super.key,
    required this.showId,
    required this.name,
  });

  @override
  State<ActorListScreen> createState() => _ActorListScreenState();
}

class _ActorListScreenState extends State<ActorListScreen> {
  ShowActorProvider? _showActorProvider;
  List<ShowActor>? _actors;
  late TextEditingController showController;

  @override
  void initState() {
    super.initState();
    _showActorProvider = context.read<ShowActorProvider>();
    showController = TextEditingController(text: widget.name);
    loadData();
  }

  void loadData() async {
    dynamic request = {
      'ShowId': widget.showId,
    };

    var data = await _showActorProvider!.get(request);
    setState(() {
      _actors = data;
    });
  }

  void openDeleteModal(ShowActor a) {
    if (_actors!.length == 1) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          backgroundColor: Colors.red,
          content: Text('The play must have at least one actor!'),
        ),
      );
      return;
    }
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Deleting an actor'),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text('Are you sure you want to delete the actor?'),
            ],
          ),
          actions: [
            TextButton(
              onPressed: () {
                Navigator.pop(context);
              },
              child: const Text('Cancel'),
            ),
            ElevatedButton(
              onPressed: () async {
                try {
                  await _showActorProvider!.remove(a.showActorId);
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
                        content: Text('You cannot delete an actor!'),
                      ),
                    );
                  }
                }
              },
              child: const Text(
                'Delete',
                style: TextStyle(color: Colors.red),
              ),
            ),
          ],
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_actors == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      appBar: AppBar(
        title: const Text('List of actors'),
      ),
      body: Column(
        children: [
          const SizedBox(height: 20),
          Row(
            children: [
              const SizedBox(width: 16.0),
              Expanded(
                child: TextFormField(
                  enabled: false,
                  controller: showController,
                  style: const TextStyle(
                      color: Color.fromARGB(255, 250, 250, 250)),
                  decoration: const InputDecoration(
                    labelText: 'Show',
                  ),
                ),
              ),
            ],
          ),
          const SizedBox(height: 16),
          SizedBox(
            height: 300,
            width: double.infinity,
            child: SingleChildScrollView(
              child: DataTable(
                columns: const [
                  DataColumn(label: Text('Actor')),
                  DataColumn(label: Text('Delete')),
                ],
                rows: _actors!.isNotEmpty
                    ? _actors!.map((actor) {
                        return DataRow(cells: [
                          DataCell(Text(
                              '${actor.actor!.firstName} ${actor.actor!.lastName}')),
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
                          DataCell(Center(child: Text('No search results'))),
                          DataCell(Text('')),
                        ])
                      ],
              ),
            ),
          ),
        ],
      ),
    );
  }
}
