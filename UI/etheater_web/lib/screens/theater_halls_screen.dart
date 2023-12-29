import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/hall_provider.dart';
import 'package:etheater_web/widgets/modals/halls/add_hall_modal.dart';
import 'package:etheater_web/widgets/modals/halls/edit_hall_modal.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class TheaterHalls extends StatefulWidget {
  const TheaterHalls({super.key});

  @override
  State<TheaterHalls> createState() => _TheaterHallsState();
}

class _TheaterHallsState extends State<TheaterHalls> {
  HallProvider? _hallProvider;
  List<Hall>? _halls;
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _hallProvider = context.read<HallProvider>();
    loadData();
  }

  void loadData() async {
    var data = await _hallProvider!.get({'Name': _searchController.text});
    setState(() {
      _halls = data;
    });
  }

  void resetSearch() {
    _searchController.text = '';
  }

  void handleEdit(int id, dynamic request) async {
    await _hallProvider!.update(id, request);
    if (context.mounted) {
      Navigator.pop(context);
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('You have successfully modified the hall!'),
        ),
      );
    }
  }

  void openEditModal(Hall h) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return EditHallModal(hall: h, handleEdit: handleEdit);
      },
    );
  }

  void openDeleteModal(Hall h) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Deleting a hall'),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text('Are you sure you want to delete the hall?'),
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
                  await _hallProvider!.remove(h.hallId);
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
                        content: Text('You cannot delete a hall !'),
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
    await _hallProvider!.insert(request);
    if (context.mounted) {
      Navigator.pop(context);
      resetSearch();
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('You have successfully added a new hall!'),
        ),
      );
    }
  }

  void openAddModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AddHallModal(handleAdd: handleAdd);
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_halls == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      body: Column(
        children: [
          Row(
            children: [
              const SizedBox(width: 16.0),
              Expanded(
                child: TextFormField(
                  controller: _searchController,
                  decoration: const InputDecoration(
                    labelText: 'Hall',
                    hintText: 'Enter the name of the hall',
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
            width: double.infinity,
            child: SingleChildScrollView(
              child: DataTable(
                columnSpacing: 0,
                columns: const [
                  DataColumn(label: Text('Name')),
                  DataColumn(label: Text('Total seats'), numeric: true),
                  DataColumn(label: Text('Total rows'), numeric: true),
                  DataColumn(
                      label: Text('Number of seats per row'), numeric: true),
                  DataColumn(
                    numeric: false,
                    label: Expanded(
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [Text("Edit")],
                      ),
                    ),
                  ),
                  DataColumn(
                    numeric: false,
                    label: Expanded(
                      child: Row(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [Text("Delete")],
                      ),
                    ),
                  ),
                ],
                rows: _halls!.isNotEmpty
                    ? _halls!.map((hall) {
                        return DataRow(
                          cells: [
                            DataCell(
                              Tooltip(
                                message: hall.name,
                                child: Text(
                                  hall.name.length > 20
                                      ? "${hall.name.substring(0, 20)} ..."
                                      : hall.name,
                                ),
                              ),
                            ),
                            DataCell(Text(hall.totalSeats.toString())),
                            DataCell(Text(hall.totalRows.toString())),
                            DataCell(Text(hall.numberOfSeatsPerRow.toString())),
                            DataCell(
                              Center(
                                child: IconButton(
                                  icon: Icon(Icons.edit,
                                      color: Theme.of(context).primaryColor),
                                  onPressed: () {
                                    openEditModal(hall);
                                  },
                                ),
                              ),
                            ),
                            DataCell(
                              Center(
                                child: IconButton(
                                  icon: const Icon(Icons.delete,
                                      color: Colors.red),
                                  onPressed: () {
                                    openDeleteModal(hall);
                                  },
                                ),
                              ),
                            ),
                          ],
                        );
                      }).toList()
                    : [
                        const DataRow(cells: [
                          DataCell(Text('')),
                          DataCell(Text('')),
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
    );
  }
}
