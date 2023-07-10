using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class changed_roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "369 Dax Divide", "Jazminshire", new DateTime(2022, 9, 20, 8, 43, 29, 280, DateTimeKind.Local).AddTicks(6545), "Abdullah.Steuber34@hotmail.com", 81.922600000000003, -36.613199999999999, "Global Implementation Executive", "896-504-1747 x4492", "27519-2896" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "11505 Blanda Harbor", "North Antoniettaview", new DateTime(2022, 7, 13, 12, 24, 18, 53, DateTimeKind.Local).AddTicks(2927), "Ottilie69@hotmail.com", -68.325999999999993, 117.2208, "Legacy Interactions Executive", "(976) 647-2594", "05707" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "64594 Laron Springs", "New Brookfort", new DateTime(2023, 1, 13, 9, 51, 9, 85, DateTimeKind.Local).AddTicks(2558), "Cordell.Hettinger30@yahoo.com", -84.044300000000007, -143.512, "Internal Configuration Director", "(643) 746-5063 x916", "79921-5121" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2637 Veronica Rapids", "Rodriguezland", new DateTime(2022, 7, 26, 17, 30, 31, 682, DateTimeKind.Local).AddTicks(7962), "Landen.Harvey41@gmail.com", -82.246300000000005, -135.06739999999999, "District Web Producer", "550-855-4586 x8092", "01373" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "60789 Abshire Pine", "Kaleyhaven", new DateTime(2022, 8, 24, 4, 2, 39, 21, DateTimeKind.Local).AddTicks(5379), "Kaleigh_Pollich@hotmail.com", -59.867400000000004, -53.099200000000003, "Dynamic Identity Supervisor", "511.374.4563 x43983", "21830-2750" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "52556 Ella Coves", "Brakusside", new DateTime(2022, 8, 22, 15, 42, 8, 964, DateTimeKind.Local).AddTicks(3261), "Marcellus_Lueilwitz@gmail.com", -43.972299999999997, 165.5487, "Customer Directives Administrator", "711-374-8778 x28054", "37418-1460" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "78910 Maggio Parkway", "Schummton", new DateTime(2022, 7, 19, 15, 0, 4, 94, DateTimeKind.Local).AddTicks(7473), "Savanna.Schultz@yahoo.com", -15.6747, 89.360600000000005, "Principal Implementation Facilitator", "1-399-269-9001 x60634", "46687-0021" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "05237 Dexter Fords", "Wunschburgh", new DateTime(2023, 5, 18, 12, 12, 42, 38, DateTimeKind.Local).AddTicks(897), "Rosemarie43@hotmail.com", -18.2013, -6.3719999999999999, "Dynamic Integration Liaison", "775-817-5069 x5383", "52606" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "497 Bayer Walks", "West Meaganbury", new DateTime(2022, 11, 30, 4, 53, 16, 40, DateTimeKind.Local).AddTicks(4393), "Albina_Wilderman@gmail.com", -1.3023, 128.6191, "Product Identity Representative", "889-770-1899 x5736", "76307" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "454 Bergstrom Cliff", "Hobarttown", new DateTime(2022, 9, 29, 13, 11, 1, 709, DateTimeKind.Local).AddTicks(902), "Rusty.Oberbrunner@hotmail.com", 73.2834, 59.385100000000001, "Chief Program Associate", "(825) 229-2019", "67472-1754" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 14, 5, 41, 41, 234, DateTimeKind.Local).AddTicks(3170), "Bugatti" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 2, 8, 10, 32, 436, DateTimeKind.Local).AddTicks(6056), "Chevrolet" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 11, 12, 18, 43, 250, DateTimeKind.Local).AddTicks(407), "Chrysler" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 27, 10, 32, 48, 635, DateTimeKind.Local).AddTicks(3555), "BMW" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 29, 2, 255, DateTimeKind.Local).AddTicks(6700), "Ferrari" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 28, 5, 44, 9, 860, DateTimeKind.Local).AddTicks(8289), "Polestar" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 8, 5, 31, 41, 477, DateTimeKind.Local).AddTicks(6331), "Mini" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 27, 19, 47, 39, 565, DateTimeKind.Local).AddTicks(619), "Ford" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 3, 12, 9, 22, 344, DateTimeKind.Local).AddTicks(6101), "Volvo" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 7, 12, 14, 5, 30, 470, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 5, 35, 511, DateTimeKind.Local).AddTicks(1303), 3, "Corvette" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 4, 20, 5, 6, 25, 934, DateTimeKind.Local).AddTicks(6386), 4, "Alpine" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 2, 10, 18, 51, 29, 647, DateTimeKind.Local).AddTicks(1294), 9, "Golf" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 11, 18, 7, 12, 30, 346, DateTimeKind.Local).AddTicks(5352), 4, "Charger" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 6, 29, 12, 39, 26, 293, DateTimeKind.Local).AddTicks(5964), 3, "Altima" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 2, 21, 12, 25, 3, 543, DateTimeKind.Local).AddTicks(4189), 1, "Jetta" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 29, 7, 32, 36, 919, DateTimeKind.Local).AddTicks(8846), "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 12, 7, 58, 13, 853, DateTimeKind.Local).AddTicks(3544), "CX-9" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 9, 21, 4, 16, 54, 194, DateTimeKind.Local).AddTicks(5582), 3, "Charger" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 3, 18, 5, 12, 30, 659, DateTimeKind.Local).AddTicks(9796), 4, "Altima" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Commercial");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Agent");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 1, 18, 25, 34, 888, DateTimeKind.Local).AddTicks(3204), "Aimee.Walter@gmail.com", "Cleora", 1, 2, false, "Harris", "$2a$11$h3x0CUvYYpaJ7cKFVHf6Zu1sK5DdHWpqGcP6mQ6Y0lCfcpTAIFACe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 16, 22, 49, 17, 421, DateTimeKind.Local).AddTicks(1872), "Sammie15@hotmail.com", "Mireya", 6, 4, true, "Littel", "$2a$11$1nsL8c9LUMOwFWBWRUPJOOEXLyE3b8yaQlLz.8BzdbW79W/dIFjVu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 1, 10, 49, 17, 954, DateTimeKind.Local).AddTicks(6324), "Miguel45@hotmail.com", "Louvenia", 5, 4, true, "Bruen", "$2a$11$.i1y805toR3p0v8GhWVoaeZAcOScmuK5B0UsfQjgShnt6o76FeVVC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 6, 18, 26, 31, 371, DateTimeKind.Local).AddTicks(9475), "Selmer.Smitham@yahoo.com", "Carter", 4, 2, false, "Tromp", "$2a$11$OG4WHfrDi02E7ZpHXq3Kre/zNVHbwS.6nbR2RiA9KVUSB.laeLCG2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 23, 0, 24, 55, 813, DateTimeKind.Local).AddTicks(9620), "Luciano83@yahoo.com", "Alexis", 2, 1, false, "Smitham", "$2a$11$8XaHECFoRfIALvmKSXmSmuy0Tolkx36kPP5JUUYfSFsQGh0.gW9km" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 13, 1, 49, 55, 260, DateTimeKind.Local).AddTicks(1848), "Marc_Ondricka@yahoo.com", "Elody", 4, "Wehner", "$2a$11$gZdvmrCieGA4kX47vPRSMuX0iEaiD6jnz85JjjrghlVIfvjhPQkoi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 1, 21, 52, 57, 697, DateTimeKind.Local).AddTicks(2015), "Glennie_Hilpert@yahoo.com", "German", 9, "Berge", "$2a$11$TTSpvHFIBMKtJzu8zZVKeeoxCa44w99M8Z76X7HyJ/aN893SP7ubm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 7, 27, 2, 35, 25, 774, DateTimeKind.Local).AddTicks(6385), "Austen_Kassulke@hotmail.com", "Trevion", 5, 4, "Klocko", "$2a$11$qHU5hW.Qg0PpZBbqGwMeGOk.81bcZ5G2rMk6C0pmtIgaIg7FF.a1m" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 5, 2, 13, 51, 600, DateTimeKind.Local).AddTicks(3834), "Carolina_Hand@hotmail.com", "Gerald", 2, 2, "Frami", "$2a$11$dGuekwSwbLhbdXenXditre5zwie03T0mQJCybpXBQe8vnqBou1q8a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 23, 8, 34, 56, 167, DateTimeKind.Local).AddTicks(3669), "Freddy76@hotmail.com", "Mariana", 8, 3, false, "Ledner", "$2a$11$sAHtUazdPciX.hH0VyWgbeEnsDuecL2PGPSid.oW710cNZImqw86q" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "43678 Evert Square", "East Fatimastad", new DateTime(2022, 10, 23, 7, 14, 9, 182, DateTimeKind.Local).AddTicks(4578), "Trystan65@hotmail.com", -5.2603999999999997, 54.498899999999999, "Future Configuration Orchestrator", "(681) 395-1896 x79704", "47381-6710" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "186 Jewell Ranch", "South Justuschester", new DateTime(2023, 2, 14, 11, 49, 52, 54, DateTimeKind.Local).AddTicks(9599), "Vallie39@gmail.com", -2.4176000000000002, -69.884200000000007, "Chief Quality Orchestrator", "1-893-761-4344 x9968", "16145-7143" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "688 Mosciski Lock", "Kleinport", new DateTime(2023, 1, 14, 5, 5, 29, 419, DateTimeKind.Local).AddTicks(3915), "Ollie24@hotmail.com", -0.36959999999999998, 12.352, "Senior Optimization Planner", "755.282.9459", "78306-1729" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1591 Sporer Knoll", "Jermaintown", new DateTime(2023, 1, 18, 5, 29, 6, 518, DateTimeKind.Local).AddTicks(6497), "Zion87@gmail.com", -66.161299999999997, 16.4053, "Central Response Officer", "(248) 841-7755", "65224-8645" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "950 Schuster Manors", "Lake Vincenzo", new DateTime(2023, 2, 24, 6, 50, 10, 387, DateTimeKind.Local).AddTicks(6154), "Tate_Tromp@hotmail.com", -55.594200000000001, -24.770199999999999, "Central Accountability Specialist", "1-544-599-1405 x6123", "24352" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "989 McLaughlin Tunnel", "Arianetown", new DateTime(2022, 9, 9, 16, 5, 2, 353, DateTimeKind.Local).AddTicks(91), "Retha.Krajcik75@hotmail.com", -66.605699999999999, -20.457999999999998, "Internal Data Analyst", "909-313-3654 x1799", "97308" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "88011 Collins Vista", "West Santinoberg", new DateTime(2022, 12, 25, 21, 14, 49, 508, DateTimeKind.Local).AddTicks(8241), "Francesco.OConnell@hotmail.com", -24.0307, 90.381500000000003, "National Configuration Coordinator", "(315) 436-8541 x9400", "49132" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "6129 Corkery Points", "North Helen", new DateTime(2022, 12, 14, 17, 47, 21, 473, DateTimeKind.Local).AddTicks(9132), "Stanley.Wisoky@gmail.com", -86.257199999999997, 10.185700000000001, "Product Research Orchestrator", "(864) 422-9758", "97637-8114" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "391 Cassin Manor", "South Darron", new DateTime(2023, 3, 19, 7, 33, 6, 363, DateTimeKind.Local).AddTicks(2281), "Imani.Thompson8@hotmail.com", -83.481999999999999, 91.739900000000006, "District Usability Consultant", "(609) 940-4636 x6903", "83032-2810" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "938 Lind Crest", "Lake Norene", new DateTime(2023, 4, 24, 8, 58, 22, 754, DateTimeKind.Local).AddTicks(3717), "Fermin.Cartwright@gmail.com", -34.8626, 119.5598, "Human Data Assistant", "(738) 322-4130 x83176", "79722-7331" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 22, 7, 46, 20, 417, DateTimeKind.Local).AddTicks(8521), "Tesla" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 7, 23, 20, 21, 999, DateTimeKind.Local).AddTicks(3518), "Toyota" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 23, 14, 29, 35, 511, DateTimeKind.Local).AddTicks(9111), "Cadillac" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 18, 22, 4, 27, 631, DateTimeKind.Local).AddTicks(3149), "Volvo" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 2, 16, 9, 7, 52, 805, DateTimeKind.Local).AddTicks(9050), "Volkswagen" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 11, 8, 44, 35, 85, DateTimeKind.Local).AddTicks(1077), "BMW" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 28, 15, 58, 57, 762, DateTimeKind.Local).AddTicks(6452), "Audi" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 19, 19, 2, 11, 489, DateTimeKind.Local).AddTicks(6391), "Dodge" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 20, 18, 28, 42, 497, DateTimeKind.Local).AddTicks(5860), "Porsche" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 8, 15, 19, 28, 54, 106, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 2, 23, 20, 31, 58, 744, DateTimeKind.Local).AddTicks(2325), 1, "Silverado" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 6, 25, 18, 32, 29, 262, DateTimeKind.Local).AddTicks(5344), 6, "Mercielago" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 1, 19, 4, 24, 16, 761, DateTimeKind.Local).AddTicks(6133), 2, "Spyder" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 9, 11, 10, 42, 32, 261, DateTimeKind.Local).AddTicks(4259), 1, "LeBaron" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 2, 3, 17, 15, 12, 507, DateTimeKind.Local).AddTicks(9890), 9, "Taurus" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 11, 15, 21, 38, 37, 731, DateTimeKind.Local).AddTicks(7191), 10, "Element" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 4, 19, 20, 55, 763, DateTimeKind.Local).AddTicks(4739), "PT Cruiser" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 9, 18, 39, 13, 533, DateTimeKind.Local).AddTicks(7312), "PT Cruiser" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 10, 26, 0, 45, 27, 821, DateTimeKind.Local).AddTicks(8609), 9, "Countach" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 4, 27, 10, 44, 46, 955, DateTimeKind.Local).AddTicks(6637), 1, "Corvette" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Agent");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Client");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 29, 8, 38, 29, 728, DateTimeKind.Local).AddTicks(8782), "Orpha82@yahoo.com", "Jasmin", 6, 3, true, "Johnston", "$2a$11$NlWHXDWE/haYGwFj5V65XerctPkZlvvF62hRCSpNAvZH1UqZ9fW3e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 7, 21, 2, 52, 12, 766, DateTimeKind.Local).AddTicks(6179), "Forest99@hotmail.com", "Dannie", 8, 1, false, "Daugherty", "$2a$11$XLl5z3vSL3UewoX6Ifqb4OZcAYeJC9Xtz2p.Klg4RFPVWZl0vXoLa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 18, 13, 31, 16, 312, DateTimeKind.Local).AddTicks(7606), "Rozella18@yahoo.com", "Cooper", 6, 2, false, "Harvey", "$2a$11$0X6FXH0ne5xeN6LRDZrHvOmn.04DqGYsNVTAjjhZP.OBrdh6bv292" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 31, 7, 25, 32, 241, DateTimeKind.Local).AddTicks(6826), "Diamond60@gmail.com", "Angelita", 10, 3, true, "Hills", "$2a$11$TG34oTlbQxRPiYaARmj3hO5Ewal.lhlresXLtGtkAKL0PziYoqkoG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 16, 4, 44, 41, 999, DateTimeKind.Local).AddTicks(3588), "Rosemary70@yahoo.com", "Hermann", 8, 4, true, "Simonis", "$2a$11$s4nEI80ALYpD3tu02c7VWeQbntEAmAkYLSIxWXppDg4IU7tR1O5zq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 2, 9, 15, 32, 83, DateTimeKind.Local).AddTicks(3358), "Louie40@gmail.com", "Aurelie", 2, "White", "$2a$11$REDMdHGx./7ukXavujk4keyQJK3VrfSBaQ1Ii4Wto4ho8mV7I3kbG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 3, 4, 46, 29, 774, DateTimeKind.Local).AddTicks(7582), "Kendall_Jacobs19@hotmail.com", "Alexandrea", 8, "Legros", "$2a$11$q1VEY4mbt.H7NKPYCXKtKOGNsksqhbrFTcsiBqp8zQi1LNBAdSevy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 7, 11, 19, 20, 43, 140, DateTimeKind.Local).AddTicks(5107), "Oran.Considine93@yahoo.com", "Esta", 3, 2, "Armstrong", "$2a$11$n4IDwaLvu3R8ZsBj/2IHBO1ijFgYgErEHkBkrdAQwZujJrP7KNH.y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 10, 14, 30, 50, 959, DateTimeKind.Local).AddTicks(6243), "Carolanne_Larson37@hotmail.com", "Rudolph", 9, 3, "Johnston", "$2a$11$8Cdn66AnxFjowppgaUN7eOFgu.U8pmtL/pmX7NkA9B6RCg/3F/6/K" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 6, 5, 48, 16, 435, DateTimeKind.Local).AddTicks(2631), "Brenda_Spinka@hotmail.com", "Vern", 10, 4, true, "Fahey", "$2a$11$uCYkCy8xZds35rbbrma6dubsdaOK82w5RpfduRRwPp2tejapDEBGG" });
        }
    }
}
