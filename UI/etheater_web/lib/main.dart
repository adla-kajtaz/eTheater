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
        ChangeNotifierProvider(create: (_) => TheaterInfoProvider()),
        ChangeNotifierProvider(create: (_) => NotificationProvider()),
        ChangeNotifierProvider(create: (_) => PurchaseProvider()),
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
        primaryColor: const Color.fromARGB(255, 250, 250, 250),
        appBarTheme: const AppBarTheme(
            backgroundColor: Color.fromARGB(255, 28, 28, 29),
            titleTextStyle: TextStyle(
                color: Color.fromARGB(255, 250, 250, 250),
                fontWeight: FontWeight.bold,
                fontSize: 22)),
        scaffoldBackgroundColor: const Color.fromARGB(255, 28, 28, 29),
        dataTableTheme: DataTableThemeData(
          headingRowColor: MaterialStateColor.resolveWith(
              (states) => const Color.fromARGB(255, 204, 36, 68)),
          headingTextStyle:
              const TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
          dataTextStyle: const TextStyle(
            color: Color.fromARGB(255, 250, 250, 250),
          ),
        ),
        elevatedButtonTheme: ElevatedButtonThemeData(
          style: ElevatedButton.styleFrom(
            backgroundColor: const Color.fromARGB(255, 204, 36, 68),
            foregroundColor: const Color.fromARGB(255, 250, 250, 250),
          ),
        ),
        inputDecorationTheme: const InputDecorationTheme(
          hintStyle: TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
          labelStyle: TextStyle(color: Color.fromARGB(255, 144, 135, 135)),
        ),
        colorScheme: ColorScheme.fromSeed(
            seedColor: const Color.fromARGB(255, 204, 36, 68)),
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
