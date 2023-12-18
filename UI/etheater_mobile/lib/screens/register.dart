import 'package:etheater_mobile/screens/screens.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../providers/auth_provider.dart';
import '../providers/token_provider.dart';

class Register extends StatefulWidget {
  static const routeName = '/register';

  const Register({super.key});

  @override
  State<Register> createState() => _RegisterState();
}

bool isUserNameValid(String value) {
  RegExp regex = RegExp(r'^.{4,}$');
  return regex.hasMatch(value);
}

bool isPasswordValid(String value) {
  RegExp regex = RegExp(r'^.{8,}$');
  return regex.hasMatch(value);
}

bool isEmailValid(String value) {
  RegExp regex = RegExp(r'^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$',
      caseSensitive: false);
  return regex.hasMatch(value);
}

class _RegisterState extends State<Register> {
  AuthProvider? _authProvider;
  final formKey = GlobalKey<FormState>();
  String? userName;
  String? email;
  String? password;
  List<String> errors = [];
  @override
  void initState() {
    super.initState();
    _authProvider = context.read<AuthProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 28, 28, 29),
      resizeToAvoidBottomInset: false,
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 20),
            child: Column(
              children: [
                const SizedBox(height: 50),
                const Center(
                  child: Icon(
                    Icons.theater_comedy,
                    color: Colors.white,
                    size: 100,
                  ),
                ),
                const SizedBox(
                  height: 40,
                ),
                Form(
                  key: formKey,
                  child: Column(
                    children: [
                      TextFormField(
                        onSaved: (newValue) => userName = newValue,
                        validator: (newValue) {
                          if (newValue!.isEmpty) {
                            return "This field is required!";
                          }
                          if (!isUserNameValid(newValue!)) {
                            return "Username must contain at least 4 characters!";
                          }
                          if (errors.isNotEmpty &&
                              errors.any((e) =>
                                  e ==
                                  "Username '$userName' is already taken.")) {
                            return 'Username is already taken!';
                          }
                        },
                        style: const TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250)),
                        decoration: InputDecoration(
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10)),
                          labelText: 'Username',
                          hintText: 'emma123',
                          hintStyle: const TextStyle(
                              color: Color.fromARGB(255, 250, 250, 250)),
                        ),
                      ),
                      const SizedBox(height: 15),
                      TextFormField(
                        onSaved: (newValue) => email = newValue,
                        validator: (newValue) {
                          if (newValue!.isEmpty) {
                            return "This field is required!";
                          }
                          if (!isEmailValid(newValue!)) {
                            return "Please enter a valid email!";
                          }
                          if (errors.isNotEmpty &&
                              errors.any((element) =>
                                  element == "Email is already taken!")) {
                            return "Email is already taken!";
                          }
                        },
                        style: const TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250)),
                        decoration: InputDecoration(
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10)),
                          labelText: 'Email',
                          hintText: 'email@example.com',
                          hintStyle: const TextStyle(
                              color: Color.fromARGB(255, 250, 250, 250)),
                        ),
                      ),
                      const SizedBox(height: 15),
                      TextFormField(
                        onSaved: (newValue) => password = newValue,
                        validator: (newValue) {
                          if (newValue!.isEmpty) {
                            return "This field is required!";
                          }
                          if (!isPasswordValid(newValue!)) {
                            return "Password must be atleast 8 charcters!";
                          }
                        },
                        obscureText: true,
                        autocorrect: false,
                        enableSuggestions: false,
                        style: const TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250)),
                        decoration: InputDecoration(
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10)),
                          labelText: 'Password',
                          hintText: '*********',
                          hintStyle: const TextStyle(
                              color: Color.fromARGB(255, 250, 250, 250)),
                        ),
                      ),
                      const SizedBox(height: 20),
                      InkWell(
                        onTap: () async {
                          errors = [];
                          if (formKey.currentState!.validate()) {
                            formKey.currentState!.save();
                          }
                          Map registerData = {
                            'email': email,
                            'password': password,
                            'userName': userName,
                          };
                          try {
                            var data =
                                await _authProvider!.register(registerData);
                            TokenProvider.jwtToken = data!.token;
                            if (context.mounted) {
                              Navigator.popAndPushNamed(
                                  context, Navigation.routeName);
                            }
                          } on Exception catch (err) {
                            if (err.toString().contains("Bad request")) {
                              print(err.toString());
                              if (err.toString().contains(
                                  "Email '$email' is already taken")) {
                                errors.add("Email is already taken!");
                              }
                              if (err.toString().contains(
                                  "Username '$userName' is already taken.")) {
                                errors.add(
                                    "Username '$userName' is already taken.");
                              }
                              formKey.currentState!.validate();
                            }
                          }
                        },
                        child: Container(
                          decoration: BoxDecoration(
                            borderRadius: BorderRadius.circular(10),
                            color: const Color.fromARGB(255, 204, 36, 68),
                          ),
                          height: 50,
                          child: const Center(
                            child: Text(
                              'Register',
                              style: TextStyle(
                                  color: Color.fromARGB(255, 250, 250, 250),
                                  fontSize: 20,
                                  fontWeight: FontWeight.bold),
                            ),
                          ),
                        ),
                      ),
                    ],
                  ),
                ),
                const SizedBox(height: 10),
                Row(
                  children: [
                    const SizedBox(width: 5),
                    const Text(
                      'Already have an account?',
                      style:
                          TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
                    ),
                    const SizedBox(width: 20),
                    InkWell(
                      onTap: () =>
                          Navigator.pushNamed(context, Login.routeName),
                      child: const Text(
                        'Login here',
                        style: TextStyle(
                          fontWeight: FontWeight.bold,
                          color: Color.fromARGB(255, 204, 36, 68),
                        ),
                      ),
                    ),
                  ],
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
