import 'package:etheater_mobile/models/models.dart';
import 'package:flutter/material.dart';
import '../utils/util.dart';

class PurchaseHistory extends StatelessWidget {
  final List<Purchase> purchases;
  const PurchaseHistory({super.key, required this.purchases});

  @override
  Widget build(BuildContext context) {
    if (purchases.isEmpty) {
      return const Text(
        'You have no purchases!',
        style: TextStyle(
          fontSize: 15,
          color: Color.fromARGB(255, 250, 250, 250),
        ),
      );
    }
    return ListView.builder(
        itemCount: purchases.length,
        scrollDirection: Axis.vertical,
        itemBuilder: (BuildContext context, int index) {
          final purchase = purchases[index];
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
                              purchase.showSchedule!.show!.picture!,
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
                          purchase.showSchedule!.show!.name,
                          style: const TextStyle(
                              fontWeight: FontWeight.bold, fontSize: 16),
                        ),
                        Text(
                          '${purchase.showSchedule!.showDate.toString().substring(0, 10)}, ${purchase.showSchedule!.showTime.toString()}',
                          style: const TextStyle(fontSize: 12),
                        ),
                        const SizedBox(height: 10),
                        Text(
                          'Number of tickets: ${purchase.numberOfTickets}',
                          style: const TextStyle(
                            fontSize: 17,
                          ),
                        ),
                        Text(
                          'Total price:  ${purchase.totalPrice} KM',
                          style: const TextStyle(
                            fontSize: 17,
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
