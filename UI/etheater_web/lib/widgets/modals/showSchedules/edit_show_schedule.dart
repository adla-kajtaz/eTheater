import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:etheater_web/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';

class EditShowScheduleModal extends StatefulWidget {
  final ShowSchedule showSchedule;
  final Function handleEdit;
  const EditShowScheduleModal({
    Key? key,
    required this.showSchedule,
    required this.handleEdit,
  }) : super(key: key);

  @override
  State<EditShowScheduleModal> createState() => _EditShowScheduleModalState();
}

class _EditShowScheduleModalState extends State<EditShowScheduleModal> {
  ShowScheduleProvider? _scheduleProvider;
  ShowProvider? _showProvider;
  List<Show> _shows = [];
  List<String> _slots = [];
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  String? selectedTime;
  Show? _selectedShow;
  bool displayError = false;
  late TextEditingController ticketPriceController;
  late DateTime _showDate;

  @override
  void initState() {
    super.initState();
    _scheduleProvider = context.read<ShowScheduleProvider>();
    _showProvider = context.read<ShowProvider>();
    ticketPriceController =
        TextEditingController(text: widget.showSchedule.ticketPrice.toString());
    _showDate = widget.showSchedule.showDate;
    selectedTime = widget.showSchedule.showTime;
    loadShows();
    fetchSlots();
  }

  loadShows() async {
    var data = await _showProvider!.get();
    _shows = data;
    int index = data
        .indexWhere((element) => element.showId == widget.showSchedule.showId);

    setState(() {
      _shows = data;
      _selectedShow = data[index];
    });
  }

  void fetchSlots() async {
    var data = await _scheduleProvider!.getTimeSlotsForDate2({
      'hallId': widget.showSchedule.hallId,
      'date': _showDate,
      'showScheduleId': widget.showSchedule.showScheduleId
    });
    setState(() {
      _slots = data;
    });
  }

  @override
  void dispose() {
    ticketPriceController.dispose();
    super.dispose();
  }

  void handleEdit(int id, dynamic request) async {
    try {
      await _scheduleProvider!.update(id, request);
      if (context.mounted) {
        Navigator.pop(context);
        widget.handleEdit();
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
      initialDate: _showDate,
      firstDate: DateTime(2000),
      lastDate: DateTime(2100),
      builder: (BuildContext context, Widget? child) {
        return Theme(
          data: ThemeData.dark().copyWith(
            colorScheme: const ColorScheme.dark(
              primary: Color.fromARGB(255, 204, 36, 68),
              onPrimary: Color.fromARGB(255, 250, 250, 250),
              surface: Color.fromARGB(255, 51, 51, 52),
              onSurface: Color.fromARGB(255, 250, 250, 250),
            ),
          ),
          child: child!,
        );
      },
    );
    if (picked != null && picked != _showDate) {
      setState(() {
        _showDate = picked;
      });
      fetchSlots();
    }
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Edit schedule'),
      content: Form(
        key: formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            DropdownButtonFormField<Show>(
              iconEnabledColor: const Color.fromARGB(255, 204, 36, 68),
              dropdownColor: const Color.fromARGB(255, 51, 51, 52),
              style: const TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              decoration: const InputDecoration(
                labelText: 'Show',
                labelStyle:
                    TextStyle(color: Color.fromARGB(255, 144, 135, 135)),
                enabledBorder: UnderlineInputBorder(
                  borderSide:
                      BorderSide(color: Color.fromARGB(255, 144, 135, 135)),
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
              style: const TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              controller: ticketPriceController,
              keyboardType: TextInputType.number,
              inputFormatters: [FilteringTextInputFormatter.digitsOnly],
              decoration: const InputDecoration(
                labelText: 'Ticket price (KM)',
                hintText: 'Enter the ticket price',
              ),
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'This field is required!';
                }
                return null;
              },
            ),
            const SizedBox(height: 16),
            const Text(
              'Show date',
              style: TextStyle(color: Color.fromARGB(255, 144, 135, 135)),
            ),
            Container(
              decoration: BoxDecoration(
                borderRadius: BorderRadius.circular(4),
                border: Border.all(
                    color: const Color.fromARGB(255, 144, 135, 135), width: 1),
              ),
              child: Padding(
                padding: const EdgeInsets.all(8.0),
                child: InkWell(
                  onTap: () => handleSelectDate(context),
                  child: Text(
                    formatDateTime(_showDate),
                    style: const TextStyle(
                        fontSize: 16,
                        color: Color.fromARGB(255, 250, 250, 250)),
                  ),
                ),
              ),
            ),
            const SizedBox(height: 16),
            DropdownButtonFormField<String>(
              iconEnabledColor: const Color.fromARGB(255, 204, 36, 68),
              dropdownColor: const Color.fromARGB(255, 51, 51, 52),
              style: const TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              decoration: const InputDecoration(
                labelText: 'List of available times',
                labelStyle:
                    TextStyle(color: Color.fromARGB(255, 144, 135, 135)),
                enabledBorder: UnderlineInputBorder(
                  borderSide:
                      BorderSide(color: Color.fromARGB(255, 144, 135, 135)),
                ),
              ),
              value: selectedTime,
              onChanged: (value) {
                setState(() {
                  selectedTime = value!;
                });
              },
              validator: (value) {
                if (value == null) {
                  return 'This field is required!';
                }
                return null;
              },
              items: _slots.map<DropdownMenuItem<String>>((String s) {
                return DropdownMenuItem<String>(
                  value: s,
                  child: Text(s),
                );
              }).toList(),
            ),
            const SizedBox(height: 16),
            if (displayError)
              const Text('The hall for this date and time is occupied.',
                  style: TextStyle(color: Colors.red)),
            const SizedBox(height: 16),
          ],
        ),
      ),
      actions: [
        TextButton(
          onPressed: () {
            Navigator.pop(context);
          },
          child: const Text('Cancel',
              style: TextStyle(color: Color.fromARGB(255, 250, 250, 250))),
        ),
        ElevatedButton(
          onPressed: () async {
            if (formKey.currentState!.validate()) {
              dynamic request = {
                'ticketPrice': ticketPriceController.text,
                'showDate': _showDate.toIso8601String(),
                'showTime': selectedTime,
                'showId': _selectedShow!.showId,
              };
              handleEdit(widget.showSchedule.showScheduleId, request);
            }
          },
          child: const Text('Save changes'),
        ),
      ],
    );
  }
}
