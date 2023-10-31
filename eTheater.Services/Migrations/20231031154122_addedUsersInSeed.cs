using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eTheater.Services.Migrations
{
    /// <inheritdoc />
    public partial class addedUsersInSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "1", "Admin", "ADMIN" },
                    { 2, "2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "IsDeleted", "LockoutEnabled", "LockoutEnd", "ModifiedAt", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "b63567c3-e679-461e-9edc-9d68928cf853", new DateTime(2023, 10, 31, 16, 41, 21, 673, DateTimeKind.Local).AddTicks(3773), "admin@etheater.ba", true, false, false, null, null, "ADMIN@ETHEATER.BA", "admin", "AQAAAAEAACcQAAAAELM31qUwNRL7kiJWJLIreZi4PreEpvVDXR9/46oBX7EBNfADDp6rM0QB1DTVdoXEBg==", null, false, "b1795b15-28a3-4733-86f2-cb1730fd9de1", false, "admin" },
                    { 2, 0, "fb74f987-c6b4-4615-ad8e-ce7a5a548ee9", new DateTime(2023, 10, 31, 16, 41, 21, 679, DateTimeKind.Local).AddTicks(8207), "adla@gmail.com", true, false, false, null, null, "ADLA@GMAIL.COM", "ADLAKAJ", "AQAAAAEAACcQAAAAEMXOVNnwCsxU+RVNtrDB+p30eB3D7zeV6ViTpkH8M5W3BqGIGQcduGFPZMwOT9WnvQ==", null, false, "7a32c264-496d-4b6b-ba06-0ae8609d6e14", false, "adlaKaj" }
                });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6190), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6195), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6200), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6204), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6207), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6211), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "TheaterInfo",
                columns: new[] { "TheaterInfoId", "Adress", "CreatedAt", "Email", "IsDeleted", "Logo", "ModifiedAt", "Name", "PhoneNumber", "Webpage" },
                values: new object[] { 1, "Brkića br. 2", new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6230), "info@npm.ba", false, "iVBORw0KGgoAAAANSUhEUgAAARUAAAC2CAMAAADAz+kkAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAE+UExURf///+0gJAAAABEAACMfIOwAAAQAAP709Pva2h8bHA4AAI6NjRoVFggAABILDcbFxT06O+bm5mZjZO0ZHoWDhPzj4xAIChwYGayqq/ilp3d1du0VGvDw8La1tfJjZfj4+O85PPFvcPJ5e0hGR/nHyPSQkZiXl9nY2fe1tldUVfWbnPasrewKEf7u7+4yNfR0dvi+v3MVFaGgoCgoKNPS0vBaXPBRVO9FSPvS0+0lKfze3/rFxvefofFoavWHiTMwMXt5eY4aGxsAAEYzLd0gJCQAAGBdXUJCQjY2NlBOTiIUEUY8PGZYVoR0b5mJgzgAADYlIa0cHsMUF6AAAIwvMHJaWXgWFlsNDmJNRkwGBy8IAEgxKzAXD0ccFV8GBp0cHjceGIt5cy0HBlE5MrZLTLwfIdG0sdBJSrgIDtxxcnRvPPkAABdfSURBVHhe7Z0Je9pGt8eFjMwOlsVqAQLMZhCYYlbb2I6TeEltN8l726Ztbtu0973L9/8C95yZEUhCEpAEDA3/J08sjTbmx8w5ZzbEbbXVVltttdVWW2211VaLqJJkG1vp1A5G2dZWYykHPH+gsJ2tmCInPM/fV9jeVlRtgMLze5ltcdFJ3CdU+HBAZClbcVwnTKnw/E2EJW2lBBgT0Ek0zVK/dYloa8e6y7Dkb1wZxkPTXmdrdTnultGY6KDzzdcjkaEw6CrzjbujKANhVHC//E1HdQZbq9fh1bfrpyOMgZXch99qXAcNQ8z/za2bbEzJXRaVb84npakHgiClEt0jm9O6jEYq4jdFJkOLCKkoHdYestJRNBMBNt+Ix2YeiPobkVYnO50c7l8Fym2if7S9EW9ohlkPZfqS7s7WP9ptk/4m0D7b79Ddmbr/R5cV2t/E82FmTBUH06KXU+/3xtvl9BXLJd9hKfMVlhPt9Gmlry43HUvlkGWTP2Ip4jjFSQd2vigdueUvNz0k7iRYNplvhuJfZvsm7YZAbJsP21WgyFUYjrbZ3qZKF+5fsSRzbwtRyO/fAflDu2T30NoDVaJ35PCGjy0pmrEFnbByH5lyzruMCZEfC8wBPdUokTHZ+KGlibEF7VNbUbln+0whVj6gvDAwoaBFFREPfPQ00IaPLKUNBALkK9aGQVBQSkL8m+8fHp+eHh8u/SFG5YdXo7OGh9yBSElHDDc62eyuX2M/dpzY0DEVQLIT4t9eJZm/qTy95QkV/ndJFpoXgxhJVsRO2VzpNtvcmjonfYiFtgHA5UCF4d8G9F428jfBwr9zuVySKndrZ7FOpmyqcajoRhuWCsuFpmAZnPWt5nL8/EPEmL0OUvFfAxTA4nr/r//40Tq62WzDMt0PdxDJJHaZWeUfzbHaE1Lhf5Jd79+9+O7nH66hTPmJUzIpYR/6boAsYhOfW3M1/Ad21lhPO34Q//Mvv76+3tmdOKVpMBsd3erCFRTa13FoEvqVncSkZN7CGfzubgj+6QIYKs19M1F3tqHSDTCjfWU5pAr9Nul4U8RKEpkQmYEw+ScNAmhV2bWTNkGToSDicoziPz5mMhFQhvkZCsXIziCtQcDz7k3ufmGhrQUSFHz3O68/vtkh51AkIJuiQgW2l4LZZCdEummnjcREaFx1REDWAHXy+5HLJke3B+BZWWZs5Wc4mBwq0Fjgkza42dz4QEN4ZzEcTDMpEu3+Z4s9Y7PkibVGwu8LU5mnqID8fqFZ8jbYszZFsbNSTpVdP1Mqzt8/xCdj2VgV4pMNx/hXkipl6wNdy3rN5Smed12qBG2Z7wiVN28dS4CBCkszKMR/fIhGHyCgmRzm38PtZTV3UT1lT11vnaaO+7JMGniun5CK//rxwKkm6c0tSzKI/zPZEdNpsdN5fD3mQtrV2LIedi9aax/onuX7QxmLCdELQoOPig8OWHRUSB2BIFZfWfjvx40eRUz+yrjwf7BHuGSp2avRrpj1VKyUkyZIQO8olf20+IG3NS4QmDFBhv3w38c/3+yMfZH/2tjF1H5LuPAv2CNAkiS5uq21tDCeRrUnEGOi03tCJfQywikPOqNgkkYFTgjt3D9hE6fy+IZhmR5bfUQzxf9kfJQsuC5O180nxYqlpsCMiU6viPvxX2Mf3CfW/zgtrQr5d/iXZa3Z98Q813iEmuPSYgUlfoIjZipoYtRs3bs+JQZ8Tpb6HLNe/UAKCF/G0zJ2xYVRCWHfHLkhSvmemt7Q9x3YqUQyyWT04e+XRG/glt9ZPG+NfNJpqoChiaVeESe0wz+Qxpz49NGSCzUsAOVR3+b7USta99HAwcPLjyRmgdNoj4QlFSwwrm7p7NkLTKvQ0/mcKVFz67+mPYqK+HSNWQMfw4ZPd67xOKXCP+otSJr2bMPFeN5UE9OGCkiWctln9UmNUm4I9t9B7/+iVaithRRK5enDbx9fX1//9edvPz5FPpEskiqk78VVkj++NVIwy54KFBjZNcyesVutVkqj1Z3yOVN6RaPb0EfLXiIIY0jekUoIoShpMfLpw0dSOPCAvZyogCRZGF6s3PQ2vLWchc+Z1jta8q1m6aQzrzXTAcbiQQST+kiBOBcTohlUQOCTutXTFYLxVgvWPmda738hriT0caqjtfNpXB78gO5TJooNnTmAEE17ZgvJQr/UWo2J8VRLPai58+oFzTr/xC5nSre/H0e7ob9+fx1/GZpVaQyaiwoWmGG2tnwTc1rLNh18zrT+Te2tf8cwhJN8uNZqz07o+o9Xv8zumTRKH/E7S5Zz+dRSo97iKAeejz1uTrGeJ/7lZLwv8/ebSbMoFPrDJdG4ZgFNWoezJcnD3LGXPfvryyssigT06poC4K/bCkp8es3rmor863eyLL9asKjs8O8W+iTgk5Zmd70Ce8gikmh3AhQK/vXfH/7+y+B0/fyf/9XrjvLH0KbWiR11EP9vdvt5tWZUoDE0dsCGOARyz/MH/z2IYaXXz16A4AWiX2c4/Ct293m1blRc/56qHn6M+IHRZXvssKdnqSAb24rFD9nN59XaUWFdcpqQCB0A3NctVrVZXEWKDbtQJzbHZQGtH5X3v4yxYPuYZThsmNJjnEJnELan2eWaQj+wW8+t9aPiekf9kH4eyp65DeC0Eg9kBMP/xO48t9aQyvAFzlnSCgnP3+1PjxPr51Yy7QYT4fFPLOC0J8bkM1zQGlKR5P/5jWUNdLkfsJzAlZnMbie6j5bbyXa7HIjeaHMotQLj313UBa0dFUnt1QZa/Tg5SEamGopUacNCs5PkpGNOjGQCbM0itb27v2w4FUno10/BrOK0p+B+xumnALQVVqg908w3pZJhq9Kwg5J/sahjXisq0GY9py0zpVyOzFprOSksPov5KWmNGnjr/1245bE+VKBZVlqktZoem1YyKDAlRZtRdvN/Tp3FllobKnKzsGCXjzYT9ZCZY0VJoyarwNmCkSTnHQ3n7+NBrQkV2TVavLuHeWeylkjsRNoHN/dHN/tX5Uyn0yGLnSO4aJxMza5nXYsUl/WgIvc+p6uHrr8LtzklkjwK4vZYvr2jq3Ymg9wC5NxYLbdAcVkHKpJUGLCLFlMEl8qfRCJX2gopswDVHfPZyiCvsufN1hpQkYfVz/0QOJ07ceS4GJwWFZSnLsxbi56diqT2v6Cf1PpHbHSKsxOJBrk5i8tzU5GaNXb+50m/Ks9KxvjOczGcq7g8MxWp96WTPp2xTK3UrPfnMbrPS0XOf56Z1cupEh1Oj80Ws3PUomelIpS+wlid0rb5XZ/J+l+DYoXZWJ6RiiScf52Hk2DNSmV9/91YjdJMLM9HRZKr7MwvlkUfFMpufbfnfNa497NRkXJFduLXEInnTLqxb3RXm85YnouK1P+aUMC6BMzV6M5prVTVOf5/Jipy7+tCAVUCxo5/K0s7UavphOV5qMi5ZYxvV5JHjAjIYmaQQY5YnoWKnPvyMMVSImklo6zdj14tB9vyHFTk5levPmOlO6Tn8mpG9yaqah/9PwMVaYlQUErAzX6nZIbssayeitT8anHKlyplh2XlVKRhip2wBrKLcldORS0t7YmLy3NsjWXVVNTsGkGBpmLP0j+vmIrUXLOFXANL/7xaKpK0pEDl81W1WluwUiqS6xncj0fhPE49w7Vnp3LxBR3Xn6lYIXVWcOobjo2msaySitRb3uxeWynnuWHf0ZgNclNYVkjlmcI3ZXA2Yx1dasoPrZCKXGBHNMUKoxRXzZ5xSn0EW1yslM/nS2iPU/njlIerjnDfw51mR3WumK1zpzVIJ5VwAIeOcXCtWsjXIKUAZ+azHk/p+LjU4GJZOArJrSzctVoonHs8NbzXKIXX5Y/N4wpdM5bVUZFc5kd5m0KWqwl1rpFX1R7HnXZVQZC7Xq7kgr8l7lzA/R43ENQRVxVKjawM+8Q2FfHQsMbVh5BSaHDwB1K4Hp7Q507xqHTMpYQCV5fwGm4kqLIqHLfwiGCOrmPmL3B1VNSpkR9vTu4PUkKVa3RlaYhUhNZZTq1DegqaKLGUMPJW+0LLK0hDT1Wo1eVcsT6UsTAVhWzxXOhWs0Kt1ZTPuMFgkGo260K/ChdUY0K3BScP6kDFNSxVc4InNigIhUGsKozg1CmbnzKFuCujoh6z9Im8OanZQiqxYR8+OFJpcBdCvZiTucZIACpQ546F+qngEootoZYSLjhPXsAWd1HIezihV+sKnFIQkLenJKRSAjykIKRiQjbGIUK4gdAbcAXs5CoJJahOeMtpebLGOrQqKlJz2v94c64m5KQKpxa6kFmgEtOoxLKMSh6p5FwXQKUOVBoGKuddQfEcEyqDZr9RF/JTVFxg4we4PLcEV9tR4YrGEHdVVNRzlqyTtzkcFS6ASlWoF8C8kLLSlavFnGqiMur3z2ZQqQlgZcZURo2Y2j9FKhdClrogRiV/ShZImOS5MBSWFVGRuxbe0dtslrIjoFKSz2rqBVrb/LHruAG2xUSllBVSJirZQUvopsZUGs3+AKyrRiWX70pIqcCd9tUuaWYwKrluF2rSlAZ9fWFZERWpzlL18kJOmmAcucKwmJJGQAVdSMFzNlWDSiVX3kRlmGsKF96eRoXkeUIFbuRKER/EQckjTVJGBXxQljzdpNLqqcgji1KLVBpDSa1yud7pWXPIxbpCteVqtqZrUAkcjWqi0szVPGMqHgGKio5Kr1VSe2Bn4AZwK7UPfxztCjjAng7LaqgMrYoKUvGMZKCi9s6qzWEDqDTQ50xb21KjJ5moHOMHH2hUaiS3EyrZhmZtT2NYWgCZRsUuw/pW4kqoSNZdTUCFK6lqtYHFWh4OgEoMMmWkQjzzBVeAsmL0zFj6gAqHVDy5IaYaPLPKPHO3wWVV+FZmlBWuoWsOrYaKdQMIqVRVqDXCCIIvqa5RGeRk71lfBSr5hhdqFVDxVFUoK2o3Vuzj965RgaNng54KVqkbi8Ug0uueerNCXU9F7Z+d9qA8alTAB8Ws81ybhHKroCLlWJJJSKWYE6o1FULwY7mkUYHvtt9TR56Umhv1XKrHC1Q4Qa0Ncmq2J3TRdDIq3IXa76q92LHaH2W7VY/s6uEFpzoqebXXg9B4TCWXzY7Qk0/Ls9qyYhWroLzykAN7We0CCPjQo1iPRHElLjYSINgHYwECKzpAY5CDTLV64ECImz1DywFqXAhCr8hl8UwIWAZ9uKAIj+4BFbWKNSqWJ/cAgEilTk60GWW4GBeWFVCRJJay7oqNC8sKqKhfNktydfKMC8sqatCadevbq8g+8AqoQLDKUtZesRFrDa2AirXFB0UCRFE2/0bR9rXVcmKmHQiUk4Z1h2KmDKck6TpeJUOvmIjcit0noL3ErYKXULUzjuPyWl/l0qlIPdte00A8HgZpP8qbPuBxN8xmKaXbR5fueDh4cns1WVTYvr/0wSkne/t4UvqKXqEpHiez9gM0NXTPeEYu/SQB5L47cpruo7URl07FwdYG3ETBG7qbPgiSfUpFiSYSPrKfCGrZ464SQZrmC/rKcEU0TPYmIlSO6H182mumInv0IpQviK+EsJOHzcVdNhWpaVuBNCq+O7orXtIPT6gogV2yQxRmL04qMyYoH9+xozKGwNYj6qnAheQFIjZK0YWby6YiQ5RpJ43KJc2zyLJIqHTcmJNEOE6+9xB50UDlHnd84XiYHLvFGhSHWkjynICtuJ9Q4XEfFGI/1UmpBOE4uVnQYc6Pl1ahpVOx6uJhYlTcbGJ5h+UGqSjlEGz57svtgwRu3CGVJB5N7EXb0VtMDHaUSLlcbgduIdOJ+zZslwnQOJ4HCrOX6RMqwSs4YR+TfeaFvnrlV0HFcWRMo+Km32kSQYCQSvoI8u3bA3uSvsIihO/6U7C++PaSCnirEwTBDER6H4pAUHuTGcdltGoV3KdOiFAhJVAkN7t0+CX6c4SydCr2HmhCxUfXe2lGglDBChQkzqmCRSgOBESSe/IaPwqCLXNh6XQHFIBd3+EJYGPmaEKFy+ADEg7vWfKSSWFLpiKP2J6VNCosR5g5FH5+EVGwV/aRTQBUuYETwoSgUoZaovkuM5Ur2D2JAgnfHfVdOioVLIOI2Fakl2XZdsWmuUw0pkJm3Cv42VG2VDBHYyo+X5C9K9JM5TABRSUwIbEYFdIWWi4VaUja/TbSqCTIkmMFc4+yo6KrQTQMZhXBRCUNpjh4E7mH7IfoDRaiUsQvc8lUbPqbqAiVyxPmFNB+7IE1sKVCohMLB2Ki0gEGwI4ULPpKsoWoeJZPRbYcZNCEVHyHd0AGsw8uKHFz6UCFK6M5Dk69I8lEJQPBINQzDJRZZGKmEnSwttSwLJeKc9cKUgnu38NXi18eGNDggfb5LamQ3Pmmls2ZqLThdKg6UUhMHE5RwYrlpve1UQFaiMulIjiZFUolepOgJR3yFi4fOlFRSEMpcam1iphMVBAHxPpJ/BMmAYuOSgQKku/O8c05Vfzcy6XCtq2FVOJtyBMJt8BIJpL4VdpSIXkCLHEjFhMVQIftwgxSoS96nlBRAujRj5zWU3GNZVNxNraEym4EvtsENorDbt9txpkKtSzQ7s3obYuRClqOxFGFqyCVOLEghEo8KYqdA2wM+BzNCtdoSsul4hjDaVTK1LGIAOdoFhXuwA87YFsg7B/LSKUDlTB4A64eDUiYtAMIFXec53lCat9sro3ydOXlUpnRj02oZDLgjX0ZLgIV6SACEZgjlXSUdLokLnVYjFQQAQlqsAUZJG8toFSYEgHH+kP7tJdKRXD+pRlKpXPnQ58B1jEc6MyiwqVpH4sei5EKNqxJAIypvhNMMlDx2b4PXVN92VSce/cpFRE+M2QDzEsoKc6kAgaT9q644SwqI5U2mA5iOQJog3hMMlBxhx1W9BJBdLtcu2I1P2MiSoUDWwLhFmYtMwcVTmljNwJg0TJnoJI+ABgneCHpmMB7MSq+BAg3grSJbqvBcu2KlJuLCrjSxJF4lAB/Og8V1vvkjmtJBiq447slLPA60hIiVMhdy+jaE9rPY9nIm5OWSUXuOt+cUQlggJE89EEjcT4qHEYdbp+PWRYDFQxeWbbH142pQFsbm1JOvU6g095yqeTnooJ9Z8HArS94I85JRSG9+EF62EgFA73gDeGFFY30wUyosDiQXWijWHapv5stX8xFBftZffcn7uCV4khFbCeTSTrKFUGbkWD2wUgFC8MtGRHDlqbvEtMmVDoYEIWd2swQxuWXSmXWEkNGhWQbBI6o4kQlEj85cdNoHf0WC0aMVJQ26QWnI2JEQFFHZXZPAlApLJeKzTwRTRoV/NCo9gwqsBGkr9giA2pWfXHgt8mtJoIod0EqnpK6TCrCjJUvGhXMFTWCzlR2odbQl7hTKhb9tmRbLxwSW5AKd75cKvbDhkQaFeyahs8PjaExFas+/gg7CUTsj2ZKDFTQbkDAQoRbODyyZlRm/LSkRiVDBk+xGEyo4Kcn40F0CAe7BDo4Gua+giqUbmOaNh6kp1LBO12CVQa1SXAC6YtSqS+XCs72dJBGhVQXUiHGVCZjh3S4D8cORQxb3e79cvsK8biDLBjTU8HxR98e2eTSOFKCxmfNqDj2xE2oKGRMGfM1pmI5ztymMOJxQidxS25ipIJh/niOA/Z+J8A8L0qlKqwFFWThToAVmVCxmpOQ3ic4qHw0myAdFQWrGx0ywlvADhqihakstawUnJtBEyrEdGDEOaHCKVHfZP4KgQL5PwqyNDp/hUpPBTe1qQjElaNnM1PRsNkpNloiFWmGWSFzncg72ct8GKoKbFX2QlNzndy34ylhUCnYXKdbMteJSryBy+lvKypuvF5r/EXC8XAcCkbkcnxXMp+KZ6PytqovkcrMWYJkABCz0CEROjoXMoNNg0DnxbW1TBIZ5sVRpZN4EdKFSgNi8zPgXHI3iIJ0dyUz6bQJc3by9JZGJfY8LxH8KvrsH9ydreXdeena4I++1VZbbbXVVltttdVWW2211VbrIo77f2KxtupCYxwpAAAAAElFTkSuQmCC", null, "Narodno pozoriste Mostar", "036-550-128", "https://www.npm.ba/" });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "TicketId", "CreatedAt", "isActive", "IsDeleted", "ModifiedAt", "NumberOfRow", "NumberOfSeat", "PurchaseId", "Seat", "ShowScheduleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6247), false, false, null, "A", 1, null, "A1", 1 },
                    { 2, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6250), false, false, null, "A", 2, null, "A2", 1 },
                    { 3, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6252), true, false, null, "A", 3, null, "A3", 1 },
                    { 4, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6254), true, false, null, "A", 4, null, "A4", 1 },
                    { 5, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6256), true, false, null, "A", 5, null, "A5", 1 },
                    { 6, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6258), true, false, null, "A", 6, null, "A6", 1 },
                    { 7, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6260), true, false, null, "A", 7, null, "A7", 1 },
                    { 8, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6262), true, false, null, "A", 8, null, "A8", 1 },
                    { 9, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6264), true, false, null, "A", 9, null, "A9", 1 },
                    { 10, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6266), true, false, null, "A", 10, null, "A10", 1 },
                    { 11, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6272), true, false, null, "A", 11, null, "A11", 1 },
                    { 12, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6275), true, false, null, "A", 12, null, "A12", 1 },
                    { 13, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6276), true, false, null, "A", 13, null, "A13", 1 },
                    { 14, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6278), true, false, null, "A", 14, null, "A14", 1 },
                    { 15, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6280), true, false, null, "A", 15, null, "A15", 1 },
                    { 16, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6284), true, false, null, "B", 1, null, "B1", 1 },
                    { 17, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6286), true, false, null, "B", 2, null, "B2", 1 },
                    { 18, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6288), true, false, null, "B", 3, null, "B3", 1 },
                    { 19, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6290), true, false, null, "B", 4, null, "B4", 1 },
                    { 20, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6292), true, false, null, "B", 5, null, "B5", 1 },
                    { 21, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6293), true, false, null, "B", 6, null, "B6", 1 },
                    { 22, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6295), true, false, null, "B", 7, null, "B7", 1 },
                    { 23, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6297), true, false, null, "B", 8, null, "B8", 1 },
                    { 24, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6299), true, false, null, "B", 9, null, "B9", 1 },
                    { 25, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6301), true, false, null, "B", 10, null, "B10", 1 },
                    { 26, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6303), true, false, null, "B", 11, null, "B11", 1 },
                    { 27, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6305), true, false, null, "B", 12, null, "B12", 1 },
                    { 28, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6307), true, false, null, "B", 13, null, "B13", 1 },
                    { 29, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6309), true, false, null, "B", 14, null, "B14", 1 },
                    { 30, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6311), true, false, null, "B", 15, null, "B15", 1 },
                    { 31, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6312), true, false, null, "C", 1, null, "C1", 1 },
                    { 32, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6315), true, false, null, "C", 2, null, "C2", 1 },
                    { 33, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6317), true, false, null, "C", 3, null, "C3", 1 },
                    { 34, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6319), true, false, null, "C", 4, null, "C4", 1 },
                    { 35, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6321), true, false, null, "C", 5, null, "C5", 1 },
                    { 36, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6323), true, false, null, "C", 6, null, "C6", 1 },
                    { 37, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6326), true, false, null, "C", 7, null, "C7", 1 },
                    { 38, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6328), true, false, null, "C", 8, null, "C8", 1 },
                    { 39, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6329), true, false, null, "C", 9, null, "C9", 1 },
                    { 40, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6331), true, false, null, "C", 10, null, "C10", 1 },
                    { 41, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6333), true, false, null, "C", 11, null, "C11", 1 },
                    { 42, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6335), true, false, null, "C", 12, null, "C12", 1 },
                    { 43, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6337), true, false, null, "C", 13, null, "C13", 1 },
                    { 44, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6339), true, false, null, "C", 14, null, "C14", 1 },
                    { 45, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6341), true, false, null, "C", 15, null, "C15", 1 },
                    { 46, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6343), true, false, null, "D", 1, null, "D1", 1 },
                    { 47, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6345), true, false, null, "D", 2, null, "D2", 1 },
                    { 48, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6347), true, false, null, "D", 3, null, "D3", 1 },
                    { 49, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6349), true, false, null, "D", 4, null, "D4", 1 },
                    { 50, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6351), true, false, null, "D", 5, null, "D5", 1 },
                    { 51, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6353), true, false, null, "D", 6, null, "D6", 1 },
                    { 52, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6355), true, false, null, "D", 7, null, "D7", 1 },
                    { 53, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6357), true, false, null, "D", 8, null, "D8", 1 },
                    { 54, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6359), true, false, null, "D", 9, null, "D9", 1 },
                    { 55, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6361), true, false, null, "D", 10, null, "D10", 1 },
                    { 56, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6363), true, false, null, "D", 11, null, "D11", 1 },
                    { 57, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6365), true, false, null, "D", 12, null, "D12", 1 },
                    { 58, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6367), true, false, null, "D", 13, null, "D13", 1 },
                    { 59, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6369), true, false, null, "D", 14, null, "D14", 1 },
                    { 60, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6371), true, false, null, "D", 15, null, "D15", 1 },
                    { 61, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6373), true, false, null, "E", 1, null, "E1", 1 },
                    { 62, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6375), true, false, null, "E", 2, null, "E2", 1 },
                    { 63, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6377), true, false, null, "E", 3, null, "E3", 1 },
                    { 64, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6379), true, false, null, "E", 4, null, "E4", 1 },
                    { 65, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6381), true, false, null, "E", 5, null, "E5", 1 },
                    { 66, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6383), true, false, null, "E", 6, null, "E6", 1 },
                    { 67, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6385), true, false, null, "E", 7, null, "E7", 1 },
                    { 68, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6387), true, false, null, "E", 8, null, "E8", 1 },
                    { 69, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6389), true, false, null, "E", 9, null, "E9", 1 },
                    { 70, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6391), true, false, null, "E", 10, null, "E10", 1 },
                    { 71, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6393), true, false, null, "E", 11, null, "E11", 1 },
                    { 72, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6395), true, false, null, "E", 12, null, "E12", 1 },
                    { 73, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6397), true, false, null, "E", 13, null, "E13", 1 },
                    { 74, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6398), true, false, null, "E", 14, null, "E14", 1 },
                    { 75, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6400), true, false, null, "E", 15, null, "E15", 1 },
                    { 76, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6402), true, false, null, "F", 1, null, "F1", 1 },
                    { 77, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6404), true, false, null, "F", 2, null, "F2", 1 },
                    { 78, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6406), true, false, null, "F", 3, null, "F3", 1 },
                    { 79, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6409), true, false, null, "F", 4, null, "F4", 1 },
                    { 80, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6411), true, false, null, "F", 5, null, "F5", 1 },
                    { 81, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6412), true, false, null, "F", 6, null, "F6", 1 },
                    { 82, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6414), true, false, null, "F", 7, null, "F7", 1 },
                    { 83, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6416), true, false, null, "F", 8, null, "F8", 1 },
                    { 84, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6422), true, false, null, "F", 9, null, "F9", 1 },
                    { 85, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6424), true, false, null, "F", 10, null, "F10", 1 },
                    { 86, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6426), true, false, null, "F", 11, null, "F11", 1 },
                    { 87, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6428), true, false, null, "F", 12, null, "F12", 1 },
                    { 88, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6430), true, false, null, "F", 13, null, "F13", 1 },
                    { 89, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6432), true, false, null, "F", 14, null, "F14", 1 },
                    { 90, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6434), true, false, null, "F", 15, null, "F15", 1 },
                    { 91, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6435), true, false, null, "G", 1, null, "G1", 1 },
                    { 92, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6437), true, false, null, "G", 2, null, "G2", 1 },
                    { 93, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6439), true, false, null, "G", 3, null, "G3", 1 },
                    { 94, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6444), true, false, null, "G", 4, null, "G4", 1 },
                    { 95, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6445), true, false, null, "G", 5, null, "G5", 1 },
                    { 96, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6447), true, false, null, "G", 6, null, "G6", 1 },
                    { 97, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6449), true, false, null, "G", 7, null, "G7", 1 },
                    { 98, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6451), true, false, null, "G", 8, null, "G8", 1 },
                    { 99, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6453), true, false, null, "G", 9, null, "G9", 1 },
                    { 100, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6455), true, false, null, "G", 10, null, "G10", 1 },
                    { 101, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6456), true, false, null, "G", 11, null, "G11", 1 },
                    { 102, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6458), true, false, null, "G", 12, null, "G12", 1 },
                    { 103, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6460), true, false, null, "G", 13, null, "G13", 1 },
                    { 104, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6462), true, false, null, "G", 14, null, "G14", 1 },
                    { 105, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6464), true, false, null, "G", 15, null, "G15", 1 },
                    { 106, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6466), true, false, null, "H", 1, null, "H1", 1 },
                    { 107, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6468), true, false, null, "H", 2, null, "H2", 1 },
                    { 108, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6470), true, false, null, "H", 3, null, "H3", 1 },
                    { 109, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6471), true, false, null, "H", 4, null, "H4", 1 },
                    { 110, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6474), true, false, null, "H", 5, null, "H5", 1 },
                    { 111, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6477), true, false, null, "H", 6, null, "H6", 1 },
                    { 112, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6479), true, false, null, "H", 7, null, "H7", 1 },
                    { 113, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6481), true, false, null, "H", 8, null, "H8", 1 },
                    { 114, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6482), true, false, null, "H", 9, null, "H9", 1 },
                    { 115, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6484), true, false, null, "H", 10, null, "H10", 1 },
                    { 116, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6487), true, false, null, "H", 11, null, "H11", 1 },
                    { 117, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6489), true, false, null, "H", 12, null, "H12", 1 },
                    { 118, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6491), true, false, null, "H", 13, null, "H13", 1 },
                    { 119, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6492), true, false, null, "H", 14, null, "H14", 1 },
                    { 120, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6494), true, false, null, "H", 15, null, "H15", 1 },
                    { 121, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6496), true, false, null, "I", 1, null, "I1", 1 },
                    { 122, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6498), true, false, null, "I", 2, null, "I2", 1 },
                    { 123, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6500), true, false, null, "I", 3, null, "I3", 1 },
                    { 124, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6502), true, false, null, "I", 4, null, "I4", 1 },
                    { 125, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6505), true, false, null, "I", 5, null, "I5", 1 },
                    { 126, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6507), true, false, null, "I", 6, null, "I6", 1 },
                    { 127, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6508), true, false, null, "I", 7, null, "I7", 1 },
                    { 128, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6510), true, false, null, "I", 8, null, "I8", 1 },
                    { 129, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6512), true, false, null, "I", 9, null, "I9", 1 },
                    { 130, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6514), true, false, null, "I", 10, null, "I10", 1 },
                    { 131, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6516), true, false, null, "I", 11, null, "I11", 1 },
                    { 132, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6518), true, false, null, "I", 12, null, "I12", 1 },
                    { 133, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6520), true, false, null, "I", 13, null, "I13", 1 },
                    { 134, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6522), true, false, null, "I", 14, null, "I14", 1 },
                    { 135, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6524), true, false, null, "I", 15, null, "I15", 1 },
                    { 136, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6526), true, false, null, "J", 1, null, "J1", 1 },
                    { 137, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6528), true, false, null, "J", 2, null, "J2", 1 },
                    { 138, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6530), true, false, null, "J", 3, null, "J3", 1 },
                    { 139, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6533), true, false, null, "J", 4, null, "J4", 1 },
                    { 140, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6534), true, false, null, "J", 5, null, "J5", 1 },
                    { 141, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6536), true, false, null, "J", 6, null, "J6", 1 },
                    { 142, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6538), true, false, null, "J", 7, null, "J7", 1 },
                    { 143, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6540), true, false, null, "J", 8, null, "J8", 1 },
                    { 144, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6542), true, false, null, "J", 9, null, "J9", 1 },
                    { 145, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6544), true, false, null, "J", 10, null, "J10", 1 },
                    { 146, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6546), true, false, null, "J", 11, null, "J11", 1 },
                    { 147, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6547), true, false, null, "J", 12, null, "J12", 1 },
                    { 148, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6549), true, false, null, "J", 13, null, "J13", 1 },
                    { 149, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6551), true, false, null, "J", 14, null, "J14", 1 },
                    { 150, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6553), true, false, null, "J", 15, null, "J15", 1 },
                    { 151, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6555), false, false, null, "A", 1, null, "A1", 2 },
                    { 152, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6557), false, false, null, "A", 2, null, "A2", 2 },
                    { 153, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6559), true, false, null, "A", 3, null, "A3", 2 },
                    { 154, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6561), true, false, null, "A", 4, null, "A4", 2 },
                    { 155, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6563), true, false, null, "A", 5, null, "A5", 2 },
                    { 156, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6565), true, false, null, "A", 6, null, "A6", 2 },
                    { 157, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6571), true, false, null, "A", 7, null, "A7", 2 },
                    { 158, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6573), true, false, null, "A", 8, null, "A8", 2 },
                    { 159, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6575), true, false, null, "A", 9, null, "A9", 2 },
                    { 160, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6577), true, false, null, "A", 10, null, "A10", 2 },
                    { 161, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6579), true, false, null, "B", 1, null, "B1", 2 },
                    { 162, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6581), true, false, null, "B", 2, null, "B2", 2 },
                    { 163, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6583), true, false, null, "B", 3, null, "B3", 2 },
                    { 164, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6585), true, false, null, "B", 4, null, "B4", 2 },
                    { 165, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6587), true, false, null, "B", 5, null, "B5", 2 },
                    { 166, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6589), true, false, null, "B", 6, null, "B6", 2 },
                    { 167, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6590), true, false, null, "B", 7, null, "B7", 2 },
                    { 168, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6592), true, false, null, "B", 8, null, "B8", 2 },
                    { 169, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6596), true, false, null, "B", 9, null, "B9", 2 },
                    { 170, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6598), true, false, null, "B", 10, null, "B10", 2 },
                    { 171, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6600), true, false, null, "C", 1, null, "C1", 2 },
                    { 172, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6602), true, false, null, "C", 2, null, "C2", 2 },
                    { 173, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6604), true, false, null, "C", 3, null, "C3", 2 },
                    { 174, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6606), true, false, null, "C", 4, null, "C4", 2 },
                    { 175, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6608), true, false, null, "C", 5, null, "C5", 2 },
                    { 176, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6610), true, false, null, "C", 6, null, "C6", 2 },
                    { 177, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6612), true, false, null, "C", 7, null, "C7", 2 },
                    { 178, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6613), true, false, null, "C", 8, null, "C8", 2 },
                    { 179, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6615), true, false, null, "C", 9, null, "C9", 2 },
                    { 180, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6617), true, false, null, "C", 10, null, "C10", 2 },
                    { 181, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6619), true, false, null, "D", 1, null, "D1", 2 },
                    { 182, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6621), true, false, null, "D", 2, null, "D2", 2 },
                    { 183, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6623), true, false, null, "D", 3, null, "D3", 2 },
                    { 184, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6626), true, false, null, "D", 4, null, "D4", 2 },
                    { 185, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6628), true, false, null, "D", 5, null, "D5", 2 },
                    { 186, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6630), true, false, null, "D", 6, null, "D6", 2 },
                    { 187, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6632), true, false, null, "D", 7, null, "D7", 2 },
                    { 188, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6633), true, false, null, "D", 8, null, "D8", 2 },
                    { 189, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6635), true, false, null, "D", 9, null, "D9", 2 },
                    { 190, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6637), true, false, null, "D", 10, null, "D10", 2 },
                    { 191, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6639), true, false, null, "E", 1, null, "E1", 2 },
                    { 192, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6641), true, false, null, "E", 2, null, "E2", 2 },
                    { 193, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6643), true, false, null, "E", 3, null, "E3", 2 },
                    { 194, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6645), true, false, null, "E", 4, null, "E4", 2 },
                    { 195, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6647), true, false, null, "E", 5, null, "E5", 2 },
                    { 196, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6649), true, false, null, "E", 6, null, "E6", 2 },
                    { 197, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6651), true, false, null, "E", 7, null, "E7", 2 },
                    { 198, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6653), true, false, null, "E", 8, null, "E8", 2 },
                    { 199, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6655), true, false, null, "E", 9, null, "E9", 2 },
                    { 200, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6657), true, false, null, "E", 10, null, "E10", 2 },
                    { 201, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6659), true, false, null, "F", 1, null, "F1", 2 },
                    { 202, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6661), true, false, null, "F", 2, null, "F2", 2 },
                    { 203, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6663), true, false, null, "F", 3, null, "F3", 2 },
                    { 204, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6665), true, false, null, "F", 4, null, "F4", 2 },
                    { 205, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6667), true, false, null, "F", 5, null, "F5", 2 },
                    { 206, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6669), true, false, null, "F", 6, null, "F6", 2 },
                    { 207, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6672), true, false, null, "F", 7, null, "F7", 2 },
                    { 208, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6674), true, false, null, "F", 8, null, "F8", 2 },
                    { 209, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6675), true, false, null, "F", 9, null, "F9", 2 },
                    { 210, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6677), true, false, null, "F", 10, null, "F10", 2 },
                    { 211, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6679), true, false, null, "G", 1, null, "G1", 2 },
                    { 212, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6681), true, false, null, "G", 2, null, "G2", 2 },
                    { 213, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6683), true, false, null, "G", 3, null, "G3", 2 },
                    { 214, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6686), true, false, null, "G", 4, null, "G4", 2 },
                    { 215, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6688), true, false, null, "G", 5, null, "G5", 2 },
                    { 216, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6689), true, false, null, "G", 6, null, "G6", 2 },
                    { 217, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6691), true, false, null, "G", 7, null, "G7", 2 },
                    { 218, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6693), true, false, null, "G", 8, null, "G8", 2 },
                    { 219, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6695), true, false, null, "G", 9, null, "G9", 2 },
                    { 220, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6697), true, false, null, "G", 10, null, "G10", 2 },
                    { 221, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6699), true, false, null, "H", 1, null, "H1", 2 },
                    { 222, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6701), true, false, null, "H", 2, null, "H2", 2 },
                    { 223, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6703), true, false, null, "H", 3, null, "H3", 2 },
                    { 224, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6705), true, false, null, "H", 4, null, "H4", 2 },
                    { 225, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6706), true, false, null, "H", 5, null, "H5", 2 },
                    { 226, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6708), true, false, null, "H", 6, null, "H6", 2 },
                    { 227, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6710), true, false, null, "H", 7, null, "H7", 2 },
                    { 228, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6712), true, false, null, "H", 8, null, "H8", 2 },
                    { 229, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6720), true, false, null, "H", 9, null, "H9", 2 },
                    { 230, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6722), true, false, null, "H", 10, null, "H10", 2 },
                    { 231, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6724), true, false, null, "I", 1, null, "I1", 2 },
                    { 232, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6726), true, false, null, "I", 2, null, "I2", 2 },
                    { 233, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6728), true, false, null, "I", 3, null, "I3", 2 },
                    { 234, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6730), true, false, null, "I", 4, null, "I4", 2 },
                    { 235, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6732), true, false, null, "I", 5, null, "I5", 2 },
                    { 236, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6734), true, false, null, "I", 6, null, "I6", 2 },
                    { 237, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6736), true, false, null, "I", 7, null, "I7", 2 },
                    { 238, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6738), true, false, null, "I", 8, null, "I8", 2 },
                    { 239, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6739), true, false, null, "I", 9, null, "I9", 2 },
                    { 240, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6741), true, false, null, "I", 10, null, "I10", 2 },
                    { 241, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6743), true, false, null, "J", 1, null, "J1", 2 },
                    { 242, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6745), true, false, null, "J", 2, null, "J2", 2 },
                    { 243, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6747), true, false, null, "J", 3, null, "J3", 2 },
                    { 244, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6750), true, false, null, "J", 4, null, "J4", 2 },
                    { 245, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6752), true, false, null, "J", 5, null, "J5", 2 },
                    { 246, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6754), true, false, null, "J", 6, null, "J6", 2 },
                    { 247, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6756), true, false, null, "J", 7, null, "J7", 2 },
                    { 248, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6758), true, false, null, "J", 8, null, "J8", 2 },
                    { 249, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6759), true, false, null, "J", 9, null, "J9", 2 },
                    { 250, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6761), true, false, null, "J", 10, null, "J10", 2 },
                    { 251, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6763), true, false, null, "A", 1, null, "A1", 3 },
                    { 252, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6765), true, false, null, "A", 2, null, "A2", 3 },
                    { 253, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6767), true, false, null, "A", 3, null, "A3", 3 },
                    { 254, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6769), true, false, null, "A", 4, null, "A4", 3 },
                    { 255, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6771), true, false, null, "A", 5, null, "A5", 3 },
                    { 256, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6773), true, false, null, "A", 6, null, "A6", 3 },
                    { 257, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6774), true, false, null, "A", 7, null, "A7", 3 },
                    { 258, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6776), true, false, null, "A", 8, null, "A8", 3 },
                    { 259, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6780), true, false, null, "A", 9, null, "A9", 3 },
                    { 260, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6782), true, false, null, "A", 10, null, "A10", 3 },
                    { 261, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6784), true, false, null, "B", 1, null, "B1", 3 },
                    { 262, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6786), true, false, null, "B", 2, null, "B2", 3 },
                    { 263, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6787), true, false, null, "B", 3, null, "B3", 3 },
                    { 264, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6789), true, false, null, "B", 4, null, "B4", 3 },
                    { 265, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6791), true, false, null, "B", 5, null, "B5", 3 },
                    { 266, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6793), true, false, null, "B", 6, null, "B6", 3 },
                    { 267, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6795), true, false, null, "B", 7, null, "B7", 3 },
                    { 268, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6797), true, false, null, "B", 8, null, "B8", 3 },
                    { 269, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6799), true, false, null, "B", 9, null, "B9", 3 },
                    { 270, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6801), true, false, null, "B", 10, null, "B10", 3 },
                    { 271, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6803), true, false, null, "C", 1, null, "C1", 3 },
                    { 272, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6804), true, false, null, "C", 2, null, "C2", 3 },
                    { 273, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6806), true, false, null, "C", 3, null, "C3", 3 },
                    { 274, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6809), true, false, null, "C", 4, null, "C4", 3 },
                    { 275, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6811), true, false, null, "C", 5, null, "C5", 3 },
                    { 276, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6813), true, false, null, "C", 6, null, "C6", 3 },
                    { 277, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6815), true, false, null, "C", 7, null, "C7", 3 },
                    { 278, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6817), true, false, null, "C", 8, null, "C8", 3 },
                    { 279, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6819), true, false, null, "C", 9, null, "C9", 3 },
                    { 280, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6820), true, false, null, "C", 10, null, "C10", 3 },
                    { 281, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6822), true, false, null, "D", 1, null, "D1", 3 },
                    { 282, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6824), true, false, null, "D", 2, null, "D2", 3 },
                    { 283, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6827), true, false, null, "D", 3, null, "D3", 3 },
                    { 284, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6829), true, false, null, "D", 4, null, "D4", 3 },
                    { 285, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6830), true, false, null, "D", 5, null, "D5", 3 },
                    { 286, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6832), true, false, null, "D", 6, null, "D6", 3 },
                    { 287, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6834), true, false, null, "D", 7, null, "D7", 3 },
                    { 288, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6837), true, false, null, "D", 8, null, "D8", 3 },
                    { 289, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6839), true, false, null, "D", 9, null, "D9", 3 },
                    { 290, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6841), true, false, null, "D", 10, null, "D10", 3 },
                    { 291, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6843), true, false, null, "E", 1, null, "E1", 3 },
                    { 292, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6844), true, false, null, "E", 2, null, "E2", 3 },
                    { 293, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6846), true, false, null, "E", 3, null, "E3", 3 },
                    { 294, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6848), true, false, null, "E", 4, null, "E4", 3 },
                    { 295, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6850), true, false, null, "E", 5, null, "E5", 3 },
                    { 296, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6852), true, false, null, "E", 6, null, "E6", 3 },
                    { 297, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6854), true, false, null, "E", 7, null, "E7", 3 },
                    { 298, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6856), true, false, null, "E", 8, null, "E8", 3 },
                    { 299, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6858), true, false, null, "E", 9, null, "E9", 3 },
                    { 300, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6859), true, false, null, "E", 10, null, "E10", 3 },
                    { 301, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6861), true, false, null, "F", 1, null, "F1", 3 },
                    { 302, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6867), true, false, null, "F", 2, null, "F2", 3 },
                    { 303, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6872), true, false, null, "F", 3, null, "F3", 3 },
                    { 304, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6874), true, false, null, "F", 4, null, "F4", 3 },
                    { 305, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6876), true, false, null, "F", 5, null, "F5", 3 },
                    { 306, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6877), true, false, null, "F", 6, null, "F6", 3 },
                    { 307, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6879), true, false, null, "F", 7, null, "F7", 3 },
                    { 308, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6881), true, false, null, "F", 8, null, "F8", 3 },
                    { 309, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6883), true, false, null, "F", 9, null, "F9", 3 },
                    { 310, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6885), true, false, null, "F", 10, null, "F10", 3 },
                    { 311, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6887), true, false, null, "G", 1, null, "G1", 3 },
                    { 312, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6889), true, false, null, "G", 2, null, "G2", 3 },
                    { 313, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6891), true, false, null, "G", 3, null, "G3", 3 },
                    { 314, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6893), true, false, null, "G", 4, null, "G4", 3 },
                    { 315, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6895), true, false, null, "G", 5, null, "G5", 3 },
                    { 316, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6896), true, false, null, "G", 6, null, "G6", 3 },
                    { 317, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6899), true, false, null, "G", 7, null, "G7", 3 },
                    { 318, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6902), true, false, null, "G", 8, null, "G8", 3 },
                    { 319, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6903), true, false, null, "G", 9, null, "G9", 3 },
                    { 320, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6905), true, false, null, "G", 10, null, "G10", 3 },
                    { 321, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6907), true, false, null, "H", 1, null, "H1", 3 },
                    { 322, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6909), true, false, null, "H", 2, null, "H2", 3 },
                    { 323, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6911), true, false, null, "H", 3, null, "H3", 3 },
                    { 324, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6913), true, false, null, "H", 4, null, "H4", 3 },
                    { 325, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6915), true, false, null, "H", 5, null, "H5", 3 },
                    { 326, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6916), true, false, null, "H", 6, null, "H6", 3 },
                    { 327, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6918), true, false, null, "H", 7, null, "H7", 3 },
                    { 328, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6920), true, false, null, "H", 8, null, "H8", 3 },
                    { 329, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6922), true, false, null, "H", 9, null, "H9", 3 },
                    { 330, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6924), true, false, null, "H", 10, null, "H10", 3 },
                    { 331, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6926), true, false, null, "I", 1, null, "I1", 3 },
                    { 332, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6928), true, false, null, "I", 2, null, "I2", 3 },
                    { 333, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6930), true, false, null, "I", 3, null, "I3", 3 },
                    { 334, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6932), true, false, null, "I", 4, null, "I4", 3 },
                    { 335, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6934), true, false, null, "I", 5, null, "I5", 3 },
                    { 336, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6936), true, false, null, "I", 6, null, "I6", 3 },
                    { 337, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6938), true, false, null, "I", 7, null, "I7", 3 },
                    { 338, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6940), true, false, null, "I", 8, null, "I8", 3 },
                    { 339, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6942), true, false, null, "I", 9, null, "I9", 3 },
                    { 340, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6944), true, false, null, "I", 10, null, "I10", 3 },
                    { 341, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6945), true, false, null, "J", 1, null, "J1", 3 },
                    { 342, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6947), true, false, null, "J", 2, null, "J2", 3 },
                    { 343, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6949), true, false, null, "J", 3, null, "J3", 3 },
                    { 344, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6951), true, false, null, "J", 4, null, "J4", 3 },
                    { 345, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6953), true, false, null, "J", 5, null, "J5", 3 },
                    { 346, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6955), true, false, null, "J", 6, null, "J6", 3 },
                    { 347, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6957), true, false, null, "J", 7, null, "J7", 3 },
                    { 348, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6960), true, false, null, "J", 8, null, "J8", 3 },
                    { 349, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6962), true, false, null, "J", 9, null, "J9", 3 },
                    { 350, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6964), true, false, null, "J", 10, null, "J10", 3 },
                    { 351, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6965), true, false, null, "A", 1, null, "A1", 4 },
                    { 352, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6967), true, false, null, "A", 2, null, "A2", 4 },
                    { 353, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6969), true, false, null, "A", 3, null, "A3", 4 },
                    { 354, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6971), true, false, null, "A", 4, null, "A4", 4 },
                    { 355, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6973), true, false, null, "A", 5, null, "A5", 4 },
                    { 356, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6975), true, false, null, "A", 6, null, "A6", 4 },
                    { 357, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6977), true, false, null, "A", 7, null, "A7", 4 },
                    { 358, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6979), true, false, null, "A", 8, null, "A8", 4 },
                    { 359, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6981), true, false, null, "A", 9, null, "A9", 4 },
                    { 360, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6983), true, false, null, "A", 10, null, "A10", 4 },
                    { 361, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6985), true, false, null, "B", 1, null, "B1", 4 },
                    { 362, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6986), true, false, null, "B", 2, null, "B2", 4 },
                    { 363, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6989), true, false, null, "B", 3, null, "B3", 4 },
                    { 364, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6991), true, false, null, "B", 4, null, "B4", 4 },
                    { 365, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6993), true, false, null, "B", 5, null, "B5", 4 },
                    { 366, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6995), true, false, null, "B", 6, null, "B6", 4 },
                    { 367, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6997), true, false, null, "B", 7, null, "B7", 4 },
                    { 368, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(6999), true, false, null, "B", 8, null, "B8", 4 },
                    { 369, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7001), true, false, null, "B", 9, null, "B9", 4 },
                    { 370, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7003), true, false, null, "B", 10, null, "B10", 4 },
                    { 371, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7005), true, false, null, "C", 1, null, "C1", 4 },
                    { 372, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7006), true, false, null, "C", 2, null, "C2", 4 },
                    { 373, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7008), true, false, null, "C", 3, null, "C3", 4 },
                    { 374, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7010), true, false, null, "C", 4, null, "C4", 4 },
                    { 375, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7016), true, false, null, "C", 5, null, "C5", 4 },
                    { 376, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7018), true, false, null, "C", 6, null, "C6", 4 },
                    { 377, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7020), true, false, null, "C", 7, null, "C7", 4 },
                    { 378, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7023), true, false, null, "C", 8, null, "C8", 4 },
                    { 379, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7025), true, false, null, "C", 9, null, "C9", 4 },
                    { 380, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7027), true, false, null, "C", 10, null, "C10", 4 },
                    { 381, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7028), true, false, null, "D", 1, null, "D1", 4 },
                    { 382, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7030), true, false, null, "D", 2, null, "D2", 4 },
                    { 383, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7032), true, false, null, "D", 3, null, "D3", 4 },
                    { 384, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7034), true, false, null, "D", 4, null, "D4", 4 },
                    { 385, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7036), true, false, null, "D", 5, null, "D5", 4 },
                    { 386, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7038), true, false, null, "D", 6, null, "D6", 4 },
                    { 387, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7040), true, false, null, "D", 7, null, "D7", 4 },
                    { 388, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7041), true, false, null, "D", 8, null, "D8", 4 },
                    { 389, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7043), true, false, null, "D", 9, null, "D9", 4 },
                    { 390, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7045), true, false, null, "D", 10, null, "D10", 4 },
                    { 391, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7047), true, false, null, "E", 1, null, "E1", 4 },
                    { 392, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7049), true, false, null, "E", 2, null, "E2", 4 },
                    { 393, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7052), true, false, null, "E", 3, null, "E3", 4 },
                    { 394, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7054), true, false, null, "E", 4, null, "E4", 4 },
                    { 395, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7056), true, false, null, "E", 5, null, "E5", 4 },
                    { 396, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7058), true, false, null, "E", 6, null, "E6", 4 },
                    { 397, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7060), true, false, null, "E", 7, null, "E7", 4 },
                    { 398, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7061), true, false, null, "E", 8, null, "E8", 4 },
                    { 399, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7063), true, false, null, "E", 9, null, "E9", 4 },
                    { 400, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7065), true, false, null, "E", 10, null, "E10", 4 },
                    { 401, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7067), true, false, null, "F", 1, null, "F1", 4 },
                    { 402, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7069), true, false, null, "F", 2, null, "F2", 4 },
                    { 403, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7071), true, false, null, "F", 3, null, "F3", 4 },
                    { 404, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7072), true, false, null, "F", 4, null, "F4", 4 },
                    { 405, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7074), true, false, null, "F", 5, null, "F5", 4 },
                    { 406, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7076), true, false, null, "F", 6, null, "F6", 4 },
                    { 407, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7078), true, false, null, "F", 7, null, "F7", 4 },
                    { 408, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7081), true, false, null, "F", 8, null, "F8", 4 },
                    { 409, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7083), true, false, null, "F", 9, null, "F9", 4 },
                    { 410, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7085), true, false, null, "F", 10, null, "F10", 4 },
                    { 411, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7086), true, false, null, "G", 1, null, "G1", 4 },
                    { 412, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7088), true, false, null, "G", 2, null, "G2", 4 },
                    { 413, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7090), true, false, null, "G", 3, null, "G3", 4 },
                    { 414, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7092), true, false, null, "G", 4, null, "G4", 4 },
                    { 415, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7094), true, false, null, "G", 5, null, "G5", 4 },
                    { 416, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7096), true, false, null, "G", 6, null, "G6", 4 },
                    { 417, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7098), true, false, null, "G", 7, null, "G7", 4 },
                    { 418, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7099), true, false, null, "G", 8, null, "G8", 4 },
                    { 419, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7101), true, false, null, "G", 9, null, "G9", 4 },
                    { 420, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7103), true, false, null, "G", 10, null, "G10", 4 },
                    { 421, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7105), true, false, null, "H", 1, null, "H1", 4 },
                    { 422, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7108), true, false, null, "H", 2, null, "H2", 4 },
                    { 423, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7110), true, false, null, "H", 3, null, "H3", 4 },
                    { 424, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7112), true, false, null, "H", 4, null, "H4", 4 },
                    { 425, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7114), true, false, null, "H", 5, null, "H5", 4 },
                    { 426, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7116), true, false, null, "H", 6, null, "H6", 4 },
                    { 427, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7118), true, false, null, "H", 7, null, "H7", 4 },
                    { 428, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7120), true, false, null, "H", 8, null, "H8", 4 },
                    { 429, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7121), true, false, null, "H", 9, null, "H9", 4 },
                    { 430, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7123), true, false, null, "H", 10, null, "H10", 4 },
                    { 431, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7126), true, false, null, "I", 1, null, "I1", 4 },
                    { 432, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7128), true, false, null, "I", 2, null, "I2", 4 },
                    { 433, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7130), true, false, null, "I", 3, null, "I3", 4 },
                    { 434, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7131), true, false, null, "I", 4, null, "I4", 4 },
                    { 435, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7133), true, false, null, "I", 5, null, "I5", 4 },
                    { 436, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7135), true, false, null, "I", 6, null, "I6", 4 },
                    { 437, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7138), true, false, null, "I", 7, null, "I7", 4 },
                    { 438, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7140), true, false, null, "I", 8, null, "I8", 4 },
                    { 439, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7142), true, false, null, "I", 9, null, "I9", 4 },
                    { 440, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7143), true, false, null, "I", 10, null, "I10", 4 },
                    { 441, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7145), true, false, null, "J", 1, null, "J1", 4 },
                    { 442, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7147), true, false, null, "J", 2, null, "J2", 4 },
                    { 443, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7149), true, false, null, "J", 3, null, "J3", 4 },
                    { 444, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7151), true, false, null, "J", 4, null, "J4", 4 },
                    { 445, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7153), true, false, null, "J", 5, null, "J5", 4 },
                    { 446, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7155), true, false, null, "J", 6, null, "J6", 4 },
                    { 447, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7156), true, false, null, "J", 7, null, "J7", 4 },
                    { 448, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7162), true, false, null, "J", 8, null, "J8", 4 },
                    { 449, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7164), true, false, null, "J", 9, null, "J9", 4 },
                    { 450, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7166), true, false, null, "J", 10, null, "J10", 4 },
                    { 451, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7168), true, false, null, "A", 1, null, "A1", 5 },
                    { 452, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7171), true, false, null, "A", 2, null, "A2", 5 },
                    { 453, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7173), false, false, null, "A", 3, null, "A3", 5 },
                    { 454, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7175), true, false, null, "A", 4, null, "A4", 5 },
                    { 455, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7177), true, false, null, "A", 5, null, "A5", 5 },
                    { 456, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7179), true, false, null, "A", 6, null, "A6", 5 },
                    { 457, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7181), true, false, null, "A", 7, null, "A7", 5 },
                    { 458, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7183), true, false, null, "A", 8, null, "A8", 5 },
                    { 459, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7185), true, false, null, "A", 9, null, "A9", 5 },
                    { 460, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7186), true, false, null, "A", 10, null, "A10", 5 },
                    { 461, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7188), true, false, null, "B", 1, null, "B1", 5 },
                    { 462, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7190), true, false, null, "B", 2, null, "B2", 5 },
                    { 463, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7192), true, false, null, "B", 3, null, "B3", 5 },
                    { 464, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7194), true, false, null, "B", 4, null, "B4", 5 },
                    { 465, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7196), true, false, null, "B", 5, null, "B5", 5 },
                    { 466, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7198), true, false, null, "B", 6, null, "B6", 5 },
                    { 467, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7202), true, false, null, "B", 7, null, "B7", 5 },
                    { 468, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7204), true, false, null, "B", 8, null, "B8", 5 },
                    { 469, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7206), true, false, null, "B", 9, null, "B9", 5 },
                    { 470, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7208), true, false, null, "B", 10, null, "B10", 5 },
                    { 471, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7210), true, false, null, "C", 1, null, "C1", 5 },
                    { 472, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7212), true, false, null, "C", 2, null, "C2", 5 },
                    { 473, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7214), true, false, null, "C", 3, null, "C3", 5 },
                    { 474, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7215), true, false, null, "C", 4, null, "C4", 5 },
                    { 475, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7217), true, false, null, "C", 5, null, "C5", 5 },
                    { 476, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7219), true, false, null, "C", 6, null, "C6", 5 },
                    { 477, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7221), true, false, null, "C", 7, null, "C7", 5 },
                    { 478, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7223), true, false, null, "C", 8, null, "C8", 5 },
                    { 479, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7225), true, false, null, "C", 9, null, "C9", 5 },
                    { 480, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7227), true, false, null, "C", 10, null, "C10", 5 },
                    { 481, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7229), true, false, null, "D", 1, null, "D1", 5 },
                    { 482, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7231), true, false, null, "D", 2, null, "D2", 5 },
                    { 483, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7233), true, false, null, "D", 3, null, "D3", 5 },
                    { 484, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7235), true, false, null, "D", 4, null, "D4", 5 },
                    { 485, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7237), true, false, null, "D", 5, null, "D5", 5 },
                    { 486, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7239), true, false, null, "D", 6, null, "D6", 5 },
                    { 487, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7241), true, false, null, "D", 7, null, "D7", 5 },
                    { 488, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7243), true, false, null, "D", 8, null, "D8", 5 },
                    { 489, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7245), true, false, null, "D", 9, null, "D9", 5 },
                    { 490, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7247), true, false, null, "D", 10, null, "D10", 5 },
                    { 491, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7249), true, false, null, "E", 1, null, "E1", 5 },
                    { 492, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7250), true, false, null, "E", 2, null, "E2", 5 },
                    { 493, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7252), true, false, null, "E", 3, null, "E3", 5 },
                    { 494, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7254), true, false, null, "E", 4, null, "E4", 5 },
                    { 495, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7256), true, false, null, "E", 5, null, "E5", 5 },
                    { 496, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7258), true, false, null, "E", 6, null, "E6", 5 },
                    { 497, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7262), true, false, null, "E", 7, null, "E7", 5 },
                    { 498, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7263), true, false, null, "E", 8, null, "E8", 5 },
                    { 499, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7265), true, false, null, "E", 9, null, "E9", 5 },
                    { 500, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7267), true, false, null, "E", 10, null, "E10", 5 },
                    { 501, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7270), true, false, null, "F", 1, null, "F1", 5 },
                    { 502, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7272), true, false, null, "F", 2, null, "F2", 5 },
                    { 503, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7274), true, false, null, "F", 3, null, "F3", 5 },
                    { 504, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7275), true, false, null, "F", 4, null, "F4", 5 },
                    { 505, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7278), true, false, null, "F", 5, null, "F5", 5 },
                    { 506, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7280), true, false, null, "F", 6, null, "F6", 5 },
                    { 507, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7282), true, false, null, "F", 7, null, "F7", 5 },
                    { 508, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7283), true, false, null, "F", 8, null, "F8", 5 },
                    { 509, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7285), true, false, null, "F", 9, null, "F9", 5 },
                    { 510, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7287), true, false, null, "F", 10, null, "F10", 5 },
                    { 511, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7289), true, false, null, "G", 1, null, "G1", 5 },
                    { 512, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7292), true, false, null, "G", 2, null, "G2", 5 },
                    { 513, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7294), true, false, null, "G", 3, null, "G3", 5 },
                    { 514, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7296), true, false, null, "G", 4, null, "G4", 5 },
                    { 515, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7298), true, false, null, "G", 5, null, "G5", 5 },
                    { 516, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7300), true, false, null, "G", 6, null, "G6", 5 },
                    { 517, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7302), true, false, null, "G", 7, null, "G7", 5 },
                    { 518, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7304), true, false, null, "G", 8, null, "G8", 5 },
                    { 519, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7305), true, false, null, "G", 9, null, "G9", 5 },
                    { 520, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7307), true, false, null, "G", 10, null, "G10", 5 },
                    { 521, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7314), true, false, null, "H", 1, null, "H1", 5 },
                    { 522, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7316), true, false, null, "H", 2, null, "H2", 5 },
                    { 523, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7318), true, false, null, "H", 3, null, "H3", 5 },
                    { 524, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7320), true, false, null, "H", 4, null, "H4", 5 },
                    { 525, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7322), true, false, null, "H", 5, null, "H5", 5 },
                    { 526, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7324), true, false, null, "H", 6, null, "H6", 5 },
                    { 527, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7327), true, false, null, "H", 7, null, "H7", 5 },
                    { 528, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7328), true, false, null, "H", 8, null, "H8", 5 },
                    { 529, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7330), true, false, null, "H", 9, null, "H9", 5 },
                    { 530, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7332), true, false, null, "H", 10, null, "H10", 5 },
                    { 531, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7334), true, false, null, "I", 1, null, "I1", 5 },
                    { 532, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7336), true, false, null, "I", 2, null, "I2", 5 },
                    { 533, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7338), true, false, null, "I", 3, null, "I3", 5 },
                    { 534, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7340), true, false, null, "I", 4, null, "I4", 5 },
                    { 535, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7342), true, false, null, "I", 5, null, "I5", 5 },
                    { 536, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7343), true, false, null, "I", 6, null, "I6", 5 },
                    { 537, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7345), true, false, null, "I", 7, null, "I7", 5 },
                    { 538, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7347), true, false, null, "I", 8, null, "I8", 5 },
                    { 539, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7349), true, false, null, "I", 9, null, "I9", 5 },
                    { 540, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7351), true, false, null, "I", 10, null, "I10", 5 },
                    { 541, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7353), true, false, null, "J", 1, null, "J1", 5 },
                    { 542, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7356), true, false, null, "J", 2, null, "J2", 5 },
                    { 543, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7358), true, false, null, "J", 3, null, "J3", 5 },
                    { 544, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7360), true, false, null, "J", 4, null, "J4", 5 },
                    { 545, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7361), true, false, null, "J", 5, null, "J5", 5 },
                    { 546, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7363), true, false, null, "J", 6, null, "J6", 5 },
                    { 547, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7366), true, false, null, "J", 7, null, "J7", 5 },
                    { 548, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7367), true, false, null, "J", 8, null, "J8", 5 },
                    { 549, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7369), true, false, null, "J", 9, null, "J9", 5 },
                    { 550, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7371), false, false, null, "J", 10, null, "J10", 5 },
                    { 551, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7373), false, false, null, "A", 1, null, "A1", 6 },
                    { 552, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7375), false, false, null, "A", 2, null, "A2", 6 },
                    { 553, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7377), true, false, null, "A", 3, null, "A3", 6 },
                    { 554, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7379), true, false, null, "A", 4, null, "A4", 6 },
                    { 555, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7380), true, false, null, "A", 5, null, "A5", 6 },
                    { 556, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7382), true, false, null, "A", 6, null, "A6", 6 },
                    { 557, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7385), true, false, null, "A", 7, null, "A7", 6 },
                    { 558, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7388), true, false, null, "A", 8, null, "A8", 6 },
                    { 559, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7390), true, false, null, "A", 9, null, "A9", 6 },
                    { 560, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7392), true, false, null, "A", 10, null, "A10", 6 },
                    { 561, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7394), true, false, null, "B", 1, null, "B1", 6 },
                    { 562, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7396), true, false, null, "B", 2, null, "B2", 6 },
                    { 563, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7398), true, false, null, "B", 3, null, "B3", 6 },
                    { 564, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7400), true, false, null, "B", 4, null, "B4", 6 },
                    { 565, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7401), true, false, null, "B", 5, null, "B5", 6 },
                    { 566, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7403), true, false, null, "B", 6, null, "B6", 6 },
                    { 567, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7405), true, false, null, "B", 7, null, "B7", 6 },
                    { 568, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7407), true, false, null, "B", 8, null, "B8", 6 },
                    { 569, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7409), true, false, null, "B", 9, null, "B9", 6 },
                    { 570, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7411), true, false, null, "B", 10, null, "B10", 6 },
                    { 571, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7414), true, false, null, "C", 1, null, "C1", 6 },
                    { 572, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7416), true, false, null, "C", 2, null, "C2", 6 },
                    { 573, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7418), true, false, null, "C", 3, null, "C3", 6 },
                    { 574, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7420), true, false, null, "C", 4, null, "C4", 6 },
                    { 575, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7421), true, false, null, "C", 5, null, "C5", 6 },
                    { 576, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7423), true, false, null, "C", 6, null, "C6", 6 },
                    { 577, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7425), true, false, null, "C", 7, null, "C7", 6 },
                    { 578, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7427), true, false, null, "C", 8, null, "C8", 6 },
                    { 579, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7430), true, false, null, "C", 9, null, "C9", 6 },
                    { 580, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7431), true, false, null, "C", 10, null, "C10", 6 },
                    { 581, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7433), true, false, null, "D", 1, null, "D1", 6 },
                    { 582, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7435), true, false, null, "D", 2, null, "D2", 6 },
                    { 583, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7437), true, false, null, "D", 3, null, "D3", 6 },
                    { 584, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7439), true, false, null, "D", 4, null, "D4", 6 },
                    { 585, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7441), true, false, null, "D", 5, null, "D5", 6 },
                    { 586, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7444), true, false, null, "D", 6, null, "D6", 6 },
                    { 587, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7446), true, false, null, "D", 7, null, "D7", 6 },
                    { 588, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7448), true, false, null, "D", 8, null, "D8", 6 },
                    { 589, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7449), true, false, null, "D", 9, null, "D9", 6 },
                    { 590, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7452), true, false, null, "D", 10, null, "D10", 6 },
                    { 591, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7454), true, false, null, "E", 1, null, "E1", 6 },
                    { 592, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7456), true, false, null, "E", 2, null, "E2", 6 },
                    { 593, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7458), true, false, null, "E", 3, null, "E3", 6 },
                    { 594, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7464), true, false, null, "E", 4, null, "E4", 6 },
                    { 595, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7466), true, false, null, "E", 5, null, "E5", 6 },
                    { 596, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7468), true, false, null, "E", 6, null, "E6", 6 },
                    { 597, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7470), true, false, null, "E", 7, null, "E7", 6 },
                    { 598, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7473), true, false, null, "E", 8, null, "E8", 6 },
                    { 599, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7475), true, false, null, "E", 9, null, "E9", 6 },
                    { 600, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7477), true, false, null, "E", 10, null, "E10", 6 },
                    { 601, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7479), true, false, null, "F", 1, null, "F1", 6 },
                    { 602, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7481), true, false, null, "F", 2, null, "F2", 6 },
                    { 603, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7483), true, false, null, "F", 3, null, "F3", 6 },
                    { 604, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7485), true, false, null, "F", 4, null, "F4", 6 },
                    { 605, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7487), true, false, null, "F", 5, null, "F5", 6 },
                    { 606, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7489), true, false, null, "F", 6, null, "F6", 6 },
                    { 607, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7491), true, false, null, "F", 7, null, "F7", 6 },
                    { 608, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7493), true, false, null, "F", 8, null, "F8", 6 },
                    { 609, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7495), true, false, null, "F", 9, null, "F9", 6 },
                    { 610, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7497), true, false, null, "F", 10, null, "F10", 6 },
                    { 611, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7499), true, false, null, "G", 1, null, "G1", 6 },
                    { 612, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7501), true, false, null, "G", 2, null, "G2", 6 },
                    { 613, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7503), true, false, null, "G", 3, null, "G3", 6 },
                    { 614, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7505), true, false, null, "G", 4, null, "G4", 6 },
                    { 615, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7507), true, false, null, "G", 5, null, "G5", 6 },
                    { 616, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7509), true, false, null, "G", 6, null, "G6", 6 },
                    { 617, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7511), true, false, null, "G", 7, null, "G7", 6 },
                    { 618, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7513), true, false, null, "G", 8, null, "G8", 6 },
                    { 619, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7515), true, false, null, "G", 9, null, "G9", 6 },
                    { 620, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7517), true, false, null, "G", 10, null, "G10", 6 },
                    { 621, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7518), true, false, null, "H", 1, null, "H1", 6 },
                    { 622, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7520), true, false, null, "H", 2, null, "H2", 6 },
                    { 623, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7522), true, false, null, "H", 3, null, "H3", 6 },
                    { 624, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7524), true, false, null, "H", 4, null, "H4", 6 },
                    { 625, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7526), true, false, null, "H", 5, null, "H5", 6 },
                    { 626, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7528), true, false, null, "H", 6, null, "H6", 6 },
                    { 627, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7530), true, false, null, "H", 7, null, "H7", 6 },
                    { 628, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7532), true, false, null, "H", 8, null, "H8", 6 },
                    { 629, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7533), true, false, null, "H", 9, null, "H9", 6 },
                    { 630, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7535), true, false, null, "H", 10, null, "H10", 6 },
                    { 631, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7538), true, false, null, "I", 1, null, "I1", 6 },
                    { 632, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7540), true, false, null, "I", 2, null, "I2", 6 },
                    { 633, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7542), true, false, null, "I", 3, null, "I3", 6 },
                    { 634, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7544), true, false, null, "I", 4, null, "I4", 6 },
                    { 635, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7546), true, false, null, "I", 5, null, "I5", 6 },
                    { 636, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7548), true, false, null, "I", 6, null, "I6", 6 },
                    { 637, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7550), true, false, null, "I", 7, null, "I7", 6 },
                    { 638, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7552), true, false, null, "I", 8, null, "I8", 6 },
                    { 639, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7554), true, false, null, "I", 9, null, "I9", 6 },
                    { 640, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7555), true, false, null, "I", 10, null, "I10", 6 },
                    { 641, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7557), true, false, null, "J", 1, null, "J1", 6 },
                    { 642, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7559), true, false, null, "J", 2, null, "J2", 6 },
                    { 643, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7561), true, false, null, "J", 3, null, "J3", 6 },
                    { 644, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7563), true, false, null, "J", 4, null, "J4", 6 },
                    { 645, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7565), true, false, null, "J", 5, null, "J5", 6 },
                    { 646, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7567), true, false, null, "J", 6, null, "J6", 6 },
                    { 647, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7569), true, false, null, "J", 7, null, "J7", 6 },
                    { 648, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7570), true, false, null, "J", 8, null, "J8", 6 },
                    { 649, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7572), true, false, null, "J", 9, null, "J9", 6 },
                    { 650, new DateTime(2023, 10, 31, 16, 41, 21, 686, DateTimeKind.Local).AddTicks(7574), true, false, null, "J", 10, null, "J10", 6 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", "admin", 1 },
                    { 2, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", "admin@etheater.ba", 1 },
                    { 4, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", "adlaKaj", 2 },
                    { 5, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", "adla@gmail.com", 2 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "TheaterInfo",
                keyColumn: "TheaterInfoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "TicketId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "HallId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Show",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5266), new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5271), new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5276), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5280), new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5283), new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "ShowSchedule",
                keyColumn: "ShowScheduleId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ShowDate" },
                values: new object[] { new DateTime(2023, 10, 28, 15, 57, 8, 793, DateTimeKind.Local).AddTicks(5287), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
