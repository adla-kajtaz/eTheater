import 'dart:convert';
import 'dart:io';
import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/utils/util.dart';
import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class EditShowModal extends StatefulWidget {
  final Show show;
  final Function handleEdit;
  const EditShowModal({
    Key? key,
    required this.show,
    required this.handleEdit,
  }) : super(key: key);

  @override
  State<EditShowModal> createState() => _EditShowModalState();
}

class _EditShowModalState extends State<EditShowModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();

  late TextEditingController nameController;
  late TextEditingController descriptionController;
  late TextEditingController durationController;
  late TextEditingController directorController;
  bool pictureError = false;
  ShowGenre? _showGenre;
  String? _selectedImage;
  @override
  void initState() {
    super.initState();
    nameController = TextEditingController(text: widget.show.name);
    descriptionController = TextEditingController(text: widget.show.description);
    durationController = TextEditingController(
        text: widget.show.duration.toString());
    directorController = TextEditingController(text: widget.show.director);
    _selectedImage = widget.show.picture;
    _showGenre = widget.show.showGenre;
  }

  void selectImage() async {
    FilePickerResult? result =
        await FilePicker.platform.pickFiles(type: FileType.image);

    if (result != null) {
      final file = File(result.files.single.path!);
      final bytes = await file.readAsBytes();
      final image = base64Encode(bytes);
      setState(() {
        _selectedImage = image;
        pictureError = false;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Edit show'),
      content: Form(
          key: formKey,
          child: Row(
            children: [
              SizedBox(
                width: 220,
                child: Column(
                  children: [
                    TextFormField(
                      controller: nameController,
                      decoration: const InputDecoration(
                        labelText: 'Name',
                        hintText: 'Enter the shows name',
                      ),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'This field is required!';
                        }
                        return null;
                      },
                    ),
                    TextFormField(
                      controller: descriptionController,
                      maxLines: 6,
                      decoration: const InputDecoration(
                          labelText: 'Description',
                          hintText: 'Enter the show description'),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'This field is required!';
                        }
                        return null;
                      },
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      controller: durationController,
                      keyboardType: TextInputType.number,
                      inputFormatters: [FilteringTextInputFormatter.digitsOnly],
                      decoration: const InputDecoration(
                        labelText: 'Duration(min)',
                        hintText: '45',
                      ),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'This field is required!';
                        }
                        return null;
                      },
                    ),
                    const SizedBox(height: 16),
                    TextFormField(
                      controller: directorController,
                      decoration: const InputDecoration(
                        labelText: 'Director',
                        hintText: 'Enter shows director',
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
              const SizedBox(width: 40),
              SizedBox(
                width: 220,
                child: Column(
                  children: [
                    /*Column(
                      children: [
                        Container(
                          height: 200,
                          width: 200,
                          decoration: BoxDecoration(
                            border: Border.all(
                              color: Theme.of(context).primaryColor,
                              style: _selectedImage == null
                                  ? BorderStyle.solid
                                  : BorderStyle.none,
                            ),
                            borderRadius: BorderRadius.circular(8),
                          ),
                          child: InkWell(
                            onTap: selectImage,
                            child: _selectedImage == null
                                ? SizedBox(
                                    width: double.infinity,
                                    child: Column(
                                      mainAxisAlignment:
                                          MainAxisAlignment.center,
                                      children: [
                                        Icon(
                                          Icons.cloud_upload,
                                          size: 48,
                                          color: Theme.of(context).primaryColor,
                                        ),
                                        const SizedBox(height: 8),
                                        Text(
                                          'Select an image',
                                          style: TextStyle(
                                            color:
                                                Theme.of(context).primaryColor,
                                          ),
                                        ),
                                      ],
                                    ),
                                  )
                                : imageFromBase64String(
                                    _selectedImage!,
                                    200,
                                    200,
                                  ),
                          ),
                        ),
                        if (pictureError)
                          const Text(
                            'The picture is required!',
                            style: TextStyle(color: Colors.red),
                          )
                      ],
                    ),*/
                    const SizedBox(height: 16),
                    SizedBox(
                      width: double.infinity,
                      child: DropdownButtonFormField<ShowGenre>(
                    decoration: InputDecoration(
                      labelText: 'Show genre',
                      labelStyle:
                          TextStyle(color: Theme.of(context).primaryColor),
                      enabledBorder: UnderlineInputBorder(
                        borderSide:
                            BorderSide(color: Theme.of(context).primaryColor),
                      ),
                    ),
                    value: _showGenre,
                    validator: (value) {
                if (value == null) {
                  return 'This field is required!';
                }
                return null;
              },
                    onChanged: (value) {
                      setState(() {
                        _showGenre = value!;
                      });
          
                    },
                    items: ShowGenre.values.where((genre) => genre != ShowGenre.zeroPlaceholder).map<DropdownMenuItem<ShowGenre>>((ShowGenre entry) {
      return DropdownMenuItem<ShowGenre>(
        value: entry,
        child: Text(entry.toString().split('.').last),
      );
                          }).toList(),
                        ),
                    ),
                  ],
                ),
              )
            ],
          )),
      actions: [
        TextButton(
          onPressed: () {
            Navigator.pop(context);
          },
          child: const Text('Cancel'),
        ),
        ElevatedButton(
          onPressed: () async {
            setState(() {
              pictureError = false;
            });
            if (formKey.currentState!.validate()) {
              if (_selectedImage == null) {
                setState(() {
                  pictureError = true;
                });
                return;
              }
              dynamic request = {
                'name': nameController.text,
                'description': descriptionController.text,
                'picture': '_selectedImage',
                'duration': int.parse(durationController.text),
                'director': directorController.text,
                'showGenre': _showGenre?.index,
              };
              widget.handleEdit(widget.show.showId, request);
            }
          },
          child: const Text('Save changes'),
        ),
      ],
    );
  }
}
