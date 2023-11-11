import 'package:json_annotation/json_annotation.dart';

enum ShowGenre { zeroPlaceholder, drama, komedija, opera, mjuzikl, balet }

class ShowGenreConverter implements JsonConverter<ShowGenre, int> {
  const ShowGenreConverter();
  @override
  ShowGenre fromJson(int json) {
    if (json == 0) {
      return ShowGenre.zeroPlaceholder;
    } else if (json == 1) {
      return ShowGenre.drama;
    } else if (json == 2) {
      return ShowGenre.komedija;
    } else if (json == 3) {
      return ShowGenre.opera;
    } else if (json == 4) {
      return ShowGenre.mjuzikl;
    } else if (json == 5) {
      return ShowGenre.balet;
    } else {
      throw ArgumentError('Invalid value: $json');
    }
  }

  @override
  int toJson(ShowGenre object) => object.index;
}

Map<ShowGenre, String> ShowGenreString = {
  ShowGenre.zeroPlaceholder: 'placeholder',
  ShowGenre.drama: 'drama',
  ShowGenre.komedija: 'komedija',
  ShowGenre.opera: 'opera',
  ShowGenre.mjuzikl: 'mjuzikl',
  ShowGenre.balet: 'balet',
};

enum NotificationCategory { zeroPlaceholder, novost, ponude, obavijest }

class NotificationCategoryConverter
    implements JsonConverter<NotificationCategory, int> {
  const NotificationCategoryConverter();
  @override
  NotificationCategory fromJson(int json) {
    if (json == 0) {
      return NotificationCategory.zeroPlaceholder;
    } else if (json == 1) {
      return NotificationCategory.novost;
    } else if (json == 2) {
      return NotificationCategory.ponude;
    } else if (json == 3) {
      return NotificationCategory.obavijest;
    } else {
      throw ArgumentError('Invalid value: $json');
    }
  }

  @override
  int toJson(NotificationCategory object) => object.index;
}

Map<NotificationCategory, String> NotificationCategoryString = {
  NotificationCategory.zeroPlaceholder: 'placeholder',
  NotificationCategory.novost: 'novost',
  NotificationCategory.ponude: 'ponude',
  NotificationCategory.obavijest: 'obavijest',
};
