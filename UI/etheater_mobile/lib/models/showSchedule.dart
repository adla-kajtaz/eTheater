import 'package:etheater_mobile/models/models.dart';
import 'package:json_annotation/json_annotation.dart';

part 'showSchedule.g.dart';

@JsonSerializable()
class ShowSchedule {
  int showScheduleId;
  int ticketPrice;
  DateTime showDateTime;
  int? hallId;
  Hall? hall;
  int? showId;
  Show? show;

  ShowSchedule(
      {required this.showScheduleId,
      required this.ticketPrice,
      required this.showDateTime,
      this.hallId,
      this.hall,
      this.showId,
      this.show});

  factory ShowSchedule.fromJson(Map<String, dynamic> json) =>
      _$ShowScheduleFromJson(json);
  Map<String, dynamic> toJson() => _$ShowScheduleToJson(this);
}
