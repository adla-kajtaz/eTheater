import 'package:etheater_mobile/models/models.dart';
import 'package:etheater_mobile/providers/purchase_provider.dart';
import 'package:etheater_mobile/providers/ticket_provider.dart';
import 'package:etheater_mobile/screens/screens.dart';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:provider/provider.dart';

class Seats extends StatefulWidget {
  static const routeName = '/sjedista';

  final ShowSchedule? showSchedule;
  const Seats({super.key, this.showSchedule});

  @override
  State<Seats> createState() => _SeatsState();
}

class _SeatsState extends State<Seats> {
  List<Ticket> tickets = [];
  List<Ticket>? selectedSeats = [];
  TicketProvider? _ticketProvider;
  PurchaseProvider? _purchaseProvider;
  @override
  void initState() {
    super.initState();
    _ticketProvider = context.read<TicketProvider>();
    _purchaseProvider = context.read<PurchaseProvider>();
    loadData();
  }

  Future loadData() async {
    ShowSchedule? _showSchedule = widget.showSchedule;

    var tempData = await _ticketProvider
        ?.getByShowScheduleId(_showSchedule!.showScheduleId);
    setState(() {
      tickets = tempData!;
    });
  }

  void pay(BuildContext context, String paymentIntentId, int purchaseId) async {
    await Stripe.instance.initPaymentSheet(
      paymentSheetParameters: SetupPaymentSheetParameters(
        paymentIntentClientSecret: paymentIntentId,
        style: ThemeMode.light,
        merchantDisplayName: "eTheater",
      ),
    );
    try {
      var result = await Stripe.instance.presentPaymentSheet();
      dynamic request = {
        'purchaseId': purchaseId,
        'ticketList': selectedSeats?.map((x) => x.ticketId).toList(),
      };
      var purchase = await _purchaseProvider!.changeStatus(request);
      Navigator.pushNamed(context, SuccessfulPurchase.routeName);
    } catch (e) {
      print(e.toString());
    }
  }

  @override
  Widget build(BuildContext context) {
    ShowSchedule? _showSchedule = widget.showSchedule;
    if (tickets.isEmpty) {
      return Scaffold(
        backgroundColor: const Color.fromARGB(255, 28, 28, 29),
        resizeToAvoidBottomInset: false,
        appBar: AppBar(
          automaticallyImplyLeading: false,
          backgroundColor: const Color.fromARGB(255, 28, 28, 29),
          leading: IconButton(
            icon: const Icon(Icons.arrow_back_ios_new_rounded,
                color: Colors.white),
            onPressed: () => Navigator.of(context).pop(),
          ),
          title: const Text(
            'Seats',
            style: TextStyle(color: Colors.white),
          ),
        ),
        body: const Center(
          child: Text(
            'Loading ...',
            style: TextStyle(
              color: Color.fromARGB(225, 195, 178, 178),
            ),
          ),
        ),
      );
    }
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 40, 38, 38),
      resizeToAvoidBottomInset: false,
      appBar: AppBar(
        automaticallyImplyLeading: false,
        backgroundColor: const Color.fromARGB(255, 40, 38, 38),
        leading: IconButton(
          icon:
              const Icon(Icons.arrow_back_ios_new_rounded, color: Colors.white),
          onPressed: () => Navigator.of(context).pop(),
        ),
        title: const Text(
          'Seats',
          style: TextStyle(color: Colors.white),
        ),
      ),
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.all(30),
            child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                mainAxisAlignment: MainAxisAlignment.start,
                children: [
                  Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        _showSchedule!.show!.name,
                        style: const TextStyle(
                            fontWeight: FontWeight.bold,
                            fontSize: 25,
                            color: Colors.white),
                      ),
                      Text(
                          '${_showSchedule.showDate.toString().substring(0, 10)}, ${_showSchedule.showTime}',
                          style: const TextStyle(
                              color: Color.fromARGB(255, 227, 223, 223))),
                      Text(_showSchedule.hall!.name,
                          style: const TextStyle(
                              color: Color.fromARGB(255, 227, 223, 223))),
                      Text('Number of tickets: ${selectedSeats!.length}',
                          style: const TextStyle(
                              color: Color.fromARGB(255, 227, 223, 223))),
                      Text(
                          'Total price: ${(_showSchedule.ticketPrice! * selectedSeats!.length)} KM',
                          style: const TextStyle(
                              color: Color.fromARGB(255, 227, 223, 223))),
                    ],
                  ),
                  const SizedBox(
                    height: 10,
                  ),
                  Row(
                    children: [
                      Column(
                        children: [
                          Padding(
                              padding: const EdgeInsets.all(8),
                              child: Container(
                                  decoration: BoxDecoration(
                                      color: Colors.white,
                                      border: Border.all(
                                          color: Colors.grey,
                                          width: 1.0,
                                          style: BorderStyle.solid),
                                      borderRadius: BorderRadius.circular(4)),
                                  width: 20,
                                  height: 20)),
                          const Text("Free",
                              style: TextStyle(color: Colors.white)),
                        ],
                      ),
                      const SizedBox(
                        width: 40,
                      ),
                      Column(
                        children: [
                          Padding(
                              padding: const EdgeInsets.all(8),
                              child: Container(
                                  decoration: BoxDecoration(
                                      color: const Color.fromARGB(
                                          255, 222, 175, 7),
                                      border: Border.all(
                                          color: Colors.grey,
                                          width: 1.0,
                                          style: BorderStyle.solid),
                                      borderRadius: BorderRadius.circular(4)),
                                  width: 20,
                                  height: 20)),
                          const Text("Selected",
                              style: TextStyle(color: Colors.white)),
                        ],
                      ),
                      const SizedBox(
                        width: 40,
                      ),
                      Column(
                        children: [
                          Padding(
                              padding: const EdgeInsets.all(8),
                              child: Container(
                                  decoration: BoxDecoration(
                                      color: const Color.fromARGB(
                                          255, 184, 32, 32),
                                      border: Border.all(
                                          color: const Color.fromARGB(
                                              255, 56, 41, 41),
                                          width: 1.0,
                                          style: BorderStyle.solid),
                                      borderRadius: BorderRadius.circular(4)),
                                  width: 20,
                                  height: 20)),
                          const Text("Sold",
                              style: TextStyle(color: Colors.white)),
                        ],
                      ),
                    ],
                  ),
                  SizedBox(
                    height: 350,
                    width: double.infinity,
                    child: Padding(
                      padding: const EdgeInsets.all(5.0),
                      child: Row(
                        children: [
                          Expanded(
                            child: GridView.count(
                              crossAxisCount: 10,
                              children: List.generate(tickets.length, (index) {
                                final seat = tickets[index];
                                return InkWell(
                                    onTap: () {
                                      if (!seat.isActive) {
                                        showMessage("The seat is sold out!");
                                      } else if (selectedSeats!
                                          .contains(tickets[index])) {
                                        setState(() {
                                          selectedSeats!.remove(tickets[index]);
                                        });
                                      } else {
                                        setState(() {
                                          selectedSeats!.add(tickets[index]);
                                        });
                                      }
                                    },
                                    child: Container(
                                      width: 80,
                                      height: 80,
                                      decoration: BoxDecoration(
                                          border: Border.all(
                                              color: Colors.grey,
                                              width: 1.0,
                                              style: BorderStyle.solid),
                                          borderRadius:
                                              BorderRadius.circular(4),
                                          color: (selectedSeats!
                                                  .contains(tickets[index]))
                                              ? const Color.fromARGB(
                                                  255, 184, 32, 32)
                                              : (seat.isActive)
                                                  ? Colors.white
                                                  : const Color.fromARGB(
                                                      255, 222, 175, 7)),
                                      margin: const EdgeInsets.all(5),
                                      child: Center(
                                        child: Text(
                                          seat.seat,
                                          style: const TextStyle(fontSize: 6),
                                        ),
                                      ),
                                    ));
                              }),
                            ),
                          ),
                        ],
                      ),
                    ),
                  ),
                  const SizedBox(height: 40),
                  Center(
                    child: Container(
                      height: 50,
                      width: 200,
                      decoration: BoxDecoration(
                        color: const Color.fromARGB(223, 217, 217, 217),
                        borderRadius: BorderRadius.circular(10),
                      ),
                      child: InkWell(
                        onTap: () async {
                          if (selectedSeats!.isEmpty)
                            showMessage("You must choose at least one seat!");
                          else {
                            Map newPurchase = {
                              "showScheduleId": _showSchedule.showScheduleId,
                              "tickets":
                                  selectedSeats!.map((e) => e.ticketId).toList()
                            };
                            var data =
                                await _purchaseProvider?.insert(newPurchase);
                            pay(context, data!.paymentIntentId!,
                                data.purchaseId);
                          }
                        },
                        child: const Center(
                          child: Text(
                            'Pay',
                            style: TextStyle(
                              color: Color.fromARGB(225, 86, 81, 81),
                              fontSize: 20,
                            ),
                          ),
                        ),
                      ),
                    ),
                  ),
                ]),
          ),
        ),
      ),
    );
  }

  showMessage(String message) {
    return showDialog(
        context: context,
        builder: (BuildContext context) => AlertDialog(
              title: const Text("Message"),
              content: Text(message),
              actions: [
                TextButton(
                    child: const Text("Ok"),
                    onPressed: () => Navigator.pop(context))
              ],
            ));
  }
}
