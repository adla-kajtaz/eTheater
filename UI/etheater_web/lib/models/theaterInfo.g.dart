// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'theaterInfo.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

TheaterInfo _$TheaterInfoFromJson(Map<String, dynamic> json) => TheaterInfo(
      theaterInfoId: json['theaterInfoId'] as int,
      name: json['name'] as String,
      logo: json['logo'] as String?,
      adress: json['adress'] as String?,
      email: json['email'] as String?,
      webpage: json['webpage'] as String?,
      phoneNumber: json['phoneNumber'] as String?,
      isDeleted: json['isDeleted'] as bool?,
    );

Map<String, dynamic> _$TheaterInfoToJson(TheaterInfo instance) =>
    <String, dynamic>{
      'theaterInfoId': instance.theaterInfoId,
      'name': instance.name,
      'logo': instance.logo,
      'adress': instance.adress,
      'email': instance.email,
      'webpage': instance.webpage,
      'phoneNumber': instance.phoneNumber,
      'isDeleted': instance.isDeleted,
    };
