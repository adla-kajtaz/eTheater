import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:etheater_web/screens/screens.dart';
import 'package:etheater_web/widgets/modals/shows/add_actor_show_modal.dart';
import 'package:etheater_web/widgets/modals/shows/add_show_modal.dart';
import 'package:etheater_web/widgets/modals/shows/edit_show_modal.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ShowScreen extends StatefulWidget {
  const ShowScreen({super.key});

  @override
  State<ShowScreen> createState() => _ShowScreenState();
}

class _ShowScreenState extends State<ShowScreen> {
  ShowProvider? _showProvider;
  List<Show>? _shows;
  final TextEditingController _searchController = TextEditingController();
  String _showGenre = 'All';

  @override
  void initState() {
    super.initState();
    _showProvider = context.read<ShowProvider>();
    loadData();
  }

  void loadData() async {
    String showGenre = _showGenre == 'All' ? '' : _showGenre;
    dynamic request = {
      'ShowGenre': showGenre,
      'Name': _searchController.text
    };
    var data = await _showProvider!.get(request);
    setState(() {
      _shows = data;
    });
  }

  void resetSearch() {
    _searchController.text = '';
    _showGenre = 'All';
  }

  void handleEdit(int id, dynamic request) async {
    await _showProvider!.update(id, request);
    if (context.mounted) {
      Navigator.pop(context);
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('You have successfully modified the show!'),
        ),
      );
    }
  }

  void openEditModal(Show s) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return EditShowModal(show: s, handleEdit: handleEdit);
      },
    );
  }

  void openDeleteModal(Show s) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Deleting a show'),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text('Are you sure you want to delete the show?'),
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
                  await _showProvider!.remove(s.showId);
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
                            'You cannot delete a show!'),
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

  void handleAdd(dynamic request) async {
    var response = await _showProvider!.insert(request);
    if (context.mounted) {
      Navigator.pop(context);
      showDialog(
        barrierDismissible: false,
        context: context,
        builder: (BuildContext context) {
          return AddActorShowModal(
            showName: response!.name,
            showId: response.showId,
          );
        },
      );
      resetSearch();
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('You have successfully added a new show!'),
        ),
      );
    }
  }

  void openAddModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AddShowModal(handleAdd: handleAdd);
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_shows == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      body: SingleChildScrollView(
        child: Column(
          children: [
            Row(
              children: [
                const SizedBox(width: 16.0),
                Expanded(
                  child: TextFormField(
                    controller: _searchController,
                    decoration: const InputDecoration(
                      labelText: 'Show',
                      hintText: 'Enter the name of the show',
                    ),
                  ),
                ),
                const SizedBox(width: 16.0),
                 Expanded(
                  child:DropdownButtonFormField<String>(
                    decoration: InputDecoration(
                      labelText: 'Show genre',
                      labelStyle:
                          TextStyle(color: Theme.of(context).primaryColor),
                      enabledBorder: UnderlineInputBorder(
                        borderSide:
                            BorderSide(color: Theme.of(context).primaryColor),
                      ),
                    ),
                    value: _showGenre,
                    onChanged: (value) {
                      setState(() {
                        _showGenre = value ?? 'All';
                      });
          
                    },
                    items: <String>[
              'All',
              'Drama',
              'Komedija',
              'Opera',
              'Mjuzikl',
              'Balet',
            ].map<DropdownMenuItem<String>>((String value) {
              return DropdownMenuItem<String>(
                value: value,
                child: Text(value),
              );
              }).toList(),
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
              width: double.infinity,
              child: DataTable(
                columnSpacing: 0,
                columns: const [
                  DataColumn(label: Text('Name')),
                  DataColumn(label: Text('Duration')),
                  DataColumn(label: Text('Show genre')),
                  DataColumn(label: Text('Edit')),
                  DataColumn(label: Text('Delete')),
                  DataColumn(label: Text('Add actor')),
                  DataColumn(label: Text('Show actors')),
                  DataColumn(label: Text('Report')),
                ],
                rows: _shows!.isNotEmpty
                    ? _shows!.map((show) {
                        return DataRow(cells: [
                          DataCell(Text(show.name)),
                          DataCell(Text(show.duration.toString())),
                          DataCell(Text(show.showGenre.name)),
                          DataCell(
                            IconButton(
                              icon: Icon(Icons.edit,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                openEditModal(show);
                              },
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: const Icon(Icons.delete, color: Colors.red),
                              onPressed: () {
                                openDeleteModal(show);
                              },
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: Icon(Icons.person_add,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                showDialog(
                                  barrierDismissible: true,
                                  context: context,
                                  builder: (BuildContext context) {
                                    return AddActorShowModal(
                                      showName: show.name,
                                      showId: show.showId,
                                    );
                                  },
                                );
                              },
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: Icon(Icons.format_list_bulleted,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                Navigator.pushNamed(
                                  context,
                                  ActorListScreen.routeName,
                                  arguments: {
                                    'showId': show.showId,
                                    'name': show.name
                                  },
                                );
                              },
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: Icon(Icons.addchart,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                /*showDialog(
                                  context: context,
                                  builder: (BuildContext context) {
                                    return AlertDialog(
                                      title: const Text('Zarada po predstavi'),
                                      content: PredstavaZarada(
                                        predstavaId: predstava.predstavaId,
                                      ),
                                    );
                                  },
                                );*/
                              },
                            ),
                          ),
                        ]);
                      }).toList()
                    : [
                        const DataRow(cells: [
                          DataCell(Text('')),
                          DataCell(Text('')),
                          DataCell(Text('')),
                          DataCell(
                              Center(child: Text('No search results'))),
                          DataCell(Text('')),
                          DataCell(Text('')),
                          DataCell(Text('')),
                          DataCell(Text('')),
                        ])
                      ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
