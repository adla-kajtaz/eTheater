import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/base_provider.dart';

class NotificationProvider extends BaseProvider<NotificationEtheater> {
  NotificationProvider() : super("Notification");

  @override
  NotificationEtheater fromJson(data) {
    return NotificationEtheater.fromJson(data);
  }
}
