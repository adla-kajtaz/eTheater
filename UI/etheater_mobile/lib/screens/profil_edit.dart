import '../models/models.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../providers/user_provider.dart';

class ProfilEdit extends StatefulWidget {
  static const routeName = '/profilEdit';

  const ProfilEdit({super.key});

  @override
  State<ProfilEdit> createState() => _ProfilEditState();
}

class _ProfilEditState extends State<ProfilEdit> {
  final formKey = GlobalKey<FormState>();
  UserProvider? _userProvider;
  User? user;
  String? error;

  @override
  void initState() {
    super.initState();
    _userProvider = context.read<UserProvider>();
    loadUser();
  }

  void loadUser() async {
    var data = await _userProvider!.getMe();
    setState(() {
      user = data;
    });
  }

  bool isUserNameValid(String value) {
    RegExp regex = RegExp(r'^.{4,}$');
    return regex.hasMatch(value);
  }

  bool isEmailValid(String value) {
    RegExp regex = RegExp(r'^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$',
        caseSensitive: false);
    return regex.hasMatch(value);
  }

  void closeToast(context, scaffold) async {
    scaffold.hideCurrentSnackBar;
    await Future.delayed(const Duration(milliseconds: 400));
    Navigator.pop(context);
  }

  void _showToast(BuildContext context) {
    final scaffold = ScaffoldMessenger.of(context);
    scaffold.showSnackBar(
      SnackBar(
        content: const Text('Profile updated successfully'),
        action: SnackBarAction(
            label: 'OK', onPressed: () => closeToast(context, scaffold)),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    if (user == null) {
      return Scaffold(
        backgroundColor: const Color.fromARGB(255, 28, 28, 29),
        resizeToAvoidBottomInset: false,
        appBar: AppBar(
          automaticallyImplyLeading: false,
          backgroundColor: const Color.fromARGB(255, 28, 28, 29),
          leading: IconButton(
            icon: const Icon(Icons.arrow_back_ios_new_rounded,
                color: Color.fromARGB(255, 250, 250, 250)),
            onPressed: () => Navigator.of(context).pop(),
          ),
          title: const Text(
            'Profile settings',
            style: TextStyle(
                color: Color.fromARGB(255, 250, 250, 250),
                fontWeight: FontWeight.bold),
          ),
          actions: const [
            Padding(
              padding: EdgeInsets.all(8.0),
              child: Icon(
                Icons.theater_comedy,
                color: Color.fromARGB(255, 250, 250, 250),
                size: 40,
              ),
            ),
          ],
        ),
        body: const Center(
          child: Text(
            'Loading ...',
            style: TextStyle(
              color: Color.fromARGB(255, 250, 250, 250),
            ),
          ),
        ),
      );
    }
    return Scaffold(
      backgroundColor: const Color.fromARGB(255, 28, 28, 29),
      resizeToAvoidBottomInset: true,
      appBar: AppBar(
        automaticallyImplyLeading: false,
        backgroundColor: const Color.fromARGB(255, 28, 28, 29),
        leading: IconButton(
          icon: const Icon(Icons.arrow_back_ios_new_rounded,
              color: Color.fromARGB(255, 250, 250, 250)),
          onPressed: () => Navigator.of(context).pop(),
        ),
        title: const Text(
          'Profile settings',
          style: TextStyle(
              color: Color.fromARGB(255, 250, 250, 250),
              fontWeight: FontWeight.bold),
        ),
        actions: const [
          Padding(
            padding: EdgeInsets.all(8.0),
            child: Icon(
              Icons.theater_comedy,
              color: Color.fromARGB(255, 250, 250, 250),
              size: 40,
            ),
          ),
        ],
      ),
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.all(20),
            child: Form(
              key: formKey,
              child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  mainAxisAlignment: MainAxisAlignment.start,
                  children: [
                    TextFormField(
                      onSaved: (newValue) => user!.userName = newValue!,
                      initialValue: user!.userName,
                      style: const TextStyle(
                        color: Color.fromARGB(255, 250, 250, 250),
                      ),
                      decoration: InputDecoration(
                        labelText: 'Username:',
                        hintText: 'emma123',
                        border: OutlineInputBorder(
                          borderRadius: BorderRadius.circular(10),
                        ),
                        hintStyle: const TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250)),
                      ),
                      validator: (newValue) {
                        if (newValue!.isEmpty) {
                          return 'This field is required!';
                        }
                        if (!isUserNameValid(newValue!)) {
                          return "Username must contain at least 4 characters!";
                        }
                        if (error != null && error!.contains("Username")) {
                          return 'Username is already taken!';
                        }
                        return null;
                      },
                    ),
                    const SizedBox(height: 15),
                    TextFormField(
                      onSaved: (newValue) => user!.email = newValue!,
                      initialValue: user!.email,
                      style: const TextStyle(
                          color: Color.fromARGB(255, 250, 250, 250)),
                      decoration: InputDecoration(
                        labelText: 'Email:',
                        hintText: 'email@example.com',
                        border: OutlineInputBorder(
                            borderRadius: BorderRadius.circular(10)),
                        hintStyle: const TextStyle(
                            color: Color.fromARGB(255, 250, 250, 250)),
                      ),
                      validator: (newValue) {
                        if (newValue!.isEmpty) {
                          return 'This field is required!';
                        }
                        if (!isEmailValid(newValue!)) {
                          return "Please enter a valid email!";
                        }
                        if (error != null && error!.contains('Email')) {
                          return 'Email is already taken!';
                        }
                        return null;
                      },
                    ),
                    const SizedBox(height: 15),
                    InkWell(
                      onTap: () async {
                        error = null;
                        if (formKey.currentState!.validate()) {
                          setState(() {
                            error = null;
                          });
                          formKey.currentState!.save();
                          Map<String, dynamic> data = {
                            "userName": user!.userName,
                            "email": user!.email
                          };
                          try {
                            await _userProvider!.updateProfile(user!.id, data);
                            if (context.mounted) {
                              _showToast(context);
                            }
                          } on Exception catch (err) {
                            String errorString =
                                err.toString().replaceFirst("Bad request ", "");
                            setState(() {
                              error = errorString;
                            });
                            formKey.currentState!.validate();
                          }
                        }
                      },
                      child: Container(
                        decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(10),
                          color: const Color.fromARGB(255, 204, 36, 68),
                        ),
                        height: 50,
                        child: const Center(
                          child: Text(
                            'Save',
                            style: TextStyle(
                                color: Color.fromARGB(255, 250, 250, 250),
                                fontSize: 20,
                                fontWeight: FontWeight.bold),
                          ),
                        ),
                      ),
                    ),
                  ]),
            ),
          ),
        ),
      ),
    );
  }
}
