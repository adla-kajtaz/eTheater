import 'package:etheater_mobile/models/models.dart';
import 'package:json_annotation/json_annotation.dart';

part 'showSchedule.g.dart';

@JsonSerializable()
class ShowSchedule {
  int showScheduleId;
  int? ticketPrice;
  DateTime showDate;
  String? showTime;
  int? hallId;
  Hall? hall;
  int? showId;
  Show? show;
  bool? isDeleted;

  ShowSchedule(
      {required this.showScheduleId,
      this.ticketPrice,
      required this.showDate,
      this.showTime,
      this.hallId,
      this.hall,
      this.showId,
      this.show,
      this.isDeleted});

  factory ShowSchedule.fromJson(Map<String, dynamic> json) =>
      _$ShowScheduleFromJson(json);
  Map<String, dynamic> toJson() => _$ShowScheduleToJson(this);
}
