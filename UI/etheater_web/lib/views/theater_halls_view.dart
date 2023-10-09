import 'package:flutter/material.dart';

class TheaterHalls extends StatefulWidget {
  const TheaterHalls({super.key});

  @override
  _TheaterHallsState createState() => _TheaterHallsState();
}

class _TheaterHallsState extends State<TheaterHalls> {
  final formKey = GlobalKey<FormState>();

  String? name;
  String? totalRows;
  String? totalSeats;
  String? numberOfSeatsPerRow;

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
                              title: Text('Schedule form'),
                              content: Container(
                                width: 500,
                                height: 300,
                                child: Form(
                                  key: formKey,
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
                                                  const Text(
                                                    'Total rows:',
                                                    style: TextStyle(
                                                      color: Color.fromARGB(
                                                          255, 40, 38, 38),
                                                    ),
                                                  ),
                                                  const SizedBox(height: 5),
                                                  TextFormField(
                                                    onSaved: (newValue) =>
                                                        totalRows = newValue,
                                                    validator: (value) {
                                                      if (value!.isEmpty) {
                                                        return "This field is required!";
                                                      }
                                                    },
                                                    initialValue: 'totalRows',
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
                                                  'Total seats:',
                                                  style: TextStyle(
                                                    color: Color.fromARGB(
                                                        255, 40, 38, 38),
                                                  ),
                                                ),
                                                const SizedBox(height: 5),
                                                TextFormField(
                                                  onSaved: (newValue) =>
                                                      totalSeats = newValue,
                                                  validator: (value) {
                                                    if (value!.isEmpty) {
                                                      return "This field is required!";
                                                    }
                                                  },
                                                  initialValue: 'totalSeats',
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
                                                  'Number of seats per row:',
                                                  style: TextStyle(
                                                    color: Color.fromARGB(
                                                        255, 40, 38, 38),
                                                  ),
                                                ),
                                                const SizedBox(height: 5),
                                                TextFormField(
                                                  onSaved: (newValue) =>
                                                      numberOfSeatsPerRow =
                                                          newValue,
                                                  validator: (value) {
                                                    if (value!.isEmpty) {
                                                      return "This field is required!";
                                                    }
                                                  },
                                                  initialValue:
                                                      'numberOfSeatsPerRow',
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
                                      const SizedBox(height: 25),
                                      Padding(
                                        padding: const EdgeInsets.fromLTRB(
                                            260, 0, 0, 0),
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
                                                formKey.currentState!.save();
                                                try {} on Exception catch (error) {
                                                  print(error.toString());
                                                  if (error.toString().contains(
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
                                  child: const Text('Cancel'),
                                ),
                              ],
                            );
                          },
                        );
                      },
                      child: const Icon(Icons.add_outlined,
                          size: 35, color: Color.fromARGB(255, 40, 38, 38))),
                  const SizedBox(width: 700),
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
                            contentPadding:
                                const EdgeInsets.only(left: 8, bottom: 8),
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
                              child: Text('Total seats',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Total rows',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Number of seats per row',
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
                          child: Center(child: Text('Velika sala')),
                        ),
                      ),
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('200')),
                        ),
                      ),
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('20')),
                        ),
                      ),
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('10')),
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
