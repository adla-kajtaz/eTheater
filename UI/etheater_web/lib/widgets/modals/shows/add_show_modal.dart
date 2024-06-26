import 'dart:convert';
import 'package:etheater_web/models/enums.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:file_picker/file_picker.dart';

class AddShowModal extends StatefulWidget {
  final Function handleAdd;
  const AddShowModal({
    super.key,
    required this.handleAdd,
  });

  @override
  State<AddShowModal> createState() => _AddShowModalState();
}

class _AddShowModalState extends State<AddShowModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  String? name;
  String? description;
  String? duration;
  String? director;
  bool pictureError = false;
  String _imageFile = '';
  Uint8List? selectedImageInBytes;
  ShowGenre? _showGenre;

  @override
  void initState() {
    super.initState();
  }

  void selectImage() async {
    FilePickerResult? result =
        await FilePicker.platform.pickFiles(type: FileType.image);

    if (result != null) {
      setState(() {
        _imageFile = result.files.first.name;
        selectedImageInBytes = result.files.first.bytes;
        pictureError = false;
      });
    } else {
      // User canceled the picker
    }
  }

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text('Add show'),
      content: SingleChildScrollView(
        child: Form(
            key: formKey,
            child: Row(
              children: [
                SizedBox(
                  width: 220,
                  child: Column(
                    children: [
                      TextFormField(
                        style: const TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250)),
                        decoration: const InputDecoration(
                          labelText: 'Name',
                          hintText: 'Enter the shows name',
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
                        style: const TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250)),
                        maxLines: 6,
                        decoration: const InputDecoration(
                            labelText: 'Description',
                            hintText: 'Enter the show description'),
                        onChanged: (value) {
                          description = value;
                        },
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'This field is required!';
                          }
                          return null;
                        },
                      ),
                      const SizedBox(height: 16),
                      TextFormField(
                        style: const TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250)),
                        keyboardType: TextInputType.number,
                        inputFormatters: [
                          FilteringTextInputFormatter.digitsOnly
                        ],
                        decoration: const InputDecoration(
                          labelText: 'Duration(min)',
                          hintText: '45',
                        ),
                        onChanged: (value) {
                          duration = value;
                        },
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'This field is required!';
                          }
                          return null;
                        },
                      ),
                      const SizedBox(height: 16),
                      TextFormField(
                        style: const TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250)),
                        decoration: const InputDecoration(
                          labelText: 'Director',
                          hintText: 'Enter shows director',
                        ),
                        onChanged: (value) {
                          director = value;
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
                const SizedBox(width: 40),
                SizedBox(
                  width: 220,
                  child: Column(
                    children: [
                      Column(
                        children: [
                          Container(
                              height: 200,
                              width: 200,
                              decoration: BoxDecoration(
                                border: Border.all(
                                  color:
                                      const Color.fromARGB(255, 144, 135, 135),
                                  style: _imageFile.isEmpty
                                      ? BorderStyle.solid
                                      : BorderStyle.none,
                                ),
                                borderRadius: BorderRadius.circular(8),
                              ),
                              child: InkWell(
                                onTap: selectImage,
                                child: _imageFile.isEmpty
                                    ? const SizedBox(
                                        width: double.infinity,
                                        child: Column(
                                          mainAxisAlignment:
                                              MainAxisAlignment.center,
                                          children: [
                                            Icon(
                                              Icons.cloud_upload,
                                              size: 48,
                                              color: Color.fromARGB(
                                                  255, 144, 135, 135),
                                            ),
                                            SizedBox(height: 8),
                                            Text(
                                              'Select an image',
                                              style: TextStyle(
                                                color: Color.fromARGB(
                                                    255, 144, 135, 135),
                                              ),
                                            ),
                                          ],
                                        ),
                                      )
                                    : Image.memory(
                                        selectedImageInBytes!,
                                        height: 200,
                                        width: 200,
                                        fit: BoxFit.contain,
                                      ),
                              )),
                          if (pictureError)
                            const Text(
                              'The picture is required!',
                              style: TextStyle(color: Colors.red),
                            )
                        ],
                      ),
                      const SizedBox(height: 16),
                      SizedBox(
                        width: double.infinity,
                        child: DropdownButtonFormField<ShowGenre>(
                          iconEnabledColor:
                              const Color.fromARGB(255, 204, 36, 68),
                          dropdownColor: const Color.fromARGB(255, 51, 51, 52),
                          style: const TextStyle(
                              color: Color.fromARGB(255, 250, 250, 250)),
                          decoration: const InputDecoration(
                            labelText: 'Show genre',
                            labelStyle: TextStyle(
                                color: Color.fromARGB(255, 144, 135, 135)),
                            enabledBorder: UnderlineInputBorder(
                              borderSide: BorderSide(
                                  color: Color.fromARGB(255, 144, 135, 135)),
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
                          items: ShowGenre.values
                              .where(
                                  (genre) => genre != ShowGenre.zeroPlaceholder)
                              .map<DropdownMenuItem<ShowGenre>>(
                                  (ShowGenre entry) {
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
            setState(() {
              pictureError = false;
            });

            if (_imageFile.isEmpty) {
              setState(() {
                pictureError = true;
              });
              return;
            }
            if (formKey.currentState!.validate()) {
              final image = base64Encode(selectedImageInBytes!);
              dynamic request = {
                'name': name,
                'description': description,
                'picture': image,
                'duration': int.parse(duration.toString()),
                'director': director,
                'showGenre': _showGenre?.index,
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
