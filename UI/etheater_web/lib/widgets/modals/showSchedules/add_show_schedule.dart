import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:provider/provider.dart';

class AddShowScheduleModal extends StatefulWidget {
  final Function handleAdd;
  const AddShowScheduleModal({super.key, required this.handleAdd});

  @override
  State<AddShowScheduleModal> createState() => _AddShowScheduleModalState();
}

class _AddShowScheduleModalState extends State<AddShowScheduleModal> {
  @override
  Widget build(BuildContext context) {
    return Scaffold();
  }
}
