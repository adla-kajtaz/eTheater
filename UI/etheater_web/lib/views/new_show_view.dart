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
  /*Widget build(BuildContext context) {
    return Scaffold(
        body: Center(
      child: Text('nestooo'),
    ));
  }*/
  Widget build(BuildContext context) {
    return AlertDialog(
      title: Text('Modal Form'),
      content: Container(
        // You can place your form widgets here
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: <Widget>[
            TextField(
              decoration: InputDecoration(labelText: 'Name'),
            ),
            TextField(
              decoration: InputDecoration(labelText: 'Email'),
            ),
          ],
        ),
      ),
      actions: <Widget>[
        TextButton(
          onPressed: () {
            // Close the dialog
            Navigator.of(context).pop();
          },
          child: Text('Cancel'),
        ),
        ElevatedButton(
          onPressed: () {
            // Perform form submission or other actions here
            // Close the dialog
            Navigator.of(context).pop();
          },
          child: Text('Submit'),
        ),
      ],
    );
  }
}
