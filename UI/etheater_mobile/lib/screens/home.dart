import 'package:etheater_mobile/models/models.dart';
import 'package:etheater_mobile/screens/recommendation.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../providers/showSchedule_provider.dart';
import 'show_listing.dart';

class Home extends StatefulWidget {
  const Home({super.key});
  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home> {
  List<ShowSchedule> showSchedules = [];
  ShowScheduleProvider? _showScheduleProvider;

  final List<Tab> myTabs = <Tab>[
    const Tab(text: 'Now'),
    const Tab(text: 'Recommended')
  ];

  @override
  void initState() {
    super.initState();
    _showScheduleProvider = context.read<ShowScheduleProvider>();
    loadData();
  }

  Future loadData() async {
    var tempData = await _showScheduleProvider?.get();

    setState(() {
      showSchedules = tempData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return DefaultTabController(
      length: 2,
      child: SafeArea(
        child: Scaffold(
          backgroundColor: const Color.fromARGB(255, 28, 28, 29),
          appBar: AppBar(
            automaticallyImplyLeading: false,
            backgroundColor: const Color.fromARGB(255, 28, 28, 29),
            title: const Text(
              'Shows',
              style: TextStyle(
                  color: Color.fromARGB(255, 250, 250, 250),
                  fontWeight: FontWeight.bold),
            ),
            actions: const [
              Padding(
                padding: EdgeInsets.all(8.0),
                child: Icon(
                  Icons.theater_comedy,
                  color: Color.fromARGB(255, 250, 250, 250),
                  size: 40,
                ),
              ),
            ],
            bottom: TabBar(
                labelColor: Colors.white,
                unselectedLabelColor: const Color.fromARGB(225, 195, 178, 178),
                indicatorColor: Colors.white,
                tabs: myTabs),
          ),
          body: const Padding(
            padding: EdgeInsets.all(16),
            child: TabBarView(
              children: [
                ShowListing(),
                Recommend(),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
