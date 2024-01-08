import 'package:etheater_web/providers/providers.dart';
import 'package:etheater_web/screens/screens.dart';
import 'package:etheater_web/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

RegExp regexEmail = RegExp(
    r"^[a-zA-Z0-9.a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9]+\.[a-zA-Z]+");
RegExp regexPassword = RegExp(r'^.{8,}$');

class LoginScreen extends StatefulWidget {
  static const routeName = '/login';

  const LoginScreen({super.key});

  @override
  State<LoginScreen> createState() => _LoginScreenState();
}

class _LoginScreenState extends State<LoginScreen> {
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
      appBar: AppBar(
        title: const Text('Welcome to eTheater'),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Center(
          child: SizedBox(
            width: 500,
            child: Form(
              key: formKey,
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  const SizedBox(height: 16.0),
                  TextFormField(
                    onSaved: (newValue) => email = newValue,
                    validator: (value) {
                      if (value!.isEmpty) {
                        return "This field is required!";
                      }
                      if (!regexEmail.hasMatch(value)) {
                        return 'Invalid email!';
                      }
                      return null;
                    },
                    style: const TextStyle(
                        color: Color.fromARGB(255, 250, 250, 250)),
                    decoration: const InputDecoration(
                      labelText: 'Email',
                      hintText: 'email@example.com',
                    ),
                  ),
                  const SizedBox(
                    height: 20,
                  ),
                  TextFormField(
                    onSaved: (newValue) => password = newValue,
                    validator: (value) {
                      if (value!.isEmpty) {
                        return "This field is required!";
                      }
                      if (!regexPassword.hasMatch(value)) {
                        return 'Password must have at least 8 characters!';
                      }
                      if (loginFailed) {
                        return "Incorrect username or password!";
                      }
                      return null;
                    },
                    obscureText: true,
                    autocorrect: false,
                    style: const TextStyle(
                        color: Color.fromARGB(255, 250, 250, 250)),
                    decoration: const InputDecoration(
                      labelText: 'Password',
                      hintText: '********',
                    ),
                  ),
                  const SizedBox(height: 16.0),
                  if (loginFailed)
                    const Text(
                      'Login Failed',
                      style: TextStyle(color: Colors.red),
                    ),
                  const SizedBox(height: 16.0),
                  ElevatedButton(
                    style: ElevatedButton.styleFrom(
                      minimumSize: const Size(double.infinity, 50),
                    ),
                    onPressed: () async {
                      loginFailed = false;
                      if (formKey.currentState!.validate()) {
                        formKey.currentState!.save();
                        Map loginData = {'email': email, 'password': password};
                        try {
                          var data = await _authProvider!.loginAdmin(loginData);
                          TokenProvider.jwtToken = data!.token;
                          saveUserToken(data.token);
                          if (context.mounted) {
                            Navigator.pushReplacementNamed(
                                context, MainNavigationScreen.routeName);
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
                    child: const Text('Login', style: TextStyle(fontSize: 20)),
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
