// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'hall.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Hall _$HallFromJson(Map<String, dynamic> json) => Hall(
      hallId: json['hallId'] as int,
      name: json['name'] as String,
      totalSeats: json['totalSeats'] as int,
      totalRows: json['totalRows'] as int,
      numberOfSeatsPerRow: json['numberOfSeatsPerRow'] as int,
      isDeleted: json['isDeleted'] as bool?,
    );

Map<String, dynamic> _$HallToJson(Hall instance) => <String, dynamic>{
      'hallId': instance.hallId,
      'name': instance.name,
      'totalSeats': instance.totalSeats,
      'totalRows': instance.totalRows,
      'numberOfSeatsPerRow': instance.numberOfSeatsPerRow,
      'isDeleted': instance.isDeleted,
    };
