import 'package:etheater_web/models/models.dart';
import 'package:flutter/material.dart';

class TicketView extends StatelessWidget {
  final int numberOfRows;
  final int numberOfSeatsPerRow;
  final int numberOfSeats;
  final int free;
  final int sold;
  final List<Ticket> _tickets;

  const TicketView({
    super.key,
    required this.numberOfRows,
    required this.numberOfSeatsPerRow,
    required this.numberOfSeats,
    required this.free,
    required this.sold,
    required tickets,
  }) : _tickets = tickets;

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          Row(
            children: [
              Container(width: 20, height: 20, color: Colors.yellow),
              const SizedBox(width: 10),
              Text(
                'Free: $free',
                style:
                    const TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              )
            ],
          ),
          const SizedBox(height: 16),
          Row(
            children: [
              Container(
                  width: 20,
                  height: 20,
                  color: const Color.fromARGB(255, 204, 36, 68)),
              const SizedBox(width: 10),
              Text(
                'Sold: $sold',
                style:
                    const TextStyle(color: Color.fromARGB(255, 250, 250, 250)),
              )
            ],
          ),
          const SizedBox(height: 16),
          SizedBox(
            height: 300,
            width: 600,
            child: GridView.builder(
              itemCount: _tickets.length,
              gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                crossAxisCount: numberOfSeatsPerRow,
              ),
              itemBuilder: (context, index) {
                return Container(
                  margin: const EdgeInsets.all(2.0),
                  decoration: BoxDecoration(
                    color: _tickets[index].isActive
                        ? Colors.yellow
                        : const Color.fromARGB(255, 204, 36, 68),
                    border: Border.all(color: Colors.black),
                  ),
                  child: Center(
                    child: Text(
                      _tickets[index].seat,
                      textAlign: TextAlign.center,
                    ),
                  ),
                );
              },
            ),
          ),
        ],
      ),
    );
  }
}
