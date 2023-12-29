import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/hall_provider.dart';
import 'package:etheater_web/providers/showSchedule_provider.dart';
import 'package:etheater_web/providers/show_provider.dart';
import 'package:etheater_web/widgets/modals/showSchedules/add_show_schedule.dart';
import 'package:etheater_web/widgets/modals/showSchedules/edit_show_schedule.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class Schedule extends StatefulWidget {
  const Schedule({super.key});

  @override
  State<Schedule> createState() => _ScheduleState();
}

class _ScheduleState extends State<Schedule> {
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
    return Scaffold();
  }
}
