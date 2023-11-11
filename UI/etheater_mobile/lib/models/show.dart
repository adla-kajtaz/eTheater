import 'package:json_annotation/json_annotation.dart';
import 'enums.dart';

part 'show.g.dart';

@JsonSerializable()
class Show {
  int showId;
  String name;
  String description;
  String? picture;
  int duration;
  String? director;
  @JsonKey(fromJson: showGenreFromJson, toJson: showGenreToJson)
  ShowGenre showGenre;
  bool? isDeleted;

  Show(
      {required this.showId,
      required this.name,
      required this.description,
      this.picture,
      required this.duration,
      this.director,
      required this.showGenre,
      this.isDeleted});

  factory Show.fromJson(Map<String, dynamic> json) => _$ShowFromJson(json);
  Map<String, dynamic> toJson() => _$ShowToJson(this);

  static ShowGenre showGenreFromJson(int json) =>
      const ShowGenreConverter().fromJson(json);
  static int showGenreToJson(ShowGenre object) =>
      const ShowGenreConverter().toJson(object);
}
