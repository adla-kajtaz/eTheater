// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'showActor.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ShowActor _$ShowActorFromJson(Map<String, dynamic> json) => ShowActor(
      showActorId: json['showActorId'] as int,
      actorId: json['actorId'] as int,
      showId: json['showId'] as int,
      actor: json['actor'] == null
          ? null
          : Actor.fromJson(json['actor'] as Map<String, dynamic>),
      show: json['show'] == null
          ? null
          : Show.fromJson(json['show'] as Map<String, dynamic>),
      isDeleted: json['isDeleted'] as bool?,
    );

Map<String, dynamic> _$ShowActorToJson(ShowActor instance) => <String, dynamic>{
      'showActorId': instance.showActorId,
      'actorId': instance.actorId,
      'showId': instance.showId,
      'actor': instance.actor,
      'show': instance.show,
      'isDeleted': instance.isDeleted,
    };
