// import 'package:etheater_web/views/view.dart';
import 'package:flutter/material.dart';
import 'dart:io';
import 'package:image_picker/image_picker.dart';

class Shows extends StatefulWidget {
  const Shows({super.key});

  @override
  _ShowsState createState() => _ShowsState();
}

class _ShowsState extends State<Shows> {
  final formKey = GlobalKey<FormState>();
  XFile? pickedImage;
  String? name;
  String? description;
  String? email;
  String? phoneNumber;
  String? duration;
  String? director;
  File? _file;

  @override
  void initState() {
    super.initState();
  }

  Future<File?> pickImage() async {
    final myfile = await ImagePicker().pickImage(source: ImageSource.gallery);

    if (myfile != null) {
      return File(myfile.path);
    }
    return null;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.all(50),
            child: Column(children: [
              Row(
                children: [
                  InkWell(
                      onTap: () async {
                        showDialog(
                          context: context,
                          builder: (BuildContext context) {
                            return AlertDialog(
                              title: Text(
                                  'Show form'), // Customize the title as needed
                              content: Container(
                                width: 500,
                                height: 500, // Adjust the width as needed
                                child: Form(
                                  key: formKey,
                                  child: Column(
                                    children: [
                                      // Your form fields and widgets go here
                                      // ...
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
                                                      color: Color.fromARGB(
                                                          255, 40, 38, 38),
                                                    ),
                                                  ),
                                                  const SizedBox(height: 5),
                                                  TextFormField(
                                                    onSaved: (newValue) =>
                                                        name = newValue,
                                                    validator: (value) {
                                                      if (value!.isEmpty) {
                                                        return "This field is required!";
                                                      }
                                                    },
                                                    initialValue: 'Name',
                                                    style: const TextStyle(
                                                        color: Color.fromARGB(
                                                            255, 40, 38, 38)),
                                                    decoration: InputDecoration(
                                                      filled: true,
                                                      fillColor: Colors.white,
                                                      border:
                                                          OutlineInputBorder(
                                                              borderRadius:
                                                                  BorderRadius
                                                                      .circular(
                                                                          10)),
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
                                                  GestureDetector(
                                                    onTap: () async {
                                                      final tmp =
                                                          await pickImage();
                                                      setState(() {
                                                        _file = tmp;
                                                      });
                                                    },
                                                    child: Center(
                                                      child: Container(
                                                        height: 100,
                                                        width: 100,
                                                        decoration: BoxDecoration(
                                                            borderRadius:
                                                                BorderRadius
                                                                    .circular(
                                                                        10),
                                                            color: Colors.grey,
                                                            image: DecorationImage(
                                                                image: _file ==
                                                                        null
                                                                    ? const AssetImage(
                                                                        '../assets/imageHolder.png')
                                                                    : FileImage(
                                                                            _file!)
                                                                        as ImageProvider,
                                                                fit:
                                                                    BoxFit.fill,
                                                                alignment:
                                                                    Alignment
                                                                        .center)),
                                                      ),
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
                                              crossAxisAlignment:
                                                  CrossAxisAlignment.start,
                                              children: [
                                                const Text(
                                                  'Description:',
                                                  style: TextStyle(
                                                    color: Color.fromARGB(
                                                        255, 40, 38, 38),
                                                  ),
                                                ),
                                                const SizedBox(height: 5),
                                                TextFormField(
                                                  onSaved: (newValue) =>
                                                      description = newValue,
                                                  validator: (value) {
                                                    if (value!.isEmpty) {
                                                      return "This field is required!";
                                                    }
                                                  },
                                                  initialValue: 'Description',
                                                  style: const TextStyle(
                                                      color: Color.fromARGB(
                                                          255, 40, 38, 38)),
                                                  decoration: InputDecoration(
                                                    filled: true,
                                                    fillColor: Colors.white,
                                                    border: OutlineInputBorder(
                                                        borderRadius:
                                                            BorderRadius
                                                                .circular(10)),
                                                  ),
                                                ),
                                              ]),
                                        ),
                                      ]),
                                      const SizedBox(height: 20),
                                      Row(children: [
                                        Expanded(
                                          child: Column(
                                              crossAxisAlignment:
                                                  CrossAxisAlignment.start,
                                              children: [
                                                const Text(
                                                  'Duration:',
                                                  style: TextStyle(
                                                    color: Color.fromARGB(
                                                        255, 40, 38, 38),
                                                  ),
                                                ),
                                                const SizedBox(height: 5),
                                                TextFormField(
                                                  onSaved: (newValue) =>
                                                      duration = newValue,
                                                  validator: (value) {
                                                    if (value!.isEmpty) {
                                                      return "This field is required!";
                                                    }
                                                  },
                                                  initialValue: 'Duration',
                                                  style: const TextStyle(
                                                      color: Color.fromARGB(
                                                          255, 40, 38, 38)),
                                                  decoration: InputDecoration(
                                                    filled: true,
                                                    fillColor: Colors.white,
                                                    border: OutlineInputBorder(
                                                        borderRadius:
                                                            BorderRadius
                                                                .circular(10)),
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
                                                  'Show genre:',
                                                  style: TextStyle(
                                                    color: Color.fromARGB(
                                                        255, 40, 38, 38),
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
                                                  initialValue: 'Show genre',
                                                  style: const TextStyle(
                                                      color: Color.fromARGB(
                                                          255, 40, 38, 38)),
                                                  decoration: InputDecoration(
                                                    filled: true,
                                                    fillColor: Colors.white,
                                                    border: OutlineInputBorder(
                                                        borderRadius:
                                                            BorderRadius
                                                                .circular(10)),
                                                  ),
                                                ),
                                              ]),
                                        ),
                                      ]),
                                      SizedBox(height: 25),
                                      Row(children: [
                                        Expanded(
                                          child: Column(
                                              crossAxisAlignment:
                                                  CrossAxisAlignment.start,
                                              children: [
                                                const Text(
                                                  'Director:',
                                                  style: TextStyle(
                                                    color: Color.fromARGB(
                                                        255, 40, 38, 38),
                                                  ),
                                                ),
                                                const SizedBox(height: 5),
                                                TextFormField(
                                                  onSaved: (newValue) =>
                                                      director = newValue,
                                                  validator: (value) {
                                                    if (value!.isEmpty) {
                                                      return "This field is required!";
                                                    }
                                                  },
                                                  initialValue: 'Director',
                                                  style: const TextStyle(
                                                      color: Color.fromARGB(
                                                          255, 40, 38, 38)),
                                                  decoration: InputDecoration(
                                                    filled: true,
                                                    fillColor: Colors.white,
                                                    border: OutlineInputBorder(
                                                        borderRadius:
                                                            BorderRadius
                                                                .circular(10)),
                                                  ),
                                                ),
                                              ]),
                                        ),
                                        const SizedBox(width: 20),
                                        Expanded(
                                          child: Padding(
                                            padding: const EdgeInsets.fromLTRB(
                                                0, 20, 0, 0),
                                            child: Container(
                                              height: 55,
                                              width: double.infinity,
                                              decoration: BoxDecoration(
                                                color: const Color.fromARGB(
                                                    255, 40, 38, 38),
                                                borderRadius:
                                                    BorderRadius.circular(10),
                                              ),
                                              child: InkWell(
                                                onTap: () async {
                                                  if (formKey.currentState!
                                                      .validate()) {
                                                    formKey.currentState!
                                                        .save();
                                                    try {} on Exception catch (error) {
                                                      print(error.toString());
                                                      if (error
                                                          .toString()
                                                          .contains(
                                                              "Bad request")) {
                                                        formKey.currentState!
                                                            .validate();
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
                                                        fontWeight:
                                                            FontWeight.bold),
                                                  ),
                                                ),
                                              ),
                                            ),
                                          ),
                                        ),
                                      ]),
                                    ],
                                  ),
                                ),
                              ),
                              actions: <Widget>[
                                TextButton(
                                  onPressed: () {
                                    // Close the dialog without saving
                                    Navigator.of(context).pop();
                                  },
                                  child: Text('Cancel'),
                                ),
                              ],
                            );
                          },
                        );
                        /*showDialog(
                            context: context,
                            builder: (BuildContext context) => AlertDialog(
                                  title: Text('Show Form'),
                                  content: Container(
                                    child: Row(
                                      children: [
                                        Expanded(
                                          child: Column(
                                            mainAxisSize: MainAxisSize.min,
                                            children: <Widget>[
                                              // First column of form fields
                                              TextField(
                                                decoration: InputDecoration(
                                                  labelText: 'Name',
                                                ),
                                              ),
                                              TextField(
                                                decoration: InputDecoration(
                                                  labelText: 'Email',
                                                ),
                                              ),
                                              // Add more form fields for the first column
                                            ],
                                          ),
                                        ),
                                        Expanded(
                                          child: Column(
                                            mainAxisSize: MainAxisSize.min,
                                            children: <Widget>[
                                              // Second column of form fields
                                              TextField(
                                                decoration: InputDecoration(
                                                  labelText: 'Phone',
                                                ),
                                              ),
                                              TextField(
                                                decoration: InputDecoration(
                                                  labelText: 'Address',
                                                ),
                                              ),
                                              // Add more form fields for the second column
                                            ],
                                          ),
                                        ),
                                      ],
                                    ),
                                  ),
                                  actions: <Widget>[
                                    TextButton(
                                      onPressed: () {
                                        // Close the dialog
                                        Navigator.of(context).pop();
                                      },
                                      child: Text('Cancel'),
                                    ),
                                    ElevatedButton(
                                      onPressed: () {
                                        // Perform form submission or other actions here
                                        // Close the dialog
                                        Navigator.of(context).pop();
                                      },
                                      child: Text('Submit'),
                                    ),
                                  ],
                                ));*/
                        // Navigator.popAndPushNamed(context, NewShow.routeName);
                      },
                      child: const Icon(Icons.add_outlined,
                          size: 35, color: Color.fromARGB(255, 40, 38, 38))),
                  const SizedBox(width: 650),
                  Expanded(
                    child: SizedBox(
                      height: 37,
                      width: 166,
                      child: Padding(
                        padding: const EdgeInsets.symmetric(horizontal: 10),
                        child: TextField(
                          decoration: InputDecoration(
                            hintText: 'Search by name',
                            border: OutlineInputBorder(
                              borderRadius: BorderRadius.circular(10),
                              borderSide: BorderSide.none,
                            ),
                            contentPadding: const EdgeInsets.only(
                                left: 8,
                                bottom:
                                    8), // Adjust padding to position hint text
                            alignLabelWithHint: true,
                            filled: true,
                            fillColor: const Color.fromARGB(255, 40, 38, 38),
                            hintStyle: const TextStyle(color: Colors.white),
                          ),
                          style: const TextStyle(
                              color: Colors.white, fontSize: 20),
                        ),
                      ),
                    ),
                  ),
                  const SizedBox(width: 10),
                  InkWell(
                    onTap: () async {},
                    child: Container(
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(10),
                        color: const Color.fromARGB(255, 40, 38, 38),
                      ),
                      height: 37,
                      width: 166,
                      child: const Center(
                        child: Text(
                          'Search',
                          style: TextStyle(color: Colors.white, fontSize: 20),
                        ),
                      ),
                    ),
                  ),
                ],
              ),
              const SizedBox(height: 10),
              Table(
                border: TableBorder.all(),
                children: [
                  TableRow(
                    children: [
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Name',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Duration',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Director',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Genre',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Deleted',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Action',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                    ],
                  ),
                  TableRow(
                    children: [
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('Ćelava pjevačica')),
                        ),
                      ),
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('45')),
                        ),
                      ),
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('Neko Nekić')),
                        ),
                      ),
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('Drama')),
                        ),
                      ),
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('No')),
                        ),
                      ),
                      TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Padding(
                            padding: const EdgeInsets.fromLTRB(70, 0, 60, 0),
                            child: Row(
                              children: [
                                InkWell(
                                    onTap: () async {},
                                    child: const Icon(Icons.edit,
                                        size: 25,
                                        color:
                                            Color.fromARGB(255, 40, 38, 38))),
                                const SizedBox(width: 15),
                                InkWell(
                                    onTap: () async {},
                                    child: const Icon(
                                        Icons.delete_forever_outlined,
                                        size: 25,
                                        color:
                                            Color.fromARGB(255, 171, 20, 20)))
                              ],
                            ),
                          ),
                        ),
                      ),
                    ],
                  ),
                ],
              ),
            ]),
          ),
        ),
      ),
    );
  }
}
