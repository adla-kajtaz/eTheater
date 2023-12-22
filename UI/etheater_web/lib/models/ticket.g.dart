// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'ticket.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Ticket _$TicketFromJson(Map<String, dynamic> json) => Ticket(
      ticketId: json['ticketId'] as int,
      seat: json['seat'] as String,
      numberOfRow: json['numberOfRow'] as String,
      numberOfSeat: json['numberOfSeat'] as int,
      isActive: json['isActive'] as bool,
      showScheduleId: json['showScheduleId'] as int?,
      showSchedule: json['showSchedule'] == null
          ? null
          : ShowSchedule.fromJson(json['showSchedule'] as Map<String, dynamic>),
      purchaseId: json['purchaseId'] as int?,
      purchase: json['purchase'] == null
          ? null
          : Purchase.fromJson(json['purchase'] as Map<String, dynamic>),
      isDeleted: json['isDeleted'] as bool?,
    );

Map<String, dynamic> _$TicketToJson(Ticket instance) => <String, dynamic>{
      'ticketId': instance.ticketId,
      'seat': instance.seat,
      'numberOfRow': instance.numberOfRow,
      'numberOfSeat': instance.numberOfSeat,
      'isActive': instance.isActive,
      'showScheduleId': instance.showScheduleId,
      'showSchedule': instance.showSchedule,
      'purchaseId': instance.purchaseId,
      'purchase': instance.purchase,
      'isDeleted': instance.isDeleted,
    };
