import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class ShowRevenue extends StatefulWidget {
  final int showId;
  const ShowRevenue({
    super.key,
    required this.showId,
  });

  @override
  State<ShowRevenue> createState() => _ShowRevenueState();
}

class _ShowRevenueState extends State<ShowRevenue> {
  ShowProvider? _showProvider;
  RevenuesPerShow? _revenue;
  @override
  void initState() {
    super.initState();
    _showProvider = context.read<ShowProvider>();
    loadData();
  }

  void loadData() async {
    var data = await _showProvider!.getRevenue(widget.showId);
    setState(() {
      _revenue = data;
    });
  }

  @override
  Widget build(BuildContext context) {
    if (_revenue == null) {
      return const Center(
        child: CircularProgressIndicator(),
      );
    }
    return Column(
      mainAxisSize: MainAxisSize.min,
      children: [
        Text(
          'Revenue: ${_revenue!.totalRevenues} KM',
          style: const TextStyle(
            fontSize: 20,
            fontWeight: FontWeight.bold,
          ),
        ),
        const SizedBox(height: 10),
        Text(
          'Number of schedules: ${_revenue!.numberOfShowSchedules}',
          style: const TextStyle(
            fontSize: 20,
            fontWeight: FontWeight.bold,
          ),
        ),
        const SizedBox(height: 10),
        Text(
          'Number of sold tickets: ${_revenue!.numberOfTickets}',
          style: const TextStyle(
            fontSize: 20,
            fontWeight: FontWeight.bold,
          ),
        ),
      ],
    );
  }
}
