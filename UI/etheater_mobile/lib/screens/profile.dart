import 'package:etheater_mobile/screens/screens.dart';
import 'package:flutter/material.dart';

class Profile extends StatefulWidget {
  const Profile({super.key});

  @override
  State<Profile> createState() => _ProfileState();
}

class _ProfileState extends State<Profile> {
  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 40, 38, 38),
      resizeToAvoidBottomInset: false,
      appBar: AppBar(
        automaticallyImplyLeading: false,
        backgroundColor: const Color.fromARGB(255, 40, 38, 38),
        leading: Padding(
          padding: const EdgeInsets.all(8.0),
          child: Icon(
            Icons.settings,
            color: Colors.white,
            size: 40,
          ),
        ),
        actions: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Icon(
              Icons.theater_comedy,
              color: Colors.white,
              size: 40,
            ),
          ),
        ],
      ),
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.all(16),
            child: Column(children: [
              InkWell(
                onTap: () async {
                  Navigator.pushNamed(context, Login.routeName);
                },
                child: Container(
                  decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(10),
                    color: Colors.white,
                  ),
                  height: 50,
                  child: const Center(
                    child: Row(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        Text(
                          'Logout',
                          style: TextStyle(
                              color: Color.fromARGB(255, 40, 38, 38),
                              fontSize: 20),
                        ),
                        SizedBox(width: 10),
                        Icon(
                          Icons.logout_outlined,
                          color: Color.fromARGB(255, 40, 38, 38),
                          size: 20,
                        ),
                      ],
                    ),
                  ),
                ),
              ),
            ]),
          ),
        ),
      ),
    );
  }
}
