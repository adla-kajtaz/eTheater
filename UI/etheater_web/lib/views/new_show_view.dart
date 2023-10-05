import 'package:flutter/material.dart';

class NewShow extends StatefulWidget {
  static const routeName = '/newShow';

  const NewShow({super.key});

  @override
  _NewShowState createState() => _NewShowState();
}

class _NewShowState extends State<NewShow> {
  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Center(
      child: Text('nestooo'),
    ));
  }
}
