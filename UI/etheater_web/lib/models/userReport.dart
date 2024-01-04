import 'package:etheater_web/models/userPurchases.dart';
import 'package:json_annotation/json_annotation.dart';

part 'userReport.g.dart';

@JsonSerializable()
class UserReport {
  List<UserPurchases>? purchases;
  int totalPrice;

  UserReport({
    this.purchases,
    required this.totalPrice,
  });

  factory UserReport.fromJson(Map<String, dynamic> json) =>
      _$UserReportFromJson(json);
  Map<String, dynamic> toJson() => _$UserReportToJson(this);
}
