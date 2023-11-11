// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'notification.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Notification _$NotificationFromJson(Map<String, dynamic> json) => Notification(
      notificationId: json['notificationId'] as int,
      title: json['title'] as String,
      content: json['content'] as String,
      picture: json['picture'] as String?,
      notificationCategory: Notification.notificationCategoryFromJson(
          json['notificationCategory'] as int),
      userId: json['userId'] as int?,
      user: User.fromJson(json['user'] as Map<String, dynamic>),
      createdAt: DateTime.parse(json['createdAt'] as String),
      isDeleted: json['isDeleted'] as bool?,
    );

Map<String, dynamic> _$NotificationToJson(Notification instance) =>
    <String, dynamic>{
      'notificationId': instance.notificationId,
      'title': instance.title,
      'content': instance.content,
      'picture': instance.picture,
      'notificationCategory': Notification.notificationCategoryToJson(
          instance.notificationCategory),
      'userId': instance.userId,
      'user': instance.user,
      'createdAt': instance.createdAt.toIso8601String(),
      'isDeleted': instance.isDeleted,
    };
