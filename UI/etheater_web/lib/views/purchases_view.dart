import 'package:flutter/material.dart';

class Purchases extends StatefulWidget {
  const Purchases({super.key});

  @override
  _PurchasesState createState() => _PurchasesState();
}

class _PurchasesState extends State<Purchases> {
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
                  const SizedBox(width: 500),
                  Expanded(
                    child: SizedBox(
                      height: 37,
                      width: 166,
                      child: Padding(
                        padding: const EdgeInsets.symmetric(horizontal: 10),
                        child: TextField(
                          decoration: InputDecoration(
                            hintText: 'Search by user',
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
                  Expanded(
                    child: SizedBox(
                      height: 37,
                      width: 166,
                      child: Padding(
                        padding: const EdgeInsets.symmetric(horizontal: 10),
                        child: TextField(
                          decoration: InputDecoration(
                            hintText: 'Search by purchase ID',
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
                              child: Text('Purchase ID',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('User',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Number of tickets',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                      TableCell(
                        child: Container(
                          height: 40,
                          color: const Color.fromARGB(255, 40, 38, 38),
                          child: const Center(
                              child: Text('Total price',
                                  style: TextStyle(color: Colors.white))),
                        ),
                      ),
                    ],
                  ),
                  const TableRow(
                    children: [
                      TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('PK1250')),
                        ),
                      ),
                      TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('adla@gmail.com')),
                        ),
                      ),
                      TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('2')),
                        ),
                      ),
                      TableCell(
                        child: SizedBox(
                          height: 40,
                          child: Center(child: Text('40.00 KM')),
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
