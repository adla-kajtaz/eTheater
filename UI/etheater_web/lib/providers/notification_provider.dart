import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/base_provider.dart';

class NotificationProvider extends BaseProvider<NotificationEtheater> {
  static String? _baseUrl;
  NotificationProvider() : super("Notification") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://localhost:5192/");
  }

  @override
  NotificationEtheater fromJson(data) {
    return NotificationEtheater.fromJson(data);
  }
}
