import 'package:etheater_web/screens/profile_screen.dart';
import 'package:etheater_web/screens/screens.dart';
import 'package:flutter/material.dart';
import 'package:go_router/go_router.dart';

final List<Object> _navigationItems = [
  {'label': 'Actors', 'route': ActorScreen.routeName},
  /*{'label': 'Shows', 'route': ShowScreen.routeName},
  {'label': 'Schedules', 'route': ScheduleScreen.routeName},
  {'label': 'Notifications', 'route': NotificationScreen.routeName},
  {'label': 'Theater halls', 'route': TheaterHalls.routeName},
  {'label': 'Purchases', 'route': PurchasesScreen.routeName},
  {'label': 'Users', 'route': UsersScreen.routeName},
  {'label': 'Theater info', 'route': TheaterInfoScreen.routeName},
  {'label': 'Revenue', 'route': RevenueScreen.routeName},
  {'label': 'Profile', 'route': ProfileScreen.routeName},*/
];

class DrawerMenu extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: ListView.builder(
        itemCount: _navigationItems.length,
        itemBuilder: (BuildContext context, int index) {
          return ListTile(
            title: Text('Actors',
                style:
                    const TextStyle(color: Color.fromARGB(255, 250, 250, 250))),
            // selected: _selectedIndex == index,
            onTap: () {
              context.go('/actors');
            },
          );
        },
      ),
    );
  }
}
