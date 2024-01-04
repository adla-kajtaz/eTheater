import 'package:json_annotation/json_annotation.dart';

part 'userPurchases.g.dart';

@JsonSerializable()
class UserPurchases {
  String showName;
  int numberOfTickets;
  int price;

  UserPurchases({
    required this.showName,
    required this.numberOfTickets,
    required this.price,
  });

  factory UserPurchases.fromJson(Map<String, dynamic> json) =>
      _$UserPurchasesFromJson(json);
  Map<String, dynamic> toJson() => _$UserPurchasesToJson(this);
}
