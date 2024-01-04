import 'package:json_annotation/json_annotation.dart';

part 'user.g.dart';

@JsonSerializable()
class User {
  int id;
  String userName;
  String email;
  bool? isDeleted;

  User(
      {required this.id,
      required this.userName,
      required this.email,
      this.isDeleted});

  factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);
  Map<String, dynamic> toJson() => _$UserToJson(this);
}
