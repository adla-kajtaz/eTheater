import 'dart:convert';
import 'package:etheater_web/models/models.dart';
import 'package:flutter/material.dart';
import 'package:flutter/foundation.dart';
import 'package:file_picker/file_picker.dart';

class AddNotificationModal extends StatefulWidget {
  final Function handleAdd;
  const AddNotificationModal({
    super.key,
    required this.handleAdd,
  });

  @override
  State<AddNotificationModal> createState() => _AddNotificationModalState();
}

class _AddNotificationModalState extends State<AddNotificationModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();
  String? title;
  String? content;
  NotificationCategory? _notificationCategory;
  bool pictureError = false;
  String _imageFile = '';
  Uint8List? selectedImageInBytes;

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
      title: const Text('Add notification'),
      content: Form(
          key: formKey,
          child: Row(
            children: [
              SizedBox(
                width: 300,
                child: Column(
                  children: [
                    TextFormField(
                      style: const TextStyle(
                          color: Color.fromARGB(255, 250, 250, 250)),
                      decoration: const InputDecoration(
                        labelText: 'Title',
                        hintText: 'Enter the notitification title',
                      ),
                      onChanged: (value) {
                        title = value;
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
                      maxLines: 5,
                      decoration: const InputDecoration(
                          labelText: 'Content',
                          hintText: 'Enter the notification content'),
                      onChanged: (value) {
                        content = value;
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
              Expanded(
                child: Column(
                  children: [
                    SizedBox(
                      width: double.infinity,
                      child: DropdownButtonFormField<NotificationCategory>(
                        iconEnabledColor:
                            const Color.fromARGB(255, 204, 36, 68),
                        dropdownColor: const Color.fromARGB(255, 51, 51, 52),
                        style: const TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250)),
                        decoration: const InputDecoration(
                          labelText: 'Notification category',
                          labelStyle: TextStyle(
                              color: Color.fromARGB(255, 144, 135, 135)),
                          enabledBorder: UnderlineInputBorder(
                            borderSide: BorderSide(
                                color: Color.fromARGB(255, 144, 135, 135)),
                          ),
                        ),
                        value: _notificationCategory,
                        onChanged: (value) {
                          setState(() {
                            _notificationCategory = value!;
                          });
                        },
                        validator: (value) {
                          if (value == null) {
                            return 'This field is required!';
                          }
                          return null;
                        },
                        items: NotificationCategory.values
                            .where((genre) =>
                                genre != NotificationCategory.zeroPlaceholder)
                            .map<DropdownMenuItem<NotificationCategory>>(
                                (NotificationCategory entry) {
                          return DropdownMenuItem<NotificationCategory>(
                            value: entry,
                            child: Text(entry.toString().split('.').last),
                          );
                        }).toList(),
                      ),
                    ),
                    const SizedBox(height: 20),
                    Column(
                      children: [
                        Container(
                            height: 200,
                            width: 200,
                            decoration: BoxDecoration(
                              border: Border.all(
                                color: const Color.fromARGB(255, 144, 135, 135),
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
          child: const Text(
            'Cancel',
            style: TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
          ),
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
              int? notificationC = _notificationCategory?.index;
              widget.handleAdd(title, content, notificationC, image);
            }
          },
          child: const Text('Add'),
        ),
      ],
    );
  }
}
