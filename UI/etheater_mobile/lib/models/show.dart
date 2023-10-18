import 'package:etheater_mobile/models/models.dart';
import 'package:json_annotation/json_annotation.dart';

part 'show.g.dart';

@JsonSerializable()
class Show {
  int showId;
  String showName;
  String showDescription;
  String? picture;
  int duration;
  String director;
  int? showGenreId;
  ShowGenre? showGenre;

  Show(
      {required this.showId,
      required this.showName,
      required this.showDescription,
      this.picture,
      required this.duration,
      required this.director,
      this.showGenreId,
      this.showGenre});

  factory Show.fromJson(Map<String, dynamic> json) => _$ShowFromJson(json);
  Map<String, dynamic> toJson() => _$ShowToJson(this);
}
