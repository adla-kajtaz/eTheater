import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

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
    });
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
                        TextFormField(
                          onSaved: (newValue) =>
                              _theaterInfo!.name = newValue!,
                          validator: (value) {
                            if (value!.isEmpty) {
                              return "This field is required!";
                            }
                            return null;
                          },
                          initialValue: _theaterInfo!.name,
                          decoration: const InputDecoration(
                            labelText: 'Name',
                            hintText: 'Enter the name of the theater'
                          ),
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
                          decoration: const InputDecoration(
                            labelText: 'Adress',
                            hintText: 'Enter the adress of the theater'
                          ),
                        ),
                        const SizedBox(height: 20),
                        TextFormField(
                          onSaved: (newValue) => _theaterInfo!.email = newValue!,
                          validator: (value) {
                            if (value!.isEmpty) {
                              return "This field is required!";
                            }
                            else if (!RegExp(patternEmail).hasMatch(value)) {
                              return 'Please enter a valid email address!';
                            }
                            return null;
                          },
                          initialValue: _theaterInfo!.email,
                          decoration: const InputDecoration(
                            labelText: 'Email',
                            hintText: 'Enter the email of the theater',
                          ),
                        ),
                        const SizedBox(height: 20),
                        TextFormField(
                          onSaved: (newValue) => _theaterInfo!.webpage = newValue!,
                          validator: (value) {
                            if (value!.isEmpty) {
                              return "This field is required!";
                            }
                            else if (!RegExp(patternUrl).hasMatch(value)) {
                              return 'Please enter a valid url(https://page.com)!';
                            }
                            return null;
                          },
                          initialValue: _theaterInfo!.webpage,
                          decoration: const InputDecoration(
                            labelText: 'Webpage',
                            hintText: 'Enter the webpage of the theater',
                          ),
                        ),
                        const SizedBox(height: 20),
                        TextFormField(
                          onSaved: (newValue) => _theaterInfo!.phoneNumber = newValue!,
                          validator: (value) {
                            if (value!.isEmpty) {
                              return "This field is required!";
                            }
                            else if (!RegExp(patternPhone).hasMatch(value)) {
                              return 'The phone format must be xxx-xxx-xxx !';
                            }
                            return null;
                          },
                          initialValue: _theaterInfo!.phoneNumber,
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
                              Map<String, dynamic> data = {
                                "name": _theaterInfo!.name,
                                "logo": _theaterInfo!.logo,
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
                                    SnackBar(
                                      backgroundColor:
                                          Theme.of(context).primaryColor,
                                      content: const Text(
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
