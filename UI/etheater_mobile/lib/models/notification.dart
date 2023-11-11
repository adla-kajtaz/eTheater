import 'package:json_annotation/json_annotation.dart';
import 'enums.dart';
import 'models.dart';

part 'notification.g.dart';

@JsonSerializable()
class Notification {
  int notificationId;
  String title;
  String content;
  String? picture;
  @JsonKey(
      fromJson: notificationCategoryFromJson,
      toJson: notificationCategoryToJson)
  NotificationCategory notificationCategory;
  int? userId;
  User user;
  DateTime createdAt;
  bool? isDeleted;

  Notification(
      {required this.notificationId,
      required this.title,
      required this.content,
      this.picture,
      required this.notificationCategory,
      this.userId,
      required this.user,
      required this.createdAt,
      this.isDeleted});

  factory Notification.fromJson(Map<String, dynamic> json) =>
      _$NotificationFromJson(json);
  Map<String, dynamic> toJson() => _$NotificationToJson(this);

  static NotificationCategory notificationCategoryFromJson(int json) =>
      const NotificationCategoryConverter().fromJson(json);
  static int notificationCategoryToJson(NotificationCategory object) =>
      const NotificationCategoryConverter().toJson(object);
}
