import 'dart:convert';

import 'package:etheater_mobile/models/models.dart';
import 'package:etheater_mobile/providers/base_provider.dart';

class ShowScheduleProvider extends BaseProvider<ShowSchedule> {
  static String? _baseUrl;
  ShowScheduleProvider() : super("ShowSchedule") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://10.0.2.2:5192/");
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
}
