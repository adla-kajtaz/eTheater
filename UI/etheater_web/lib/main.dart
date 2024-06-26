import 'package:etheater_web/providers/providers.dart';
import 'package:etheater_web/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'screens/screens.dart';
import 'package:go_router/go_router.dart';

final GoRouter _router = GoRouter(
  initialLocation: LoginScreen.routeName,
  routes: <RouteBase>[
    GoRoute(
      path: LoginScreen.routeName,
      builder: (BuildContext context, GoRouterState state) {
        return const LoginScreen();
      },
    ),
    GoRoute(
      path: MainNavigationScreen.routeName,
      builder: (BuildContext context, GoRouterState state) {
        return const MainNavigationScreen();
      },
    ),
    GoRoute(
      path: TicketsScreen.routeName,
      builder: (BuildContext context, GoRouterState state) {
        final id = state.pathParameters['id'];
        return TicketsScreen(showScheduleId: int.parse(id as String));
      },
    ),
    GoRoute(
      path: ActorListScreen.routeName,
      builder: (BuildContext context, GoRouterState state) {
        final id = state.pathParameters['id'];
        final name = state.pathParameters['name'];
        return ActorListScreen(
          showId: int.parse(id as String),
          name: name as String,
        );
      },
    ),
  ],
);

void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  String token = await getUserToken();
  TokenProvider.jwtToken = token;

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
    return MaterialApp.router(
      routerConfig: _router,
      title: 'eTheater Admin',
      theme: ThemeData(
        primaryColor: const Color.fromARGB(255, 250, 250, 250),
        appBarTheme: const AppBarTheme(
            iconTheme: IconThemeData(color: Color.fromARGB(255, 250, 250, 250)),
            backgroundColor: Color.fromARGB(255, 28, 28, 29),
            titleTextStyle: TextStyle(
                color: Color.fromARGB(255, 250, 250, 250),
                fontWeight: FontWeight.bold,
                fontSize: 22)),
        scaffoldBackgroundColor: const Color.fromARGB(255, 28, 28, 29),
        dialogTheme: const DialogTheme(
            backgroundColor: Color.fromARGB(255, 51, 51, 52),
            titleTextStyle: TextStyle(
                color: Color.fromARGB(255, 250, 250, 250), fontSize: 20)),
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
          hintStyle: TextStyle(color: Color.fromARGB(255, 84, 77, 77)),
          labelStyle: TextStyle(color: Color.fromARGB(255, 144, 135, 135)),
          focusedBorder: UnderlineInputBorder(
            borderSide: BorderSide(color: Color.fromARGB(255, 144, 135, 135)),
          ),
        ),
        colorScheme: ColorScheme.fromSeed(
            seedColor: const Color.fromARGB(255, 204, 36, 68)),
        useMaterial3: true,
      ),
      //initialRoute: LoginScreen.routeName,
      /*routes: {
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
      },*/
    );
  }
}
