import 'package:flutter/material.dart';

class Login extends StatefulWidget {
  static const routeName = '/login';

  const Login({super.key});

  @override
  _LoginState createState() => _LoginState();
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
      body: SafeArea(
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 20.0),
          child: SingleChildScrollView(
            child: Column(children: [
              const SizedBox(height: 70),
              Center(
                child:
                    Image.asset('../assets/logo.png', width: 414, height: 256),
              ),
              const SizedBox(height: 30),
              Form(
                  key: formKey,
                  child: Container(
                      width: 680,
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
                              hintText: 'Email',
                              hintStyle: const TextStyle(
                                  color: Color.fromARGB(255, 40, 38, 38)),
                              filled: true,
                              fillColor: Colors.white,
                              border: OutlineInputBorder(
                                  borderRadius: BorderRadius.circular(10)),
                            ),
                          ),
                          const SizedBox(height: 20),
                          TextFormField(
                            onSaved: (newValue) => password = newValue,
                            validator: (value) {
                              if (value!.isEmpty) {
                                return "This field is required!";
                              }
                            },
                            style: const TextStyle(
                                color: Color.fromARGB(255, 40, 38, 38)),
                            decoration: InputDecoration(
                              hintText: 'Password',
                              hintStyle: const TextStyle(
                                  color: Color.fromARGB(255, 40, 38, 38)),
                              filled: true,
                              fillColor: Colors.white,
                              border: OutlineInputBorder(
                                  borderRadius: BorderRadius.circular(10)),
                            ),
                          ),
                          const SizedBox(height: 25),
                          Container(
                            height: 50,
                            width: double.infinity,
                            decoration: BoxDecoration(
                              color: Colors.white,
                              borderRadius: BorderRadius.circular(10),
                            ),
                            child: InkWell(
                              onTap: () async {
                                if (formKey.currentState!.validate()) {
                                  formKey.currentState!.save();
                                  try {} on Exception catch (error) {
                                    print(error.toString());
                                    if (error
                                        .toString()
                                        .contains("Bad request")) {
                                      formKey.currentState!.validate();
                                    }
                                  }
                                }
                              },
                              child: const Center(
                                child: Text(
                                  'Login',
                                  style: TextStyle(
                                    color: Color.fromARGB(255, 40, 38, 38),
                                    fontSize: 20,
                                    // fontWeight: FontWeight.bold
                                  ),
                                ),
                              ),
                            ),
                          ),
                        ],
                      )))
            ]),
          ),
        ),
      ),
    );
  }
}
