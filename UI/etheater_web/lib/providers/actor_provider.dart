import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/base_provider.dart';

class ActorProvider extends BaseProvider<Actor> {
  static String? _baseUrl;
  ActorProvider() : super("Actor") {
    _baseUrl = const String.fromEnvironment("baseUrl",
        defaultValue: "http://localhost:5192/");
  }

  @override
  Actor fromJson(data) {
    return Actor.fromJson(data);
  }
}
