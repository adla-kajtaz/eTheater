import 'package:etheater_mobile/models/models.dart';
import 'package:etheater_mobile/screens/screens.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../providers/purchase_provider.dart';
import '../widgets/purchase_history.dart';

class Profile extends StatefulWidget {
  const Profile({super.key});

  @override
  State<Profile> createState() => _ProfileState();
}

class _ProfileState extends State<Profile> {
  List<Purchase> purchases = [];
  PurchaseProvider? _purchaseProvider;
  @override
  void initState() {
    super.initState();
    _purchaseProvider = context.read<PurchaseProvider>();
    loadData();
  }

  Future loadData() async {
    var tempData = await _purchaseProvider?.getByUser();
    setState(() {
      purchases = tempData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 40, 38, 38),
      resizeToAvoidBottomInset: false,
      appBar: AppBar(
        automaticallyImplyLeading: false,
        backgroundColor: const Color.fromARGB(255, 40, 38, 38),
        title: const Text(
          'Profile',
          style: TextStyle(color: Colors.white),
        ),
        leading: IconButton(
          icon: const Icon(
            Icons.settings,
            color: Colors.white,
            size: 40,
          ),
          onPressed: () => Navigator.pushNamed(context, ProfilEdit.routeName),
        ),
        actions: const [
          Padding(
            padding: EdgeInsets.all(8.0),
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
              const SizedBox(height: 15),
              const Align(
                alignment: Alignment.centerLeft,
                child: Text(
                  'Your purchases',
                  style: TextStyle(
                    color: Color.fromARGB(255, 219, 209, 209),
                    fontSize: 20,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ),
              const SizedBox(height: 5),
              SizedBox(
                height: 550,
                width: double.infinity,
                child: PurchaseHistory(
                  purchases: [...purchases],
                ),
              ),
            ]),
          ),
        ),
      ),
    );
  }
}
