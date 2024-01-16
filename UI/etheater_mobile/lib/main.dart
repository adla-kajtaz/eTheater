import 'package:etheater_mobile/providers/auth_provider.dart';
import 'package:etheater_mobile/providers/notification_provider.dart';
import 'package:etheater_mobile/providers/purchase_provider.dart';
import 'package:etheater_mobile/providers/showSchedule_provider.dart';
import 'package:etheater_mobile/providers/theater_provider.dart';
import 'package:etheater_mobile/providers/ticket_provider.dart';
import 'package:etheater_mobile/providers/user_provider.dart';
import 'package:etheater_mobile/screens/screens.dart';
import 'package:etheater_mobile/screens/show_listing.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:flutter_stripe/flutter_stripe.dart';

void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  Stripe.publishableKey =
      "pk_test_51NtWjdEDYm8POibPT31r3QwFT9jr7oT1eT5yHSjnxyTGdtLs1FNm9ytNJwylIdvHRaJBOFL97AkkR53eeYPSHCDE00nrXcw0rp";
  Stripe.merchantIdentifier = 'any string works';
  Stripe.urlScheme = "flutterstripe";
  await Stripe.instance.applySettings();
  runApp(
    MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => ShowScheduleProvider()),
        ChangeNotifierProvider(create: (_) => AuthProvider()),
        ChangeNotifierProvider(create: (_) => NotificationProvider()),
        ChangeNotifierProvider(create: (_) => PurchaseProvider()),
        ChangeNotifierProvider(create: (_) => UserProvider()),
        ChangeNotifierProvider(create: (_) => TicketProvider()),
        ChangeNotifierProvider(create: (_) => TheaterInfoProvider()),
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
            seedColor: const Color.fromARGB(255, 204, 36, 68)),
        useMaterial3: true,
      ),
      initialRoute: '/login',
      routes: {
        Login.routeName: (context) => const Login(),
        Register.routeName: (context) => const Register(),
        Navigation.routeName: (context) => const Navigation(),
        Recommend.routeName: (context) => const Recommend(),
        ShowListing.routeName: (context) => const ShowListing(),
        ProfilEdit.routeName: (context) => const ProfilEdit(),
        NewsDetails.routeName: (context) => const NewsDetails(),
        ShowDetails.routeName: (context) => const ShowDetails(),
        Seats.routeName: (context) => const Seats(),
        SuccessfulPurchase.routeName: (context) => const SuccessfulPurchase(),
      },
    );
  }
}
