import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:etheater_web/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';

class AddShowScheduleModal extends StatefulWidget {
  final Function handleAdd;
  const AddShowScheduleModal({super.key, required this.handleAdd});

  @override
  State<AddShowScheduleModal> createState() => _AddShowScheduleModalState();
}

class _AddShowScheduleModalState extends State<AddShowScheduleModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  ShowScheduleProvider? _scheduleProvider;
  ShowProvider? _showProvider;
  HallProvider? _hallProvider;
  int selectedSlot = -1;
  String showTime = "20:00-22:00";
  List<String> _slots = [];
  List<Show> _shows = [];
  List<Hall> _halls = [];
  Show? _selectedShow;
  Hall? _selectedHall;
  int ticketPrice = 0;
  DateTime showDate = DateTime.now();
  bool displayError = false;

   @override
  void initState() {
    super.initState();
    _scheduleProvider = context.read<ShowScheduleProvider>();
    _showProvider = context.read<ShowProvider>();
    _hallProvider = context.read<HallProvider>();
    loadShows();
    loadHalls();
  }

  loadShows() async {
    var data = await _showProvider!.get();
    setState(() {
      _shows = data;
    });
  }

  loadHalls() async {
    var data = await _hallProvider!.get();
    setState(() {
      _halls = data;
    });
  }

  void fetchSlots() async {
    var data = await _scheduleProvider!
        .getTimeSlotsForDate({'hallId': _selectedHall!.hallId, 'date': showDate});
    setState(() {
      _slots = data;
    });
  }

  void setSlotIndex(int index) {
    setState(() {
      selectedSlot = index;
    });
  }

  void handleAdd(dynamic request) async {
    try {
      await _scheduleProvider!.insert(request);
      if (context.mounted) {
        Navigator.pop(context);
        widget.handleAdd();
      }
    } catch (e) {
      if (context.mounted) {
        setState(() {
          displayError = true;
        });
      }
    }
  }

  Future<void> handleSelectDate(BuildContext context) async {
    final DateTime? picked = await showDatePicker(
      context: context,
      initialDate: showDate,
      firstDate: DateTime(2000),
      lastDate: DateTime(2100),
    );
    if (picked != null && picked != showDate) {
      setState(() {
        showDate = picked;
      });
      fetchSlots();
    }
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Add schedule'),
      content: Form(
        key: formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            DropdownButtonFormField<Hall>(
              decoration: InputDecoration(
                labelText: 'Hall',
                labelStyle: TextStyle(color: Theme.of(context).primaryColor),
                enabledBorder: UnderlineInputBorder(
                  borderSide: BorderSide(color: Theme.of(context).primaryColor),
                ),
              ),
              value: _selectedHall,
              onChanged: (Hall? h) {
                setState(() {
                  _selectedHall = h!;
                });
                fetchSlots();
              },
              validator: (value) {
                if (value == null) {
                  return 'This field is required!';
                }
                return null;
              },
              items: _halls.map<DropdownMenuItem<Hall>>((Hall h) {
                return DropdownMenuItem<Hall>(
                  value: h,
                  child: Text(h.name),
                );
              }).toList(),
            ),
            const SizedBox(height: 16),
            DropdownButtonFormField<Show>(
              decoration: InputDecoration(
                labelText: 'Show',
                labelStyle: TextStyle(color: Theme.of(context).primaryColor),
                enabledBorder: UnderlineInputBorder(
                  borderSide: BorderSide(color: Theme.of(context).primaryColor),
                ),
              ),
              value: _selectedShow,
              onChanged: (Show? p) {
                setState(() {
                  _selectedShow = p!;
                });
              },
              validator: (value) {
                if (value == null) {
                  return 'This field is required!';
                }
                return null;
              },
              items: _shows.map<DropdownMenuItem<Show>>((Show s) {
                return DropdownMenuItem<Show>(
                  value: s,
                  child: Text(s.name),
                );
              }).toList(),
            ),
            const SizedBox(height: 16),
            TextFormField(
              keyboardType: TextInputType.number,
              inputFormatters: [FilteringTextInputFormatter.digitsOnly],
              decoration: const InputDecoration(
                labelText: 'Ticket price (KM)',
              ),
              onChanged: (String value) {
                if (value.isEmpty) return;
                ticketPrice = int.parse(value);
                setState(() {
                  ticketPrice = int.parse(value);
                });
              },
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'This field is required!';
                }
                return null;
              },
            ),
            const SizedBox(height: 16),
            const Text('Show date'),
            Container(
              decoration: BoxDecoration(
                borderRadius: BorderRadius.circular(4),
                border: Border.all(color: Colors.black, width: 1),
              ),
              child: Padding(
                padding: const EdgeInsets.all(8.0),
                child: InkWell(
                  onTap: () => handleSelectDate(context),
                  child: Text(
                    formatDateTime(showDate),
                    style: const TextStyle(fontSize: 16),
                  ),
                ),
              ),
            ),
            const SizedBox(height: 16),
            const Text("Time "),
            const SizedBox(height: 16),
            if (displayError)
              const Text('The hall for this date and time is occupied.',
                  style: TextStyle(color: Colors.red)),
            const SizedBox(height: 16)
          ],
        ),
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
            if (formKey.currentState!.validate()) {
              dynamic request = {
                'ticketPrice': ticketPrice,
                'showDate': showDate.toIso8601String(),
                'showTime': showTime,
                'showId': _selectedShow!.showId,
                'hallId': _selectedHall!.hallId
              };

              handleAdd(request);
            }
          },
          child: const Text('Add'),
        ),
      ],
    );
  }
}
