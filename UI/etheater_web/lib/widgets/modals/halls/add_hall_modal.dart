import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class AddHallModal extends StatefulWidget {
  final Function handleAdd;
  const AddHallModal({
    super.key,
    required this.handleAdd,
  });

  @override
  State<AddHallModal> createState() => _AddHallModalState();
}

class _AddHallModalState extends State<AddHallModal> {
  final totalSeatsController = TextEditingController();
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  String? name;
  int numberOfRows = 10;
  int numberOfSeatsPerRow = 10;
  int? totalSeats;
  @override
  void initState() {
    super.initState();
    totalSeatsController.text = '100';
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Add hall'),
      content: Form(
        key: formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextFormField(
              style: const TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              decoration: const InputDecoration(
                labelText: 'Name',
              ),
              onChanged: (value) {
                name = value;
              },
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'This field is required!';
                }
                return null;
              },
            ),
            TextFormField(
              style: const TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              initialValue: '10',
              keyboardType: TextInputType.number,
              inputFormatters: [FilteringTextInputFormatter.digitsOnly],
              decoration: const InputDecoration(
                labelText: 'Number of rows',
              ),
              onChanged: (String value) {
                if (value.isEmpty) return;
                numberOfRows = int.parse(value);
                setState(() {
                  numberOfRows = int.parse(value);
                });
                totalSeatsController.text =
                    (numberOfRows * numberOfSeatsPerRow).toString();
              },
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'This field is required!';
                }
                return null;
              },
            ),
            TextFormField(
              style: const TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              initialValue: '10',
              keyboardType: TextInputType.number,
              inputFormatters: [FilteringTextInputFormatter.digitsOnly],
              decoration: const InputDecoration(
                labelText: 'Number of seats per row',
              ),
              onChanged: (String value) {
                if (value.isEmpty) return;
                setState(() {
                  numberOfSeatsPerRow = int.parse(value);
                });

                totalSeatsController.text =
                    (numberOfRows * numberOfSeatsPerRow).toString();
              },
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'This field is required!';
                }
                return null;
              },
            ),
            TextFormField(
              style: const TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              controller: totalSeatsController,
              keyboardType: TextInputType.number,
              enabled: false,
              decoration: const InputDecoration(
                labelText: 'Total seats',
              ),
            ),
          ],
        ),
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
          onPressed: () {
            if (formKey.currentState!.validate()) {
              dynamic request = {
                'name': name,
                'totalRows': numberOfRows,
                'numberOfSeatsPerRow': numberOfSeatsPerRow
              };
              widget.handleAdd(request);
            }
          },
          child: const Text('Add'),
        ),
      ],
    );
  }
}
