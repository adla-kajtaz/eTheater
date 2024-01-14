import 'package:etheater_web/models/models.dart';
import 'package:etheater_web/providers/base_provider.dart';

class ActorProvider extends BaseProvider<Actor> {
  ActorProvider() : super("Actor");

  @override
  Actor fromJson(data) {
    return Actor.fromJson(data);
  }
}
