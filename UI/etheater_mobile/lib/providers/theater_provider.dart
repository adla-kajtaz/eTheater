import 'package:etheater_mobile/providers/base_provider.dart';
import '../models/models.dart';

class TheaterInfoProvider extends BaseProvider<TheaterInfo> {
  TheaterInfoProvider() : super("TheaterInfo");

  @override
  TheaterInfo fromJson(data) {
    return TheaterInfo.fromJson(data);
  }
}
