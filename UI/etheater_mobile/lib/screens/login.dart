import 'package:etheater_mobile/screens/screens.dart';
import 'package:flutter/material.dart';

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

  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 40, 38, 38),
      body: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20),
        child: SingleChildScrollView(
          child: Column(
            children: [
              const SizedBox(height: 150),
              Center(
                child: const Icon(
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
                      },
                      style: const TextStyle(
                          color: Color.fromARGB(255, 40, 38, 38)),
                      decoration: InputDecoration(
                        filled: true,
                        fillColor: Colors.white,
                        labelText: 'Email',
                        hintText: 'Email',
                        hintStyle: const TextStyle(
                            color: Color.fromARGB(255, 40, 38, 38)),
                        border: OutlineInputBorder(
                            borderRadius: BorderRadius.circular(10)),
                      ),
                    ),
                    const SizedBox(
                      height: 10,
                    ),
                    TextFormField(
                      onSaved: (newValue) => password = newValue,
                      validator: (value) {
                        if (value!.isEmpty) {
                          return "This field is required!";
                        }
                      },
                      obscureText: true,
                      autocorrect: false,
                      style: const TextStyle(
                          color: Color.fromARGB(255, 40, 38, 38)),
                      decoration: InputDecoration(
                          filled: true,
                          fillColor: Colors.white,
                          hintStyle: const TextStyle(
                              color: Color.fromARGB(255, 40, 38, 38)),
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
                  color: Colors.white,
                  borderRadius: BorderRadius.circular(10),
                ),
                child: InkWell(
                  onTap: () async {
                    Navigator.popAndPushNamed(context, Navigation.routeName);
                    /*if (formKey.currentState!.validate()) {
                      formKey.currentState!.save();

                      try {
                        Navigator.popAndPushNamed(
                            context, Navigation.routeName);
                      } on Exception catch (error) {
                        print(error.toString());
                        if (error.toString().contains("Bad request")) {
                          formKey.currentState!.validate();
                        }
                      }
                    }*/
                  },
                  child: const Center(
                    child: Text(
                      'Login',
                      style: TextStyle(
                          color: Color.fromARGB(255, 40, 38, 38),
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
                    style: TextStyle(color: Colors.white),
                  ),
                  const SizedBox(width: 20),
                  InkWell(
                    onTap: () =>
                        Navigator.pushNamed(context, Register.routeName),
                    child: const Text(
                      'Register here',
                      style: TextStyle(
                        fontWeight: FontWeight.bold,
                        color: Colors.white,
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
