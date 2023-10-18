import 'package:json_annotation/json_annotation.dart';

part 'showGenre.g.dart';

@JsonSerializable()
class ShowGenre {
  int showGenreId;
  String showGenreName;

  ShowGenre({
    required this.showGenreId,
    required this.showGenreName,
  });

  factory ShowGenre.fromJson(Map<String, dynamic> json) =>
      _$ShowGenreFromJson(json);
  Map<String, dynamic> toJson() => _$ShowGenreToJson(this);
}
