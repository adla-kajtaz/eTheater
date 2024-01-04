// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'userReport.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

UserReport _$UserReportFromJson(Map<String, dynamic> json) => UserReport(
      purchases: (json['purchases'] as List<dynamic>?)
          ?.map((e) => UserPurchases.fromJson(e as Map<String, dynamic>))
          .toList(),
      totalPrice: json['totalPrice'] as int,
    );

Map<String, dynamic> _$UserReportToJson(UserReport instance) =>
    <String, dynamic>{
      'purchases': instance.purchases,
      'totalPrice': instance.totalPrice,
    };
