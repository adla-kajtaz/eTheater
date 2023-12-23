// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'actor.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Actor _$ActorFromJson(Map<String, dynamic> json) => Actor(
      actorId: json['actorId'] as int,
      firstName: json['firstName'] as String,
      lastName: json['lastName'] as String,
      isDeleted: json['isDeleted'] as bool?,
    );

Map<String, dynamic> _$ActorToJson(Actor instance) => <String, dynamic>{
      'actorId': instance.actorId,
      'firstName': instance.firstName,
      'lastName': instance.lastName,
      'isDeleted': instance.isDeleted,
    };
