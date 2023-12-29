import 'dart:convert';
import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/base_provider.dart';

class ShowProvider extends BaseProvider<Show> {
  static String? _baseUrl;
  ShowProvider() : super("Show") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://localhost:5192/");
  }

  @override
  Show fromJson(data) {
    return Show.fromJson(data);
  }
}
