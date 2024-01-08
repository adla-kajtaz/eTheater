import 'dart:convert';

import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:file_picker/file_picker.dart';
import 'package:flutter/foundation.dart';

String patternUrl =
    r'^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$';
String patternEmail = r'^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$';
String patternPhone = r'^\d{3}-\d{3}-\d{3}$';

class TheaterInfoScreen extends StatefulWidget {
  const TheaterInfoScreen({super.key});

  @override
  State<TheaterInfoScreen> createState() => _TheaterInfoScreenState();
}

class _TheaterInfoScreenState extends State<TheaterInfoScreen> {
  final formKey = GlobalKey<FormState>();
  TheaterInfoProvider? _theaterInfoProvider;
  TheaterInfo? _theaterInfo;
  String? _imageFile;
  Uint8List? selectedImageInBytes;

  @override
  void initState() {
    super.initState();
    _theaterInfoProvider = context.read<TheaterInfoProvider>();
    loadTheater();
  }

  void loadTheater() async {
    var data = await _theaterInfoProvider!.getById(1);
    setState(() {
      _theaterInfo = data;
      _imageFile = _theaterInfo!.logo;
      List<int> imageBytes = base64.decode(_theaterInfo!.logo!);
      selectedImageInBytes = Uint8List.fromList(imageBytes);
    });
  }

  void selectImage() async {
    FilePickerResult? result =
        await FilePicker.platform.pickFiles(type: FileType.image);

    if (result != null && result.files.isNotEmpty) {
      setState(() {
        _imageFile = result.files.first.name;
        selectedImageInBytes = result.files.first.bytes;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    if (_theaterInfo == null) {
      return const Center(
        child: Text(
          'Loading ...',
        ),
      );
    }
    return Scaffold(
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.all(16.0),
            child: Center(
              child: SizedBox(
                width: 600,
                child: Form(
                  key: formKey,
                  child: Column(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        Column(
                          children: [
                            Container(
                              height: 200,
                              width: 200,
                              decoration: BoxDecoration(
                                border: Border.all(
                                  color: Theme.of(context).primaryColor,
                                  style:
                                      _imageFile == null || _imageFile!.isEmpty
                                          ? BorderStyle.solid
                                          : BorderStyle.none,
                                ),
                                borderRadius: BorderRadius.circular(8),
                              ),
                              child: InkWell(
                                onTap: selectImage,
                                child: _imageFile == null || _imageFile!.isEmpty
                                    ? SizedBox(
                                        width: double.infinity,
                                        child: Column(
                                          mainAxisAlignment:
                                              MainAxisAlignment.center,
                                          children: [
                                            Icon(
                                              Icons.cloud_upload,
                                              size: 48,
                                              color: Theme.of(context)
                                                  .primaryColor,
                                            ),
                                            const SizedBox(height: 8),
                                            Text(
                                              'Select an image',
                                              style: TextStyle(
                                                color: Theme.of(context)
                                                    .primaryColor,
                                              ),
                                            ),
                                          ],
                                        ),
                                      )
                                    : Image.memory(
                                        selectedImageInBytes!,
                                        height: 200,
                                        width: 200,
                                        fit: BoxFit.cover,
                                      ),
                              ),
                            ),
                          ],
                        ),
                        const SizedBox(height: 20),
                        TextFormField(
                          onSaved: (newValue) => _theaterInfo!.name = newValue!,
                          validator: (value) {
                            if (value!.isEmpty) {
                              return "This field is required!";
                            }
                            return null;
                          },
                          initialValue: _theaterInfo!.name,
                          style: const TextStyle(
                              color: Color.fromARGB(255, 250, 250, 250)),
                          decoration: const InputDecoration(
                              labelText: 'Name',
                              hintText: 'Enter the name of the theater'),
                        ),
                        const SizedBox(height: 20),
                        TextFormField(
                          onSaved: (newValue) =>
                              _theaterInfo!.adress = newValue!,
                          validator: (value) {
                            if (value!.isEmpty) {
                              return "This field is required!";
                            }
                            return null;
                          },
                          initialValue: _theaterInfo!.adress,
                          style: const TextStyle(
                              color: Color.fromARGB(255, 250, 250, 250)),
                          decoration: const InputDecoration(
                              labelText: 'Adress',
                              hintText: 'Enter the adress of the theater'),
                        ),
                        const SizedBox(height: 20),
                        TextFormField(
                          onSaved: (newValue) =>
                              _theaterInfo!.email = newValue!,
                          validator: (value) {
                            if (value!.isEmpty) {
                              return "This field is required!";
                            } else if (!RegExp(patternEmail).hasMatch(value)) {
                              return 'Please enter a valid email address!';
                            }
                            return null;
                          },
                          initialValue: _theaterInfo!.email,
                          style: const TextStyle(
                              color: Color.fromARGB(255, 250, 250, 250)),
                          decoration: const InputDecoration(
                            labelText: 'Email',
                            hintText: 'Enter the email of the theater',
                          ),
                        ),
                        const SizedBox(height: 20),
                        TextFormField(
                          onSaved: (newValue) =>
                              _theaterInfo!.webpage = newValue!,
                          validator: (value) {
                            if (value!.isEmpty) {
                              return "This field is required!";
                            } else if (!RegExp(patternUrl).hasMatch(value)) {
                              return 'Please enter a valid url(https://page.com)!';
                            }
                            return null;
                          },
                          initialValue: _theaterInfo!.webpage,
                          style: const TextStyle(
                              color: Color.fromARGB(255, 250, 250, 250)),
                          decoration: const InputDecoration(
                            labelText: 'Webpage',
                            hintText: 'Enter the webpage of the theater',
                          ),
                        ),
                        const SizedBox(height: 20),
                        TextFormField(
                          onSaved: (newValue) =>
                              _theaterInfo!.phoneNumber = newValue!,
                          validator: (value) {
                            if (value!.isEmpty) {
                              return "This field is required!";
                            } else if (!RegExp(patternPhone).hasMatch(value)) {
                              return 'The phone format must be xxx-xxx-xxx !';
                            }
                            return null;
                          },
                          initialValue: _theaterInfo!.phoneNumber,
                          style: const TextStyle(
                              color: Color.fromARGB(255, 250, 250, 250)),
                          decoration: const InputDecoration(
                            labelText: 'Phone number',
                            hintText: 'Enter the phone number of the theater',
                          ),
                        ),
                        const SizedBox(height: 25),
                        ElevatedButton(
                          style: ElevatedButton.styleFrom(
                            minimumSize: const Size(double.infinity, 50),
                          ),
                          onPressed: () async {
                            if (formKey.currentState!.validate()) {
                              formKey.currentState!.save();
                              final image = base64Encode(selectedImageInBytes!);
                              Map<String, dynamic> data = {
                                "name": _theaterInfo!.name,
                                "logo": image,
                                "adress": _theaterInfo!.adress,
                                "email": _theaterInfo!.email,
                                "webpage": _theaterInfo!.webpage,
                                "phoneNumber": _theaterInfo!.phoneNumber
                              };
                              try {
                                await _theaterInfoProvider!
                                    .update(_theaterInfo!.theaterInfoId, data);
                                if (context.mounted) {
                                  ScaffoldMessenger.of(context).showSnackBar(
                                    const SnackBar(
                                      backgroundColor:
                                          Color.fromARGB(249, 21, 136, 38),
                                      content: Text(
                                          'Theater info updated successfully!'),
                                    ),
                                  );
                                }
                              } on Exception catch (error) {
                                print(error.toString());
                                if (error.toString().contains("Bad request")) {
                                  formKey.currentState!.validate();
                                }
                              }
                            }
                          },
                          child: const Text('Save changes',
                              style: TextStyle(fontSize: 20)),
                        ),
                      ]),
                ),
              ),
            ),
          ),
        ),
      ),
    );
  }
}
