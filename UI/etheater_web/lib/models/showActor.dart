import 'package:etheater_web/models/models.dart';
import 'package:json_annotation/json_annotation.dart';

part 'showActor.g.dart';

@JsonSerializable()
class ShowActor {
  int showActorId;
  int actorId;
  int showId;
  Actor? actor;
  Show? show;
  bool? isDeleted;

  ShowActor(
      {required this.showActorId,
      required this.actorId,
      required this.showId,
      this.actor,
      this.show,
      this.isDeleted});

  factory ShowActor.fromJson(Map<String, dynamic> json) =>
      _$ShowActorFromJson(json);
  Map<String, dynamic> toJson() => _$ShowActorToJson(this);
}
