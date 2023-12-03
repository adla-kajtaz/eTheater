import 'package:etheater_mobile/models/showSchedule.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../providers/showSchedule_provider.dart';
import '../utils/util.dart';

class Recommend extends StatefulWidget {
  static const routeName = '/recommend';
  const Recommend({super.key});

  @override
  State<Recommend> createState() => _RecommendState();
}

class _RecommendState extends State<Recommend> {
  List<ShowSchedule> showSchedules = [];
  ShowScheduleProvider? _showScheduleProvider;
  bool notEnough = false;

  @override
  void initState() {
    super.initState();
    _showScheduleProvider = context.read<ShowScheduleProvider>();
    loadData();
  }

  Future loadData() async {
    try {
      setState(() {
        notEnough = false;
      });
      var tempData = await _showScheduleProvider!.recommend();
      setState(() {
        showSchedules = tempData;
      });
    } catch (e) {
      setState(() {
        notEnough = true;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    if (notEnough) {
      return const Center(
        child: Text(
          'You must have at least 3 purchases before we recommend something!',
          style: TextStyle(
            color: Color.fromARGB(255, 219, 209, 209),
          ),
        ),
      );
    }
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
                SizedBox(
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
                            onPressed: () {},
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
