import 'package:json_annotation/json_annotation.dart';

part 'hall.g.dart';

@JsonSerializable()
class Hall {
  int hallId;
  String hallName;
  int totalSeats;
  int totalRows;
  int numberOfSeatsPerRow;

  Hall({
    required this.hallId,
    required this.hallName,
    required this.totalSeats,
    required this.totalRows,
    required this.numberOfSeatsPerRow,
  });

  factory Hall.fromJson(Map<String, dynamic> json) => _$HallFromJson(json);
  Map<String, dynamic> toJson() => _$HallToJson(this);
}
