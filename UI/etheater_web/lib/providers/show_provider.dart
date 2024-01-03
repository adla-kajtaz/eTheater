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

  Future<RevenuesPerShow> getRevenue(int id) async {
    var url = "${_baseUrl}Show/revenuesPerShowReport/$id";
    var uri = Uri.parse(url);
    Map<String, String> headers = createHeaders();

    var response = await http!.get(uri, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return RevenuesPerShow.fromJson(data);
    } else {
      throw Exception("Exception... handle this gracefully");
    }
  }
}
