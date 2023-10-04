import 'package:flutter/material.dart';
import 'screens/screens.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'eTheater',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(
            seedColor: const Color.fromARGB(255, 234, 191, 90)),
        useMaterial3: true,
      ),
      initialRoute: '/home',
      routes: {
        Login.routeName: (context) => const Login(),
        Navigation.routeName: (context) => const Navigation(),
      },
    );
  }
}
