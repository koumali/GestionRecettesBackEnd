using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class add_join_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PermissionRole",
                columns: table => new
                {
                    PermissionsId = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionRole", x => new { x.PermissionsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_PermissionRole_Permissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissionRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

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

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "PlatformTopLevelPermission" },
                    { 2, "AgencyFirstLevelPermission" },
                    { 3, "AgencySecondLevelPermission" },
                    { 4, "AgencyThirdLevelPermission" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 3, 3, 31, 44, 790, DateTimeKind.Local).AddTicks(7244), "Isabel_Turner@hotmail.com", "Lavina", 2, "Graham", "$2a$11$/ImrfWKdOaqxGBrzoYLMh.YyteIX6QhPVxAeqr5kSukjiSuy.3LUS" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 12, 8, 18, 7, 443, DateTimeKind.Local).AddTicks(6663), "Geo62@gmail.com", "Oswald", 9, 4, false, "Wisoky", "$2a$11$QW1S6hTRvUuM9pX8aDz4s.k8AE1FTgCZBbOYf8YafOyoq2WBVgAwG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 13, 6, 56, 18, 262, DateTimeKind.Local).AddTicks(9736), "Modesto.Jast@gmail.com", "Stephany", 4, "Franecki", "$2a$11$eMcpy9nW4dke8bZ4v7Ain.mlLOPBRnk.NNJSHbE10S5EJEAC2iAvK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 6, 12, 48, 10, 199, DateTimeKind.Local).AddTicks(8296), "Demario_Rempel@yahoo.com", "Antoinette", 4, true, "Sipes", "$2a$11$DW1nusNT0kjCdsE4j5Nw6OB9L6pzQ.f0d3rW2r./imjqiB8muk7qe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 27, 4, 26, 59, 242, DateTimeKind.Local).AddTicks(3382), "Wendell.Funk33@yahoo.com", "Barrett", 6, true, "Runte", "$2a$11$qhzhrAh8v7aJPTvivhH7Qe3A2alZ7JuFz9mSYzZ2nRC4c2v7Sv9iS" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 5, 1, 52, 48, 559, DateTimeKind.Local).AddTicks(2830), "Kenyatta.Frami84@hotmail.com", "Ally", 9, "Bernier", "$2a$11$k4TSzdGWf/VC3tU0QUnf6ua5JGid4eX6PoR839KP2M.My0CWxxSdi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 31, 14, 17, 59, 778, DateTimeKind.Local).AddTicks(138), "Simeon77@gmail.com", "Reilly", 10, 4, "Willms", "$2a$11$hFMmU6QAThj7Po6Ca2bQK.Ox/NX/VP1zSJTrwMqRbCvy0rPpFijTy" });

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

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRole_RolesId",
                table: "PermissionRole",
                column: "RolesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermissionRole");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "7082 Tyshawn Village", "Lynchhaven", new DateTime(2023, 1, 29, 15, 7, 15, 935, DateTimeKind.Local).AddTicks(3813), "Jay21@gmail.com", 39.089599999999997, -17.216899999999999, "Dynamic Brand Liaison", "1-670-473-1536", "41390" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "416 Mariano Streets", "Denesikport", new DateTime(2023, 7, 6, 2, 32, 35, 694, DateTimeKind.Local).AddTicks(650), "Lafayette39@hotmail.com", -41.639099999999999, 144.57589999999999, "Legacy Quality Strategist", "440.346.3530", "74811-7796" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "50495 Herzog Ports", "Port Prince", new DateTime(2022, 12, 6, 0, 27, 1, 73, DateTimeKind.Local).AddTicks(230), "Hugh76@hotmail.com", -28.9011, -58.121600000000001, "National Operations Architect", "375-992-8117", "74813" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "34880 Jonas Viaduct", "North Tre", new DateTime(2023, 3, 8, 8, 15, 36, 677, DateTimeKind.Local).AddTicks(5336), "Otha.Lubowitz9@hotmail.com", 68.265900000000002, 78.034899999999993, "Product Assurance Associate", "427-463-5827 x5862", "50161" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "926 Sheila Skyway", "New Walterland", new DateTime(2022, 10, 18, 8, 50, 20, 642, DateTimeKind.Local).AddTicks(8665), "Mauricio84@hotmail.com", -84.6935, 175.94540000000001, "International Configuration Officer", "(959) 238-9060 x016", "08945" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "068 Eden Point", "East Armandobury", new DateTime(2022, 9, 12, 3, 50, 39, 945, DateTimeKind.Local).AddTicks(3129), "Berneice.Cole11@yahoo.com", -38.082799999999999, 22.272600000000001, "Dynamic Communications Agent", "1-590-523-3108", "30166" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "74501 O'Conner Spring", "New Carrollville", new DateTime(2023, 3, 8, 16, 59, 20, 141, DateTimeKind.Local).AddTicks(4372), "Aliyah10@gmail.com", -42.827199999999998, 13.028700000000001, "Investor Marketing Technician", "345-735-5581 x7197", "11678" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2351 Guillermo Springs", "Vandervortburgh", new DateTime(2023, 6, 17, 20, 31, 16, 604, DateTimeKind.Local).AddTicks(2731), "Velma67@gmail.com", 15.434699999999999, 110.461, "Internal Implementation Assistant", "587-939-2455", "14590" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3547 Keanu Flats", "Macejkovicborough", new DateTime(2022, 10, 18, 8, 27, 5, 659, DateTimeKind.Local).AddTicks(927), "Jaleel.Berge@gmail.com", -20.495999999999999, -25.457899999999999, "Dynamic Accountability Coordinator", "1-976-815-2122 x085", "91748" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "95305 Monte Flat", "Lexifort", new DateTime(2022, 9, 25, 20, 6, 15, 161, DateTimeKind.Local).AddTicks(3598), "Christian_Donnelly24@gmail.com", -42.770099999999999, -62.4925, "Direct Accounts Specialist", "1-393-591-1010 x3797", "23629-9703" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 17, 12, 49, 9, 836, DateTimeKind.Local).AddTicks(1940), "Gudrun_Hudson@yahoo.com", "Alejandra", 3, "Durgan", "$2a$11$cM5lG1wMQNxGLA6KiFKo..1zCruIedH1Y6eWTDslnBMIwOXZ70A3K" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 9, 13, 44, 59, 337, DateTimeKind.Local).AddTicks(8003), "Ona.Kerluke@gmail.com", "Florida", 2, 3, "Bosco", "$2a$11$l0.JMlnuQlc2jgFQmMjqJuMPFRzQ8Z1NVuxc64cXluUC54qWtgHR." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 25, 3, 34, 20, 133, DateTimeKind.Local).AddTicks(9649), "Deontae.Wyman59@yahoo.com", "Ruth", 2, 3, true, "Reinger", "$2a$11$IzTifLaA3J2mGK6fdjqjrOjZc/P2x/WipWcE4EYj1UdVMqsYeZFKa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 19, 19, 49, 27, 852, DateTimeKind.Local).AddTicks(3533), "Kristina.Williamson63@gmail.com", "Jordan", 7, "Wunsch", "$2a$11$mSW1tZROULX3hE.paVZJKOTMZlBJOQ7HBP7YAftcF1lMSYDgJg1I6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 19, 21, 14, 38, 190, DateTimeKind.Local).AddTicks(2656), "Johnnie.Nitzsche@hotmail.com", "Ofelia", 7, false, "Goldner", "$2a$11$2iCe.tKiI1y5Hoh59Zb8rOdXM1eKRwp/9aIzG773DoFsWRFvOAziK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 23, 22, 10, 22, 798, DateTimeKind.Local).AddTicks(2597), "Ibrahim87@yahoo.com", "Adeline", 3, false, "Rath", "$2a$11$WboPpah2GsyccIosq2jfxOyo9t1ZWgudP6SHmBwBj7gDnGBfcSOLK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 1, 5, 35, 38, 335, DateTimeKind.Local).AddTicks(1630), "Annetta80@yahoo.com", "Emelie", 7, 4, false, "Mueller", "$2a$11$OUoAQoZH7Kn0BLBREF2j7OIBUWqcGzFggYplVGa.n/P7oN7ZlczJG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 30, 11, 59, 40, 189, DateTimeKind.Local).AddTicks(5261), "Kiera57@hotmail.com", "Christop", 10, 4, "Sanford", "$2a$11$FnfrvT.MIM8Q07YMfzSN/ubQxDEXs55p.nunIHVChAXXErffZ8FNy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 16, 10, 33, 6, 146, DateTimeKind.Local).AddTicks(6201), "Ally30@yahoo.com", "Elisabeth", 6, "Heller", "$2a$11$Ob7VpbFsMhKyGECJajAb9uhe38JlZAEMKxuD5.tm228cK0zvyzJWK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 15, 8, 46, 0, 493, DateTimeKind.Local).AddTicks(312), "Alvera22@hotmail.com", "Reese", 9, 1, "Bechtelar", "$2a$11$K2VLXQ5ipEDNs9Pbx9ebTOQ/.86hSDdcHzG/YWmJtEOUihkGn5sbe" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 12, 13, 2, 36, 116, DateTimeKind.Local).AddTicks(9455), "Wintheiser", "Yoshiko_Mueller@hotmail.com", "Fisher, Bogan and Dicki", "Christelle", "230-622-6594 x25585", "Grimes", "Forestview", "73101" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 6, 3, 26, 41, 639, DateTimeKind.Local).AddTicks(215), "Morar", "Angeline.Keebler@hotmail.com", "Wisoky, Bashirian and Wilkinson", "Yesenia", "1-463-211-2143 x515", "Champlin", "Hellentown", "42954" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 14, 19, 6, 2, 777, DateTimeKind.Local).AddTicks(9264), "Stroman", "Talon_Doyle@gmail.com", "Koss - Walter", "Bradly", "(468) 868-4250 x925", "Windler", "North Alfreda", "97378-1413" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 9, 3, 30, 8, 380, DateTimeKind.Local).AddTicks(3445), "Schinner", "Juvenal_Kshlerin99@gmail.com", "Jast Inc", "Euna", "(503) 404-6540 x888", "Schultz", "Port Dorthafort", "28059-8144" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 14, 1, 35, 16, 282, DateTimeKind.Local).AddTicks(7463), "O'Connell", "Nicholas.Pacocha79@hotmail.com", "Parker LLC", "Mohamed", "801-238-8419 x56428", "Hagenes", "Kassulkeberg", "73306" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 22, 11, 33, 20, 412, DateTimeKind.Local).AddTicks(6999), "Farrell", "Anibal47@yahoo.com", "Towne - Rau", "Lula", "1-388-786-0140", "Heller", "Nonaberg", "36387-1515" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 11, 4, 51, 20, 338, DateTimeKind.Local).AddTicks(1334), "VonRueden", "Gisselle_Veum28@gmail.com", "Oberbrunner LLC", "Aubree", "232.981.9325", "Swift", "Loweshire", "98372" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 9, 1, 17, 48, 311, DateTimeKind.Local).AddTicks(3124), "Smitham", "Dell_Waelchi95@gmail.com", "Ward Inc", "Rosina", "396.479.3204 x5033", "Hilll", "Erinfort", "84495" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 10, 8, 42, 33, 127, DateTimeKind.Local).AddTicks(2302), "Marvin", "Jarrell31@yahoo.com", "Stark, Fahey and Carter", "Ned", "1-477-700-2894", "Beahan", "Emelieview", "16077" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 31, 9, 33, 38, 617, DateTimeKind.Local).AddTicks(9409), "Wolff", "Bernard_MacGyver31@hotmail.com", "Walter, Beatty and Konopelski", "Peter", "1-272-470-8425 x199", "Pfeffer", "New Ramirohaven", "13983" });
        }
    }
}
