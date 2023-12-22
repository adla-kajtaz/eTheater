import 'package:json_annotation/json_annotation.dart';

part 'hall.g.dart';

@JsonSerializable()
class Hall {
  int hallId;
  String name;
  int totalSeats;
  int totalRows;
  int numberOfSeatsPerRow;
  bool? isDeleted;

  Hall(
      {required this.hallId,
      required this.name,
      required this.totalSeats,
      required this.totalRows,
      required this.numberOfSeatsPerRow,
      this.isDeleted});

  factory Hall.fromJson(Map<String, dynamic> json) => _$HallFromJson(json);
  Map<String, dynamic> toJson() => _$HallToJson(this);
}
