using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class addIsVerifiedToAgence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Agences",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "34212 Alba Pine", "Smithamborough", new DateTime(2023, 1, 12, 16, 26, 58, 992, DateTimeKind.Local).AddTicks(9493), "Izabella13@hotmail.com", false, -80.509200000000007, 145.8767, "Regional Accounts Administrator", "1-921-466-0912", "45560" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "9129 Lamont Mountains", "Gislasonburgh", new DateTime(2023, 3, 23, 3, 5, 37, 263, DateTimeKind.Local).AddTicks(6759), "Theodora.Hand@yahoo.com", false, -48.445900000000002, 170.64750000000001, "Investor Functionality Consultant", "(713) 946-5557", "21990-4466" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "68653 Waelchi Vista", "West Groverhaven", new DateTime(2023, 1, 25, 8, 46, 49, 704, DateTimeKind.Local).AddTicks(1984), "Darron38@gmail.com", false, 51.888100000000001, -44.440399999999997, "Dynamic Intranet Specialist", "201.529.2034 x31694", "72317" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "326 Lesch Street", "Alberthashire", new DateTime(2022, 9, 1, 1, 26, 4, 790, DateTimeKind.Local).AddTicks(1880), "Ola_Ferry1@gmail.com", false, -56.504600000000003, 48.0396, "International Interactions Consultant", "1-780-429-7890", "32755-9853" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "99540 Mellie Motorway", "Sandrafurt", new DateTime(2023, 6, 12, 20, 25, 14, 550, DateTimeKind.Local).AddTicks(156), "Sid25@yahoo.com", false, 30.244399999999999, -140.99459999999999, "Forward Directives Associate", "(547) 823-2940", "24892-5671" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "8965 Helga Road", "Emardmouth", new DateTime(2022, 12, 2, 16, 43, 41, 211, DateTimeKind.Local).AddTicks(9066), "Vinnie.Kris70@hotmail.com", false, -19.171700000000001, -26.8064, "Principal Marketing Orchestrator", "699.870.0596 x80361", "83163" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "592 Carmelo Prairie", "Prohaskaport", new DateTime(2023, 4, 14, 22, 1, 49, 166, DateTimeKind.Local).AddTicks(7235), "Murl.Strosin@yahoo.com", false, 89.850300000000004, 26.8841, "Future Usability Specialist", "428.205.1293", "97458" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "549 Reichel Hollow", "New Jasmintown", new DateTime(2023, 6, 5, 14, 9, 12, 767, DateTimeKind.Local).AddTicks(3559), "Kiana39@hotmail.com", false, -47.155999999999999, -88.463999999999999, "Investor Assurance Orchestrator", "884-809-8261 x1741", "23713-6545" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "800 Walter Meadows", "South Kurtchester", new DateTime(2023, 7, 1, 12, 23, 44, 946, DateTimeKind.Local).AddTicks(2814), "Gina7@gmail.com", false, 21.319099999999999, -163.34299999999999, "Customer Data Liaison", "429-236-7004", "54120" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "06088 Bayer Divide", "East Ashleigh", new DateTime(2022, 8, 5, 14, 2, 52, 910, DateTimeKind.Local).AddTicks(1555), "Santina_Mante@yahoo.com", false, -69.301100000000005, 158.88249999999999, "Direct Branding Technician", "1-739-497-7236", "25209-7048" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 19, 17, 46, 34, 564, DateTimeKind.Local).AddTicks(1119), "Volkswagen" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 2, 22, 7, 21, 37, 144, DateTimeKind.Local).AddTicks(1237), "Volvo" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 20, 22, 13, 34, 550, DateTimeKind.Local).AddTicks(8247), "Kia" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 21, 7, 3, 15, 685, DateTimeKind.Local).AddTicks(3920), "Chrysler" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 13, 4, 55, 58, 522, DateTimeKind.Local).AddTicks(5215), "Rolls Royce" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 22, 7, 51, 32, 720, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 13, 9, 56, 4, 139, DateTimeKind.Local).AddTicks(7335), "Dodge" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 14, 3, 55, 20, 368, DateTimeKind.Local).AddTicks(1215), "Cadillac" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 8, 23, 50, 9, 190, DateTimeKind.Local).AddTicks(9942), "Jeep" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 8, 18, 6, 33, 981, DateTimeKind.Local).AddTicks(1456), "Ferrari" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 55, 34, 848, DateTimeKind.Local).AddTicks(194), 9, "Silverado" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 3, 22, 14, 52, 13, 941, DateTimeKind.Local).AddTicks(8187), 5, "Alpine" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 9, 26, 10, 8, 36, 949, DateTimeKind.Local).AddTicks(88), 9, "XC90" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 11, 1, 2, 32, 6, 665, DateTimeKind.Local).AddTicks(3324), 8, "PT Cruiser" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 3, 29, 2, 59, 13, 269, DateTimeKind.Local).AddTicks(7029), 7, "Golf" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 7, 21, 22, 15, 23, 436, DateTimeKind.Local).AddTicks(4052), 5, "A8" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 4, 27, 16, 49, 51, 451, DateTimeKind.Local).AddTicks(2581), 5, "Camry" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 9, 20, 6, 50, 59, 31, DateTimeKind.Local).AddTicks(6583), 8, "Volt" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 4, 25, 22, 53, 47, 148, DateTimeKind.Local).AddTicks(4103), 10, "Jetta" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 12, 25, 13, 56, 49, 981, DateTimeKind.Local).AddTicks(4364), 4, "Civic" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 42, 51, 295, DateTimeKind.Local).AddTicks(8370), "Donato95@hotmail.com", "Lenore", 5, 3, "Botsford", "$2a$11$ng4PeuJBmGJSWvMj/Cz1zO34bKr8hg5y42F.Vz.u12Wv0/Rh0Zz6a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 29, 9, 30, 34, 437, DateTimeKind.Local).AddTicks(7895), "Gunner_Metz80@gmail.com", "Bulah", 4, 2, true, "Hettinger", "$2a$11$YPG9aY1zeb8EBRO8cdrXpOkz0vAFdAXO1r25Gpwqiyt69t3HI2Sei" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 6, 5, 53, 41, 903, DateTimeKind.Local).AddTicks(3863), "Rosalyn.Kshlerin39@yahoo.com", "Felicia", 8, 3, "Leuschke", "$2a$11$GRABlhLlhOe7R3eMkRsy8uUZftShvSzHo/7e9fJS6g/pteMXN7UZi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 30, 7, 14, 48, 900, DateTimeKind.Local).AddTicks(8714), "Floy73@gmail.com", "Lela", 6, false, "Rodriguez", "$2a$11$YSzmyzAvdk.lBbgge4804uW7q.ESSEA.kgoRFIqX/rvK7ecvkfn4W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 27, 8, 59, 16, 980, DateTimeKind.Local).AddTicks(1273), "Jon82@hotmail.com", "Adan", 9, 3, false, "Mills", "$2a$11$uzam0so6zElurmS26Rls5uYQAy1FjHtb4U4R3v1.jlzHyfeqGP.vi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 5, 0, 0, 44, 118, DateTimeKind.Local).AddTicks(7580), "Coy99@gmail.com", "Ryann", 8, 4, true, "Bosco", "$2a$11$oT/Vc.1BCOU69qQ0P.VP3ON6.v0p3C1WAuArw0lz/8SzIDhRkwGV6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 23, 16, 2, 23, 243, DateTimeKind.Local).AddTicks(1897), "Jodie.Steuber@hotmail.com", "Beaulah", 2, 2, "Stracke", "$2a$11$yxEKlBkLCmqqeKNAUekKpuQBs0XCijEyQmbqXGPJ/v/vK5otY6It." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 10, 18, 45, 24, 489, DateTimeKind.Local).AddTicks(4327), "Corbin.Yundt@hotmail.com", "Eddie", 2, 4, "Cremin", "$2a$11$HO9Vu820q4sJDZ9J8T8zJOQKgh5vhVoPbqBVf.fnFkl6g2R0NrVoW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 15, 14, 25, 33, 310, DateTimeKind.Local).AddTicks(5669), "Lew.Ritchie38@yahoo.com", "Ethel", 1, 1, true, "Hills", "$2a$11$nLmmSv3QW5OePA4kRzD27eG3B8Y6tsW5kCv54ZnIyOY/YXqJjetMS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 30, 12, 28, 58, 809, DateTimeKind.Local).AddTicks(477), "Gertrude_Leffler@yahoo.com", "Rachel", 9, 4, "Jenkins", "$2a$11$nDM7ud/hfeRM.3L7IY/guejoHvqdp/pqXU7E5hfdWuLjheqLj/Vw2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Agences");

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
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 50, 12, 355, DateTimeKind.Local).AddTicks(7503), "Cadillac" });

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
                column: "CreatedAt",
                value: new DateTime(2023, 6, 17, 3, 4, 15, 704, DateTimeKind.Local).AddTicks(3951));

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
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 10, 23, 15, 6, 46, 117, DateTimeKind.Local).AddTicks(3087), 5, "CTS" });

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
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 5, 21, 10, 37, 23, 919, DateTimeKind.Local).AddTicks(6138), 4, "CTS" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 10, 18, 22, 44, 41, 319, DateTimeKind.Local).AddTicks(2400), 1, "Mustang" });

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
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 10, 17, 16, 43, 9, 0, DateTimeKind.Local).AddTicks(9221), 3, "Aventador" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 15, 17, 52, 2, 738, DateTimeKind.Local).AddTicks(6342), "Mellie7@yahoo.com", "Amara", 4, 2, "Kuhic", "$2a$11$gDZsrLc/ZtDdKjw9/5QMte1qvkcLts58pEuX1f/LQ3dOZNTx.2Evq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 12, 20, 28, 21, 849, DateTimeKind.Local).AddTicks(1607), "Braeden.Christiansen2@gmail.com", "Tia", 7, 4, false, "Nicolas", "$2a$11$ZFwlfL9i9WSVzKo8felosuRe4Xew5VRGFPPT0j2WcduduNU5G/za6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 7, 13, 9, 14, 58, 129, DateTimeKind.Local).AddTicks(639), "Robert.Herman86@gmail.com", "Felipa", 2, 4, "Barton", "$2a$11$OeiEf/KCZspNqYHufJaMM.6wEZmYXp01MUbhP6E3s/iuGXsMEW3IK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 10, 13, 31, 322, DateTimeKind.Local).AddTicks(6957), "Vaughn.Hickle42@gmail.com", "Wilton", 7, true, "Ebert", "$2a$11$92VKUg/ZyaENaimHgdaZV.nljdkEZPhVZoo7yPJqIOE2w9Oj.gOKK" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 30, 9, 42, 36, 62, DateTimeKind.Local).AddTicks(3661), "Maud98@gmail.com", "Reggie", 1, 3, false, "Bernier", "$2a$11$RiOuHpuJe2zQWbJo362l7u6Wde99A4b1FLq/4NeunUpE0hxBxrMLe" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 10, 17, 2, 59, 418, DateTimeKind.Local).AddTicks(7006), "Kaley.Hammes@gmail.com", "Neva", 10, 1, "Kohler", "$2a$11$WsZxji2hPwsOeDd9w4Ki8e9qnS4115L7I7pVnfH/wPpUO0XZ0jazu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 6, 11, 23, 27, 432, DateTimeKind.Local).AddTicks(9850), "Sandy78@gmail.com", "Waylon", 10, 4, false, "Torp", "$2a$11$iz0aWWo6z0CGMhXOZuuiUeXsVAAqFYEW5zM1Ykir89PpDMf1nTNCu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 3, 17, 51, 22, 593, DateTimeKind.Local).AddTicks(7214), "Freda_Predovic43@gmail.com", "Chaim", 1, 2, "Turcotte", "$2a$11$GclBZmm2N8QgR0d993mI1uMVbgGhddiSfu7cdeJDQGsa0bD2MZVfu" });
        }
    }
}
