import 'package:flutter/material.dart';
import 'screens.dart';

class Navigation extends StatefulWidget {
  static const routeName = '/home';

  const Navigation({super.key});

  @override
  State<Navigation> createState() => _NavigationState();
}

class _NavigationState extends State<Navigation> {
  final List<Widget> _screens = [const Home(), const News(), const Profile()];
  final List<IconData> _icons = const [
    Icons.home,
    Icons.newspaper,
    Icons.person_outline
  ];
  int _currentIndex = 0;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: _screens[_currentIndex],
      bottomNavigationBar: BottomNavigationBar(
        currentIndex: _currentIndex,
        showSelectedLabels: false,
        showUnselectedLabels: false,
        onTap: (int index) {
          setState(() {
            _currentIndex = index;
          });
        },
        items: _icons.map((IconData icon) {
          return BottomNavigationBarItem(
            icon: Icon(
              icon,
              size: 30,
            ),
            label: '', // Add labels if needed
          );
        }).toList(),
        selectedItemColor: const Color.fromARGB(255, 204, 36, 68),
        unselectedItemColor: const Color.fromARGB(255, 250, 250, 250),
        backgroundColor: const Color.fromARGB(255, 28, 28, 29),
      ),
    );
  }
}
