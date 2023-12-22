// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'show.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Show _$ShowFromJson(Map<String, dynamic> json) => Show(
      showId: json['showId'] as int,
      name: json['name'] as String,
      description: json['description'] as String,
      picture: json['picture'] as String?,
      duration: json['duration'] as int,
      director: json['director'] as String?,
      showGenre: Show.showGenreFromJson(json['showGenre'] as int),
      isDeleted: json['isDeleted'] as bool?,
    );

Map<String, dynamic> _$ShowToJson(Show instance) => <String, dynamic>{
      'showId': instance.showId,
      'name': instance.name,
      'description': instance.description,
      'picture': instance.picture,
      'duration': instance.duration,
      'director': instance.director,
      'showGenre': Show.showGenreToJson(instance.showGenre),
      'isDeleted': instance.isDeleted,
    };
