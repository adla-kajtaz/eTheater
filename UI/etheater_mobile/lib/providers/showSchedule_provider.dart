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
}
