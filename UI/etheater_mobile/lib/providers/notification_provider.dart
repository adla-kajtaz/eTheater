import 'package:etheater_mobile/models/models.dart';
import 'package:etheater_mobile/providers/base_provider.dart';

class NotificationProvider extends BaseProvider<NotificationEtheater> {
  static String? _baseUrl;
  NotificationProvider() : super("Notification") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://10.0.2.2:5192/");
  }

  @override
  NotificationEtheater fromJson(data) {
    return NotificationEtheater.fromJson(data);
  }
}
