# eTheater

eTheater is an online ticket purchasing application for theater events. I used ASP.NET Core API for developing the backend, and for creating the web and mobile applications, I used Flutter. The application consists of a web component designed for administrators and a mobile component tailored for end users. The web segment is utilized for managing shows, schedules, as well as generating reports. In contrast, the mobile segment enables end users to browse currently active shows, purchase tickets, and make online payments. The web component serves as a platform for administrators to oversee and manage theatrical productions, schedules, and reporting, while the mobile component caters to the convenience of end users who can effortlessly view ongoing shows, buy tickets, and conduct secure online transactions.

### Credentials

Web application:

- email: admin@etheater.ba
- password: Admin123!

Mobile application:

- email: adla@gmail.com
- password: Test123!

Test data for Stripe:

- Card number: 4242 4242 4242 4242
- Date: You can enter any date in the future
- CVC: You can enter any 3 numbers

## Launching the Application

1. After cloning the repository, open the command line, navigate to the folder where the repository is cloned, and initiate the Dockerized API and database using the following command:

- `docker-compose up --build`

2. Start the mobile application by opening the etheater_mobile folder in VSCode and executing the following commands in the terminal:

- `flutter pub get` - to fetch dependencies
- `flutter run` - to launch the application
