import 'package:etheater_mobile/models/models.dart';
import 'package:etheater_mobile/screens/screens.dart';
import 'package:flutter/material.dart';
import '../utils/util.dart';

class NewsListing extends StatelessWidget {
  final List<NotificationEtheater> notifications;
  const NewsListing({super.key, required this.notifications});

  @override
  Widget build(BuildContext context) {
    return ListView.builder(
        itemCount: notifications.length,
        scrollDirection: Axis.vertical,
        itemBuilder: (BuildContext context, int index) {
          final notification = notifications[index];
          return Container(
            margin: const EdgeInsets.symmetric(vertical: 10, horizontal: 10),
            height: 150,
            decoration: BoxDecoration(
              color: Colors.white,
              borderRadius: BorderRadius.circular(5),
            ),
            child: Row(
              children: [
                Container(
                  height: 150,
                  width: 120,
                  child: ClipRRect(
                    child: Stack(
                      children: [
                        Positioned.fill(
                          child: SizedBox.expand(
                            child: imageFromBase64String(
                              notification.picture!,
                            ),
                          ),
                        )
                      ],
                    ),
                  ),
                ),
                Expanded(
                  child: Padding(
                    padding: const EdgeInsets.all(10.0),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          notification!.title,
                          style: const TextStyle(
                              fontWeight: FontWeight.bold, fontSize: 12),
                        ),
                        Text(
                          '${notification.user.userName.toString()}, ${notification.createdAt.toString().substring(0, 10)}',
                          style: const TextStyle(fontSize: 12),
                        ),
                        const SizedBox(height: 20),
                        Center(
                          child: ElevatedButton(
                            onPressed: () {
                              Navigator.push(
                                context,
                                MaterialPageRoute(
                                  builder: (context) =>
                                      NewsDetails(notification: notification),
                                ),
                              );
                            },
                            style: ElevatedButton.styleFrom(
                                backgroundColor:
                                    const Color.fromARGB(255, 40, 38, 38)),
                            child: const Text(
                              'Read more',
                              style:
                                  TextStyle(fontSize: 12, color: Colors.white),
                            ),
                          ),
                        ),
                      ],
                    ),
                  ),
                ),
              ],
            ),
          );
        });
  }
}
