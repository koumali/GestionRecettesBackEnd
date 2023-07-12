using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class filter_deleted_items : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "755 Swaniawski Path", "South Annabellburgh", new DateTime(2023, 2, 26, 6, 6, 40, 758, DateTimeKind.Local).AddTicks(6428), "Idella75@hotmail.com", 12.1572, 144.29499999999999, "District Marketing Liaison", "1-963-246-0604 x799", "40262" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "21905 Christiansen Skyway", "Katelintown", new DateTime(2023, 1, 31, 21, 57, 16, 499, DateTimeKind.Local).AddTicks(8766), "Manley_Hane9@hotmail.com", -25.9941, -175.828, "Global Usability Supervisor", "1-451-801-2027 x6877", "65865" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4272 Walter Heights", "Bettyhaven", new DateTime(2022, 10, 6, 1, 8, 23, 477, DateTimeKind.Local).AddTicks(3204), "Murl73@yahoo.com", 58.849699999999999, 52.4069, "Dynamic Marketing Coordinator", "(970) 872-4332", "80193-1477" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "658 Spinka Centers", "New Ambrose", new DateTime(2023, 4, 17, 18, 47, 6, 290, DateTimeKind.Local).AddTicks(7821), "Jazmyne_Padberg@gmail.com", 10.9077, -153.81049999999999, "Dynamic Applications Officer", "(734) 416-2760", "81383-1060" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "6494 Uriah Place", "Manteshire", new DateTime(2022, 8, 14, 18, 41, 34, 478, DateTimeKind.Local).AddTicks(1373), "Yasmeen16@gmail.com", -60.220300000000002, -162.2869, "Investor Accountability Coordinator", "615-936-9975 x62037", "89101" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "29368 Larkin Canyon", "Spencerton", new DateTime(2023, 5, 27, 21, 51, 46, 455, DateTimeKind.Local).AddTicks(3057), "Nathanael_Ernser@yahoo.com", -58.051000000000002, 60.2804, "Regional Factors Executive", "681-762-6177 x1805", "02780-7174" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "46271 Brendan Club", "Gilbertside", new DateTime(2023, 6, 18, 11, 7, 48, 484, DateTimeKind.Local).AddTicks(9375), "Lafayette.Hilll@gmail.com", 11.714700000000001, -138.32400000000001, "International Configuration Strategist", "(331) 324-5668", "24940" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "76746 Elvera Ways", "Rashadfort", new DateTime(2022, 10, 30, 11, 57, 37, 660, DateTimeKind.Local).AddTicks(207), "Daryl44@gmail.com", 60.231400000000001, -82.7864, "Forward Directives Specialist", "350.957.6673 x79991", "54754" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "471 Deckow Junctions", "Shanelletown", new DateTime(2023, 2, 14, 4, 15, 50, 292, DateTimeKind.Local).AddTicks(603), "Andreanne25@hotmail.com", 82.485600000000005, -67.108199999999997, "Investor Operations Technician", "(496) 439-1998", "00879-1492" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "910 Kailey Islands", "Hillsberg", new DateTime(2023, 5, 23, 4, 0, 6, 85, DateTimeKind.Local).AddTicks(253), "Linda.Rice@yahoo.com", 61.142400000000002, 12.273, "National Data Analyst", "1-316-663-4172", "46271-2547" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 27, 1, 54, 15, 707, DateTimeKind.Local).AddTicks(9213), "Smart" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 14, 9, 47, 49, 906, DateTimeKind.Local).AddTicks(5632), "Mercedes Benz" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 8, 50, 12, 355, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 14, 3, 10, 26, 922, DateTimeKind.Local).AddTicks(2142), "Jaguar" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 13, 7, 15, 43, 701, DateTimeKind.Local).AddTicks(970), "BMW" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 17, 3, 4, 15, 704, DateTimeKind.Local).AddTicks(3951), "Cadillac" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 12, 20, 17, 34, 579, DateTimeKind.Local).AddTicks(9090), "Maserati" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 2, 25, 21, 18, 38, 651, DateTimeKind.Local).AddTicks(2028), "Honda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 13, 15, 12, 6, 446, DateTimeKind.Local).AddTicks(430), "Rolls Royce" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 1, 6, 25, 26, 350, DateTimeKind.Local).AddTicks(7322), "Mini" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque" },
                values: new object[] { new DateTime(2022, 10, 23, 15, 6, 46, 117, DateTimeKind.Local).AddTicks(3087), 5 });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 9, 1, 22, 0, 20, 679, DateTimeKind.Local).AddTicks(4515), 7, "Malibu" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 11, 26, 7, 1, 16, 373, DateTimeKind.Local).AddTicks(8949), 5, "Camry" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 6, 10, 5, 4, 31, 858, DateTimeKind.Local).AddTicks(4132), 6, "Sentra" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 16, 10, 995, DateTimeKind.Local).AddTicks(1515), 4, "Impala" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 8, 25, 3, 43, 55, 108, DateTimeKind.Local).AddTicks(3446), 2, "Escalade" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 21, 10, 37, 23, 919, DateTimeKind.Local).AddTicks(6138), "CTS" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 44, 41, 319, DateTimeKind.Local).AddTicks(2400), "Mustang" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 12, 24, 20, 36, 52, 183, DateTimeKind.Local).AddTicks(7856), 6, "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque" },
                values: new object[] { new DateTime(2022, 10, 17, 16, 43, 9, 0, DateTimeKind.Local).AddTicks(9221), 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 15, 17, 52, 2, 738, DateTimeKind.Local).AddTicks(6342), "Mellie7@yahoo.com", "Amara", 4, 2, false, "Kuhic", "$2a$11$gDZsrLc/ZtDdKjw9/5QMte1qvkcLts58pEuX1f/LQ3dOZNTx.2Evq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 12, 20, 28, 21, 849, DateTimeKind.Local).AddTicks(1607), "Braeden.Christiansen2@gmail.com", "Tia", 7, 4, "Nicolas", "$2a$11$ZFwlfL9i9WSVzKo8felosuRe4Xew5VRGFPPT0j2WcduduNU5G/za6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 7, 13, 9, 14, 58, 129, DateTimeKind.Local).AddTicks(639), "Robert.Herman86@gmail.com", "Felipa", 2, 4, false, "Barton", "$2a$11$OeiEf/KCZspNqYHufJaMM.6wEZmYXp01MUbhP6E3s/iuGXsMEW3IK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 10, 13, 31, 322, DateTimeKind.Local).AddTicks(6957), "Vaughn.Hickle42@gmail.com", "Wilton", 7, 2, true, "Ebert", "$2a$11$92VKUg/ZyaENaimHgdaZV.nljdkEZPhVZoo7yPJqIOE2w9Oj.gOKK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 6, 19, 16, 50, 627, DateTimeKind.Local).AddTicks(4863), "Damaris_Okuneva24@hotmail.com", "Bulah", 1, 2, true, "Nikolaus", "$2a$11$4GNfRbzJxDglVp65N55bXOXSRvpwFqzZD1SOq/tFQPBF6JOx02uyi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 30, 9, 42, 36, 62, DateTimeKind.Local).AddTicks(3661), "Maud98@gmail.com", "Reggie", 1, 3, "Bernier", "$2a$11$RiOuHpuJe2zQWbJo362l7u6Wde99A4b1FLq/4NeunUpE0hxBxrMLe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 11, 10, 56, 29, 846, DateTimeKind.Local).AddTicks(3244), "Candida7@hotmail.com", "Abraham", 6, 3, "Grimes", "$2a$11$G7Czq4kwpDltjUhrftuRmO.0dEHVTiL2MIIszooCuBckWmD5vyle6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 10, 17, 2, 59, 418, DateTimeKind.Local).AddTicks(7006), "Kaley.Hammes@gmail.com", "Neva", 1, "Kohler", "$2a$11$WsZxji2hPwsOeDd9w4Ki8e9qnS4115L7I7pVnfH/wPpUO0XZ0jazu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 6, 11, 23, 27, 432, DateTimeKind.Local).AddTicks(9850), "Sandy78@gmail.com", "Waylon", 10, false, "Torp", "$2a$11$iz0aWWo6z0CGMhXOZuuiUeXsVAAqFYEW5zM1Ykir89PpDMf1nTNCu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 3, 17, 51, 22, 593, DateTimeKind.Local).AddTicks(7214), "Freda_Predovic43@gmail.com", "Chaim", 1, 2, "Turcotte", "$2a$11$GclBZmm2N8QgR0d993mI1uMVbgGhddiSfu7cdeJDQGsa0bD2MZVfu" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "42357 Adams Way", "Chelseafort", new DateTime(2022, 9, 25, 1, 19, 23, 680, DateTimeKind.Local).AddTicks(6227), "Georgianna.Wisoky6@gmail.com", -41.988599999999998, -27.675000000000001, "Principal Group Assistant", "314-819-6083", "84552" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "9640 Trantow Meadow", "Konopelskifurt", new DateTime(2022, 8, 13, 8, 47, 54, 724, DateTimeKind.Local).AddTicks(8293), "Tianna86@hotmail.com", -54.637700000000002, 64.6203, "Forward Factors Strategist", "1-738-284-9963 x5442", "74382" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3564 Chester Plain", "East Albertfurt", new DateTime(2023, 3, 18, 18, 4, 12, 5, DateTimeKind.Local).AddTicks(9139), "Bertrand.Gutmann63@hotmail.com", 77.494900000000001, -19.206199999999999, "International Creative Specialist", "(545) 898-7688", "73125" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "28597 Turcotte Fall", "New Braxtonport", new DateTime(2023, 4, 16, 3, 53, 19, 976, DateTimeKind.Local).AddTicks(2191), "Ramona.Pacocha@gmail.com", 88.236400000000003, -156.1352, "Chief Identity Assistant", "(927) 527-3006", "50730-9532" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "80098 Olson Village", "Port Sheridanbury", new DateTime(2022, 8, 31, 1, 22, 28, 65, DateTimeKind.Local).AddTicks(5047), "Adelbert_Gerlach66@hotmail.com", 77.659099999999995, -34.9773, "Regional Data Analyst", "355.453.7251", "48280-9645" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1024 Vandervort Union", "East Hudson", new DateTime(2023, 4, 17, 9, 6, 12, 291, DateTimeKind.Local).AddTicks(6323), "Ignacio1@hotmail.com", -8.6000999999999994, -155.7364, "Internal Accounts Strategist", "730-460-6455", "80626-5256" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "24076 Wilderman Mission", "Rosenbaummouth", new DateTime(2023, 1, 3, 18, 51, 56, 722, DateTimeKind.Local).AddTicks(2245), "Lenore20@gmail.com", -37.361499999999999, -148.0334, "Internal Data Developer", "1-221-997-6310 x3215", "38389-6916" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "582 Schumm Flat", "Hackettburgh", new DateTime(2023, 5, 29, 1, 15, 0, 976, DateTimeKind.Local).AddTicks(5533), "Colleen_McClure47@yahoo.com", -89.906099999999995, -10.010899999999999, "Central Brand Orchestrator", "(481) 636-0398 x9194", "72350" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "166 Fausto Via", "Port Horacestad", new DateTime(2022, 9, 8, 15, 19, 25, 134, DateTimeKind.Local).AddTicks(3806), "Crawford38@yahoo.com", 54.662300000000002, -57.753500000000003, "Senior Brand Supervisor", "454-325-1666 x0253", "97108" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "889 Afton Ways", "South Aryanna", new DateTime(2022, 7, 11, 20, 54, 24, 361, DateTimeKind.Local).AddTicks(6700), "Cleve.Fay@yahoo.com", 54.5471, 90.205100000000002, "Principal Optimization Consultant", "(316) 964-7358 x1228", "98453-3417" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 1, 15, 56, 29, 139, DateTimeKind.Local).AddTicks(2967), "Honda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 17, 12, 45, 56, 861, DateTimeKind.Local).AddTicks(4707), "Dodge" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 6, 15, 0, 17, 20, 932, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 19, 17, 28, 0, 42, DateTimeKind.Local).AddTicks(3467), "Mercedes Benz" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 14, 11, 38, 56, 902, DateTimeKind.Local).AddTicks(6594), "Mazda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 23, 3, 0, 51, 370, DateTimeKind.Local).AddTicks(6959), "Volvo" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 23, 22, 36, 55, 965, DateTimeKind.Local).AddTicks(4061), "Dodge" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 50, 28, 78, DateTimeKind.Local).AddTicks(606), "Smart" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 19, 6, 44, 41, 2, DateTimeKind.Local).AddTicks(9135), "Lamborghini" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 21, 3, 59, 47, 541, DateTimeKind.Local).AddTicks(1803), "Ford" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque" },
                values: new object[] { new DateTime(2022, 12, 9, 1, 48, 21, 374, DateTimeKind.Local).AddTicks(4461), 3 });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 4, 25, 15, 53, 50, 75, DateTimeKind.Local).AddTicks(2200), 10, "CTS" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 2, 22, 9, 35, 43, 565, DateTimeKind.Local).AddTicks(528), 9, "Beetle" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 1, 25, 22, 36, 33, 233, DateTimeKind.Local).AddTicks(8708), 9, "Element" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 1, 23, 2, 27, 47, 180, DateTimeKind.Local).AddTicks(5589), 3, "Civic" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 6, 1, 15, 47, 19, 256, DateTimeKind.Local).AddTicks(2390), 3, "Focus" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 2, 5, 8, 42, 21, 648, DateTimeKind.Local).AddTicks(3186), "A4" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 5, 10, 14, 50, 495, DateTimeKind.Local).AddTicks(3637), "Spyder" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 6, 20, 14, 35, 31, 72, DateTimeKind.Local).AddTicks(6777), 2, "CX-9" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque" },
                values: new object[] { new DateTime(2023, 2, 15, 22, 18, 59, 332, DateTimeKind.Local).AddTicks(5806), 9 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 29, 10, 56, 34, 585, DateTimeKind.Local).AddTicks(1686), "Nash_Kling52@hotmail.com", "Chaz", 9, 1, true, "Feest", "$2a$11$Fy1TVJB.BGkjRN1GWPsaX.9BqhfQT5Q53K0iQYOHRKbo1yR9h450m" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 14, 17, 10, 25, 267, DateTimeKind.Local).AddTicks(490), "Casper.Will@yahoo.com", "Jeffrey", 8, 2, "Schuster", "$2a$11$g6Gmc6TZ2Y1LMVhrYeJ4QeqJ92xwSGaLPLgU.tlTgxSRY76e4MZoi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 2, 33, 16, 913, DateTimeKind.Local).AddTicks(4135), "Oswald_Treutel65@hotmail.com", "Marilou", 9, 1, true, "Nader", "$2a$11$S.oUOLowbRREDmP4q9Q0O.xoCjjXtf2I5YbeWfA3d/zY6TOSNPesu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 17, 22, 5, 52, 145, DateTimeKind.Local).AddTicks(5260), "Verner_Murazik56@hotmail.com", "Richmond", 1, 3, false, "Bogisich", "$2a$11$mnWr6CeoJNsljdWn2sbb0.XtJ2SrF278YGOzwgLUhwI0yjpNXx4zi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 3, 18, 23, 8, 158, DateTimeKind.Local).AddTicks(3083), "Milton.Bradtke2@yahoo.com", "Dayna", 9, 1, false, "Quigley", "$2a$11$EoCqGAlFig90z.oUsy4X9eeFL6g.zZmIQs0Rnn/mbfZr0gnWTaVhW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 21, 3, 40, 53, 55, DateTimeKind.Local).AddTicks(5560), "Annetta_Donnelly@hotmail.com", "Isabell", 5, 2, "Hegmann", "$2a$11$OSNDtsB.2fxzm.B0MkafWuyKchIk2dD7QEHlliQB1HMn0pBz99Pfy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 19, 7, 57, 40, 374, DateTimeKind.Local).AddTicks(8950), "Elna_Crist99@gmail.com", "Alva", 8, 4, "Windler", "$2a$11$elaZSQQ.LUNGI4tHITvx.usdqsoYMQ7LnOnK4YOkFB5dKV2ijIkGS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 1, 3, 3, 23, 841, DateTimeKind.Local).AddTicks(9832), "Esperanza83@yahoo.com", "Sam", 4, "Farrell", "$2a$11$hPy9t5tby2RxRLwVYR.rSuexGWqwmzllqX/B7XsotTMRwhbv8lMym" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 4, 0, 42, 47, 105, DateTimeKind.Local).AddTicks(6377), "Amir.Abernathy14@hotmail.com", "Rod", 1, true, "Krajcik", "$2a$11$t.Elvv4ANg0rSJAQ/ohGa.RwLsj8.FkwI/KbiYOoWm/1oJoSyZjNu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 23, 13, 13, 5, 419, DateTimeKind.Local).AddTicks(1999), "Crawford_Schuppe@gmail.com", "Camille", 4, 1, "Wisozk", "$2a$11$29jyucECiIFiLhcul2ycJO/WjnCwwhCS6mPHYHxijB5M2sn1nGvnu" });
        }
    }
}
