import 'package:etheater_mobile/models/showSchedule.dart';
import 'package:etheater_mobile/screens/seats.dart';
import 'package:flutter/material.dart';
import '../utils/util.dart';

class ShowDetails extends StatefulWidget {
  static const routeName = '/showDetails';

  final ShowSchedule? showSchedule;
  const ShowDetails({super.key, this.showSchedule});

  @override
  State<ShowDetails> createState() => _ShowDetailsState();
}

class _ShowDetailsState extends State<ShowDetails> {
  @override
  Widget build(BuildContext context) {
    ShowSchedule? _showSchedule = widget.showSchedule;
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 28, 28, 29),
      resizeToAvoidBottomInset: false,
      appBar: AppBar(
        automaticallyImplyLeading: false,
        backgroundColor: const Color.fromARGB(255, 28, 28, 29),
        leading: IconButton(
          icon: const Icon(Icons.arrow_back_ios_new_rounded,
              color: Color.fromARGB(255, 250, 250, 250)),
          onPressed: () => Navigator.of(context).pop(),
        ),
        title: Text(
          _showSchedule!.show!.name,
          style: const TextStyle(
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
      body: SingleChildScrollView(
        child: SafeArea(
            child: Column(
          mainAxisAlignment: MainAxisAlignment.start,
          children: [
            SizedBox(
              height: 200,
              width: double.infinity,
              child: imageFromBase64String(
                _showSchedule!.show!.picture!,
              ),
            ),
            Padding(
              padding: const EdgeInsets.all(30.0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                mainAxisAlignment: MainAxisAlignment.start,
                children: [
                  Container(
                    padding: const EdgeInsets.symmetric(horizontal: 20),
                    decoration: BoxDecoration(
                      borderRadius: BorderRadius.circular(5),
                      border: Border.all(
                        color: const Color.fromARGB(255, 144, 135, 135),
                        width: 1.0,
                      ),
                    ),
                    child: Text(
                      _showSchedule.show!.showGenre.name,
                      style: const TextStyle(
                          fontSize: 14,
                          color: Color.fromARGB(255, 144, 135, 135)),
                    ),
                  ),
                  const SizedBox(height: 10),
                  const Text(
                    "Description",
                    style: TextStyle(color: Color.fromARGB(255, 144, 135, 135)),
                  ),
                  Text(
                    _showSchedule.show!.description,
                    style: const TextStyle(
                        color: Color.fromARGB(255, 250, 250, 250)),
                  ),
                  const SizedBox(height: 5),
                  const Text(
                    "Director",
                    style: TextStyle(color: Color.fromARGB(255, 144, 135, 135)),
                  ),
                  Text(
                    _showSchedule.show!.director!,
                    style: const TextStyle(
                        color: Color.fromARGB(255, 250, 250, 250)),
                  ),
                ],
              ),
            ),
            const SizedBox(
              height: 15,
            ),
            Padding(
              padding: const EdgeInsets.all(30.0),
              child: Container(
                height: 150,
                width: double.infinity,
                decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(10),
                  border: Border.all(
                    color: const Color.fromARGB(255, 144, 135, 135),
                    width: 1.0,
                  ),
                ),
                child: Column(children: [
                  const SizedBox(
                    height: 7,
                  ),
                  Text(
                    '${_showSchedule.showDate.toString().substring(0, 10)}, ${_showSchedule.showTime}',
                    style: const TextStyle(
                        color: Color.fromARGB(255, 250, 250, 250)),
                  ),
                  Text(
                    _showSchedule.hall!.name,
                    style: const TextStyle(
                        color: Color.fromARGB(255, 250, 250, 250)),
                  ),
                  Text(
                    'Cijena karte: ${_showSchedule.ticketPrice} KM',
                    style: const TextStyle(
                        color: Color.fromARGB(255, 250, 250, 250)),
                  ),
                  const SizedBox(
                    height: 15,
                  ),
                  Container(
                    height: 40,
                    width: 200,
                    decoration: BoxDecoration(
                      color: const Color.fromARGB(255, 204, 36, 68),
                      borderRadius: BorderRadius.circular(10),
                    ),
                    child: InkWell(
                      onTap: () async {
                        try {
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                              builder: (context) =>
                                  Seats(showSchedule: _showSchedule),
                            ),
                          );
                        } catch (e) {
                          print(e.toString());
                        }
                      },
                      child: const Center(
                        child: Text(
                          'Buy',
                          style: TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250),
                            fontSize: 20,
                          ),
                        ),
                      ),
                    ),
                  ),
                ]),
              ),
            ),
          ],
        )),
      ),
    );
  }
}
