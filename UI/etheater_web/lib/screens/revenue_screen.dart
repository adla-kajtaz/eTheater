import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class RevenueScreen extends StatefulWidget {
  const RevenueScreen({super.key});

  @override
  State<RevenueScreen> createState() => _RevenueScreenState();
}

class _RevenueScreenState extends State<RevenueScreen> {
  ShowProvider? _showProvider;
  RevenuesPerShow? _revenue;
  List<Show>? _shows;
  Show? _selectedShow;

  @override
  void initState() {
    super.initState();
    _showProvider = context.read<ShowProvider>();
    loadPredstave();
  }

  void loadData() async {
    var data = await _showProvider!.getRevenue(_selectedShow!.showId);
    setState(() {
      _revenue = data;
    });
  }

  void loadPredstave() async {
    var data = await _showProvider!.get();
    setState(() {
      _shows = [...data];
      _selectedShow = data[0];
      loadData();
    });
  }

  @override
  Widget build(BuildContext context) {
    if (_shows == null) {
      return const Center(child: CircularProgressIndicator());
    }
    return Scaffold(
        body: SingleChildScrollView(
            child: Center(
                child: SizedBox(
                    width: 400,
                    height: 400,
                    child: Column(children: [
                      Row(
                          crossAxisAlignment: CrossAxisAlignment.center,
                          children: [
                            Expanded(
                              child: DropdownButtonFormField<Show>(
                                decoration: InputDecoration(
                                  labelText: 'Show',
                                  labelStyle: TextStyle(
                                      color: Theme.of(context).primaryColor),
                                  enabledBorder: UnderlineInputBorder(
                                    borderSide: BorderSide(
                                        color: Theme.of(context).primaryColor),
                                  ),
                                ),
                                value: _selectedShow,
                                onChanged: (Show? s) {
                                  setState(() {
                                    _selectedShow = s!;
                                    loadData();
                                  });
                                },
                                items: _shows!
                                    .map<DropdownMenuItem<Show>>((Show s) {
                                  return DropdownMenuItem<Show>(
                                    value: s,
                                    child: Text(s.name),
                                  );
                                }).toList(),
                              ),
                            ),
                          ]),
                      const SizedBox(height: 30),
                      if (_revenue != null)
                        Container(
                            width: double.infinity,
                            height: 120,
                            color: Theme.of(context).primaryColor,
                            child: Column(
                              children: [
                                Text(
                                  'Revenue: ${_revenue!.totalRevenues} KM',
                                  style: const TextStyle(
                                      fontSize: 20,
                                      fontWeight: FontWeight.bold,
                                      color: Colors.white),
                                ),
                                const SizedBox(height: 10),
                                Text(
                                  'Number of schedules: ${_revenue!.numberOfShowSchedules}',
                                  style: const TextStyle(
                                      fontSize: 20,
                                      fontWeight: FontWeight.bold,
                                      color: Colors.white),
                                ),
                                const SizedBox(height: 10),
                                Text(
                                  'Number of sold tickets: ${_revenue!.numberOfTickets}',
                                  style: const TextStyle(
                                      fontSize: 20,
                                      fontWeight: FontWeight.bold,
                                      color: Colors.white),
                                ),
                              ],
                            ))
                    ])))));
  }
}
