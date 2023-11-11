import 'dart:convert';
import 'dart:io';
import 'package:etheater_mobile/providers/base_provider.dart';
import 'package:http/io_client.dart';
import 'package:http/src/response.dart';

import '../models/models.dart';

class AuthProvider extends BaseProvider<Token> {
  HttpClient client = HttpClient();
  IOClient? http;
  static String? _baseUrl;

  AuthProvider() : super("Auth") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://10.0.2.2:5192/");
    print("baseurl: $_baseUrl");

    if (_baseUrl!.endsWith("/") == false) {
      _baseUrl = "${_baseUrl!}/";
    }
  }

  @override
  Token fromJson(data) {
    return Token.fromJson(data);
  }

  Future<Token?> login(dynamic request) async {
    var url = "$_baseUrl" + "Auth/login";
    var headers = createHeaders();
    var uri = Uri.parse(url);
    var jsonRequest = jsonEncode(request);
    var response = await http!.post(uri, headers: headers, body: jsonRequest);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    }
    return null;
  }

  Future<Token?> register(dynamic request) async {
    var url = "$_baseUrl" + "Auth/register";
    var headers = createHeaders();
    var uri = Uri.parse(url);
    var jsonRequest = jsonEncode(request);
    var response = await http!.post(uri, headers: headers, body: jsonRequest);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      return null;
    }
  }

  @override
  bool isValidResponseCode(Response response) {
    if (response.statusCode == 200) {
      if (response.body != "") {
        return true;
      } else {
        return false;
      }
    } else if (response.statusCode == 204) {
      return true;
    } else if (response.statusCode == 400) {
      if (response.body.isNotEmpty) {
        var data = jsonDecode(response.body);
        if (data['errors'] != null && !data['errors'].isEmpty) {
          var errorString = data['errors'];
          print("Error string is $errorString");
          throw Exception("Bad request $errorString");
        }
        throw Exception('Bad request');
      }
      throw Exception('Empty 400 response');
    } else if (response.statusCode == 401) {
      throw Exception("Unauthorized");
    } else if (response.statusCode == 403) {
      throw Exception("Forbidden");
    } else if (response.statusCode == 404) {
      throw Exception("Not found");
    } else if (response.statusCode == 500) {
      throw Exception("Internal server error");
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }
}
