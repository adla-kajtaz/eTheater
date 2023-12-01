import 'package:json_annotation/json_annotation.dart';
import 'enums.dart';
import 'models.dart';

part 'notification.g.dart';

@JsonSerializable()
class NotificationEtheater {
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

  NotificationEtheater(
      {required this.notificationId,
      required this.title,
      required this.content,
      this.picture,
      required this.notificationCategory,
      this.userId,
      required this.user,
      required this.createdAt,
      this.isDeleted});

  factory NotificationEtheater.fromJson(Map<String, dynamic> json) =>
      _$NotificationEtheaterFromJson(json);
  Map<String, dynamic> toJson() => _$NotificationEtheaterToJson(this);

  static NotificationCategory notificationCategoryFromJson(int json) =>
      const NotificationCategoryConverter().fromJson(json);
  static int notificationCategoryToJson(NotificationCategory object) =>
      const NotificationCategoryConverter().toJson(object);
}
