import 'dart:convert';
import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/base_provider.dart';

class ShowScheduleProvider extends BaseProvider<ShowSchedule> {
  static String? _baseUrl;
  ShowScheduleProvider() : super("ShowSchedule") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://localhost:5192/");
  }

  @override
  ShowSchedule fromJson(data) {
    return ShowSchedule.fromJson(data);
  }

  Future<List<ShowSchedule>> recommend() async {
    var url = "$_baseUrl" + "ShowSchedule/recommend";
    var headers = createHeaders();
    var uri = Uri.parse(url);
    var response = await http!.get(uri, headers: headers);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data.map((x) => fromJson(x)).cast<ShowSchedule>().toList();
    }
    throw Exception("Error on the server");
  }

  Future<List<String>> getTimeSlotsForDate([dynamic search]) async {
    var url = "$_baseUrl" + "ShowSchedule/getTimeSlotsForDate";
    if (search != null) {
      String queryString = getQueryString(search);
      url = "$url?$queryString";
    }
    var headers = createHeaders();
    var uri = Uri.parse(url);
    var response = await http!.get(uri, headers: headers);
    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      List<String> slots = List<String>.from(data);
      return slots;
    }
    return [];
  }

  Future<bool> deleteTickets(int id) async {
    var url = "$_baseUrl" + "ShowSchedule/deleteTickets/$id";
    var headers = createHeaders();
    var uri = Uri.parse(url);
    var response = await http!.get(uri, headers: headers);
    if (isValidResponseCode(response)) {
      return true;
    }
    throw Exception("Error on the server");
  }
}
