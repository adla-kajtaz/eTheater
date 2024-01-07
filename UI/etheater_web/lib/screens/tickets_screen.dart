import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:etheater_web/widgets/ticket_view.dart';
import 'package:fl_chart/fl_chart.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class TicketsScreen extends StatefulWidget {
  static const routeName = '/tickets';
  final int showScheduleId;
  const TicketsScreen({
    super.key,
    required this.showScheduleId,
  });

  @override
  State<TicketsScreen> createState() => _TicketsScreenState();
}

class _TicketsScreenState extends State<TicketsScreen> {
  TicketProvider? _ticketProvider;
  ShowScheduleProvider? _showScheduleProvider;
  List<Ticket> _tickets = [];
  bool filterActive = false;

  @override
  void initState() {
    super.initState();
    _ticketProvider = context.read<TicketProvider>();
    _showScheduleProvider = context.read<ShowScheduleProvider>();
    loadData();
  }

  void loadData() async {
    var data = await _ticketProvider!.get({
      'ShowScheduleId': widget.showScheduleId,
      'IsActive': filterActive ? true : null,
    });
    setState(() {
      _tickets = data;
    });
  }

  void seatingView() {
    int free = _tickets.where((k) => k.isActive).toList().length;
    int sold = _tickets.where((k) => !k.isActive).toList().length;
    int numberOfSeats = _tickets[0].showSchedule!.hall!.totalSeats;
    int numberOfRows = _tickets[0].showSchedule!.hall!.totalRows;
    int numberOfSeatsPerRow =
        _tickets[0].showSchedule!.hall!.numberOfSeatsPerRow;

    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
            title: const Text("Ticket view"),
            content: TicketView(
              free: free,
              sold: sold,
              numberOfSeats: numberOfSeats,
              numberOfRows: numberOfRows,
              numberOfSeatsPerRow: numberOfSeatsPerRow,
              tickets: _tickets,
            ));
      },
    );
  }

  void openDeleteModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Deleting tickets'),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text('Are you sure you want to delete tickets?'),
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
                  var deleteT = await _showScheduleProvider!
                      .deleteTickets(widget.showScheduleId);

                  if (deleteT && context.mounted) {
                    Navigator.pop(context);
                    loadData();
                  }
                } catch (e) {
                  Navigator.pop(context);
                  ScaffoldMessenger.of(context).showSnackBar(
                    const SnackBar(
                      backgroundColor: Colors.red,
                      content: Text(
                          'You cannot delete tickets because some have already been purchased!'),
                    ),
                  );
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

  void createReport() async {
    int active = _tickets.where((k) => k.isActive).toList().length;
    int inactive = _tickets.where((k) => !k.isActive).toList().length;
    int total = active + inactive;
    String percentageOfActive = "${(active / total * 100).round()}%";
    String percentageOfInactive = "${(inactive / total * 100).round()}%";
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Report'),
          content: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              SizedBox(
                height: 200,
                child: PieChart(
                  PieChartData(
                    sections: [
                      PieChartSectionData(
                        color: Colors.green,
                        value: active.toDouble(),
                        title: percentageOfActive,
                      ),
                      PieChartSectionData(
                        color: Colors.red,
                        value: inactive.toDouble(),
                        title: percentageOfInactive,
                      ),
                    ],
                  ),
                ),
              ),
              const SizedBox(height: 30),
              Row(
                children: [
                  Container(
                    height: 20,
                    width: 20,
                    decoration: const BoxDecoration(
                      color: Colors.green,
                      borderRadius: BorderRadius.all(Radius.circular(10)),
                    ),
                  ),
                  const SizedBox(width: 16),
                  Text('Free tickets: ${active.toString()}')
                ],
              ),
              const SizedBox(height: 5),
              Row(
                children: [
                  Container(
                    height: 20,
                    width: 20,
                    decoration: const BoxDecoration(
                      color: Colors.red,
                      borderRadius: BorderRadius.all(Radius.circular(10)),
                    ),
                  ),
                  const SizedBox(width: 16),
                  Text('Sold tickets: ${inactive.toString()}')
                ],
              )
            ],
          ),
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(title: const Text('Ticket view')),
        body: SingleChildScrollView(
          child: Column(children: [
            Row(
              mainAxisAlignment: MainAxisAlignment.end,
              children: [
                Checkbox(
                  value: filterActive,
                  onChanged: (bool? s) {
                    setState(() {
                      filterActive = s!;
                    });
                  },
                  activeColor: Theme.of(context).primaryColor,
                ),
                const Text('Active'),
                const SizedBox(width: 20),
                ElevatedButton(
                  onPressed: () {
                    loadData();
                  },
                  child: const Text('Search'),
                ),
                const SizedBox(width: 10),
                ElevatedButton(
                  onPressed: () {
                    openDeleteModal();
                  },
                  child: const Text('Delete'),
                ),
                const SizedBox(width: 10),
                ElevatedButton(
                  onPressed: () {
                    createReport();
                  },
                  child: const Text('Report'),
                ),
                const SizedBox(width: 10),
                ElevatedButton(
                  onPressed: () {
                    seatingView();
                  },
                  child: const Text('Seating view'),
                ),
                const SizedBox(width: 10),
              ],
            ),
            const SizedBox(height: 16),
            SizedBox(
              width: double.infinity,
              child: DataTable(
                columnSpacing: 0,
                columns: const [
                  DataColumn(label: Text('Number of seat')),
                  DataColumn(label: Text('Number of row')),
                  DataColumn(label: Text('Seat')),
                  DataColumn(label: Text('Active')),
                ],
                rows: _tickets.isNotEmpty
                    ? _tickets.map((ticket) {
                        return DataRow(cells: [
                          DataCell(Text(ticket.numberOfSeat.toString())),
                          DataCell(Text(ticket.numberOfRow)),
                          DataCell(Text(ticket.seat)),
                          DataCell(
                            Checkbox(
                              value: ticket.isActive,
                              onChanged: (bool? s) {},
                              activeColor: Theme.of(context).primaryColor,
                            ),
                          ),
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
            )
          ]),
        ));
  }
}
