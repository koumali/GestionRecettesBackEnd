using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class add_some_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "424 Bella Forge", "Laylahaven", new DateTime(2022, 9, 4, 23, 18, 20, 701, DateTimeKind.Local).AddTicks(5844), "Frida_Lakin89@hotmail.com", 20.971, 1.3127, "Forward Markets Representative", "(404) 365-8103 x921", "21755-3963" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "638 Gottlieb Flats", "Daronview", new DateTime(2023, 4, 24, 3, 39, 17, 905, DateTimeKind.Local).AddTicks(3587), "Queenie_Batz@gmail.com", -27.850200000000001, -32.797800000000002, "Global Quality Coordinator", "1-303-996-9627 x13295", "85756" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0349 Kellie Street", "East Caroleborough", new DateTime(2023, 3, 13, 23, 40, 3, 591, DateTimeKind.Local).AddTicks(8927), "Dion.Funk@gmail.com", -39.069299999999998, -9.8082999999999991, "Future Identity Technician", "(512) 596-4376", "72478" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "41617 Lind Camp", "North Robynton", new DateTime(2022, 12, 3, 11, 44, 2, 439, DateTimeKind.Local).AddTicks(8541), "Jake_Stoltenberg39@hotmail.com", -87.442499999999995, 55.696899999999999, "Future Branding Supervisor", "1-784-443-6104 x1817", "98674" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0509 Will Shoals", "O'Connellside", new DateTime(2023, 5, 1, 19, 13, 42, 299, DateTimeKind.Local).AddTicks(6212), "Crawford99@gmail.com", -60.0946, 149.62379999999999, "Product Intranet Specialist", "218-770-0477", "75727" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3120 Lowe Islands", "Bechtelarshire", new DateTime(2022, 9, 10, 11, 30, 49, 559, DateTimeKind.Local).AddTicks(301), "Aditya91@yahoo.com", -66.672499999999999, 102.36450000000001, "Senior Markets Architect", "(405) 779-0200 x9743", "92703-8603" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "7220 Louie View", "Onieville", new DateTime(2022, 8, 2, 1, 57, 33, 871, DateTimeKind.Local).AddTicks(760), "Caleb23@hotmail.com", -71.110500000000002, 143.1935, "Customer Usability Liaison", "1-455-406-4591 x27097", "27587" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "18382 Rosenbaum Port", "North Zulamouth", new DateTime(2023, 5, 19, 9, 20, 3, 545, DateTimeKind.Local).AddTicks(6263), "Pearl99@hotmail.com", -84.276899999999998, -172.9864, "Future Accountability Facilitator", "506-802-7433 x14963", "07542" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "458 Nicolas Road", "West Cristopherhaven", new DateTime(2022, 7, 25, 3, 36, 0, 397, DateTimeKind.Local).AddTicks(5571), "Ned10@gmail.com", -14.058, -19.055099999999999, "Internal Tactics Producer", "706.708.2382", "50574-3191" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4472 Timothy Inlet", "South Eltaview", new DateTime(2023, 5, 18, 15, 24, 53, 835, DateTimeKind.Local).AddTicks(9170), "Skyla_Russel@yahoo.com", 60.646700000000003, -117.53400000000001, "Chief Group Agent", "1-539-358-3123 x00260", "64122" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "AgencyFourthLevelPermission" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 29, 6, 36, 12, 181, DateTimeKind.Local).AddTicks(4376), "Stephany_Marquardt96@yahoo.com", "Milford", 10, "Senger", "$2a$11$ml3TAbgsRp2Q6ZPjd21Ft.TrnMyEaQOOxtV7T/xD4fcKYavTp97R." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 8, 3, 9, 54, 518, DateTimeKind.Local).AddTicks(3772), "Austin_Schmeler58@gmail.com", "Mark", 8, 3, "Beer", "$2a$11$iFTM90MWZtTMrmS6SSrSNOHSIOkDLxUGLKU3QX5jvQSzol9eRlqVS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 20, 9, 39, 19, 0, DateTimeKind.Local).AddTicks(3054), "Kamryn78@yahoo.com", "Pasquale", 3, true, "Ebert", "$2a$11$kVQz.JIZYHbqBsOym8vEz.6LO8VfzVl.IXH6G.CjQvsTMoQCg5qmK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 11, 6, 38, 36, 274, DateTimeKind.Local).AddTicks(5470), "Francesca.Cormier0@gmail.com", "Catalina", 5, 2, "O'Reilly", "$2a$11$C42fdddildPq7TedQbeWBuSxdCPSmUnrny0FoD9XTUaAbJPPwN0he" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 30, 1, 4, 46, 679, DateTimeKind.Local).AddTicks(6310), "Felipa_Lind48@yahoo.com", "Marshall", 10, 2, "Emmerich", "$2a$11$HxO3SHAicfvSGw9pieJh0.Vb4o0BLnsDZ8p7F8eSI.0pGaE49jcym" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 3, 1, 42, 41, 117, DateTimeKind.Local).AddTicks(6611), "Princess_McKenzie74@gmail.com", "Steve", 4, "Renner", "$2a$11$Skl4Qnz6QeUPrEOIGpUFCOoPjVFEdtBq.OqKu6hkbqT53ptG7LTE2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 22, 23, 31, 11, 438, DateTimeKind.Local).AddTicks(551), "Preston45@hotmail.com", "Lizzie", 7, 1, false, "Bergnaum", "$2a$11$aB6qf3rilIOh.SrFkAnbA.lzwPAMji52edn08xzfiBNsZ9sdLHY7q" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 4, 23, 55, 44, 180, DateTimeKind.Local).AddTicks(2546), "Malcolm60@yahoo.com", "Queenie", 6, 1, "Mohr", "$2a$11$z8EO409X8JMLMnhnNO8PiOGWxlPnrXhIgTSYlUS90QMGCVCuYL5sO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 16, 3, 0, 46, 400, DateTimeKind.Local).AddTicks(7489), "Mandy80@yahoo.com", "Cameron", 8, 4, "Botsford", "$2a$11$6eAOc7m1IB4zKLUAW2CSPumbaC/73mY4t0bhd6Sv2Dpgk4EzOHh7y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 8, 12, 44, 45, 670, DateTimeKind.Local).AddTicks(4125), "Johann49@yahoo.com", "Frederic", 2, false, "Bernier", "$2a$11$n5DKTMtCasQ1kM5rx1BNFuujnMBoI5I3DVa2Qwpi3lakn.d.8nkFO" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 8, 2, 6, 42, 50, 462, DateTimeKind.Local).AddTicks(6052), "Gerlach", "Jayda78@gmail.com", "Jakubowski - Ortiz", "Rod", "1-726-730-7674 x75075", "Rice", "New Hayleyland", "34250" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 8, 7, 20, 23, 26, 980, DateTimeKind.Local).AddTicks(4598), "Klein", "Casimir_Schoen@yahoo.com", "Graham - Paucek", "Kailee", "(896) 619-9909 x267", "Abbott", "North Zaria", "97255-5537" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 21, 7, 51, 53, 909, DateTimeKind.Local).AddTicks(5428), "Bahringer", "Madisyn.Volkman@hotmail.com", "Williamson LLC", "Margaretta", "285-676-5787 x38611", "Klein", "Lake Darius", "66066-7947" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 16, 19, 12, 20, 640, DateTimeKind.Local).AddTicks(699), "Bradtke", "Jamey84@yahoo.com", "Block - Wisozk", "Oran", "457-284-1405", "Mohr", "West Dellburgh", "57936-3030" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 14, 14, 8, 8, 127, DateTimeKind.Local).AddTicks(5960), "Windler", "Elyse_Bailey@gmail.com", "Jakubowski, VonRueden and Nicolas", "Yasmine", "1-708-506-9081 x07820", "Denesik", "Terrellfurt", "10913" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 13, 12, 18, 33, 565, DateTimeKind.Local).AddTicks(678), "Bauch", "Phoebe_Gusikowski@yahoo.com", "Metz and Sons", "Horace", "(691) 599-5028", "Bayer", "North Zelmachester", "18010" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 8, 15, 23, 56, 45, 958, DateTimeKind.Local).AddTicks(3315), "Beahan", "Elda_Little@gmail.com", "Price Group", "Eliezer", "(381) 787-7415 x14543", "Kulas", "Thompsonchester", "17574-7562" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 3, 22, 46, 44, 258, DateTimeKind.Local).AddTicks(6982), "Ullrich", "Eleanora.Reilly63@yahoo.com", "Mertz, Gislason and Dietrich", "Jayne", "887.282.9377 x09184", "Reichel", "Rippinbury", "90196" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 10, 2, 48, 58, 907, DateTimeKind.Local).AddTicks(5046), "Spinka", "Kiel.Green@yahoo.com", "Greenholt - Witting", "Mandy", "(309) 734-3511", "Towne", "Port Hallie", "02127-7912" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 8, 27, 3, 56, 59, 463, DateTimeKind.Local).AddTicks(524), "McLaughlin", "Lisa27@hotmail.com", "Kulas, Miller and Welch", "Daphne", "(744) 670-2731", "Toy", "Paulinestad", "55544-2800" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "37479 Aleen Mission", "Rennerville", new DateTime(2023, 7, 15, 17, 30, 55, 553, DateTimeKind.Local).AddTicks(6195), "Aurelia33@yahoo.com", 26.6965, -91.185599999999994, "Central Factors Director", "967-758-8571 x625", "88172" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "06444 Champlin River", "North Ava", new DateTime(2022, 9, 8, 11, 12, 55, 360, DateTimeKind.Local).AddTicks(9817), "Moriah_Rowe10@hotmail.com", -29.777000000000001, 95.994799999999998, "Future Data Developer", "1-760-975-2445", "79476" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "249 Gleason Burg", "South Garnettchester", new DateTime(2023, 4, 3, 5, 12, 12, 682, DateTimeKind.Local).AddTicks(3643), "Edythe.Kirlin@yahoo.com", 32.485199999999999, 154.036, "Future Brand Analyst", "1-539-823-4665 x92270", "18055" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "074 Shanie Mission", "Gayburgh", new DateTime(2023, 7, 7, 2, 51, 18, 894, DateTimeKind.Local).AddTicks(2097), "Jesus_Kshlerin76@yahoo.com", -84.794600000000003, -47.960099999999997, "Lead Intranet Architect", "524.785.5526 x623", "49726" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "25833 White Radial", "South Edmondmouth", new DateTime(2023, 4, 15, 9, 14, 15, 903, DateTimeKind.Local).AddTicks(2754), "Keira.Greenfelder93@hotmail.com", 12.786099999999999, 50.371499999999997, "District Branding Executive", "(708) 538-1768 x98827", "50006" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "642 Weber Parkway", "Webertown", new DateTime(2023, 4, 13, 8, 24, 45, 746, DateTimeKind.Local).AddTicks(7236), "Elyssa_Jacobson@hotmail.com", 2.8231000000000002, -83.285700000000006, "International Intranet Planner", "449-649-6353 x175", "39851-6106" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "310 Skyla Locks", "North Darlenefurt", new DateTime(2023, 1, 30, 23, 29, 6, 402, DateTimeKind.Local).AddTicks(9915), "Maximillian3@hotmail.com", -88.369399999999999, 89.458500000000001, "Global Integration Technician", "(817) 359-2619 x6299", "09604-1086" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "309 Dibbert Street", "New Nannie", new DateTime(2022, 9, 10, 7, 2, 45, 42, DateTimeKind.Local).AddTicks(994), "Winfield5@yahoo.com", -19.883600000000001, 108.08750000000001, "Regional Mobility Liaison", "1-418-897-4009 x9876", "49950" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "99963 Goyette Gardens", "Raheemton", new DateTime(2023, 3, 29, 16, 33, 20, 37, DateTimeKind.Local).AddTicks(6969), "Rodrick.Kerluke24@yahoo.com", 30.129200000000001, -73.728399999999993, "Central Solutions Coordinator", "(564) 971-2252 x3952", "68629" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "853 Steuber Corner", "Dickimouth", new DateTime(2022, 10, 3, 16, 26, 41, 717, DateTimeKind.Local).AddTicks(6177), "Rogers.Williamson@hotmail.com", -0.027699999999999999, 39.350299999999997, "Legacy Assurance Manager", "1-250-668-4349 x4605", "86460" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 3, 3, 31, 44, 790, DateTimeKind.Local).AddTicks(7244), "Isabel_Turner@hotmail.com", "Lavina", 3, "Graham", "$2a$11$/ImrfWKdOaqxGBrzoYLMh.YyteIX6QhPVxAeqr5kSukjiSuy.3LUS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 31, 3, 4, 11, 382, DateTimeKind.Local).AddTicks(8952), "Manuela26@hotmail.com", "Santina", 10, 2, "Haag", "$2a$11$9ChLIN7faOWsGsGNeJmM4.e/Wb9/Jk70zym6ZbrceSns6Ved7.hS." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 12, 8, 18, 7, 443, DateTimeKind.Local).AddTicks(6663), "Geo62@gmail.com", "Oswald", 9, false, "Wisoky", "$2a$11$QW1S6hTRvUuM9pX8aDz4s.k8AE1FTgCZBbOYf8YafOyoq2WBVgAwG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 13, 6, 56, 18, 262, DateTimeKind.Local).AddTicks(9736), "Modesto.Jast@gmail.com", "Stephany", 4, 3, "Franecki", "$2a$11$eMcpy9nW4dke8bZ4v7Ain.mlLOPBRnk.NNJSHbE10S5EJEAC2iAvK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 6, 12, 48, 10, 199, DateTimeKind.Local).AddTicks(8296), "Demario_Rempel@yahoo.com", "Antoinette", 4, 3, "Sipes", "$2a$11$DW1nusNT0kjCdsE4j5Nw6OB9L6pzQ.f0d3rW2r./imjqiB8muk7qe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 27, 4, 26, 59, 242, DateTimeKind.Local).AddTicks(3382), "Wendell.Funk33@yahoo.com", "Barrett", 6, "Runte", "$2a$11$qhzhrAh8v7aJPTvivhH7Qe3A2alZ7JuFz9mSYzZ2nRC4c2v7Sv9iS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 24, 16, 41, 1, 530, DateTimeKind.Local).AddTicks(981), "Jamey.Willms14@gmail.com", "Emil", 9, 3, true, "Oberbrunner", "$2a$11$2dC4judp56VS6AUnHpPKHuXuW0T4dBZ/UGxhPXOch5QervUkFfqIa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 21, 21, 43, 13, 802, DateTimeKind.Local).AddTicks(4494), "Oswaldo_MacGyver@yahoo.com", "Sammy", 4, 2, "Sauer", "$2a$11$QI5wz/TEs.ETFfS3mDzgHO1935DDDsDmcUkKXy3kWZJnMXR7LSM1q" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 5, 1, 52, 48, 559, DateTimeKind.Local).AddTicks(2830), "Kenyatta.Frami84@hotmail.com", "Ally", 9, 1, "Bernier", "$2a$11$k4TSzdGWf/VC3tU0QUnf6ua5JGid4eX6PoR839KP2M.My0CWxxSdi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 31, 14, 17, 59, 778, DateTimeKind.Local).AddTicks(138), "Simeon77@gmail.com", "Reilly", 10, true, "Willms", "$2a$11$hFMmU6QAThj7Po6Ca2bQK.Ox/NX/VP1zSJTrwMqRbCvy0rPpFijTy" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 27, 11, 20, 13, 192, DateTimeKind.Local).AddTicks(3396), "Harvey", "Rasheed74@hotmail.com", "Johnston, Aufderhar and Mohr", "Sandra", "(346) 239-5857 x602", "Schumm", "Lake Daryl", "93172" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 22, 14, 49, 25, 692, DateTimeKind.Local).AddTicks(2582), "Ledner", "Raul.Heaney85@hotmail.com", "Mante and Sons", "Kaley", "(891) 510-4679", "Gulgowski", "Allanstad", "15634-6251" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 30, 4, 14, 25, 161, DateTimeKind.Local).AddTicks(6036), "Hodkiewicz", "Caroline_Brown30@gmail.com", "Grimes, Lindgren and Monahan", "Pearl", "825-811-2455 x93825", "Prohaska", "West Estafort", "90428" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 27, 4, 39, 10, 60, DateTimeKind.Local).AddTicks(3719), "Bode", "Riley.Fisher25@hotmail.com", "Conn, Hickle and Kemmer", "Mateo", "550-364-5829", "Roberts", "South Linaport", "26328-6877" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 29, 14, 30, 32, 65, DateTimeKind.Local).AddTicks(7522), "Hoppe", "Jayden_Dach29@yahoo.com", "Schmeler Group", "Jaydon", "(768) 967-2897 x7460", "Hilll", "Lake Natalieland", "45615" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 15, 2, 22, 52, 344, DateTimeKind.Local).AddTicks(5666), "Carroll", "Scottie.Jacobson@hotmail.com", "Goyette LLC", "Chad", "1-944-555-3750 x69232", "Schmeler", "Jessestad", "16262" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 12, 5, 25, 53, 956, DateTimeKind.Local).AddTicks(9964), "Kiehn", "Birdie.Hamill68@yahoo.com", "Littel and Sons", "Katrine", "853.959.9028", "Rath", "Port Era", "09852" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 9, 13, 15, 23, 952, DateTimeKind.Local).AddTicks(4700), "Jast", "Nicole48@gmail.com", "Ledner, Stehr and Lebsack", "Sheldon", "(436) 527-0982 x707", "Kerluke", "South Bobbieside", "45897" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 8, 22, 21, 23, 934, DateTimeKind.Local).AddTicks(985), "Lowe", "Abbey44@gmail.com", "Littel - Hartmann", "Clyde", "(918) 539-3169 x1207", "Beer", "West Ervinside", "12057-0547" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 1, 18, 50, 12, 112, DateTimeKind.Local).AddTicks(8132), "Cormier", "Lilyan_Zboncak@hotmail.com", "Lowe - Pouros", "Letitia", "552.385.1863", "Mayert", "East Terrill", "35316-3546" });
        }
    }
}
