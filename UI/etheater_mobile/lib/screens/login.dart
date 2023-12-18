import 'package:etheater_mobile/providers/token_provider.dart';
import 'package:etheater_mobile/screens/screens.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../providers/auth_provider.dart';

RegExp regexEmail = RegExp(
    r"^[a-zA-Z0-9.a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9]+\.[a-zA-Z]+");
RegExp regexPassword = RegExp(r'^.{8,}$');

class Login extends StatefulWidget {
  static const routeName = '/login';

  const Login({super.key});

  @override
  State<Login> createState() => _LoginState();
}

class _LoginState extends State<Login> {
  final formKey = GlobalKey<FormState>();
  String? email;
  String? password;
  bool loginFailed = false;
  AuthProvider? _authProvider;

  @override
  void initState() {
    super.initState();
    _authProvider = context.read<AuthProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 28, 28, 29),
      body: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20),
        child: SingleChildScrollView(
          child: Column(
            children: [
              const SizedBox(height: 150),
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
                      onSaved: (newValue) => email = newValue,
                      validator: (value) {
                        if (value!.isEmpty) {
                          return "This field is required!";
                        }
                        if (!regexEmail.hasMatch(value)) {
                          return 'Invalid email!';
                        }
                      },
                      style: const TextStyle(
                          color: Color.fromARGB(255, 250, 250, 250)),
                      decoration: InputDecoration(
                        labelText: 'Email',
                        hintText: 'email@example.com',
                        hintStyle: const TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250)),
                        border: OutlineInputBorder(
                            borderRadius: BorderRadius.circular(10)),
                      ),
                    ),
                    const SizedBox(
                      height: 10,
                    ),
                    TextFormField(
                      onSaved: (newValue) => password = newValue,
                      enableSuggestions: false,
                      validator: (value) {
                        if (value!.isEmpty) {
                          return "This field is required!";
                        }
                        if (!regexPassword.hasMatch(value)) {
                          return 'Password must have at least 8 characters!';
                        }
                        if (loginFailed) {
                          return 'Incorrect username or password!';
                        }
                      },
                      obscureText: true,
                      autocorrect: false,
                      style: const TextStyle(
                          color: Color.fromARGB(255, 250, 250, 250)),
                      decoration: InputDecoration(
                          hintStyle: const TextStyle(
                              color: Color.fromARGB(255, 250, 250, 250)),
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10)),
                          hintText: '*********',
                          labelText: 'Password'),
                    ),
                  ],
                ),
              ),
              const SizedBox(
                height: 20,
              ),
              Container(
                height: 50,
                width: double.infinity,
                decoration: BoxDecoration(
                  color: const Color.fromARGB(255, 204, 36, 68),
                  borderRadius: BorderRadius.circular(10),
                ),
                child: InkWell(
                  onTap: () async {
                    loginFailed = false;
                    if (formKey.currentState!.validate()) {
                      formKey.currentState!.save();
                      Map loginData = {'email': email, 'password': password};
                      try {
                        var data = await _authProvider!.login(loginData);
                        TokenProvider.jwtToken = data!.token;
                        if (context.mounted) {
                          Navigator.popAndPushNamed(
                              context, Navigation.routeName);
                        }
                      } on Exception catch (error) {
                        print(error.toString());
                        if (error.toString().contains("Bad request")) {
                          loginFailed = true;
                          formKey.currentState!.validate();
                        }
                      }
                    }
                  },
                  child: const Center(
                    child: Text(
                      'Login',
                      style: TextStyle(
                          color: Color.fromARGB(255, 250, 250, 250),
                          fontSize: 20,
                          fontWeight: FontWeight.bold),
                    ),
                  ),
                ),
              ),
              const SizedBox(height: 20),
              Row(
                children: [
                  const SizedBox(width: 5),
                  const Text(
                    'Dont have an account?',
                    style: TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
                  ),
                  const SizedBox(width: 20),
                  InkWell(
                    onTap: () =>
                        Navigator.pushNamed(context, Register.routeName),
                    child: const Text(
                      'Register here',
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
    );
  }
}
