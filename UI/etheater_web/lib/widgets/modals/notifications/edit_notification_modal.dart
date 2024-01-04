import 'dart:convert';
import 'dart:io';
import 'package:etheater_web/models/models.dart';
import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class EditNotificationModal extends StatefulWidget {
  final NotificationEtheater notification;
  final Function handleEdit;
  const EditNotificationModal({
    Key? key,
    required this.notification,
    required this.handleEdit,
  }) : super(key: key);

  @override
  State<EditNotificationModal> createState() => _EditNotificationModalState();
}

class _EditNotificationModalState extends State<EditNotificationModal> {
  GlobalKey<FormState> formKey = GlobalKey<FormState>();

  late TextEditingController titleController;
  late TextEditingController contentController;
  bool pictureError = false;
  NotificationCategory? _notificationCategory;
  String? _selectedImage;

  @override
  void initState() {
    super.initState();
    titleController = TextEditingController(text: widget.notification.title);
    contentController =
        TextEditingController(text: widget.notification.content);
    _selectedImage = widget.notification.picture;
    _notificationCategory = widget.notification.notificationCategory;
  }

  void selectImage() async {
    FilePickerResult? result =
        await FilePicker.platform.pickFiles(type: FileType.image);

    if (result != null) {
      final file = File(result.files.single.path!);
      final bytes = await file!.readAsBytes();
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
      title: const Text('Edit notification'),
      content: Form(
          key: formKey,
          child: Row(
            children: [
              Expanded(
                child: Column(
                  children: [
                    TextFormField(
                      controller: titleController,
                      decoration: const InputDecoration(
                        labelText: 'Title',
                        hintText: 'Enter the notification title',
                      ),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'This field is required!';
                        }
                        return null;
                      },
                    ),
                    TextFormField(
                      controller: contentController,
                      maxLines: 5,
                      decoration: const InputDecoration(
                          labelText: 'Content',
                          hintText: 'Enter the notification content'),
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
                        decoration: InputDecoration(
                          labelText: 'Notification category',
                          labelStyle:
                              TextStyle(color: Theme.of(context).primaryColor),
                          enabledBorder: UnderlineInputBorder(
                            borderSide: BorderSide(
                                color: Theme.of(context).primaryColor),
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

            if (_selectedImage == null) {
              setState(() {
                pictureError = true;
              });
              return;
            }
            if (formKey.currentState!.validate()) {
              String image = _selectedImage!;
              int? notificationC = _notificationCategory?.index;
              widget.handleEdit(
                  widget.notification.notificationId,
                  titleController.text,
                  contentController.text,
                  notificationC,
                  'image');
            }
          },
          child: const Text('Save changes'),
        ),
      ],
    );
  }
}