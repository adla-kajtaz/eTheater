// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'show.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Show _$ShowFromJson(Map<String, dynamic> json) => Show(
      showId: json['showId'] as int,
      showName: json['showName'] as String,
      showDescription: json['showDescription'] as String,
      picture: json['picture'] as String?,
      duration: json['duration'] as int,
      director: json['director'] as String,
      showGenreId: json['showGenreId'] as int?,
      showGenre: json['showGenre'] == null
          ? null
          : ShowGenre.fromJson(json['showGenre'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$ShowToJson(Show instance) => <String, dynamic>{
      'showId': instance.showId,
      'showName': instance.showName,
      'showDescription': instance.showDescription,
      'picture': instance.picture,
      'duration': instance.duration,
      'director': instance.director,
      'showGenreId': instance.showGenreId,
      'showGenre': instance.showGenre,
    };
