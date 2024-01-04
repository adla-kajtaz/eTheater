// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'userPurchases.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

UserPurchases _$UserPurchasesFromJson(Map<String, dynamic> json) =>
    UserPurchases(
      showName: json['showName'] as String,
      numberOfTickets: json['numberOfTickets'] as int,
      price: json['price'] as int,
    );

Map<String, dynamic> _$UserPurchasesToJson(UserPurchases instance) =>
    <String, dynamic>{
      'showName': instance.showName,
      'numberOfTickets': instance.numberOfTickets,
      'price': instance.price,
    };
