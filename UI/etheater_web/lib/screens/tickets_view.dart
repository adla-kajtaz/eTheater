import 'package:flutter/material.dart';

class Tickets extends StatefulWidget {
  const Tickets({super.key});

  @override
  _TicketsState createState() => _TicketsState();
}

class _TicketsState extends State<Tickets> {
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
                      onTap: () async {},
                      child: const Icon(Icons.add_outlined,
                          size: 35, color: Color.fromARGB(255, 40, 38, 38))),
                  const SizedBox(width: 750),
                  Expanded(
                    child: SizedBox(
                      height: 37,
                      width: 166,
                      child: Padding(
                        padding: const EdgeInsets.symmetric(horizontal: 10),
                        child: TextField(
                          decoration: InputDecoration(
                            hintText: 'Search by status',
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
                              child: Text('Seat',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Active',
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
                          child: Center(child: Text('A1')),
                        ),
                      ),
                      const TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('Yes')),
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
                            padding: const EdgeInsets.fromLTRB(140, 0, 60, 0),
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
