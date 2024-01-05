import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';

class PurchasesScreen extends StatefulWidget {
  const PurchasesScreen({super.key});

  @override
  State<PurchasesScreen> createState() => _PurchasesScreenState();
}

class _PurchasesScreenState extends State<PurchasesScreen> {
  UserProvider? _userProvider;
  PurchaseProvider? _purchaseProvider;
  List<User> _users = [User(id: 0, userName: 'All', email: '')];
  User? _selectedUser;
  List<Purchase>? _purchases;

  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _purchaseProvider = context.read<PurchaseProvider>();
    _userProvider = context.read<UserProvider>();
    _selectedUser = _users[0];
    loadData();
    loadUsers();
  }

  void resetSearch() {
    _searchController.text = '';
    _selectedUser = _users[0];
  }

  void loadUsers() async {
    var data = await _userProvider!.get();
    setState(() {
      _users = [..._users, ...data];
    });
  }

  void loadData() async {
    dynamic request = {
      'UserId': _selectedUser!.id == 0 ? null : _selectedUser!.id,
      'PurchaseId': _searchController.text == ''
          ? null
          : int.parse(_searchController.text)
    };
    var data = await _purchaseProvider!.get(request);
    setState(() {
      _purchases = data;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (_purchases == null) {
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
                  keyboardType: TextInputType.number,
                  inputFormatters: [FilteringTextInputFormatter.digitsOnly],
                  decoration: const InputDecoration(
                    labelText: 'Purchase',
                    hintText: 'Enter the purchase ID',
                  ),
                ),
              ),
              const SizedBox(width: 16.0),
              Expanded(
                child: DropdownButtonFormField<User>(
                  decoration: InputDecoration(
                    labelText: 'User',
                    labelStyle:
                        TextStyle(color: Theme.of(context).primaryColor),
                    enabledBorder: UnderlineInputBorder(
                      borderSide:
                          BorderSide(color: Theme.of(context).primaryColor),
                    ),
                  ),
                  value: _selectedUser,
                  onChanged: (User? u) {
                    setState(() {
                      _selectedUser = u!;
                    });
                  },
                  items: _users.map<DropdownMenuItem<User>>((User u) {
                    return DropdownMenuItem<User>(
                      value: u,
                      child: Text(u.userName),
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
            ],
          ),
          const SizedBox(height: 16),
          SizedBox(
            width: double.infinity,
            child: SingleChildScrollView(
              child: DataTable(
                columnSpacing: 0,
                columns: const [
                  DataColumn(label: Text('Purchase ID')),
                  DataColumn(label: Text('User')),
                  DataColumn(label: Text('Show')),
                  DataColumn(label: Text('Number of tickets')),
                  DataColumn(label: Text('Total price')),
                ],
                rows: _purchases!.isNotEmpty
                    ? _purchases!.map((purchase) {
                        return DataRow(
                          cells: [
                            DataCell(Text(purchase.purchaseId.toString())),
                            DataCell(Text(purchase.user!.userName)),
                            DataCell(
                              Tooltip(
                                message: purchase.showSchedule!.show!.name,
                                child: Text(
                                  purchase.showSchedule!.show!.name.length > 20
                                      ? "${purchase.showSchedule!.show!.name.substring(0, 20)} ..."
                                      : purchase.showSchedule!.show!.name,
                                ),
                              ),
                            ),
                            DataCell(Text(purchase.numberOfTickets.toString())),
                            DataCell(Text(purchase.totalPrice.toString())),
                          ],
                        );
                      }).toList()
                    : [
                        const DataRow(cells: [
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
