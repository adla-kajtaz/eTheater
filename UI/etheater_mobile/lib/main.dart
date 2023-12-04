import 'package:etheater_mobile/providers/auth_provider.dart';
import 'package:etheater_mobile/providers/notification_provider.dart';
import 'package:etheater_mobile/providers/purchase_provider.dart';
import 'package:etheater_mobile/providers/showSchedule_provider.dart';
import 'package:etheater_mobile/providers/user_provider.dart';
import 'package:etheater_mobile/screens/screens.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  runApp(
    MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => ShowScheduleProvider()),
        ChangeNotifierProvider(create: (_) => AuthProvider()),
        ChangeNotifierProvider(create: (_) => NotificationProvider()),
        ChangeNotifierProvider(create: (_) => PurchaseProvider()),
        ChangeNotifierProvider(create: (_) => UserProvider()),
      ],
      child: const MyApp(),
    ),
  );
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'eTheater',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(
            seedColor: const Color.fromARGB(255, 237, 241, 192)),
        useMaterial3: true,
      ),
      initialRoute: '/login',
      routes: {
        Login.routeName: (context) => const Login(),
        Register.routeName: (context) => const Register(),
        Navigation.routeName: (context) => const Navigation(),
        Recommend.routeName: (context) => const Recommend(),
        ProfilEdit.routeName: (context) => const ProfilEdit(),
      },
    );
  }
}
