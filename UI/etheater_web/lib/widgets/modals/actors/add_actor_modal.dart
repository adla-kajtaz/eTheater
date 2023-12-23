import 'package:flutter/material.dart';

class AddActorModal extends StatefulWidget {
  final Function handleAdd;
  const AddActorModal({
    super.key,
    required this.handleAdd,
  });

  @override
  State<AddActorModal> createState() => _AddActorModalState();
}

class _AddActorModalState extends State<AddActorModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  String? firstName;
  String? lastName;
  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Add actor'),
      content: Form(
        key: formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextFormField(
              decoration: const InputDecoration(
                labelText: 'First name',
              ),
              onChanged: (value) {
                firstName = value;
              },
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'This field is required!';
                }
                return null;
              },
            ),
            TextFormField(
              decoration: const InputDecoration(
                labelText: 'Last name',
              ),
              onChanged: (value) {
                lastName = value;
              },
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'This field is required!';
                }
                return null;
              },
            ),
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
          onPressed: () {
            if (formKey.currentState!.validate()) {
              widget.handleAdd(firstName!, lastName!);
            }
          },
          child: const Text('Add'),
        ),
      ],
    );
  }
}
