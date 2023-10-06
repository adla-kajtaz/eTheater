import 'package:flutter/material.dart';

class Profile extends StatefulWidget {
  static const routeName = '/profile';

  const Profile({super.key});

  @override
  _ProfileState createState() => _ProfileState();
}

class _ProfileState extends State<Profile> {
  final formKey = GlobalKey<FormState>();
  String? firstName;
  String? lastName;
  String? email;
  String? phoneNumber;

  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.all(20),
            child:
                Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
              const Text(
                'Profile',
                style: TextStyle(
                    color: Color.fromARGB(255, 40, 38, 38),
                    fontSize: 30,
                    fontWeight: FontWeight.bold),
              ),
              const SizedBox(height: 10),
              Form(
                  key: formKey,
                  child: Container(
                      width: 600,
                      child: Column(
                        children: [
                          Row(
                            children: [
                              Expanded(
                                child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      const Text(
                                        'First name:',
                                        style: TextStyle(
                                          color:
                                              Color.fromARGB(255, 40, 38, 38),
                                        ),
                                      ),
                                      const SizedBox(height: 5),
                                      TextFormField(
                                        onSaved: (newValue) =>
                                            firstName = newValue,
                                        validator: (value) {
                                          if (value!.isEmpty) {
                                            return "This field is required!";
                                          }
                                        },
                                        initialValue: 'First name',
                                        style: const TextStyle(
                                            color: Color.fromARGB(
                                                255, 40, 38, 38)),
                                        decoration: InputDecoration(
                                          filled: true,
                                          fillColor: Colors.white,
                                          border: OutlineInputBorder(
                                              borderRadius:
                                                  BorderRadius.circular(10)),
                                        ),
                                      ),
                                    ]),
                              ),
                              const SizedBox(width: 20),
                              Expanded(
                                child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      const Text(
                                        'Email:',
                                        style: TextStyle(
                                          color:
                                              Color.fromARGB(255, 40, 38, 38),
                                        ),
                                      ),
                                      const SizedBox(height: 5),
                                      TextFormField(
                                        onSaved: (newValue) => email = newValue,
                                        validator: (value) {
                                          if (value!.isEmpty) {
                                            return "This field is required!";
                                          }
                                        },
                                        initialValue: 'Email',
                                        style: const TextStyle(
                                            color: Color.fromARGB(
                                                255, 40, 38, 38)),
                                        decoration: InputDecoration(
                                          filled: true,
                                          fillColor: Colors.white,
                                          border: OutlineInputBorder(
                                              borderRadius:
                                                  BorderRadius.circular(10)),
                                        ),
                                      ),
                                    ]),
                              ),
                            ],
                          ),
                          const SizedBox(height: 20),
                          Row(children: [
                            Expanded(
                              child: Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    const Text(
                                      'Last name:',
                                      style: TextStyle(
                                        color: Color.fromARGB(255, 40, 38, 38),
                                      ),
                                    ),
                                    const SizedBox(height: 5),
                                    TextFormField(
                                      onSaved: (newValue) =>
                                          lastName = newValue,
                                      validator: (value) {
                                        if (value!.isEmpty) {
                                          return "This field is required!";
                                        }
                                      },
                                      initialValue: 'Last name',
                                      style: const TextStyle(
                                          color:
                                              Color.fromARGB(255, 40, 38, 38)),
                                      decoration: InputDecoration(
                                        filled: true,
                                        fillColor: Colors.white,
                                        border: OutlineInputBorder(
                                            borderRadius:
                                                BorderRadius.circular(10)),
                                      ),
                                    ),
                                  ]),
                            ),
                            const SizedBox(width: 20),
                            Expanded(
                              child: Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    const Text(
                                      'Phone number:',
                                      style: TextStyle(
                                        color: Color.fromARGB(255, 40, 38, 38),
                                      ),
                                    ),
                                    const SizedBox(height: 5),
                                    TextFormField(
                                      onSaved: (newValue) =>
                                          phoneNumber = newValue,
                                      validator: (value) {
                                        if (value!.isEmpty) {
                                          return "This field is required!";
                                        }
                                      },
                                      initialValue: '062-025-025',
                                      style: const TextStyle(
                                          color:
                                              Color.fromARGB(255, 40, 38, 38)),
                                      decoration: InputDecoration(
                                        filled: true,
                                        fillColor: Colors.white,
                                        border: OutlineInputBorder(
                                            borderRadius:
                                                BorderRadius.circular(10)),
                                      ),
                                    ),
                                  ]),
                            ),
                          ]),
                          const SizedBox(height: 25),
                          Padding(
                            padding: const EdgeInsets.fromLTRB(310, 0, 0, 0),
                            child: Container(
                              height: 50,
                              width: double.infinity,
                              decoration: BoxDecoration(
                                color: const Color.fromARGB(255, 40, 38, 38),
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
                                    'Save',
                                    style: TextStyle(
                                        color: Colors.white,
                                        fontSize: 20,
                                        fontWeight: FontWeight.bold),
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
