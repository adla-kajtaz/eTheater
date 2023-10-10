import 'package:etheater_mobile/screens/screens.dart';
import 'package:flutter/material.dart';

void main() async {
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
            seedColor: const Color.fromARGB(255, 215, 179, 70)),
        useMaterial3: true,
      ),
      initialRoute: '/login',
      routes: {
        Login.routeName: (context) => const Login(),
        Register.routeName: (context) => const Register(),
      },
    );
  }
}
