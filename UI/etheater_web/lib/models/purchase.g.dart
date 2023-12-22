// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'purchase.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Purchase _$PurchaseFromJson(Map<String, dynamic> json) => Purchase(
      purchaseId: json['purchaseId'] as int,
      totalPrice: json['totalPrice'] as int,
      numberOfTickets: json['numberOfTickets'] as int,
      isPaid: json['isPaid'] as bool,
      paymentIntentId: json['paymentIntentId'] as String?,
      userId: json['userId'] as int?,
      user: json['user'] == null
          ? null
          : User.fromJson(json['user'] as Map<String, dynamic>),
      showScheduleId: json['showScheduleId'] as int?,
      showSchedule: json['showSchedule'] == null
          ? null
          : ShowSchedule.fromJson(json['showSchedule'] as Map<String, dynamic>),
      createdAt: DateTime.parse(json['createdAt'] as String),
    );

Map<String, dynamic> _$PurchaseToJson(Purchase instance) => <String, dynamic>{
      'purchaseId': instance.purchaseId,
      'totalPrice': instance.totalPrice,
      'numberOfTickets': instance.numberOfTickets,
      'isPaid': instance.isPaid,
      'paymentIntentId': instance.paymentIntentId,
      'userId': instance.userId,
      'user': instance.user,
      'showScheduleId': instance.showScheduleId,
      'showSchedule': instance.showSchedule,
      'createdAt': instance.createdAt.toIso8601String(),
    };
