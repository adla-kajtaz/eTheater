import 'package:etheater_mobile/screens/screens.dart';
import 'package:flutter/material.dart';

class SuccessfulPurchase extends StatelessWidget {
  static const routeName = '/successfulPurchase';

  const SuccessfulPurchase({super.key});

  final IconData _icon = Icons.check_circle_outlined;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        backgroundColor: const Color.fromARGB(255, 28, 28, 29),
        resizeToAvoidBottomInset: false,
        body: SafeArea(
          child: Padding(
            padding: const EdgeInsets.all(30),
            child: Center(
              child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    Container(
                      height: 200,
                      width: double.infinity,
                      child: Column(
                        children: [
                          const SizedBox(height: 5),
                          const Text(
                            'Successful purchase',
                            style: TextStyle(
                                fontSize: 32,
                                color: Color.fromARGB(255, 250, 250, 250)),
                          ),
                          const SizedBox(height: 10),
                          Icon(
                            _icon,
                            size: 30,
                            color: const Color.fromARGB(255, 250, 250, 250),
                          ),
                          const SizedBox(height: 30),
                          Padding(
                            padding:
                                const EdgeInsets.symmetric(horizontal: 30.0),
                            child: InkWell(
                              onTap: () => Navigator.popAndPushNamed(
                                  context, Navigation.routeName),
                              borderRadius: BorderRadius.circular(5.0),
                              child: Container(
                                decoration: BoxDecoration(
                                  color: const Color.fromARGB(255, 204, 36, 68),
                                  borderRadius: BorderRadius.circular(10),
                                ),
                                height: 50,
                                width: double.infinity,
                                child: const Center(
                                  child: Text(
                                    'Go to the home page',
                                    style: TextStyle(
                                        color:
                                            Color.fromARGB(255, 250, 250, 250),
                                        fontSize: 22),
                                  ),
                                ),
                              ),
                            ),
                          ),
                        ],
                      ),
                    ),
                  ]),
            ),
          ),
        ));
  }
}
