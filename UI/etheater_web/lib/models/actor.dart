import 'package:json_annotation/json_annotation.dart';

part 'actor.g.dart';

@JsonSerializable()
class Actor {
  int actorId;
  String firstName;
  String lastName;
  bool? isDeleted;

  Actor(
      {required this.actorId,
      required this.firstName,
      required this.lastName,
      this.isDeleted});

  factory Actor.fromJson(Map<String, dynamic> json) => _$ActorFromJson(json);
  Map<String, dynamic> toJson() => _$ActorToJson(this);
}
