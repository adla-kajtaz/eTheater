import 'package:etheater_mobile/models/models.dart';
import 'package:etheater_mobile/providers/showSchedule_provider.dart';
import 'package:etheater_mobile/screens/show_details.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../utils/util.dart';

class ShowListing extends StatefulWidget {
  static const routeName = "/show-listing";
  const ShowListing({super.key});

  @override
  State<ShowListing> createState() => _ShowListingState();
}

class _ShowListingState extends State<ShowListing> {
  List<ShowSchedule> showSchedules = [];
  ShowScheduleProvider? _showScheduleProvider;
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _showScheduleProvider = context.read<ShowScheduleProvider>();
    loadData();
  }

  void loadData() async {
    var tempData =
        await _showScheduleProvider!.get({'ShowName': _searchController.text});
    setState(() {
      showSchedules = tempData;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        Padding(
          padding: const EdgeInsets.symmetric(horizontal: 10),
          child: Row(children: [
            Expanded(
              child: TextFormField(
                controller: _searchController,
                style: const TextStyle(
                  color: Color.fromARGB(255, 250, 250, 250),
                  height: 1,
                  fontSize: 12,
                ),
                decoration: InputDecoration(
                  hintText: 'Search by show name',
                  hintStyle: const TextStyle(
                      color: Color.fromARGB(255, 250, 250, 250)),
                  contentPadding:
                      const EdgeInsets.symmetric(vertical: 10, horizontal: 15),
                  border: OutlineInputBorder(
                    borderRadius: BorderRadius.circular(10),
                  ),
                ),
              ),
            ),
            const SizedBox(width: 5.0),
            IconButton(
              onPressed: () {
                loadData();
              },
              icon: const Icon(
                Icons.search,
                color: Color.fromARGB(255, 204, 36, 68),
              ),
            ),
          ]),
        ),
        const SizedBox(height: 10),
        Expanded(
          child: ListView.builder(
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
                        margin: const EdgeInsets.symmetric(
                            vertical: 15, horizontal: 10),
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
                                  padding: const EdgeInsets.symmetric(
                                      horizontal: 20),
                                  decoration: BoxDecoration(
                                    color: Colors.black.withOpacity(0.5),
                                    borderRadius: BorderRadius.circular(5),
                                  ),
                                  child: Text(
                                    ShowGenreString[
                                        showSchedule.show!.showGenre] as String,
                                    style: const TextStyle(
                                        fontSize: 14,
                                        color:
                                            Color.fromARGB(255, 250, 250, 250)),
                                  ),
                                ),
                              ),
                              Positioned(
                                bottom: 10,
                                left: 10,
                                child: Container(
                                  padding: const EdgeInsets.symmetric(
                                      horizontal: 20),
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
              }),
        ),
      ],
    );
  }
}
