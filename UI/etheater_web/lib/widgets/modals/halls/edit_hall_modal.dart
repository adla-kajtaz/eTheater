import 'package:etheater_web/models/hall.dart';
import 'package:flutter/material.dart';

class EditHallModal extends StatefulWidget {
  final Hall hall;
  final Function handleEdit;
  const EditHallModal({
    Key? key,
    required this.hall,
    required this.handleEdit,
  }) : super(key: key);

  @override
  State<EditHallModal> createState() => _EditHallModalState();
}

class _EditHallModalState extends State<EditHallModal> {
  final _formKey = GlobalKey<FormState>();
  late TextEditingController _nameController;

  @override
  void initState() {
    super.initState();
    _nameController = TextEditingController(text: widget.hall.name);
  }

  @override
  void dispose() {
    _nameController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Edit hall'),
      content: Form(
        key: _formKey,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextFormField(
              controller: _nameController,
              decoration: const InputDecoration(
                labelText: 'Name',
                hintText: 'Enter the halls name',
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
              dynamic request = {'name': _nameController.text};
              widget.handleEdit(widget.hall.hallId, request);
            }
          },
          child: const Text('Save changes'),
        ),
      ],
    );
  }
}
