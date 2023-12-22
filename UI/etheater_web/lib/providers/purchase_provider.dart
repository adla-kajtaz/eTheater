import 'dart:convert';
import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/base_provider.dart';

/*class PurchaseProvider extends BaseProvider<Purchase> {
  static String? _baseUrl;
  PurchaseProvider() : super("Purchase") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://localhost:5192/");
  }

  @override
  Purchase fromJson(data) {
    return Purchase.fromJson(data);
  }

  Future<List<Purchase>> getByUser() async {
    var url = "$_baseUrl" + "Purchase/GetByUser";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var response = await http!.get(uri, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return data.map((x) => Purchase.fromJson(x)).cast<Purchase>().toList();
    } else {
      throw Exception("Something went wrong");
    }
  }

  Future<Purchase> changeStatus(dynamic request) async {
    var url = "$_baseUrl" + "Purchase/";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();

    var response =
        await http!.patch(uri, headers: headers, body: jsonEncode(request));

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      throw Exception("Something went wrong");
    }
  }
}*/
