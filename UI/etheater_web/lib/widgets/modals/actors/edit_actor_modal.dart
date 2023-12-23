import 'package:etheater_web/models/models.dart';
import 'package:flutter/material.dart';

class EditActorModal extends StatefulWidget {
  final Actor actor;
  final Function handleEdit;
  const EditActorModal({
    Key? key,
    required this.actor,
    required this.handleEdit,
  }) : super(key: key);

  @override
  State<EditActorModal> createState() => _EditActorModalState();
}

class _EditActorModalState extends State<EditActorModal> {
  final _formKey = GlobalKey<FormState>();
  late TextEditingController _firstNameController;
  late TextEditingController _lastNameController;

  @override
  void initState() {
    super.initState();
    _firstNameController = TextEditingController(text: widget.actor.firstName);
    _lastNameController = TextEditingController(text: widget.actor.lastName);
  }

  @override
  void dispose() {
    _firstNameController.dispose();
    _lastNameController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Edit actor'),
      content: Form(
        key: _formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextFormField(
              controller: _firstNameController,
              decoration: const InputDecoration(
                labelText: 'First name ',
                hintText: 'Enter the actors fist name',
              ),
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'This field is required!';
                }
                return null;
              },
            ),
            TextFormField(
              controller: _lastNameController,
              decoration: const InputDecoration(
                labelText: 'Last name',
                hintText: 'Enter the actors last name',
              ),
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
            if (_formKey.currentState!.validate()) {
              widget.handleEdit(
                widget.actor.actorId,
                _firstNameController.text,
                _lastNameController.text,
              );
            }
          },
          child: const Text('Save changes'),
        ),
      ],
    );
  }
}
