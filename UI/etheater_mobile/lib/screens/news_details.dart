import 'package:flutter/material.dart';
import '../models/models.dart';
import '../utils/util.dart';

class NewsDetails extends StatefulWidget {
  static const routeName = '/newsDetails';

  final NotificationEtheater? notification;
  const NewsDetails({super.key, this.notification});

  @override
  State<NewsDetails> createState() => _NewsDetailsState();
}

class _NewsDetailsState extends State<NewsDetails> {
  @override
  Widget build(BuildContext context) {
    NotificationEtheater? _notification = widget.notification;
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 28, 28, 29),
      resizeToAvoidBottomInset: false,
      appBar: AppBar(
        automaticallyImplyLeading: false,
        backgroundColor: const Color.fromARGB(255, 28, 28, 29),
        leading: IconButton(
          icon: const Icon(Icons.arrow_back_ios_new_rounded,
              color: Color.fromARGB(225, 195, 178, 178)),
          onPressed: () => Navigator.of(context).pop(),
        ),
        title: const Text(
          'News details',
          style: TextStyle(color: Colors.white),
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
          child: Column(mainAxisAlignment: MainAxisAlignment.start, children: [
            SizedBox(
              height: 200,
              width: double.infinity,
              child: imageFromBase64String(
                _notification!.picture!,
              ),
            ),
            Padding(
              padding: const EdgeInsets.all(30.0),
              child: Column(
                children: [
                  Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    mainAxisAlignment: MainAxisAlignment.start,
                    children: [
                      Text(
                        _notification.title,
                        style: const TextStyle(
                          fontWeight: FontWeight.bold,
                          fontSize: 20,
                          color: Colors.white,
                        ),
                      ),
                      Text(
                        '${_notification.user.userName.toString()}, ${_notification.createdAt.toString().substring(0, 10)}',
                        style: const TextStyle(
                            color: Color.fromARGB(255, 227, 223, 223),
                            fontSize: 10),
                      ),
                      const SizedBox(height: 15),
                      Text(
                        _notification.content,
                        style: const TextStyle(
                            color: Color.fromARGB(255, 227, 223, 223)),
                      ),
                    ],
                  ),
                ],
              ),
            ),
          ]),
        ),
      ),
    );
  }
}
