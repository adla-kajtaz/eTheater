import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:etheater_web/widgets/modals/notifications/add_notification_modal.dart';
import 'package:etheater_web/widgets/modals/notifications/edit_notification_modal.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class NotificationScreen extends StatefulWidget {
  const NotificationScreen({super.key});

  @override
  State<NotificationScreen> createState() => _NotificationScreenState();
}

class _NotificationScreenState extends State<NotificationScreen> {
  NotificationProvider? _notificationProvider;
  UserProvider? _userProvider;
  User? _user;
  List<NotificationEtheater>? _notifications;
  final TextEditingController _searchController = TextEditingController();
  String _notificationCategory = 'All';

  @override
  void initState() {
    super.initState();
    _notificationProvider = context.read<NotificationProvider>();
    _userProvider = context.read<UserProvider>();
    loadData();
  }

  void loadData() async {
    String notificationCategory =
        _notificationCategory == 'All' ? '' : _notificationCategory;
    dynamic request = {
      'NotificationCategory': notificationCategory,
      'Title': _searchController.text
    };
    var data = await _notificationProvider!.get(request);
    var user = await _userProvider!.getMe();
    setState(() {
      _notifications = data;
      _user = user;
    });
  }

  void resetSearch() {
    _searchController.text = '';
    _notificationCategory = 'All';
  }

  void handleEdit(int id, String title, String content,
      int notificationCategory, String picture) async {
    dynamic request = {
      'title': title,
      'content': content,
      'picture': picture,
      'notificationCategory': notificationCategory,
      'userId': _user!.id,
    };
    await _notificationProvider!.update(id, request);
    if (context.mounted) {
      Navigator.pop(context);
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          backgroundColor: Color.fromARGB(249, 21, 136, 38),
          content: Text('You have successfully modified the notification!'),
        ),
      );
    }
  }

  void openEditModal(NotificationEtheater n) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return EditNotificationModal(notification: n, handleEdit: handleEdit);
      },
    );
  }

  void openDeleteModal(NotificationEtheater n) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Deleting a notification'),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text(
                'Are you sure you want to delete the notification?',
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
                  await _notificationProvider!.remove(n.notificationId);
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
                        content: Text('You cannot delete a notification!'),
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

  void handleAdd(String title, String content, int notificationCategory,
      String picture) async {
    dynamic request = {
      'title': title,
      'content': content,
      'picture': picture,
      'notificationCategory': notificationCategory,
      'userId': _user!.id,
    };
    await _notificationProvider!.insert(request);
    if (context.mounted) {
      Navigator.pop(context);
      resetSearch();
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          backgroundColor: Color.fromARGB(249, 21, 136, 38),
          content: Text('You have successfully added a new notification!'),
        ),
      );
    }
  }

  void openAddModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AddNotificationModal(handleAdd: handleAdd);
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_notifications == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      body: SingleChildScrollView(
        child: Padding(
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
                        labelText: 'Notification',
                        hintText: 'Enter the title of the notification',
                      ),
                    ),
                  ),
                  const SizedBox(width: 16.0),
                  Expanded(
                    child: DropdownButtonFormField<String>(
                      iconEnabledColor: const Color.fromARGB(255, 204, 36, 68),
                      dropdownColor: const Color.fromARGB(255, 51, 51, 52),
                      style: const TextStyle(
                          color: Color.fromARGB(255, 250, 250, 250)),
                      decoration: const InputDecoration(
                        labelText: 'Notification category',
                        labelStyle: TextStyle(
                            color: Color.fromARGB(255, 144, 135, 135)),
                        enabledBorder: UnderlineInputBorder(
                          borderSide: BorderSide(
                              color: Color.fromARGB(255, 144, 135, 135)),
                        ),
                      ),
                      value: _notificationCategory,
                      onChanged: (value) {
                        setState(() {
                          _notificationCategory = value ?? 'All';
                        });
                      },
                      items: <String>[
                        'All',
                        'Novost',
                        'Ponude',
                        'Obavijest',
                      ].map<DropdownMenuItem<String>>((String value) {
                        return DropdownMenuItem<String>(
                          value: value,
                          child: Text(value),
                        );
                      }).toList(),
                    ),
                  ),
                  const SizedBox(width: 16.0, height: 16),
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
                    DataColumn(label: Text('Title')),
                    DataColumn(label: Text('Created at')),
                    DataColumn(label: Text('Notification category')),
                    DataColumn(label: Text('User')),
                    DataColumn(label: Text('Edit')),
                    DataColumn(label: Text('Delete')),
                  ],
                  rows: _notifications!.isNotEmpty
                      ? _notifications!.map((notification) {
                          return DataRow(cells: [
                            DataCell(
                              Tooltip(
                                message: notification.title,
                                child: Text(
                                  notification.title.length > 20
                                      ? "${notification.title.substring(0, 20)} ..."
                                      : notification.title,
                                ),
                              ),
                            ),
                            DataCell(Text(notification.createdAt
                                .toString()
                                .substring(0, 10))),
                            DataCell(
                              Text(
                                notification.notificationCategory.name,
                              ),
                            ),
                            DataCell(Text(notification.user!.userName)),
                            DataCell(IconButton(
                              icon: Icon(Icons.edit,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                openEditModal(notification);
                              },
                            )),
                            DataCell(IconButton(
                              icon: const Icon(Icons.delete, color: Colors.red),
                              onPressed: () {
                                openDeleteModal(notification);
                              },
                            )),
                          ]);
                        }).toList()
                      : [
                          const DataRow(cells: [
                            DataCell(Text('')),
                            DataCell(Text('')),
                            DataCell(Center(child: Text('No search results'))),
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
      ),
    );
  }
}
