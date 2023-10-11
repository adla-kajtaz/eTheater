import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  const Home({super.key});
  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home> {
  final List<Tab> myTabs = <Tab>[
    const Tab(text: 'Now'),
    const Tab(text: 'Recommended')
  ];

  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return DefaultTabController(
      length: 2,
      child: SafeArea(
        child: Scaffold(
          backgroundColor: const Color.fromARGB(255, 40, 38, 38),
          appBar: AppBar(
            automaticallyImplyLeading: false,
            backgroundColor: const Color.fromARGB(255, 40, 38, 38),
            actions: [
              Padding(
                padding: const EdgeInsets.all(8.0),
                child: Icon(
                  Icons.theater_comedy,
                  color: Colors.white,
                  size: 40,
                ),
              ),
            ],
            bottom: TabBar(
                labelColor: Colors.white,
                unselectedLabelColor: const Color.fromARGB(225, 195, 178, 178),
                indicatorColor: Colors.white,
                tabs: myTabs),
          ),
          body: Padding(
            padding: const EdgeInsets.all(16),
            child: TabBarView(
              children: [
                Text("text 1"),
                Text("text 2"),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
