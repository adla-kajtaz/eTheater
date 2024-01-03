import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class AddActorShowModal extends StatefulWidget {
  final int showId;
  final String showName;
  const AddActorShowModal({
    super.key,
    required this.showName,
    required this.showId,
  });

  @override
  State<AddActorShowModal> createState() => _AddActorShowModalState();
}

class _AddActorShowModalState extends State<AddActorShowModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  ShowActorProvider? _showActorProvider;
  ActorProvider? _actorProvider;
  List<Actor> _actors = [];

  late TextEditingController nameController;
  Actor? _selectedActor;

  @override
  void initState() {
    super.initState();
    _showActorProvider = context.read<ShowActorProvider>();
    _actorProvider = context.read<ActorProvider>();
    nameController = TextEditingController(text: widget.showName);
    loadGlumci();
  }

  void loadGlumci() async {
    var data = await _actorProvider!.get();
    setState(() {
      _actors = data;
    });
  }

  void handleAdd() async {
    dynamic request = {
      "actorId": _selectedActor!.actorId,
      "showId": widget.showId,
    };
    await _showActorProvider!.insert(request);
    if (context.mounted) {
      Navigator.pop(context);
    }
  }

  @override
  void dispose() {
    nameController.dispose();
    super.dispose();
  }

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
              enabled: false,
              controller: nameController,
              decoration: const InputDecoration(
                labelText: 'Show name',
              ),
              validator: (value) {
                if (value == null || value.isEmpty) {
                  return 'This field is required!';
                }
                return null;
              },
            ),
            SizedBox(
              width: double.infinity,
              child: DropdownButtonFormField<Actor>(
                decoration: InputDecoration(
                  labelText: 'Actor',
                  labelStyle: TextStyle(color: Theme.of(context).primaryColor),
                  enabledBorder: UnderlineInputBorder(
                    borderSide:
                        BorderSide(color: Theme.of(context).primaryColor),
                  ),
                ),
                value: _selectedActor,
                onChanged: (Actor? a) {
                  setState(() {
                    _selectedActor = a!;
                  });
                },
                validator: (value) {
                  if (value == null) {
                    return 'Please select an actor!';
                  }
                  return null;
                },
                items: _actors.map<DropdownMenuItem<Actor>>((Actor a) {
                  return DropdownMenuItem<Actor>(
                    value: a,
                    child: Text("${a.firstName} ${a.lastName}"),
                  );
                }).toList(),
              ),
            )
          ],
        ),
      ),
      actions: [
        ElevatedButton(
          onPressed: () {
            if (formKey.currentState!.validate()) {
              handleAdd();
            }
          },
          child: const Text('Add'),
        ),
      ],
    );
  }
}
