// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'showSchedule.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ShowSchedule _$ShowScheduleFromJson(Map<String, dynamic> json) => ShowSchedule(
      showScheduleId: json['showScheduleId'] as int,
      ticketPrice: json['ticketPrice'] as int?,
      showDate: DateTime.parse(json['showDate'] as String),
      showTime: json['showTime'] as String?,
      hallId: json['hallId'] as int?,
      hall: json['hall'] == null
          ? null
          : Hall.fromJson(json['hall'] as Map<String, dynamic>),
      showId: json['showId'] as int?,
      show: json['show'] == null
          ? null
          : Show.fromJson(json['show'] as Map<String, dynamic>),
      isDeleted: json['isDeleted'] as bool?,
    );

Map<String, dynamic> _$ShowScheduleToJson(ShowSchedule instance) =>
    <String, dynamic>{
      'showScheduleId': instance.showScheduleId,
      'ticketPrice': instance.ticketPrice,
      'showDate': instance.showDate.toIso8601String(),
      'showTime': instance.showTime,
      'hallId': instance.hallId,
      'hall': instance.hall,
      'showId': instance.showId,
      'show': instance.show,
      'isDeleted': instance.isDeleted,
    };
