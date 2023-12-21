import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../models/models.dart';
import '../providers/notification_provider.dart';
import '../widgets/news_listing.dart';

class News extends StatefulWidget {
  const News({super.key});

  @override
  State<News> createState() => _NewsState();
}

class _NewsState extends State<News> {
  List<NotificationEtheater> notifications = [];
  NotificationProvider? _notificationProvider;

  @override
  void initState() {
    super.initState();
    _notificationProvider = context.read<NotificationProvider>();
    loadData();
  }

  Future loadData() async {
    var tempData = await _notificationProvider?.get();

    setState(() {
      notifications = tempData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Scaffold(
        backgroundColor: const Color.fromARGB(255, 28, 28, 29),
        appBar: AppBar(
          automaticallyImplyLeading: false,
          backgroundColor: const Color.fromARGB(255, 28, 28, 29),
          title: const Text(
            'News',
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
        ),
        body: Padding(
          padding: const EdgeInsets.all(16),
          child: NewsListing(notifications: [...notifications]),
        ),
      ),
    );
  }
}
