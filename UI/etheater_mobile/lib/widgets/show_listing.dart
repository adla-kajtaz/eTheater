import 'package:etheater_mobile/models/models.dart';
import 'package:etheater_mobile/screens/show_details.dart';
import 'package:flutter/material.dart';
import '../utils/util.dart';

class ShowListing extends StatelessWidget {
  final List<ShowSchedule> showSchedules;
  const ShowListing({super.key, required this.showSchedules});

  @override
  Widget build(BuildContext context) {
    return ListView.builder(
        itemCount: showSchedules.length,
        scrollDirection: Axis.vertical,
        itemBuilder: (BuildContext context, int index) {
          final showSchedule = showSchedules[index];
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
                              showSchedule.show!.picture!,
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
                          showSchedule.show!.name,
                          style: const TextStyle(
                              fontWeight: FontWeight.bold, fontSize: 16),
                        ),
                        Text(
                          '${showSchedule.showDate.toString().substring(0, 10)}, ${showSchedule.showTime.toString()}',
                          style: const TextStyle(fontSize: 12),
                        ),
                        const SizedBox(height: 30),
                        Center(
                          child: ElevatedButton(
                            onPressed: () {
                              Navigator.push(
                                context,
                                MaterialPageRoute(
                                  builder: (context) =>
                                      ShowDetails(showSchedule: showSchedule),
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
