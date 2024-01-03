import 'package:json_annotation/json_annotation.dart';

part 'revenuesPerShow.g.dart';

@JsonSerializable()
class RevenuesPerShow {
  int numberOfTickets;
  int numberOfShowSchedules;
  int totalRevenues;

  RevenuesPerShow({
    required this.numberOfTickets,
    required this.numberOfShowSchedules,
    required this.totalRevenues,
  });

  factory RevenuesPerShow.fromJson(Map<String, dynamic> json) => _$RevenuesPerShowFromJson(json);
  Map<String, dynamic> toJson() => _$RevenuesPerShowToJson(this);
}