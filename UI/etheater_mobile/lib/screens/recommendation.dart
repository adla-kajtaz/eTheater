import 'package:etheater_mobile/models/models.dart';
import 'package:etheater_mobile/screens/screens.dart';
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
          return GestureDetector(
              onTap: () => {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                        builder: (context) =>
                            ShowDetails(showSchedule: showSchedule),
                      ),
                    )
                  },
              child: Container(
                  margin:
                      const EdgeInsets.symmetric(vertical: 15, horizontal: 10),
                  height: 400,
                  width: 400,
                  child: ClipRRect(
                    borderRadius: BorderRadius.circular(10.0),
                    child: Stack(
                      children: [
                        Positioned.fill(
                          child: SizedBox.expand(
                            child: imageFromBase64String(
                              showSchedule.show!.picture!,
                            ),
                          ),
                        ),
                        Positioned(
                          top: 10,
                          right: 10,
                          child: Container(
                            padding: const EdgeInsets.symmetric(horizontal: 20),
                            decoration: BoxDecoration(
                              color: Colors.black.withOpacity(0.5),
                              borderRadius: BorderRadius.circular(5),
                            ),
                            child: Text(
                              ShowGenreString[showSchedule.show!.showGenre]
                                  as String,
                              style: const TextStyle(
                                  fontSize: 14,
                                  color: Color.fromARGB(255, 250, 250, 250)),
                            ),
                          ),
                        ),
                        Positioned(
                          bottom: 10,
                          left: 10,
                          child: Container(
                            padding: const EdgeInsets.symmetric(horizontal: 20),
                            decoration: BoxDecoration(
                              color: Colors.black.withOpacity(0.5),
                              borderRadius: BorderRadius.circular(5),
                            ),
                            child: Text(
                              showSchedule.show!.name,
                              style: const TextStyle(
                                fontSize: 14,
                                color: Color.fromARGB(255, 250, 250, 250),
                              ),
                            ),
                          ),
                        ),
                      ],
                    ),
                  )));
        });
  }
}
