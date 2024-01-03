// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'revenuesPerShow.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

RevenuesPerShow _$RevenuesPerShowFromJson(Map<String, dynamic> json) =>
    RevenuesPerShow(
      numberOfTickets: json['numberOfTickets'] as int,
      numberOfShowSchedules: json['numberOfShowSchedules'] as int,
      totalRevenues: json['totalRevenues'] as int,
    );

Map<String, dynamic> _$RevenuesPerShowToJson(RevenuesPerShow instance) =>
    <String, dynamic>{
      'numberOfTickets': instance.numberOfTickets,
      'numberOfShowSchedules': instance.numberOfShowSchedules,
      'totalRevenues': instance.totalRevenues,
    };
