import 'package:flutter/material.dart';
import 'screens.dart';

class Navigation extends StatefulWidget {
  static const routeName = '/home';

  const Navigation({super.key});

  @override
  State<Navigation> createState() => _NavigacijaState();
}

class _NavigacijaState extends State<Navigation> {
  final List<Widget> _screens = [
    const Shows(),
    const Schedule(),
  ];

  final List<String> _titles = [
    'Shows',
    'Schedule',
    'Ticktes',
    'Notifications',
    'Theater halls',
    'Purchases',
    'Users',
    'Theater info'
  ];

  int _currentIndex = 0;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Row(
        children: [
          Container(
            width: 200,
            color: const Color.fromARGB(255, 40, 38, 38),
            child: Column(children: [
              Padding(
                padding: const EdgeInsets.fromLTRB(10, 10, 0, 0),
                child: Align(
                  alignment: Alignment.topLeft,
                  child: Image.asset(
                    '../assets/logo.png',
                    width: 50,
                    height: 50,
                  ),
                ),
              ),
              const Divider(
                color: Colors.white, // Customize the line color
                thickness: 1, // Customize the line thickness
                //indent: 0, // Customize the left indentation
                //endIndent: 0, // Customize the right indentation
              ),
              Expanded(
                child: ListView.builder(
                    itemCount: _titles.length,
                    itemBuilder: (BuildContext context, int index) {
                      final naziv = _titles[index];
                      return GestureDetector(
                        child: ListTile(
                            title: Text(naziv,
                                style: const TextStyle(
                                    color: Color.fromARGB(255, 181, 176, 176))),
                            onTap: () {
                              setState(() {
                                _currentIndex = index;
                              });
                            }),
                      );
                    }),
              ),
              const Divider(
                color: Colors.white, // Customize the line color
                thickness: 1, // Customize the line thickness
                //indent: 0, // Customize the left indentation
                //endIndent: 0, // Customize the right indentation
              ),
              const Row(
                children: [
                  SizedBox(width: 10),
                  Icon(Icons.account_circle,
                      size: 25, color: Color.fromARGB(255, 181, 176, 176)),
                  SizedBox(width: 100),
                  Icon(Icons.logout_outlined,
                      size: 25, color: Color.fromARGB(255, 181, 176, 176))
                ],
              ),
              const SizedBox(height: 10),
            ]),
          ),
          Expanded(
            child: Center(
              child: _screens[_currentIndex],
            ),
          ),
        ],
      ),
    );
  }
}
