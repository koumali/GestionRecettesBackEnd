using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class addNullabilityToAgence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Agences",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Agences",
                type: "double",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Agences",
                type: "double",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Agences",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "49527 Dach Heights", "Lake Alivia", new DateTime(2022, 9, 6, 14, 59, 33, 623, DateTimeKind.Local).AddTicks(2654), "Reva.Crona@hotmail.com", -36.463500000000003, -14.8604, "Central Accountability Consultant", "682-513-6606", "46466-0821" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "44190 Baumbach Bridge", "North Codyberg", new DateTime(2022, 12, 10, 4, 18, 4, 550, DateTimeKind.Local).AddTicks(9225), "Vincenzo13@yahoo.com", -82.143699999999995, -18.473500000000001, "Dynamic Division Specialist", "698.803.6839", "21958-7393" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "63303 Kreiger Estates", "Callieside", new DateTime(2022, 11, 23, 19, 8, 40, 567, DateTimeKind.Local).AddTicks(2024), "Marcelle70@hotmail.com", -6.5202, -81.136099999999999, "Future Integration Administrator", "892-291-1844", "94480" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "03348 Wilmer Forks", "Langview", new DateTime(2023, 4, 16, 3, 0, 0, 342, DateTimeKind.Local).AddTicks(9833), "Arlene_Schaefer0@hotmail.com", -52.659700000000001, -147.1429, "Dynamic Research Coordinator", "1-990-686-0263 x4668", "24406-6088" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "870 Sabina Courts", "Moenshire", new DateTime(2023, 2, 1, 4, 53, 9, 27, DateTimeKind.Local).AddTicks(3147), "Melyna75@yahoo.com", -55.2624, -103.18600000000001, "Internal Mobility Specialist", "(699) 949-7808 x117", "11917-2256" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "5032 Spencer Point", "South Alysaburgh", new DateTime(2022, 10, 10, 2, 52, 8, 107, DateTimeKind.Local).AddTicks(8721), "Brandyn.Luettgen73@hotmail.com", 85.012600000000006, -147.738, "Principal Directives Administrator", "(683) 675-8169 x5487", "27191-0056" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "27579 Walsh Mill", "Lake Santos", new DateTime(2023, 2, 22, 17, 44, 3, 922, DateTimeKind.Local).AddTicks(9375), "Devan54@hotmail.com", 61.027099999999997, -166.2268, "Principal Infrastructure Director", "747.674.4408 x2807", "48700-5248" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3275 Schmidt Plaza", "Erdmanhaven", new DateTime(2023, 4, 21, 15, 0, 16, 34, DateTimeKind.Local).AddTicks(1068), "Sandra.Blick19@hotmail.com", 88.787000000000006, 119.35590000000001, "Corporate Group Analyst", "933-996-8428 x80542", "60642-8105" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2828 Yvette Falls", "New Eldonville", new DateTime(2023, 3, 20, 16, 10, 5, 856, DateTimeKind.Local).AddTicks(6380), "Tanner_Kassulke@hotmail.com", -50.179000000000002, -34.701300000000003, "Future Infrastructure Designer", "778.483.5509 x0145", "16578" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "132 Lavonne Mountain", "Kossburgh", new DateTime(2023, 6, 21, 8, 18, 50, 809, DateTimeKind.Local).AddTicks(5177), "Judd.Homenick@yahoo.com", 60.574199999999998, 167.61279999999999, "Direct Quality Administrator", "585.378.7443", "95140" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 11, 11, 14, 39, 587, DateTimeKind.Local).AddTicks(2217), "Land Rover" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 24, 7, 10, 48, 834, DateTimeKind.Local).AddTicks(7035), "Chrysler" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 6, 8, 59, 7, 754, DateTimeKind.Local).AddTicks(4432), "Lamborghini" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 7, 14, 23, 52, 46, 846, DateTimeKind.Local).AddTicks(4081), "Maserati" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 13, 23, 10, 41, 538, DateTimeKind.Local).AddTicks(6252), "Chrysler" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 28, 23, 37, 39, 66, DateTimeKind.Local).AddTicks(5252), "Jeep" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 23, 35, 961, DateTimeKind.Local).AddTicks(2867), "Smart" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 3, 8, 49, 51, 638, DateTimeKind.Local).AddTicks(20), "Mazda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 12, 2, 54, 20, 2, DateTimeKind.Local).AddTicks(4142), "Kia" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 16, 20, 46, 7, 22, DateTimeKind.Local).AddTicks(8447), "Kia" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 19, 17, 35, 13, 852, DateTimeKind.Local).AddTicks(4638), "PT Cruiser" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 8, 21, 11, 9, 27, 30, DateTimeKind.Local).AddTicks(4323), 1, "1" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 7, 12, 6, 17, 3, 608, DateTimeKind.Local).AddTicks(9090), 1, "Corvette" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 3, 27, 6, 20, 4, 346, DateTimeKind.Local).AddTicks(3280), 10, "Camaro" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 8, 26, 23, 5, 19, 361, DateTimeKind.Local).AddTicks(6097), 8, "Grand Caravan" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 11, 8, 14, 35, 28, 761, DateTimeKind.Local).AddTicks(3324), 4, "Corvette" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 2, 17, 16, 8, 44, 408, DateTimeKind.Local).AddTicks(4482), 2, "Corvette" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 9, 3, 1, 45, 6, 967, DateTimeKind.Local).AddTicks(7601), 9, "Mustang" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 7, 44, 136, DateTimeKind.Local).AddTicks(2470), 1, "Focus" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 12, 29, 6, 40, 5, 710, DateTimeKind.Local).AddTicks(3722), 7, "Model T" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 17, 22, 50, 38, 950, DateTimeKind.Local).AddTicks(4188), "Nigel68@yahoo.com", "Jaron", true, "Morar", "$2a$11$c6JANRBhJXZf7RpwacBcQODj3JckGmxc/V6GAOCKgv24xYnQ09Cqy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 16, 5, 1, 41, 476, DateTimeKind.Local).AddTicks(3911), "Flavie_Leuschke16@hotmail.com", "Rosetta", 10, 4, "Bailey", "$2a$11$u7ND5Qb3BqfbghYfu35wMOjlfidodvwiKIa108ajR6LSEwNAVLCmq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 29, 16, 16, 21, 122, DateTimeKind.Local).AddTicks(3060), "Geovanny64@hotmail.com", "Brando", 5, 2, true, "Lockman", "$2a$11$owoMwCZJJQuA9VAEv799uegthUAh7QHrrbj0AykpUwWmQoWyh48Nq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 27, 4, 8, 10, 892, DateTimeKind.Local).AddTicks(5159), "Consuelo_Grady@yahoo.com", "Nya", 5, 4, "Borer", "$2a$11$A0F6yxSm426JyQg.lEDGDOB47Ki0HctGGsXpvfHb41l4JYNp5MXEe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 27, 6, 8, 5, 489, DateTimeKind.Local).AddTicks(9791), "Kayleigh.Heaney15@gmail.com", "Orpha", 10, true, "Hilpert", "$2a$11$cxies/kf4xJN67wyCCSaRuJzCSsHTdpleFP5GsE4f7M.BCsbLZsNi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 30, 12, 365, DateTimeKind.Local).AddTicks(6480), "Tristin.Schinner@yahoo.com", "Onie", 3, false, "Keeling", "$2a$11$GuINn4ucQUL6yoxsZnl8GuOR9k/u4jIpI9JL8/.I9wvxb5LcFusZq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 9, 7, 51, 18, 366, DateTimeKind.Local).AddTicks(9756), "Prudence.Von@gmail.com", "Judd", 4, 1, false, "Orn", "$2a$11$sKJ8lIo7zBgb6RDfDgvhFea/YsCyuuTjDdKvhxn1ytoXuNXzsBISW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 4, 2, 14, 59, 39, DateTimeKind.Local).AddTicks(7937), "Joey.Crist22@gmail.com", "Aaliyah", 7, "Volkman", "$2a$11$NchGJo7GmZtiKsBeU616veivhmn0SZBKXZZPZ/Eb0hZs6GNsRpfd." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 10, 2, 42, 33, 792, DateTimeKind.Local).AddTicks(4939), "Shawna.Gorczany28@yahoo.com", "Osbaldo", 5, 4, false, "Cormier", "$2a$11$qk..2yumsGb1c.sMeBxdXufPlrneSeuC67MPuKOFkFSKXDfIiBulu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 16, 9, 10, 15, 507, DateTimeKind.Local).AddTicks(9082), "Danielle_Bergstrom@gmail.com", "Sam", 8, 1, true, "Kertzmann", "$2a$11$CgAtJfGepc13wgPFkLBJNuzOjyWr7LKwzW3pfLWyLduORj0/ewYeC" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Agences",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Agences",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Agences",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Agences",
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
                values: new object[] { "34212 Alba Pine", "Smithamborough", new DateTime(2023, 1, 12, 16, 26, 58, 992, DateTimeKind.Local).AddTicks(9493), "Izabella13@hotmail.com", -80.509200000000007, 145.8767, "Regional Accounts Administrator", "1-921-466-0912", "45560" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "9129 Lamont Mountains", "Gislasonburgh", new DateTime(2023, 3, 23, 3, 5, 37, 263, DateTimeKind.Local).AddTicks(6759), "Theodora.Hand@yahoo.com", -48.445900000000002, 170.64750000000001, "Investor Functionality Consultant", "(713) 946-5557", "21990-4466" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "68653 Waelchi Vista", "West Groverhaven", new DateTime(2023, 1, 25, 8, 46, 49, 704, DateTimeKind.Local).AddTicks(1984), "Darron38@gmail.com", 51.888100000000001, -44.440399999999997, "Dynamic Intranet Specialist", "201.529.2034 x31694", "72317" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "326 Lesch Street", "Alberthashire", new DateTime(2022, 9, 1, 1, 26, 4, 790, DateTimeKind.Local).AddTicks(1880), "Ola_Ferry1@gmail.com", -56.504600000000003, 48.0396, "International Interactions Consultant", "1-780-429-7890", "32755-9853" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "99540 Mellie Motorway", "Sandrafurt", new DateTime(2023, 6, 12, 20, 25, 14, 550, DateTimeKind.Local).AddTicks(156), "Sid25@yahoo.com", 30.244399999999999, -140.99459999999999, "Forward Directives Associate", "(547) 823-2940", "24892-5671" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "8965 Helga Road", "Emardmouth", new DateTime(2022, 12, 2, 16, 43, 41, 211, DateTimeKind.Local).AddTicks(9066), "Vinnie.Kris70@hotmail.com", -19.171700000000001, -26.8064, "Principal Marketing Orchestrator", "699.870.0596 x80361", "83163" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "592 Carmelo Prairie", "Prohaskaport", new DateTime(2023, 4, 14, 22, 1, 49, 166, DateTimeKind.Local).AddTicks(7235), "Murl.Strosin@yahoo.com", 89.850300000000004, 26.8841, "Future Usability Specialist", "428.205.1293", "97458" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "549 Reichel Hollow", "New Jasmintown", new DateTime(2023, 6, 5, 14, 9, 12, 767, DateTimeKind.Local).AddTicks(3559), "Kiana39@hotmail.com", -47.155999999999999, -88.463999999999999, "Investor Assurance Orchestrator", "884-809-8261 x1741", "23713-6545" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "800 Walter Meadows", "South Kurtchester", new DateTime(2023, 7, 1, 12, 23, 44, 946, DateTimeKind.Local).AddTicks(2814), "Gina7@gmail.com", 21.319099999999999, -163.34299999999999, "Customer Data Liaison", "429-236-7004", "54120" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "06088 Bayer Divide", "East Ashleigh", new DateTime(2022, 8, 5, 14, 2, 52, 910, DateTimeKind.Local).AddTicks(1555), "Santina_Mante@yahoo.com", -69.301100000000005, 158.88249999999999, "Direct Branding Technician", "1-739-497-7236", "25209-7048" });

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
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 22, 7, 51, 32, 720, DateTimeKind.Local).AddTicks(7460), "Cadillac" });

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
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 25, 23, 55, 34, 848, DateTimeKind.Local).AddTicks(194), "Silverado" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 19, 1, 42, 51, 295, DateTimeKind.Local).AddTicks(8370), "Donato95@hotmail.com", "Lenore", false, "Botsford", "$2a$11$ng4PeuJBmGJSWvMj/Cz1zO34bKr8hg5y42F.Vz.u12Wv0/Rh0Zz6a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 29, 9, 30, 34, 437, DateTimeKind.Local).AddTicks(7895), "Gunner_Metz80@gmail.com", "Bulah", 4, 2, "Hettinger", "$2a$11$YPG9aY1zeb8EBRO8cdrXpOkz0vAFdAXO1r25Gpwqiyt69t3HI2Sei" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 6, 5, 53, 41, 903, DateTimeKind.Local).AddTicks(3863), "Rosalyn.Kshlerin39@yahoo.com", "Felicia", 8, 3, false, "Leuschke", "$2a$11$GRABlhLlhOe7R3eMkRsy8uUZftShvSzHo/7e9fJS6g/pteMXN7UZi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 30, 7, 14, 48, 900, DateTimeKind.Local).AddTicks(8714), "Floy73@gmail.com", "Lela", 6, 2, "Rodriguez", "$2a$11$YSzmyzAvdk.lBbgge4804uW7q.ESSEA.kgoRFIqX/rvK7ecvkfn4W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 27, 8, 59, 16, 980, DateTimeKind.Local).AddTicks(1273), "Jon82@hotmail.com", "Adan", 9, false, "Mills", "$2a$11$uzam0so6zElurmS26Rls5uYQAy1FjHtb4U4R3v1.jlzHyfeqGP.vi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 5, 0, 0, 44, 118, DateTimeKind.Local).AddTicks(7580), "Coy99@gmail.com", "Ryann", 4, true, "Bosco", "$2a$11$oT/Vc.1BCOU69qQ0P.VP3ON6.v0p3C1WAuArw0lz/8SzIDhRkwGV6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 23, 16, 2, 23, 243, DateTimeKind.Local).AddTicks(1897), "Jodie.Steuber@hotmail.com", "Beaulah", 2, 2, true, "Stracke", "$2a$11$yxEKlBkLCmqqeKNAUekKpuQBs0XCijEyQmbqXGPJ/v/vK5otY6It." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 10, 18, 45, 24, 489, DateTimeKind.Local).AddTicks(4327), "Corbin.Yundt@hotmail.com", "Eddie", 2, "Cremin", "$2a$11$HO9Vu820q4sJDZ9J8T8zJOQKgh5vhVoPbqBVf.fnFkl6g2R0NrVoW" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 30, 12, 28, 58, 809, DateTimeKind.Local).AddTicks(477), "Gertrude_Leffler@yahoo.com", "Rachel", 9, 4, false, "Jenkins", "$2a$11$nDM7ud/hfeRM.3L7IY/guejoHvqdp/pqXU7E5hfdWuLjheqLj/Vw2" });
        }
    }
}
