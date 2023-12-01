import 'dart:convert';
import '../models/purchase.dart';
import 'base_provider.dart';

class PurchaseProvider extends BaseProvider<Purchase> {
  static String? _baseUrl;
  PurchaseProvider() : super("Purchase") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://10.0.2.2:5192/");
  }

  @override
  Purchase fromJson(data) {
    return Purchase.fromJson(data);
  }

  Future<List<Purchase>> getByUserId(int id) async {
    var url = "$_baseUrl" + "Purchase/GetByUserId/$id";
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
}
