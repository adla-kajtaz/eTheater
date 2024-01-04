import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class PurchaseReport extends StatefulWidget {
  final int userId;
  const PurchaseReport({
    super.key,
    required this.userId,
  });

  @override
  State<PurchaseReport> createState() => _PurchaseReportState();
}

class _PurchaseReportState extends State<PurchaseReport> {
  UserProvider? _userProvider;
  UserReport? _report;
  @override
  void initState() {
    super.initState();
    _userProvider = context.read<UserProvider>();
    loadData();
  }

  void loadData() async {
    var data = await _userProvider!.userReport(widget.userId);
    setState(() {
      _report = data;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (_report == null || _report!.purchases == null) {
      return const Center(
        child: CircularProgressIndicator(),
      );
    }
    return Column(
      mainAxisSize: MainAxisSize.min,
      children: [
        SizedBox(
          width: 500,
          child: DataTable(
            columnSpacing: 0,
            columns: const [
              DataColumn(label: Text('Show name')),
              DataColumn(label: Text('Number of tickets')),
              DataColumn(label: Text('Price')),
            ],
            rows: _report!.purchases!.isNotEmpty
                ? _report!.purchases!.map((purchase) {
                    return DataRow(cells: [
                      DataCell(Text(purchase.showName)),
                      DataCell(Text(purchase.numberOfTickets.toString())),
                      DataCell(Text(purchase.price.toString())),
                    ]);
                  }).toList()
                : [
                    const DataRow(cells: [
                      DataCell(Text('')),
                      DataCell(Center(child: Text('No search results'))),
                      DataCell(Text('')),
                    ])
                  ],
          ),
        ),
        const SizedBox(height: 10),
        Text(
          'Total: ${_report!.totalPrice}',
          style: const TextStyle(
            fontSize: 20,
            fontWeight: FontWeight.bold,
          ),
        ),
      ],
    );
  }
}
