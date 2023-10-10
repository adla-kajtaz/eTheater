import 'package:etheater_mobile/screens/screens.dart';
import 'package:flutter/material.dart';

class Register extends StatefulWidget {
  static const routeName = '/register';

  const Register({super.key});

  @override
  State<Register> createState() => _RegisterState();
}

bool isPasswordValid(String value) {
  RegExp regex = RegExp(r'^.{8,}$');
  return regex.hasMatch(value);
}

bool isPhoneNumberValid(String value) {
  RegExp regex = RegExp(r'^\d{3}-\d{3}-(\d{4}|\d{3})$');
  return regex.hasMatch(value);
}

bool isEmailValid(String value) {
  RegExp regex = RegExp(r'^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$',
      caseSensitive: false);
  return regex.hasMatch(value);
}

class _RegisterState extends State<Register> {
  final formKey = GlobalKey<FormState>();
  String? firstName;
  String? lastName;
  String? email;
  String? phoneNumber;
  String? password;
  List<int> uloge = [2];
  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 40, 38, 38),
      resizeToAvoidBottomInset: false,
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 20),
            child: Column(
              children: [
                const SizedBox(height: 50),
                Center(
                    child: ClipRRect(
                  borderRadius: BorderRadius.circular(50),
                  child: Image.asset(
                    'assets/logo.png',
                    width: 207,
                    height: 146,
                  ),
                )),
                const SizedBox(
                  height: 20,
                ),
                Form(
                  key: formKey,
                  child: Column(
                    children: [
                      TextFormField(
                        onSaved: (newValue) => firstName = newValue,
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
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10)),
                          hintText: 'First name',
                          hintStyle: const TextStyle(
                              color: Color.fromARGB(255, 40, 38, 38)),
                          errorStyle: const TextStyle(
                            color: Color.fromARGB(255, 226, 189, 6),
                          ),
                        ),
                      ),
                      const SizedBox(height: 10),
                      TextFormField(
                        onSaved: (newValue) => lastName = newValue,
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
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10)),
                          hintText: 'Last name',
                          hintStyle: const TextStyle(
                              color: Color.fromARGB(255, 40, 38, 38)),
                          errorStyle: const TextStyle(
                            color: Color.fromARGB(255, 226, 189, 6),
                          ),
                        ),
                      ),
                      const SizedBox(height: 10),
                      TextFormField(
                        onSaved: (newValue) => email = newValue,
                        validator: (value) {
                          if (value!.isEmpty) {
                            return "This field is required!";
                          }
                          if (!isEmailValid(value!)) {
                            return "Please enter a valid email!";
                          }
                        },
                        style: const TextStyle(
                            color: Color.fromARGB(255, 40, 38, 38)),
                        decoration: InputDecoration(
                          filled: true,
                          fillColor: Colors.white,
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10)),
                          hintText: 'Email',
                          hintStyle: const TextStyle(
                              color: Color.fromARGB(255, 40, 38, 38)),
                          errorStyle: const TextStyle(
                            color: Color.fromARGB(255, 226, 189, 6),
                          ),
                        ),
                      ),
                      const SizedBox(height: 10),
                      TextFormField(
                        onSaved: (newValue) => phoneNumber = newValue,
                        validator: (value) {
                          if (value!.isEmpty) {
                            return "This field is required!";
                          }
                          if (!isPhoneNumberValid(value!)) {
                            return "Please enter a phone number in format 06x-xxx-xxx!";
                          }
                        },
                        style: const TextStyle(
                            color: Color.fromARGB(255, 40, 38, 38)),
                        decoration: InputDecoration(
                          filled: true,
                          fillColor: Colors.white,
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10)),
                          hintText: 'Phone number',
                          hintStyle: const TextStyle(
                              color: Color.fromARGB(255, 40, 38, 38)),
                          errorStyle: const TextStyle(
                            color: Color.fromARGB(255, 226, 189, 6),
                          ),
                        ),
                      ),
                      const SizedBox(height: 10),
                      TextFormField(
                        onSaved: (newValue) => password = newValue,
                        validator: (value) {
                          if (value!.isEmpty) {
                            return "This field is required!";
                          }
                          if (!isPasswordValid(value!)) {
                            return "Password must be atleast 8 charcters!";
                          }
                        },
                        obscureText: true,
                        autocorrect: false,
                        style: const TextStyle(
                            color: Color.fromARGB(255, 40, 38, 38)),
                        decoration: InputDecoration(
                          filled: true,
                          fillColor: Colors.white,
                          border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10)),
                          hintText: 'Password',
                          hintStyle: const TextStyle(
                              color: Color.fromARGB(255, 40, 38, 38)),
                          errorStyle: const TextStyle(
                            color: Color.fromARGB(255, 226, 189, 6),
                          ),
                        ),
                      ),
                      const SizedBox(height: 20),
                      InkWell(
                        onTap: () async {
                          if (formKey.currentState!.validate()) {
                            formKey.currentState!.save();
                          }

                          try {} on Exception catch (err) {
                            print(err.toString());
                            formKey.currentState!.validate();
                          }
                        },
                        child: Container(
                          decoration: BoxDecoration(
                            borderRadius: BorderRadius.circular(10),
                            color: Colors.white,
                          ),
                          height: 50,
                          child: const Center(
                            child: Text(
                              'Register',
                              style: TextStyle(
                                  color: Color.fromARGB(255, 40, 38, 38),
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
                          TextStyle(color: Color.fromARGB(225, 195, 178, 178)),
                    ),
                    const SizedBox(width: 20),
                    InkWell(
                      onTap: () =>
                          Navigator.pushNamed(context, Login.routeName),
                      child: const Text(
                        'Login here',
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
      ),
    );
  }
}
