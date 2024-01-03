import 'package:etheater_web/providers/base_provider.dart';
import '../models/models.dart';

class ShowActorProvider extends BaseProvider<ShowActor> {
  ShowActorProvider() : super("ShowActor");

  @override
  ShowActor fromJson(data) {
    return ShowActor.fromJson(data);
  }
}
