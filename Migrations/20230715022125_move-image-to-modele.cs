using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class moveimagetomodele : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Vehicules");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Modeles",
                type: "longtext",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "713 Lebsack Light", "Kossville", new DateTime(2022, 11, 17, 11, 13, 54, 655, DateTimeKind.Local).AddTicks(5454), "Saige.Mann72@gmail.com", -77.758899999999997, -6.0167999999999999, "Dynamic Program Orchestrator", "615-661-3614 x493", "73045-7927" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "9919 Bogan Canyon", "Rodrigoshire", new DateTime(2023, 2, 15, 14, 15, 44, 615, DateTimeKind.Local).AddTicks(7552), "Julio.Sawayn90@yahoo.com", -80.090299999999999, 177.0333, "Global Optimization Architect", "(685) 395-3096 x824", "85119-1965" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "04552 Effertz Freeway", "East Jodyfort", new DateTime(2023, 6, 11, 16, 17, 0, 722, DateTimeKind.Local).AddTicks(2539), "Kenneth78@gmail.com", 82.679100000000005, 62.373399999999997, "Regional Intranet Supervisor", "913.730.1971", "66470" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "827 Hagenes Springs", "Oliverburgh", new DateTime(2022, 11, 20, 20, 29, 10, 380, DateTimeKind.Local).AddTicks(4466), "Lamar.Wolf45@gmail.com", -16.675000000000001, -138.3075, "Future Infrastructure Strategist", "937-656-9277 x27590", "74615-6893" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "04205 Al Skyway", "Garrickburgh", new DateTime(2023, 2, 28, 14, 32, 19, 371, DateTimeKind.Local).AddTicks(6888), "Dameon_Johnson55@yahoo.com", -29.692499999999999, -105.6514, "National Accountability Engineer", "(265) 222-9365", "81857-8563" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "7348 Brielle Rue", "Wilfredhaven", new DateTime(2022, 11, 10, 14, 40, 43, 66, DateTimeKind.Local).AddTicks(2013), "Tressa33@yahoo.com", -63.084600000000002, 71.602099999999993, "Corporate Group Officer", "331-942-7477", "72892-7955" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4472 Kiehn Terrace", "Dachmouth", new DateTime(2022, 11, 17, 9, 25, 5, 446, DateTimeKind.Local).AddTicks(6427), "Trever_Steuber43@hotmail.com", -3.2469000000000001, -105.685, "Legacy Brand Executive", "830-622-3610 x579", "32278-7903" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2318 Keeling Shoal", "Gorczanyview", new DateTime(2022, 10, 27, 22, 6, 15, 243, DateTimeKind.Local).AddTicks(9971), "Percival_Ankunding@yahoo.com", 6.1052, -114.95099999999999, "Regional Applications Specialist", "1-300-577-2407", "02586-5113" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "86473 Kub Courts", "Hankland", new DateTime(2022, 7, 16, 6, 46, 29, 127, DateTimeKind.Local).AddTicks(1574), "Sabina39@yahoo.com", 19.052299999999999, -46.636400000000002, "Global Infrastructure Orchestrator", "(823) 899-6052", "74141-3349" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "225 Tromp Plain", "Alexandrinemouth", new DateTime(2022, 11, 27, 9, 58, 1, 585, DateTimeKind.Local).AddTicks(5064), "Neal.Hayes@gmail.com", -2.6968000000000001, 91.466300000000004, "National Paradigm Specialist", "(841) 266-7164", "36378-0419" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 3, 9, 22, 406, DateTimeKind.Local).AddTicks(7144), "Tesla" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 8, 3, 36, 0, 920, DateTimeKind.Local).AddTicks(8033), "Chrysler" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 6, 17, 20, 54, 110, DateTimeKind.Local).AddTicks(6165), "Dodge" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 18, 15, 32, 20, 87, DateTimeKind.Local).AddTicks(7652), "Audi" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 12, 4, 49, 31, 217, DateTimeKind.Local).AddTicks(8444), "Dodge" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 1, 4, 34, 51, 263, DateTimeKind.Local).AddTicks(921), "Nissan" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 6, 16, 3, 20, 850, DateTimeKind.Local).AddTicks(5934), "Volvo" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 23, 6, 15, 0, 587, DateTimeKind.Local).AddTicks(6771), "Volvo" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 30, 7, 54, 46, 4, DateTimeKind.Local).AddTicks(1281), "Honda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 2, 8, 41, 44, 738, DateTimeKind.Local).AddTicks(7625), "Bugatti" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 6, 14, 1, 27, 23, 99, DateTimeKind.Local).AddTicks(8050), 1, "https://picsum.photos/640/480/?image=315", "XTS" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Image", "Name" },
                values: new object[] { new DateTime(2023, 6, 13, 17, 4, 34, 548, DateTimeKind.Local).AddTicks(7973), "https://picsum.photos/640/480/?image=885", "Wrangler" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 1, 16, 18, 28, 3, 383, DateTimeKind.Local).AddTicks(6401), 3, "https://picsum.photos/640/480/?image=375", "Mustang" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 8, 28, 18, 58, 15, 654, DateTimeKind.Local).AddTicks(2360), 7, "https://picsum.photos/640/480/?image=827", "A4" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 12, 4, 18, 14, 52, 789, DateTimeKind.Local).AddTicks(7149), 3, "https://picsum.photos/640/480/?image=404", "Beetle" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 12, 1, 5, 30, 39, 855, DateTimeKind.Local).AddTicks(2310), 6, "https://picsum.photos/640/480/?image=40", "Challenger" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 3, 11, 12, 6, 14, 697, DateTimeKind.Local).AddTicks(3388), 2, "https://picsum.photos/640/480/?image=784", "Charger" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 6, 12, 33, 29, 907, DateTimeKind.Local).AddTicks(3615), 7, "https://picsum.photos/640/480/?image=360", "Camry" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Image" },
                values: new object[] { new DateTime(2022, 9, 17, 18, 22, 21, 58, DateTimeKind.Local).AddTicks(1421), 8, "https://picsum.photos/640/480/?image=62" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 12, 3, 3, 21, 55, 820, DateTimeKind.Local).AddTicks(2993), 6, "https://picsum.photos/640/480/?image=53", "CTS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 52, 18, 497, DateTimeKind.Local).AddTicks(426), "Howard.Jakubowski19@hotmail.com", "Braulio", 8, "Schulist", "$2a$11$Y9LqetpOY/9RocIs4QCutuKMpXlrI91/lyWRy6Ks.Biwf5cwCErnW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 12, 16, 46, 51, 359, DateTimeKind.Local).AddTicks(9340), "Aurelio_Cummerata@yahoo.com", "Linwood", 5, 1, "Marquardt", "$2a$11$f/RZh4xTBGMpbLsulfNuPOo9gQ0Y5fxgHfgZ1mVOawKxTV7p8ijcS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 57, 34, 935, DateTimeKind.Local).AddTicks(4669), "Lew.Rippin81@gmail.com", "Berry", 1, "Pollich", "$2a$11$mp8V/q8vuskI5MIQBqVSBu7SkaYdAox7GrnRqdOofEmbYN5EXQVj." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 25, 5, 50, 10, 252, DateTimeKind.Local).AddTicks(6927), "Rosina6@hotmail.com", "Kaycee", 4, 3, false, "Hoeger", "$2a$11$Vx7D6KuiIe2k0IKlHoSu8O5tQIA0jK6y3vdJKhDeTR.PmWosKLttK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 5, 13, 30, 19, 532, DateTimeKind.Local).AddTicks(3095), "Maximillian.Sauer@hotmail.com", "Ernest", 8, 1, "Miller", "$2a$11$4Wz73zWfCSBB7sK4TJ6/IeqSKwGi3DT1AVVWyRFTSLS4U85qAv7iq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 18, 5, 4, 30, 423, DateTimeKind.Local).AddTicks(734), "Manuela_Leannon50@yahoo.com", "Amani", 2, 4, true, "Connelly", "$2a$11$MrPvHI0nqX3dFyVqgReOlu4AWlhKp.4A0HSbBmNxRXIlbkVkKORLW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 26, 1, 46, 48, 44, DateTimeKind.Local).AddTicks(6565), "Camryn_Osinski97@yahoo.com", "Hassan", 9, 4, false, "Rolfson", "$2a$11$l4F3pmlnSVWEXdiHon3sTORJHURHoH4PSJT6kAt85SPL6g8k8Mb16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 16, 20, 25, 26, 656, DateTimeKind.Local).AddTicks(4255), "Marie2@yahoo.com", "Chadrick", 8, false, "Goyette", "$2a$11$MNXsyNZwdWNG0d.8MQe33.Imn8wRKaQITEGau5Ylawph0wStiEn/W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 11, 10, 2, 51, 209, DateTimeKind.Local).AddTicks(7541), "Webster_Nicolas58@gmail.com", "Maxime", 2, 2, true, "Bechtelar", "$2a$11$G/MJUE5l.fRnfJ.6fQm3E.jU/YGfmVnZ76ftyLdthGsJxWfr.W9Yu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 25, 14, 114, DateTimeKind.Local).AddTicks(856), "Lynn.Wehner@gmail.com", "Iliana", 7, 4, true, "Mayer", "$2a$11$fu6BYrwg3.8c4E1DkuggauS19eFlCPL8kUCyPo7LPu7XHUL6oeWWy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Modeles");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Vehicules",
                type: "longtext",
                nullable: false);

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
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 10, 23, 15, 6, 46, 117, DateTimeKind.Local).AddTicks(3087), 5, "CTS" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 1, 22, 0, 20, 679, DateTimeKind.Local).AddTicks(4515), "Malibu" });

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
                columns: new[] { "CreatedAt", "IdMarque" },
                values: new object[] { new DateTime(2022, 12, 24, 20, 36, 52, 183, DateTimeKind.Local).AddTicks(7856), 6 });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 15, 17, 52, 2, 738, DateTimeKind.Local).AddTicks(6342), "Mellie7@yahoo.com", "Amara", 4, "Kuhic", "$2a$11$gDZsrLc/ZtDdKjw9/5QMte1qvkcLts58pEuX1f/LQ3dOZNTx.2Evq" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 7, 13, 9, 14, 58, 129, DateTimeKind.Local).AddTicks(639), "Robert.Herman86@gmail.com", "Felipa", 4, "Barton", "$2a$11$OeiEf/KCZspNqYHufJaMM.6wEZmYXp01MUbhP6E3s/iuGXsMEW3IK" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 6, 19, 16, 50, 627, DateTimeKind.Local).AddTicks(4863), "Damaris_Okuneva24@hotmail.com", "Bulah", 1, 2, "Nikolaus", "$2a$11$4GNfRbzJxDglVp65N55bXOXSRvpwFqzZD1SOq/tFQPBF6JOx02uyi" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 11, 10, 56, 29, 846, DateTimeKind.Local).AddTicks(3244), "Candida7@hotmail.com", "Abraham", 6, 3, true, "Grimes", "$2a$11$G7Czq4kwpDltjUhrftuRmO.0dEHVTiL2MIIszooCuBckWmD5vyle6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 10, 17, 2, 59, 418, DateTimeKind.Local).AddTicks(7006), "Kaley.Hammes@gmail.com", "Neva", 10, true, "Kohler", "$2a$11$WsZxji2hPwsOeDd9w4Ki8e9qnS4115L7I7pVnfH/wPpUO0XZ0jazu" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 3, 17, 51, 22, 593, DateTimeKind.Local).AddTicks(7214), "Freda_Predovic43@gmail.com", "Chaim", 1, 2, false, "Turcotte", "$2a$11$GclBZmm2N8QgR0d993mI1uMVbgGhddiSfu7cdeJDQGsa0bD2MZVfu" });
        }
    }
}
