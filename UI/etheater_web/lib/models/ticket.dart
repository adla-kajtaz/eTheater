import 'package:json_annotation/json_annotation.dart';
import 'models.dart';

part 'ticket.g.dart';

@JsonSerializable()
class Ticket {
  int ticketId;
  String seat;
  String numberOfRow;
  int numberOfSeat;
  bool isActive;
  int? showScheduleId;
  ShowSchedule? showSchedule;
  int? purchaseId;
  Purchase? purchase;
  bool? isDeleted;

  Ticket(
      {required this.ticketId,
      required this.seat,
      required this.numberOfRow,
      required this.numberOfSeat,
      required this.isActive,
      this.showScheduleId,
      this.showSchedule,
      this.purchaseId,
      this.purchase,
      this.isDeleted});

  factory Ticket.fromJson(Map<String, dynamic> json) => _$TicketFromJson(json);
  Map<String, dynamic> toJson() => _$TicketToJson(this);
}
