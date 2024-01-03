import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/hall_provider.dart';
import 'package:etheater_web/providers/showSchedule_provider.dart';
import 'package:etheater_web/providers/show_provider.dart';
import 'package:etheater_web/screens/screens.dart';
import 'package:etheater_web/utils/util.dart';
import 'package:etheater_web/widgets/modals/showSchedules/add_show_schedule.dart';
import 'package:etheater_web/widgets/modals/showSchedules/edit_show_schedule.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ScheduleScreen extends StatefulWidget {
  const ScheduleScreen({super.key});

  @override
  State<ScheduleScreen> createState() => _ScheduleScreenState();
}

class _ScheduleScreenState extends State<ScheduleScreen> {
  ShowScheduleProvider? _scheduleProvider;
  ShowProvider? _showProvider;
  HallProvider? _hallProvider;
  List<ShowSchedule>? _showSchedules;
  DateTime? _selectedDate;
  List<Show> _shows = [
    Show(
      showId: 0,
      name: 'Sve',
      director: '',
      description: '',
      duration: 30,
      showGenre: ShowGenre.drama,
      picture: '',
    )
  ];
  Show? _selectedShow;
  List<Hall> _halls = [
    Hall(
      hallId: 0,
      name: 'Sve',
      totalRows: 10,
      totalSeats: 100,
      numberOfSeatsPerRow: 10,
    )
  ];
  Hall? _selectedHall;

  @override
  void initState() {
    super.initState();
    _scheduleProvider = context.read<ShowScheduleProvider>();
    _showProvider = context.read<ShowProvider>();
    _hallProvider = context.read<HallProvider>();
    _selectedShow = _shows[0];
    _selectedHall = _halls[0];
    loadData();
    loadShows();
    loadHalls();
  }

  void resetState() {
    setState(() {
      _selectedDate = null;
      _selectedShow = _shows[0];
      _selectedHall = _halls[0];
    });
    loadData();
  }

  Future<void> handleSelectDate(BuildContext context) async {
    final DateTime? picked = await showDatePicker(
      context: context,
      initialDate: _selectedDate,
      firstDate: DateTime(2000),
      lastDate: DateTime(2100),
    );
    if (picked != null && picked != _selectedDate) {
      setState(() {
        _selectedDate = picked;
      });
    }
  }

  void loadShows() async {
    var data = await _showProvider!.get();
    setState(() {
      _shows = [..._shows, ...data];
    });
  }

  void loadHalls() async {
    var data = await _hallProvider!.get();
    setState(() {
      _halls = [..._halls, ...data];
    });
  }

  void loadData() async {
    dynamic request = {
      'HallId': _selectedHall!.hallId == 0 ? null : _selectedHall!.hallId,
      'ShowDate': _selectedDate?.toIso8601String(),
      'ShowId': _selectedShow!.showId == 0 ? null : _selectedShow!.showId
    };
    var data = await _scheduleProvider!.get(request);
    setState(() {
      _showSchedules = data;
    });
  }

  void handleEdit(int id, dynamic request) async {
    await _scheduleProvider!.update(id, request);
    if (context.mounted) {
      Navigator.pop(context);
      loadData();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          backgroundColor: Theme.of(context).primaryColor,
          content: const Text('You have successfully modified the schedule!'),
        ),
      );
    }
  }

  void openEditModal(ShowSchedule s) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return EditShowScheduleModal(showSchedule: s, handleEdit: loadData);
      },
    );
  }

  void openDeleteModal(ShowSchedule s) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Deleting a schedule'),
          content: const Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              Text('Are you sure you want to delete the schedule?'),
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
                  await _scheduleProvider!.remove(s.showScheduleId);
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
                        content: Text('You cannot delete a schedule!'),
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

  void openAddModal() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AddShowScheduleModal(
          handleAdd: () => {
            resetState(),
            loadData(),
            ScaffoldMessenger.of(context).showSnackBar(
              SnackBar(
                backgroundColor: Theme.of(context).primaryColor,
                content:
                    const Text('You have successfully added a new schedule!'),
              ),
            ),
          },
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_showSchedules == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
      body:  Column(
          children: [
            Row(
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                const SizedBox(width: 16.0),
                Expanded(
                    child: Container(
                  decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(4),
                    border: Border.all(
                        color: Theme.of(context).primaryColor, width: 1),
                  ),
                  child: Padding(
                    padding: const EdgeInsets.all(8.0),
                    child: InkWell(
                      onTap: () => handleSelectDate(context),
                      child: Text(
                        formatDateTime(_selectedDate ?? DateTime.now()),
                        style: const TextStyle(fontSize: 16),
                      ),
                    ),
                  ),
                )),
                const SizedBox(width: 16.0, height: 16),
                Expanded(
                  child: DropdownButtonFormField<Show>(
                    decoration: InputDecoration(
                      labelText: 'Show',
                      labelStyle:
                          TextStyle(color: Theme.of(context).primaryColor),
                      enabledBorder: UnderlineInputBorder(
                        borderSide:
                            BorderSide(color: Theme.of(context).primaryColor),
                      ),
                    ),
                    value: _selectedShow,
                    onChanged: (Show? s) {
                      setState(() {
                        _selectedShow = s!;
                      });
                    },
                    items: _shows
                        .map<DropdownMenuItem<Show>>((Show s) {
                      return DropdownMenuItem<Show>(
                        value: s,
                        child: Text(s.name),
                      );
                    }).toList(),
                  ),
                ),
                const SizedBox(width: 16.0, height: 16),
                Expanded(
                  child: DropdownButtonFormField<Hall>(
                    decoration: InputDecoration(
                      labelText: 'Hall',
                      labelStyle:
                          TextStyle(color: Theme.of(context).primaryColor),
                      enabledBorder: UnderlineInputBorder(
                        borderSide:
                            BorderSide(color: Theme.of(context).primaryColor),
                      ),
                    ),
                    value: _selectedHall,
                    onChanged: (Hall? h) {
                      setState(() {
                        _selectedHall = h!;
                      });
                    },
                    items: _halls
                        .map<DropdownMenuItem<Hall>>((Hall h) {
                      return DropdownMenuItem<Hall>(
                        value: h,
                        child: Text(h.name),
                      );
                    }).toList(),
                  ),
                ),
                const SizedBox(width: 16.0, height: 16),
                ElevatedButton(
                  onPressed: () {
                    resetState();
                  },
                  child: const Text('Reset'),
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
                  DataColumn(label: Text('Show')),
                  DataColumn(label: Text('Hall')),
                  DataColumn(label: Text('Show date')),
                  DataColumn(label: Text('Show time')),
                  DataColumn(label: Text('Ticket price')),
                  DataColumn(label: Text('Tickets')),
                  DataColumn(label: Text('Edit')),
                  DataColumn(label: Text('Delete')),
                ],
                rows: _showSchedules!.isNotEmpty
                    ? _showSchedules!.map((showSchedule) {
                        return DataRow(cells: [
                          DataCell(
                            Tooltip(
                              message: showSchedule.show!.name,
                              child: Text(
                                showSchedule.show!.name.length > 20
                                    ? "${showSchedule.show!.name.substring(0, 20)} ..."
                                    : showSchedule.show!.name,
                              ),
                            ),
                          ),
                          DataCell(
                            Tooltip(
                              message: showSchedule.hall!.name,
                              child: Text(
                                showSchedule.hall!.name.length > 20
                                    ? "${showSchedule.hall!.name.substring(0, 20)} ..."
                                    : showSchedule.hall!.name,
                              ),
                            ),
                          ),
                          DataCell(Text(showSchedule.showDate
                              .toString()
                              .substring(0, 10))),
                          DataCell(Text(showSchedule.showTime.toString())),
                          DataCell(Text(showSchedule.ticketPrice.toString())),
                          DataCell(IconButton(
                            icon: Icon(Icons.apps_sharp,
                                color: Theme.of(context).primaryColor),
                            onPressed: () {
                              Navigator.pushNamed(
                                  context, TicketsScreen.routeName,
                                  arguments: showSchedule.showScheduleId);
                            },
                          )),
                          DataCell(
                            IconButton(
                              icon: Icon(Icons.edit,
                                  color: Theme.of(context).primaryColor),
                              onPressed: () {
                                openEditModal(showSchedule);
                              },
                            ),
                          ),
                          DataCell(
                            IconButton(
                              icon: const Icon(Icons.delete, color: Colors.red),
                              onPressed: () {
                                openDeleteModal(showSchedule);
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
                          DataCell(Text('')),
                          DataCell(
                              Center(child: Text('No search results'))),
                          DataCell(Text('')),
                          DataCell(Text('')),
                          DataCell(Text('')),
                        ])
                      ],
              ),
            ),
          ],
        ),
      );
  }
}
