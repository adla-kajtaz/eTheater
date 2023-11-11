import 'package:json_annotation/json_annotation.dart';

part 'theaterInfo.g.dart';

@JsonSerializable()
class TheaterInfo {
  int theaterInfoId;
  String name;
  String? logo;
  String? adress;
  String? email;
  String? webpage;
  String? phoneNumber;
  bool? isDeleted;

  TheaterInfo(
      {required this.theaterInfoId,
      required this.name,
      this.logo,
      this.adress,
      this.email,
      this.webpage,
      this.phoneNumber,
      this.isDeleted});

  factory TheaterInfo.fromJson(Map<String, dynamic> json) =>
      _$TheaterInfoFromJson(json);
  Map<String, dynamic> toJson() => _$TheaterInfoToJson(this);
}
