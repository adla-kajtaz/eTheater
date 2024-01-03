import 'package:etheater_web/providers/providers.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'screens/screens.dart';

void main() {
  runApp(
    MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => AuthProvider()),
        ChangeNotifierProvider(create: (_) => ActorProvider()),
        ChangeNotifierProvider(create: (_) => HallProvider()),
        ChangeNotifierProvider(create: (_) => ShowScheduleProvider()),
        ChangeNotifierProvider(create: (_) => ShowProvider()),
        ChangeNotifierProvider(create: (_) => ShowActorProvider()),
        ChangeNotifierProvider(create: (_) => TicketProvider()),
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
      title: 'eTheater Admin',
      theme: ThemeData(
        dataTableTheme: DataTableThemeData(
          headingRowColor:
              MaterialStateColor.resolveWith((states) => Colors.indigo),
          headingTextStyle: const TextStyle(color: Colors.white),
        ),
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.indigo),
        useMaterial3: true,
      ),
      initialRoute: LoginScreen.routeName,
      routes: {
        LoginScreen.routeName: (context) => const LoginScreen(),
        MainNavigationScreen.routeName: (context) =>
            const MainNavigationScreen(),
         TicketsScreen.routeName: (context) => TicketsScreen(
            showScheduleId: ModalRoute.of(context)!.settings.arguments as int),
        ActorListScreen.routeName: (context) {
          final args = ModalRoute.of(context)!.settings.arguments
          as Map<String, dynamic>;
          return ActorListScreen(
            showId: args['showId'] as int,
            name: args['name'] as String,
          );
        },
      },
    );
  }
}
