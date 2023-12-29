import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:etheater_web/providers/show_provider.dart';
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
  HallProvider? _hallProvider;
  List<Show> _shows = [];
  List<Hall> _halls = [];
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  Show? _selectedShow;
  Hall? _selectedHall;
  bool displayError = false;
  late TextEditingController ticketPriceController;
  late DateTime _showDate;

  @override
  void initState() {
    super.initState();
    _scheduleProvider = context.read<ShowScheduleProvider>();
    _showProvider = context.read<ShowProvider>();
    _hallProvider = context.read<HallProvider>();
    ticketPriceController =
        TextEditingController(text: widget.showSchedule.ticketPrice.toString());
    _showDate = widget.showSchedule.showDate;
    loadShows();
    loadHalls();
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

  loadHalls() async {
    var data = await _hallProvider!.get();
    _halls = data;
    int index = data
        .indexWhere((element) => element.hallId == widget.showSchedule.hallId);

    setState(() {
      _halls = data;
      _selectedHall = data[index];
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
    );
    if (picked != null && picked != _showDate) {
      setState(() {
        _showDate = picked;
      });
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
            TextFormField(
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
                    formatDateTime(_showDate),
                    style: const TextStyle(fontSize: 16),
                  ),
                ),
              ),
            ),
            const SizedBox(height: 16),
            const SizedBox(height: 16),
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
          child: const Text('Cancel'),
        ),
        ElevatedButton(
          onPressed: () async {
            if (formKey.currentState!.validate()) {
              dynamic request = {
                'ticketPrice': ticketPriceController.text,
                'showDate': _showDate.toIso8601String(),
                'showTime': '',
                'showId': _selectedShow!.showId,
                'hallId': _selectedHall!.hallId
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
