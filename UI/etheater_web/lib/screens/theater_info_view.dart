import 'dart:io';
import 'package:flutter/material.dart';

class TheaterInfo extends StatefulWidget {
  static const routeName = '/profile';

  const TheaterInfo({super.key});

  @override
  _TheaterInfoState createState() => _TheaterInfoState();
}

class _TheaterInfoState extends State<TheaterInfo> {
  final formKey = GlobalKey<FormState>();
  // XFile? pickedImage; // Variable to store the picked image
  String? name;
  String? adress;
  String? email;
  String? phoneNumber;
  String? webPage;
  // File? _file;

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
            padding: const EdgeInsets.all(30),
            child:
                Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
              const Text(
                'Theater info',
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
                          /*Row(
                            children: [
                              Expanded(
                                child: Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    GestureDetector(
                                      onTap: () async {
                                        final tmp = await pickImage();
                                        setState(() {
                                          _file = tmp;
                                        });
                                      },
                                      child: Center(
                                        child: Container(
                                          height: 300,
                                          width: 300,
                                          decoration: BoxDecoration(
                                              borderRadius:
                                                  BorderRadius.circular(100),
                                              color: Colors.grey,
                                              image: DecorationImage(
                                                  image: _file == null
                                                      ? const AssetImage(
                                                          '../assets/imageHolder.png')
                                                      : FileImage(_file!)
                                                          as ImageProvider,
                                                  fit: BoxFit.fill,
                                                  alignment: Alignment.center)),
                                        ),
                                      ),
                                    ),
                                  ],
                                ),
                              ),
                            ],
                          ),*/
                          const SizedBox(height: 20),
                          Row(
                            children: [
                              Expanded(
                                child: Column(
                                    crossAxisAlignment:
                                        CrossAxisAlignment.start,
                                    children: [
                                      const Text(
                                        'Name:',
                                        style: TextStyle(
                                          color:
                                              Color.fromARGB(255, 40, 38, 38),
                                        ),
                                      ),
                                      const SizedBox(height: 5),
                                      TextFormField(
                                        onSaved: (newValue) => name = newValue,
                                        validator: (value) {
                                          if (value!.isEmpty) {
                                            return "This field is required!";
                                          }
                                        },
                                        initialValue:
                                            'Narodno pozorište Mostar',
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
                                        'Phone number:',
                                        style: TextStyle(
                                          color:
                                              Color.fromARGB(255, 40, 38, 38),
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
                                        initialValue: '036-551-025',
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
                                      'Adress:',
                                      style: TextStyle(
                                        color: Color.fromARGB(255, 40, 38, 38),
                                      ),
                                    ),
                                    const SizedBox(height: 5),
                                    TextFormField(
                                      onSaved: (newValue) => adress = newValue,
                                      validator: (value) {
                                        if (value!.isEmpty) {
                                          return "This field is required!";
                                        }
                                      },
                                      initialValue: 'Maršala Tita bb',
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
                                      'Webpage:',
                                      style: TextStyle(
                                        color: Color.fromARGB(255, 40, 38, 38),
                                      ),
                                    ),
                                    const SizedBox(height: 5),
                                    TextFormField(
                                      onSaved: (newValue) => webPage = newValue,
                                      validator: (value) {
                                        if (value!.isEmpty) {
                                          return "This field is required!";
                                        }
                                      },
                                      initialValue: 'www.npm.ba',
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
                          const SizedBox(height: 20),
                          Row(children: [
                            Expanded(
                              child: Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    const Text(
                                      'Email:',
                                      style: TextStyle(
                                        color: Color.fromARGB(255, 40, 38, 38),
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
                                      initialValue: 'info@npm.ba',
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
                              child: Padding(
                                padding: const EdgeInsets.fromLTRB(0, 20, 0, 0),
                                child: Container(
                                  height: 55,
                                  width: double.infinity,
                                  decoration: BoxDecoration(
                                    color:
                                        const Color.fromARGB(255, 40, 38, 38),
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
                            ),
                          ]),
                        ],
                      )))
            ]),
          ),
        ),
      ),
    );
  }
}
