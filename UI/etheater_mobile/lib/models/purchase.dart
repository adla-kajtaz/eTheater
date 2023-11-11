import 'package:json_annotation/json_annotation.dart';
import 'models.dart';

part 'purchase.g.dart';

@JsonSerializable()
class Purchase {
  int purchaseId;
  int totalPrice;
  int numberOfTickets;
  bool isPaid;
  String? paymentIntentId;
  int? userId;
  User user;
  int? showScheduleId;
  ShowSchedule showSchedule;
  DateTime createdAt;

  Purchase(
      {required this.purchaseId,
      required this.totalPrice,
      required this.numberOfTickets,
      required this.isPaid,
      this.paymentIntentId,
      this.userId,
      required this.user,
      this.showScheduleId,
      required this.showSchedule,
      required this.createdAt});

  factory Purchase.fromJson(Map<String, dynamic> json) =>
      _$PurchaseFromJson(json);
  Map<String, dynamic> toJson() => _$PurchaseToJson(this);
}
