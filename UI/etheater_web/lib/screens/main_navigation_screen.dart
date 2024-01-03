import 'package:etheater_web/screens/profile_screen.dart';
import 'package:etheater_web/screens/screens.dart';
import 'package:flutter/material.dart';

class NavigationItem {
  final String label;
  final Widget widget;

  NavigationItem({required this.label, required this.widget});
}

class MainNavigationScreen extends StatefulWidget {
  static const routeName = "/home";
  const MainNavigationScreen({super.key});

  @override
  State<MainNavigationScreen> createState() => _MainNavigationScreenState();
}

class _MainNavigationScreenState extends State<MainNavigationScreen> {
  int _selectedIndex = 0;
  static const TextStyle optionStyle =
      TextStyle(fontSize: 30, fontWeight: FontWeight.bold);

  final List<NavigationItem> _navigationItems = [
    NavigationItem(label: 'Actors', widget: const ActorScreen()),
    NavigationItem(
        label: 'Shows', widget: const ShowScreen()),
    NavigationItem(
        label: 'Schedules',
        widget: const ScheduleScreen()),
    NavigationItem(
        label: 'Notifications',
        widget: const Text('Notifications', style: optionStyle)),
    NavigationItem(label: 'Theater halls', widget: const TheaterHalls()),
    NavigationItem(
        label: 'Purchases',
        widget: const Text('Purchases', style: optionStyle)),
    NavigationItem(
        label: 'Users', widget: const Text('Users', style: optionStyle)),
    NavigationItem(
        label: 'Theater info',
        widget: const TheaterInfoScreen()),
    NavigationItem(
        label: 'Revenue', widget: const Text('Revenue', style: optionStyle)),
    NavigationItem(
        label: 'Profile', widget: const ProfileScreen()),
  ];

  void _onItemTapped(int index) {
    setState(() {
      _selectedIndex = index;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text(_navigationItems[_selectedIndex].label)),
      body: Center(
        child: _navigationItems[_selectedIndex].widget,
      ),
      drawer: Drawer(
        child: ListView.builder(
          itemCount: _navigationItems.length,
          itemBuilder: (BuildContext context, int index) {
            return ListTile(
              title: Text(_navigationItems[index].label),
              selected: _selectedIndex == index,
              onTap: () {
                _onItemTapped(index);
                Navigator.pop(context);
              },
            );
          },
        ),
      ),
    );
  }
}
