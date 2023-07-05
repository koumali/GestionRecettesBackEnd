using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Agences",
                columns: new[] { "Id", "Address", "City", "CreatedAt", "DeletedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "UpdatedAt", "ZipCode" },
                values: new object[,]
                {
                    { 1, "43678 Evert Square", "East Fatimastad", new DateTime(2022, 10, 23, 7, 14, 9, 182, DateTimeKind.Local).AddTicks(4578), null, "Trystan65@hotmail.com", -5.2603999999999997, 54.498899999999999, "Future Configuration Orchestrator", "(681) 395-1896 x79704", null, "47381-6710" },
                    { 2, "186 Jewell Ranch", "South Justuschester", new DateTime(2023, 2, 14, 11, 49, 52, 54, DateTimeKind.Local).AddTicks(9599), null, "Vallie39@gmail.com", -2.4176000000000002, -69.884200000000007, "Chief Quality Orchestrator", "1-893-761-4344 x9968", null, "16145-7143" },
                    { 3, "688 Mosciski Lock", "Kleinport", new DateTime(2023, 1, 14, 5, 5, 29, 419, DateTimeKind.Local).AddTicks(3915), null, "Ollie24@hotmail.com", -0.36959999999999998, 12.352, "Senior Optimization Planner", "755.282.9459", null, "78306-1729" },
                    { 4, "1591 Sporer Knoll", "Jermaintown", new DateTime(2023, 1, 18, 5, 29, 6, 518, DateTimeKind.Local).AddTicks(6497), null, "Zion87@gmail.com", -66.161299999999997, 16.4053, "Central Response Officer", "(248) 841-7755", null, "65224-8645" },
                    { 5, "950 Schuster Manors", "Lake Vincenzo", new DateTime(2023, 2, 24, 6, 50, 10, 387, DateTimeKind.Local).AddTicks(6154), null, "Tate_Tromp@hotmail.com", -55.594200000000001, -24.770199999999999, "Central Accountability Specialist", "1-544-599-1405 x6123", null, "24352" },
                    { 6, "989 McLaughlin Tunnel", "Arianetown", new DateTime(2022, 9, 9, 16, 5, 2, 353, DateTimeKind.Local).AddTicks(91), null, "Retha.Krajcik75@hotmail.com", -66.605699999999999, -20.457999999999998, "Internal Data Analyst", "909-313-3654 x1799", null, "97308" },
                    { 7, "88011 Collins Vista", "West Santinoberg", new DateTime(2022, 12, 25, 21, 14, 49, 508, DateTimeKind.Local).AddTicks(8241), null, "Francesco.OConnell@hotmail.com", -24.0307, 90.381500000000003, "National Configuration Coordinator", "(315) 436-8541 x9400", null, "49132" },
                    { 8, "6129 Corkery Points", "North Helen", new DateTime(2022, 12, 14, 17, 47, 21, 473, DateTimeKind.Local).AddTicks(9132), null, "Stanley.Wisoky@gmail.com", -86.257199999999997, 10.185700000000001, "Product Research Orchestrator", "(864) 422-9758", null, "97637-8114" },
                    { 9, "391 Cassin Manor", "South Darron", new DateTime(2023, 3, 19, 7, 33, 6, 363, DateTimeKind.Local).AddTicks(2281), null, "Imani.Thompson8@hotmail.com", -83.481999999999999, 91.739900000000006, "District Usability Consultant", "(609) 940-4636 x6903", null, "83032-2810" },
                    { 10, "938 Lind Crest", "Lake Norene", new DateTime(2023, 4, 24, 8, 58, 22, 754, DateTimeKind.Local).AddTicks(3717), null, "Fermin.Cartwright@gmail.com", -34.8626, 119.5598, "Human Data Assistant", "(738) 322-4130 x83176", null, "79722-7331" }
                });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 22, 7, 46, 20, 417, DateTimeKind.Local).AddTicks(8521), null, "Tesla", null },
                    { 2, new DateTime(2022, 9, 7, 23, 20, 21, 999, DateTimeKind.Local).AddTicks(3518), null, "Toyota", null },
                    { 3, new DateTime(2022, 8, 23, 14, 29, 35, 511, DateTimeKind.Local).AddTicks(9111), null, "Cadillac", null },
                    { 4, new DateTime(2023, 1, 18, 22, 4, 27, 631, DateTimeKind.Local).AddTicks(3149), null, "Volvo", null },
                    { 5, new DateTime(2023, 2, 16, 9, 7, 52, 805, DateTimeKind.Local).AddTicks(9050), null, "Volkswagen", null },
                    { 6, new DateTime(2023, 4, 11, 8, 44, 35, 85, DateTimeKind.Local).AddTicks(1077), null, "BMW", null },
                    { 7, new DateTime(2023, 1, 28, 15, 58, 57, 762, DateTimeKind.Local).AddTicks(6452), null, "Audi", null },
                    { 8, new DateTime(2022, 10, 19, 19, 2, 11, 489, DateTimeKind.Local).AddTicks(6391), null, "Dodge", null },
                    { 9, new DateTime(2022, 10, 20, 18, 28, 42, 497, DateTimeKind.Local).AddTicks(5860), null, "Porsche", null },
                    { 10, new DateTime(2022, 8, 15, 19, 28, 54, 106, DateTimeKind.Local).AddTicks(4186), null, "Mercedes Benz", null }
                });

            migrationBuilder.InsertData(
                table: "Modeles",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdMarque", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 23, 20, 31, 58, 744, DateTimeKind.Local).AddTicks(2325), null, 1, "Silverado", null },
                    { 2, new DateTime(2023, 6, 25, 18, 32, 29, 262, DateTimeKind.Local).AddTicks(5344), null, 6, "Mercielago", null },
                    { 3, new DateTime(2023, 1, 19, 4, 24, 16, 761, DateTimeKind.Local).AddTicks(6133), null, 2, "Spyder", null },
                    { 4, new DateTime(2022, 9, 11, 10, 42, 32, 261, DateTimeKind.Local).AddTicks(4259), null, 1, "LeBaron", null },
                    { 5, new DateTime(2023, 2, 3, 17, 15, 12, 507, DateTimeKind.Local).AddTicks(9890), null, 9, "Taurus", null },
                    { 6, new DateTime(2022, 11, 15, 21, 38, 37, 731, DateTimeKind.Local).AddTicks(7191), null, 10, "Element", null },
                    { 7, new DateTime(2022, 8, 4, 19, 20, 55, 763, DateTimeKind.Local).AddTicks(4739), null, 5, "PT Cruiser", null },
                    { 8, new DateTime(2022, 8, 9, 18, 39, 13, 533, DateTimeKind.Local).AddTicks(7312), null, 4, "PT Cruiser", null },
                    { 9, new DateTime(2022, 10, 26, 0, 45, 27, 821, DateTimeKind.Local).AddTicks(8609), null, 9, "Countach", null },
                    { 10, new DateTime(2023, 4, 27, 10, 44, 46, 955, DateTimeKind.Local).AddTicks(6637), null, 1, "Corvette", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 29, 8, 38, 29, 728, DateTimeKind.Local).AddTicks(8782), null, "Orpha82@yahoo.com", "Jasmin", 6, 3, true, "Johnston", "$2a$11$NlWHXDWE/haYGwFj5V65XerctPkZlvvF62hRCSpNAvZH1UqZ9fW3e", null },
                    { 2, new DateTime(2022, 7, 21, 2, 52, 12, 766, DateTimeKind.Local).AddTicks(6179), null, "Forest99@hotmail.com", "Dannie", 8, 1, false, "Daugherty", "$2a$11$XLl5z3vSL3UewoX6Ifqb4OZcAYeJC9Xtz2p.Klg4RFPVWZl0vXoLa", null },
                    { 3, new DateTime(2023, 3, 18, 13, 31, 16, 312, DateTimeKind.Local).AddTicks(7606), null, "Rozella18@yahoo.com", "Cooper", 6, 2, false, "Harvey", "$2a$11$0X6FXH0ne5xeN6LRDZrHvOmn.04DqGYsNVTAjjhZP.OBrdh6bv292", null },
                    { 4, new DateTime(2023, 1, 31, 7, 25, 32, 241, DateTimeKind.Local).AddTicks(6826), null, "Diamond60@gmail.com", "Angelita", 10, 3, true, "Hills", "$2a$11$TG34oTlbQxRPiYaARmj3hO5Ewal.lhlresXLtGtkAKL0PziYoqkoG", null },
                    { 5, new DateTime(2022, 12, 16, 4, 44, 41, 999, DateTimeKind.Local).AddTicks(3588), null, "Rosemary70@yahoo.com", "Hermann", 8, 4, true, "Simonis", "$2a$11$s4nEI80ALYpD3tu02c7VWeQbntEAmAkYLSIxWXppDg4IU7tR1O5zq", null },
                    { 6, new DateTime(2023, 1, 2, 9, 15, 32, 83, DateTimeKind.Local).AddTicks(3358), null, "Louie40@gmail.com", "Aurelie", 10, 2, false, "White", "$2a$11$REDMdHGx./7ukXavujk4keyQJK3VrfSBaQ1Ii4Wto4ho8mV7I3kbG", null },
                    { 7, new DateTime(2023, 1, 3, 4, 46, 29, 774, DateTimeKind.Local).AddTicks(7582), null, "Kendall_Jacobs19@hotmail.com", "Alexandrea", 8, 3, false, "Legros", "$2a$11$q1VEY4mbt.H7NKPYCXKtKOGNsksqhbrFTcsiBqp8zQi1LNBAdSevy", null },
                    { 8, new DateTime(2022, 7, 11, 19, 20, 43, 140, DateTimeKind.Local).AddTicks(5107), null, "Oran.Considine93@yahoo.com", "Esta", 3, 2, false, "Armstrong", "$2a$11$n4IDwaLvu3R8ZsBj/2IHBO1ijFgYgErEHkBkrdAQwZujJrP7KNH.y", null },
                    { 9, new DateTime(2023, 1, 10, 14, 30, 50, 959, DateTimeKind.Local).AddTicks(6243), null, "Carolanne_Larson37@hotmail.com", "Rudolph", 9, 3, false, "Johnston", "$2a$11$8Cdn66AnxFjowppgaUN7eOFgu.U8pmtL/pmX7NkA9B6RCg/3F/6/K", null },
                    { 10, new DateTime(2023, 3, 6, 5, 48, 16, 435, DateTimeKind.Local).AddTicks(2631), null, "Brenda_Spinka@hotmail.com", "Vern", 10, 4, true, "Fahey", "$2a$11$uCYkCy8xZds35rbbrma6dubsdaOK82w5RpfduRRwPp2tejapDEBGG", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
