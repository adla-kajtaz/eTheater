import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:etheater_web/screens/screens.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ProfileScreen extends StatefulWidget {
  const ProfileScreen({super.key});

  @override
  State<ProfileScreen> createState() => _ProfileScreenState();
}

class _ProfileScreenState extends State<ProfileScreen> {
  final formKey = GlobalKey<FormState>();
  UserProvider? _userProvider;
  User? _user;
  bool updateFailed = false;

  @override
  void initState() {
    super.initState();
    _userProvider = context.read<UserProvider>();
    loadUser();
  }

  void loadUser() async {
    var data = await _userProvider!.getMe();
    setState(() {
      _user = data;
    });
  }

  bool isUserNameValid(String value) {
    RegExp regex = RegExp(r'^.{4,}$');
    return regex.hasMatch(value);
  }

  bool isEmailValid(String value) {
    RegExp regex = RegExp(r'^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$',
        caseSensitive: false);
    return regex.hasMatch(value);
  }

  @override
  Widget build(BuildContext context) {
    if (_user == null) {
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
                          onSaved: (newValue) => _user!.userName = newValue!,
                          validator: (value) {
                            if (value!.isEmpty) {
                              return "This field is required!";
                            }
                            if (!isUserNameValid(value)) {
                              return 'The username must contain at least 4 characters!';
                            }
                            if (updateFailed) {
                              return "Username is already taken!";
                            }
                            return null;
                          },
                          initialValue: _user!.userName,
                          decoration: const InputDecoration(
                            labelText: 'Username',
                          ),
                        ),
                        const SizedBox(height: 20),
                        TextFormField(
                          onSaved: (newValue) => _user!.email = newValue!,
                          validator: (value) {
                            if (value!.isEmpty) {
                              return "This field is required!";
                            }
                            if (!isEmailValid(value)) {
                              return 'Please enter a valid email address!';
                            }
                            return null;
                          },
                          initialValue: _user!.email,
                          decoration: const InputDecoration(
                            labelText: 'Email',
                            hintText: 'Email',
                          ),
                        ),
                        const SizedBox(height: 25),
                        ElevatedButton(
                          style: ElevatedButton.styleFrom(
                            minimumSize: const Size(double.infinity, 50),
                          ),
                          onPressed: () async {
                            updateFailed = false;
                            if (formKey.currentState!.validate()) {
                              formKey.currentState!.save();
                              Map<String, dynamic> data = {
                                "userName": _user!.userName,
                                "email": _user!.email
                              };
                              try {
                                await _userProvider!
                                    .updateProfile(_user!.id, data);
                                if (context.mounted) {
                                  ScaffoldMessenger.of(context).showSnackBar(
                                    SnackBar(
                                      backgroundColor:
                                          Theme.of(context).primaryColor,
                                      content: const Text(
                                          'Profile updated successfully!'),
                                    ),
                                  );
                                }
                              } on Exception catch (error) {
                                print(error.toString());
                                if (error.toString().contains("Bad request")) {
                                  updateFailed = true;
                                  formKey.currentState!.validate();
                                }
                              }
                            }
                          },
                          child: const Text('Save changes',
                              style: TextStyle(fontSize: 20)),
                        ),
                        const SizedBox(height: 35),
                        ElevatedButton(
                          style: ElevatedButton.styleFrom(
                            minimumSize: const Size(double.infinity, 50),
                          ),
                          onPressed: () async {
                            Navigator.pushReplacementNamed(
                                context, LoginScreen.routeName);
                            TokenProvider.jwtToken = null;
                          },
                          child: const Text('Logout',
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
