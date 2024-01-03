import 'dart:convert';
import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/providers.dart';

class UserProvider extends BaseProvider<User> {
  static String? _baseUrl;
  UserProvider() : super("User") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://localhost:5192/");
  }

  @override
  User fromJson(data) {
    return User.fromJson(data);
  }

  Future<User?> getMe() async {
    var url = "$_baseUrl" + "User/getMe";
    var headers = createHeaders();
    var uri = Uri.parse(url);
    var response = await http!.get(uri, headers: headers);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    }
    return null;
  }

  Future<User?> updateProfile(int id, dynamic request) async {
    var url = "$_baseUrl" + "User/$id";
    var headers = createHeaders();
    var uri = Uri.parse(url);
    var jsonRequest = jsonEncode(request);
    var response = await http!.put(uri, headers: headers, body: jsonRequest);
    if (response.statusCode == 200) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else if (response.statusCode == 400) {
      if (response.body.isNotEmpty) {
        var data = jsonDecode(response.body);
        throw Exception("Bad request ${data["error"].toString()}");
      }
      throw Exception('Bad request');
    }
    return null;
  }
}
