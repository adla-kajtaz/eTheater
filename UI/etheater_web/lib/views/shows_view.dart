import 'package:etheater_web/views/view.dart';
import 'package:flutter/material.dart';

class Shows extends StatefulWidget {
  const Shows({super.key});

  @override
  _ShowsState createState() => _ShowsState();
}

class _ShowsState extends State<Shows> {
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
                        Navigator.popAndPushNamed(context, NewShow.routeName);
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
