// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'notification.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

NotificationEtheater _$NotificationEtheaterFromJson(
        Map<String, dynamic> json) =>
    NotificationEtheater(
      notificationId: json['notificationId'] as int,
      title: json['title'] as String,
      content: json['content'] as String,
      picture: json['picture'] as String?,
      notificationCategory: NotificationEtheater.notificationCategoryFromJson(
          json['notificationCategory'] as int),
      userId: json['userId'] as int?,
      user: json['user'] == null
          ? null
          : User.fromJson(json['user'] as Map<String, dynamic>),
      createdAt: DateTime.parse(json['createdAt'] as String),
      isDeleted: json['isDeleted'] as bool?,
    );

Map<String, dynamic> _$NotificationEtheaterToJson(
        NotificationEtheater instance) =>
    <String, dynamic>{
      'notificationId': instance.notificationId,
      'title': instance.title,
      'content': instance.content,
      'picture': instance.picture,
      'notificationCategory': NotificationEtheater.notificationCategoryToJson(
          instance.notificationCategory),
      'userId': instance.userId,
      'user': instance.user,
      'createdAt': instance.createdAt.toIso8601String(),
      'isDeleted': instance.isDeleted,
    };
