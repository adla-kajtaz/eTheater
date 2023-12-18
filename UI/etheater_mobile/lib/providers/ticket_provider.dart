import 'dart:convert';
import 'package:etheater_mobile/providers/base_provider.dart';

import '../models/models.dart';

class TicketProvider extends BaseProvider<Ticket> {
  static String? _baseUrl;
  TicketProvider() : super("Ticket") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://10.0.2.2:5192/");
  }

  @override
  Ticket fromJson(data) {
    return Ticket.fromJson(data);
  }

  Future<List<Ticket>> getByShowScheduleId(int id) async {
    var url = "$_baseUrl" + "Ticket/GetByShowScheduleId/$id";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var response = await http!.get(uri, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data.map((x) => Ticket.fromJson(x)).cast<Ticket>().toList();
    } else {
      throw Exception("Something went wrong");
    }
  }
}
