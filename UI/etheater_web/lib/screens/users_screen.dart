import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:etheater_web/widgets/purchase_report.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class UsersScreen extends StatefulWidget {
  const UsersScreen({super.key});

  @override
  State<UsersScreen> createState() => _UsersScreenState();
}

class _UsersScreenState extends State<UsersScreen> {
  UserProvider? _userProvider;
  List<User>? _users;
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _userProvider = context.read<UserProvider>();
    loadData();
  }

  void loadData() async {
    var data = await _userProvider!.get({'UserName': _searchController.text});
    setState(() {
      _users = data;
    });
  }

  void resetSearch() {
    _searchController.text = '';
  }

  void openDeleteModal(User u) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Deleting a user'),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text(
                'Are you sure you want to delete the user?',
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
                  await _userProvider!.remove(u.id);
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
                        content: Text('You cannot delete a user!'),
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

  @override
  Widget build(BuildContext context) {
    if (_users == null) {
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
                  style: const TextStyle(
                      color: Color.fromARGB(255, 250, 250, 250)),
                  decoration: const InputDecoration(
                    labelText: 'User',
                    hintText: 'Enter the username',
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
            ],
          ),
          const SizedBox(height: 16),
          SizedBox(
            width: double.infinity,
            child: SingleChildScrollView(
              child: DataTable(
                columnSpacing: 0,
                columns: const [
                  DataColumn(label: Text('Username')),
                  DataColumn(label: Text('Email')),
                  DataColumn(label: Text('Delete')),
                  DataColumn(label: Text('Report')),
                ],
                rows: _users!.isNotEmpty
                    ? _users!.map((user) {
                        return DataRow(
                          cells: [
                            DataCell(
                              Tooltip(
                                message: user.userName,
                                child: Text(
                                  user.userName.length > 20
                                      ? "${user.userName.substring(0, 20)} ..."
                                      : user.userName,
                                ),
                              ),
                            ),
                            DataCell(Text(user.email.toString())),
                            DataCell(
                              IconButton(
                                icon:
                                    const Icon(Icons.delete, color: Colors.red),
                                onPressed: () {
                                  openDeleteModal(user);
                                },
                              ),
                            ),
                            DataCell(
                              IconButton(
                                icon: Icon(Icons.addchart,
                                    color: Theme.of(context).primaryColor),
                                onPressed: () {
                                  showDialog(
                                    context: context,
                                    builder: (BuildContext context) {
                                      return AlertDialog(
                                        title: const Text('Purchase report'),
                                        content: PurchaseReport(
                                          userId: user.id,
                                        ),
                                      );
                                    },
                                  );
                                },
                              ),
                            ),
                          ],
                        );
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
    );
  }
}
