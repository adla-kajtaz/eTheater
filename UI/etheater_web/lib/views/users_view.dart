import 'package:flutter/material.dart';

class Users extends StatefulWidget {
  const Users({super.key});

  @override
  _UsersState createState() => _UsersState();
}

class _UsersState extends State<Users> {
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
                  const SizedBox(width: 750),
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
                              child: Text('Firs name',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Last name',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Email',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Phone number',
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
                          child: Center(child: Text('Neko')),
                        ),
                      ),
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('Nekić')),
                        ),
                      ),
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('neko@gmail.com')),
                        ),
                      ),
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('062-025-025')),
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
                            padding: const EdgeInsets.fromLTRB(90, 0, 60, 0),
                            child: Row(
                              children: [
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
