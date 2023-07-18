using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class nullable_fields_in_client_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ville",
                table: "Clients",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "12855 Luettgen Dale", "Framiton", new DateTime(2023, 5, 9, 12, 6, 41, 881, DateTimeKind.Local).AddTicks(8863), "Constantin51@hotmail.com", -63.026000000000003, -98.079999999999998, "Product Paradigm Coordinator", "(500) 492-3254 x57721", "08439-7035" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "5530 Cruickshank Junction", "New Ferne", new DateTime(2022, 12, 8, 11, 34, 31, 294, DateTimeKind.Local).AddTicks(6410), "Monica.Schultz@hotmail.com", 39.442700000000002, 172.20849999999999, "Human Division Facilitator", "929.302.4523", "41435-7075" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "70017 Douglas Overpass", "New Rosemarie", new DateTime(2022, 9, 20, 1, 11, 14, 728, DateTimeKind.Local).AddTicks(9849), "Jaquan_Armstrong@gmail.com", -10.6967, -51.061700000000002, "Future Accounts Planner", "418.928.4944 x0996", "90700" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2113 Bode Fields", "East Vanceburgh", new DateTime(2022, 8, 31, 12, 5, 48, 138, DateTimeKind.Local).AddTicks(5334), "German.Botsford@hotmail.com", 29.382899999999999, 52.145099999999999, "Dynamic Branding Representative", "(482) 477-5858 x54941", "01374-6576" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "50492 Danika Extensions", "Alphonsoland", new DateTime(2023, 6, 11, 22, 47, 54, 375, DateTimeKind.Local).AddTicks(6996), "Rosanna_Schumm@yahoo.com", -7.7531999999999996, -87.170199999999994, "Dynamic Creative Administrator", "1-659-810-0574 x779", "67463" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "5000 Braun Knoll", "Hillsstad", new DateTime(2022, 8, 15, 14, 45, 8, 323, DateTimeKind.Local).AddTicks(6635), "Keyon.Adams@yahoo.com", -17.693999999999999, -55.4895, "Lead Assurance Planner", "1-771-982-5682 x87346", "45311-3880" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "14487 Claud Creek", "South Modesta", new DateTime(2023, 7, 15, 23, 58, 30, 171, DateTimeKind.Local).AddTicks(5707), "Norwood_Romaguera@yahoo.com", 26.931100000000001, -153.86330000000001, "Corporate Interactions Planner", "500.771.3607", "66306-1149" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "02710 Stokes Streets", "West Savanahhaven", new DateTime(2023, 1, 11, 20, 30, 46, 28, DateTimeKind.Local).AddTicks(8420), "Edmond.Powlowski@yahoo.com", -85.633300000000006, 104.7063, "National Accounts Representative", "1-747-834-6922 x115", "31207-8724" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "55728 Mertz Summit", "West Selinachester", new DateTime(2022, 12, 7, 8, 58, 35, 890, DateTimeKind.Local).AddTicks(6994), "Jennyfer41@hotmail.com", 41.514699999999998, 70.996099999999998, "Customer Implementation Associate", "809-869-5319 x53906", "67862-3184" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "74331 Howell Overpass", "Lake Lyric", new DateTime(2023, 6, 26, 3, 51, 13, 375, DateTimeKind.Local).AddTicks(6895), "Lenora.Lueilwitz@hotmail.com", 22.179300000000001, -86.148099999999999, "Direct Group Planner", "962.673.4676 x4055", "92492" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 18, 30, 33, 60, DateTimeKind.Local).AddTicks(4170), "Chrysler" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 20, 8, 11, 36, 554, DateTimeKind.Local).AddTicks(5102), "Mazda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 29, 50, 376, DateTimeKind.Local).AddTicks(9425), "Bugatti" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 15, 11, 17, 36, 983, DateTimeKind.Local).AddTicks(2883), "Nissan" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 27, 16, 30, 40, 545, DateTimeKind.Local).AddTicks(2029), "Mazda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 23, 2, 40, 49, 407, DateTimeKind.Local).AddTicks(9220), "Hyundai" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 8, 18, 23, 51, 573, DateTimeKind.Local).AddTicks(9848), "Nissan" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 10, 4, 34, 7, 325, DateTimeKind.Local).AddTicks(3278), "Fiat" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 7, 20, 5, 59, 658, DateTimeKind.Local).AddTicks(3932), "Chevrolet" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 14, 2, 2, 27, 764, DateTimeKind.Local).AddTicks(6448), "Kia" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 5, 6, 7, 0, 42, 31, DateTimeKind.Local).AddTicks(2870), 2, "https://picsum.photos/640/480/?image=406", "Spyder" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 8, 12, 0, 28, 2, 753, DateTimeKind.Local).AddTicks(3423), 3, "https://picsum.photos/640/480/?image=236", "Taurus" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 11, 27, 0, 43, 28, 437, DateTimeKind.Local).AddTicks(5594), 3, "https://picsum.photos/640/480/?image=548", "Expedition" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 9, 13, 23, 13, 10, 630, DateTimeKind.Local).AddTicks(3225), 6, "https://picsum.photos/640/480/?image=802", "Wrangler" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 12, 25, 11, 53, 1, 449, DateTimeKind.Local).AddTicks(8036), 7, "https://picsum.photos/640/480/?image=730", "Camaro" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 20, 10, 52, 27, 56, DateTimeKind.Local).AddTicks(4412), 6, "https://picsum.photos/640/480/?image=113", "Land Cruiser" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 18, 11, 19, 6, 856, DateTimeKind.Local).AddTicks(8969), 5, "https://picsum.photos/640/480/?image=779", "Model T" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 7, 30, 11, 20, 15, 927, DateTimeKind.Local).AddTicks(3564), 9, "https://picsum.photos/640/480/?image=616", "Cruze" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 21, 22, 0, 698, DateTimeKind.Local).AddTicks(509), 2, "https://picsum.photos/640/480/?image=1069", "Challenger" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 4, 12, 3, 59, 5, 501, DateTimeKind.Local).AddTicks(3901), 7, "https://picsum.photos/640/480/?image=322", "Camry" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 7, 43, 22, 798, DateTimeKind.Local).AddTicks(2362), "Roderick_Fay@hotmail.com", "Dedric", 3, true, "Sauer", "$2a$11$fGgI8mkxfJSvFidbCECNiuYhe9uTwjUfFskLHv.MIvmPw8I.iQN1G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 26, 11, 15, 50, 444, DateTimeKind.Local).AddTicks(7056), "Nigel.Corwin95@gmail.com", "Geovanni", 2, 1, "Walker", "$2a$11$2589VZVFoa.FIvp8BZVL/.AEsNntNWZOkEf1HO1xfPRZG04cOP1ee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 19, 23, 33, 46, 779, DateTimeKind.Local).AddTicks(5695), "Concepcion.Orn@yahoo.com", "Nyasia", 8, true, "Robel", "$2a$11$lLRaWfTMGKHAsG/XJ5fFCesamk/4aFd.z1vREudJPK1dgOBr/IhTi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 27, 18, 14, 53, 988, DateTimeKind.Local).AddTicks(5419), "Matilde.Quitzon@hotmail.com", "Delta", 10, "Waters", "$2a$11$7XlQmVZ6pbwMpqf0G3qmZeHoBnU1sbV1Itsd.Ypk4X9qu3FGcUPpq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 12, 10, 16, 27, 86, DateTimeKind.Local).AddTicks(4790), "Clair27@gmail.com", "Nigel", 8, 2, true, "Murphy", "$2a$11$zvVTKIftIkm6SOR2vN38B.gUGOAXKWpzdSA8EOlth39qT2gXvCNZC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 24, 11, 6, 23, 616, DateTimeKind.Local).AddTicks(4277), "Ubaldo_Nienow94@gmail.com", "Carey", 3, 3, false, "Boyer", "$2a$11$9XhHqaecMRAopf6b4vLlMeKadk/uYYlOxozGosGvRCG99JFHoyXbe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 7, 23, 19, 59, 13, 765, DateTimeKind.Local).AddTicks(6340), "Gunner_Oberbrunner2@gmail.com", "Cecil", 10, 2, "Abbott", "$2a$11$wV1E00emDiowXGCaS/o.YuM9Nfns8Ey/eK0Qg5J/S13hSWRy47w86" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "Password" },
                values: new object[] { new DateTime(2023, 1, 14, 12, 56, 10, 335, DateTimeKind.Local).AddTicks(583), "Dexter13@gmail.com", "Alivia", 5, 4, true, "$2a$11$qqf4so6.01JLnqL4KrUhueZL2X3gul/rQlykbLg78bOQ0d.hwLKIK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 28, 16, 17, 49, 991, DateTimeKind.Local).AddTicks(6836), "Cara.Hammes@yahoo.com", "Nico", 4, 1, "Prosacco", "$2a$11$tLZ.XmtzsNBo1BC5woZ7GuPSbMSz2or1neubp12lvumUeH.spM0gm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 23, 3, 17, 49, 207, DateTimeKind.Local).AddTicks(8137), "Hershel10@yahoo.com", "Daisy", 2, false, "VonRueden", "$2a$11$SZy8tignHbvRZpPjUCCsTe.Ka/e.8Ztfl8PspuR5Q72lmFJVvzILm" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ville",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clients",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "19031 Cummerata Valleys", "Lukastown", new DateTime(2022, 7, 26, 3, 16, 18, 171, DateTimeKind.Local).AddTicks(5415), "Sabryna20@hotmail.com", 10.7562, 109.5213, "Product Usability Specialist", "843-473-0044 x19945", "74016-0143" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2878 Mae Field", "Nicholausport", new DateTime(2022, 12, 26, 20, 45, 40, 174, DateTimeKind.Local).AddTicks(525), "Jaydon73@hotmail.com", 86.797399999999996, -165.54679999999999, "Chief Markets Planner", "(936) 503-7392 x1715", "77564" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "841 Elwin Mountain", "Runolfsdottirburgh", new DateTime(2023, 3, 13, 11, 38, 14, 657, DateTimeKind.Local).AddTicks(9448), "Rosemary21@gmail.com", -82.856399999999994, 107.0355, "Corporate Intranet Administrator", "655-353-9966", "17068" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "91879 Christina Square", "Lake Corene", new DateTime(2023, 1, 20, 23, 49, 27, 881, DateTimeKind.Local).AddTicks(4000), "Coralie93@yahoo.com", -27.400300000000001, 74.327799999999996, "Human Communications Consultant", "941-951-5460 x477", "86148" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0713 Kihn Key", "West Jalonburgh", new DateTime(2022, 8, 17, 12, 0, 5, 945, DateTimeKind.Local).AddTicks(5926), "Maybelle.VonRueden@yahoo.com", 54.464300000000001, -62.989600000000003, "Internal Research Supervisor", "761-869-7256 x003", "80057" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "012 Pollich Isle", "Timothystad", new DateTime(2023, 5, 29, 6, 8, 28, 991, DateTimeKind.Local).AddTicks(1089), "Reyes_Balistreri0@yahoo.com", 35.712800000000001, -164.02510000000001, "Chief Program Coordinator", "(695) 969-8173 x42521", "26417" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "04641 Kuhic Cliffs", "Port Kianna", new DateTime(2022, 11, 9, 16, 22, 15, 31, DateTimeKind.Local).AddTicks(2984), "Missouri_Hand@gmail.com", -1.5061, -118.09139999999999, "Direct Research Facilitator", "(846) 222-0759", "35482-6697" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1663 Trantow Knolls", "Selinaton", new DateTime(2023, 4, 21, 16, 51, 33, 950, DateTimeKind.Local).AddTicks(3537), "Skye_Lubowitz32@gmail.com", -77.889700000000005, -131.0684, "Central Applications Representative", "309.918.8859 x40887", "25904-4808" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "60899 Nicholaus Divide", "West Magnoliaville", new DateTime(2022, 9, 8, 7, 54, 48, 169, DateTimeKind.Local).AddTicks(6706), "Herman.Sporer@hotmail.com", -60.446899999999999, 2.6415000000000002, "Regional Accounts Designer", "1-490-648-1759 x2330", "90503-1101" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "12377 Waelchi Greens", "Lake Novella", new DateTime(2023, 3, 30, 8, 0, 34, 188, DateTimeKind.Local).AddTicks(323), "Maximo49@yahoo.com", -18.476299999999998, 52.676699999999997, "Dynamic Marketing Technician", "(383) 431-9025 x5941", "07825" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 2, 26, 21, 22, 20, 444, DateTimeKind.Local).AddTicks(3338), "Dodge" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 25, 21, 5, 23, 282, DateTimeKind.Local).AddTicks(734), "Bentley" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 24, 0, 44, 57, 625, DateTimeKind.Local).AddTicks(8480), "Audi" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 31, 15, 49, 54, 711, DateTimeKind.Local).AddTicks(8875), "Land Rover" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 18, 19, 13, 40, 79, DateTimeKind.Local).AddTicks(4488), "Porsche" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 23, 11, 48, 22, 887, DateTimeKind.Local).AddTicks(6668), "Jaguar" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 18, 16, 12, 38, 741, DateTimeKind.Local).AddTicks(5959), "Ferrari" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 10, 19, 2, 50, 931, DateTimeKind.Local).AddTicks(8279), "Ferrari" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 2, 14, 23, 2, 452, DateTimeKind.Local).AddTicks(1316), "Mini" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 8, 20, 2, 23, 42, DateTimeKind.Local).AddTicks(5630), "Polestar" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 7, 20, 6, 39, 32, 245, DateTimeKind.Local).AddTicks(400), 4, "https://picsum.photos/640/480/?image=1057", "Corvette" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 5, 1, 7, 25, 26, 842, DateTimeKind.Local).AddTicks(5958), 5, "https://picsum.photos/640/480/?image=451", "Grand Cherokee" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 16, 23, 55, 43, 438, DateTimeKind.Local).AddTicks(8346), 2, "https://picsum.photos/640/480/?image=995", "Colorado" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 6, 19, 7, 0, 8, 903, DateTimeKind.Local).AddTicks(8425), 8, "https://picsum.photos/640/480/?image=903", "Cruze" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 3, 8, 6, 43, 14, 588, DateTimeKind.Local).AddTicks(2080), 3, "https://picsum.photos/640/480/?image=1022", "CX-9" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 1, 19, 2, 26, 57, 442, DateTimeKind.Local).AddTicks(8903), 3, "https://picsum.photos/640/480/?image=749", "CX-9" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 1, 17, 10, 58, 52, 88, DateTimeKind.Local).AddTicks(7171), 6, "https://picsum.photos/640/480/?image=885", "PT Cruiser" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 8, 20, 5, 19, 44, 902, DateTimeKind.Local).AddTicks(4038), 2, "https://picsum.photos/640/480/?image=330", "Land Cruiser" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 9, 17, 11, 14, 23, 252, DateTimeKind.Local).AddTicks(5801), 8, "https://picsum.photos/640/480/?image=346", "Prius" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 11, 28, 1, 14, 37, 796, DateTimeKind.Local).AddTicks(2580), 8, "https://picsum.photos/640/480/?image=123", "Corvette" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 12, 2, 58, 41, 836, DateTimeKind.Local).AddTicks(4151), "Antwan72@gmail.com", "Connor", 9, false, "Dickinson", "$2a$11$GTnLbxsi1JfNnIZVmhV7F.cvnC9FCaWcYyE8/7vhfxzfsy8EW.JJm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 12, 13, 18, 12, 423, DateTimeKind.Local).AddTicks(3915), "Jamil43@gmail.com", "Bernardo", 7, 2, "Hartmann", "$2a$11$uwG4172EoyN/1jfr0W5Q1OMUbXvCTB2pwDaNyvLm6g7..DcmoBtja" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 27, 16, 32, 31, 619, DateTimeKind.Local).AddTicks(4060), "Kip.Johns60@hotmail.com", "Sonny", 7, false, "Tremblay", "$2a$11$kEJSvadXHaex2JS9f3KUl.7rd8pGDU2Xlb.YYy.ZItYdUYmRON46G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 10, 5, 45, 35, 289, DateTimeKind.Local).AddTicks(3431), "Haylie.Padberg75@gmail.com", "Jerrold", 2, "Green", "$2a$11$vmTlYYuxRPvR7iF5D/WBKOwRIgJv3UsLrJel4U6539RPs20i90wEW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 21, 9, 53, 43, 735, DateTimeKind.Local).AddTicks(4108), "Annabel_Schneider59@yahoo.com", "Scottie", 7, 4, false, "Conn", "$2a$11$KR3DDNOZ6DRwEYiTAQS8uOaIms4RaACuq5otlCJbmP6Fk/x3xHPWi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 2, 11, 28, 24, 654, DateTimeKind.Local).AddTicks(7279), "Kenneth.Collier@gmail.com", "Carolyn", 10, 1, true, "Kautzer", "$2a$11$euG3h/gbDHhn5N.W7KOoUOzFB2uRI1DAszOtktbfuz9py30caul7i" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 11, 12, 5, 8, 363, DateTimeKind.Local).AddTicks(8547), "Branson_Windler44@gmail.com", "Carter", 2, 4, "Swift", "$2a$11$H3AQqG.nJitsVmvlN2tIUegdIlvZ22Pyiy2KFGfd0ZFsjGgk9STAq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "Password" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 22, 9, 666, DateTimeKind.Local).AddTicks(3944), "Jackeline95@hotmail.com", "Bobbie", 2, 3, false, "$2a$11$KqyXpTIUL6v2fZL/H.CV8.VbRqVItpb7wkEx0y3TjkrABHidzrKcO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 28, 16, 36, 21, 36, DateTimeKind.Local).AddTicks(7396), "Emil.Altenwerth57@gmail.com", "Ophelia", 1, 2, "Reichert", "$2a$11$ETq5EE2erlyzsdILQUs79.fRcT7TiaQB36TchPtmqAmWi8byS9r6G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 20, 6, 46, 5, 464, DateTimeKind.Local).AddTicks(9559), "Jaylin.Johnston51@gmail.com", "Nicolette", 4, true, "Nienow", "$2a$11$cR1av.1IRraUz5x6RqeyAOaywWCfYmQ0Ch38DhAvnXpN9VLact8Ky" });
        }
    }
}
