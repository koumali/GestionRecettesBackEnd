using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class addNull_isVerified : Migration
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
                values: new object[] { "060 Hansen Views", "East Alexanderfort", new DateTime(2022, 10, 5, 13, 40, 42, 544, DateTimeKind.Local).AddTicks(9751), "Eliseo_Botsford@yahoo.com", false, 60.918500000000002, 70.925700000000006, "Principal Tactics Orchestrator", "916-545-3370 x1349", "27432-5405" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4780 Harris Wall", "North Kenna", new DateTime(2022, 10, 31, 14, 28, 15, 580, DateTimeKind.Local).AddTicks(6684), "Collin74@gmail.com", false, -50.716700000000003, 148.6438, "Corporate Implementation Liaison", "364-793-6504 x680", "26091" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "894 Rolfson Parkway", "South Derrickfort", new DateTime(2022, 11, 17, 16, 24, 48, 654, DateTimeKind.Local).AddTicks(7115), "Felipa.Cartwright@gmail.com", false, 23.108799999999999, -136.268, "Dynamic Applications Director", "259.419.9467 x20021", "95905" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "404 Schumm Flat", "Tylerside", new DateTime(2022, 12, 31, 18, 20, 18, 848, DateTimeKind.Local).AddTicks(9744), "Jennings_Mitchell@yahoo.com", false, -70.596400000000003, 4.0307000000000004, "Legacy Branding Specialist", "1-883-822-9467", "13317" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "691 Freeda Spur", "North Dimitritown", new DateTime(2023, 7, 11, 1, 32, 28, 753, DateTimeKind.Local).AddTicks(553), "Lou_Grimes@yahoo.com", false, -4.2397, 152.0771, "Legacy Accounts Architect", "700-378-3582 x6702", "91775-5217" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "349 Pacocha Inlet", "New Keirabury", new DateTime(2022, 11, 10, 6, 35, 19, 436, DateTimeKind.Local).AddTicks(3890), "Lonnie24@yahoo.com", false, 42.260199999999998, 38.253999999999998, "International Web Assistant", "542.398.9809 x8690", "13756-8710" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "606 Cassandre Neck", "Brookeland", new DateTime(2023, 5, 14, 3, 42, 27, 519, DateTimeKind.Local).AddTicks(7784), "Houston35@hotmail.com", false, -10.809799999999999, -0.14149999999999999, "Corporate Assurance Representative", "1-976-471-5147", "00582" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "21965 D'Amore View", "East Dorthy", new DateTime(2022, 11, 24, 3, 4, 12, 811, DateTimeKind.Local).AddTicks(8898), "Constance.Strosin27@yahoo.com", false, 55.369599999999998, -177.8569, "Principal Solutions Consultant", "(366) 982-0034", "22109" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "98615 Moore Ports", "D'Amoreborough", new DateTime(2022, 12, 27, 20, 44, 11, 50, DateTimeKind.Local).AddTicks(8432), "Johnnie15@hotmail.com", false, -65.623900000000006, 122.1855, "International Integration Agent", "326.449.4100 x24715", "40562" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "IsVerified", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "609 Fisher Orchard", "East Minervaland", new DateTime(2023, 3, 14, 22, 35, 28, 218, DateTimeKind.Local).AddTicks(9288), "Leonard85@yahoo.com", false, 56.336100000000002, -73.749899999999997, "District Accounts Supervisor", "(411) 821-2893", "51766" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 12, 40, 111, DateTimeKind.Local).AddTicks(8930), "Lamborghini" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 25, 2, 20, 58, 514, DateTimeKind.Local).AddTicks(8898), "Polestar" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 2, 19, 26, 33, 699, DateTimeKind.Local).AddTicks(3911), "Land Rover" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 6, 8, 44, 14, 353, DateTimeKind.Local).AddTicks(968), "Fiat" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 12, 5, 58, 22, 150, DateTimeKind.Local).AddTicks(2559), "Smart" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 19, 18, 39, 19, 965, DateTimeKind.Local).AddTicks(6999), "Bentley" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 8, 17, 27, 13, 523, DateTimeKind.Local).AddTicks(3592), "BMW" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 12, 15, 52, 17, 952, DateTimeKind.Local).AddTicks(7217), "Tesla" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 5, 10, 37, 28, 138, DateTimeKind.Local).AddTicks(2932), "Hyundai" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 7, 31, 13, 18, 34, 598, DateTimeKind.Local).AddTicks(3964), "Rolls Royce" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 7, 5, 0, 43, 49, 713, DateTimeKind.Local).AddTicks(5935), 5, "https://picsum.photos/640/480/?image=805", "Charger" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 3, 25, 12, 30, 11, 313, DateTimeKind.Local).AddTicks(1799), 1, "https://picsum.photos/640/480/?image=826", "Countach" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 12, 15, 7, 2, 53, 151, DateTimeKind.Local).AddTicks(6188), 7, "https://picsum.photos/640/480/?image=789", "Civic" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 3, 2, 12, 25, 22, 726, DateTimeKind.Local).AddTicks(4034), 6, "https://picsum.photos/640/480/?image=703", "Volt" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Image", "Name" },
                values: new object[] { new DateTime(2023, 2, 5, 7, 37, 6, 974, DateTimeKind.Local).AddTicks(5108), "https://picsum.photos/640/480/?image=482", "Durango" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Image", "Name" },
                values: new object[] { new DateTime(2023, 5, 28, 21, 42, 50, 51, DateTimeKind.Local).AddTicks(6264), "https://picsum.photos/640/480/?image=651", "PT Cruiser" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 6, 20, 11, 35, 20, 81, DateTimeKind.Local).AddTicks(7365), 8, "https://picsum.photos/640/480/?image=221", "Model 3" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 2, 28, 14, 12, 20, 619, DateTimeKind.Local).AddTicks(5302), 6, "https://picsum.photos/640/480/?image=392", "F-150" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 11, 14, 45, 5, 911, DateTimeKind.Local).AddTicks(4037), 2, "https://picsum.photos/640/480/?image=783", "Ranchero" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 7, 9, 11, 0, 43, 529, DateTimeKind.Local).AddTicks(5532), 9, "https://picsum.photos/640/480/?image=208", "Grand Caravan" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 5, 10, 42, 19, 51, DateTimeKind.Local).AddTicks(5410), "Judy.Padberg@hotmail.com", "Precious", 10, 1, true, "Grady", "$2a$11$GqlhA2FOkAPIeGu2mJZ06uw4KEsbLUhVhcmFEYWijDtxkKtXcKoGy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 22, 8, 40, 54, 842, DateTimeKind.Local).AddTicks(6395), "Clay17@gmail.com", "Davin", 7, 4, true, "Block", "$2a$11$MCUmUrX9O0c4xKSO4QgPfeYBlMSlr504Lk4y8tbisyAz/ETv3Jguu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 18, 24, 498, DateTimeKind.Local).AddTicks(4729), "Rashawn.Bechtelar@gmail.com", "Vern", 10, 3, "Hayes", "$2a$11$mmiGqImu8KPFz99VlaRKj.kirRjoBuTy6GXHk4PfZjeauiaGYa5eG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 11, 14, 2, 54, 434, DateTimeKind.Local).AddTicks(5458), "Murphy_OHara89@yahoo.com", "Ashlee", 1, true, "Rippin", "$2a$11$ECexlam7WEKTTz9VfkNloOIEQeEtylC5hidOz4r8JliPcYx8dPqbC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 16, 7, 242, DateTimeKind.Local).AddTicks(133), "Gaetano28@gmail.com", "Albertha", 6, 4, "Raynor", "$2a$11$3XUJnTNDfuzT2vrumB9yrOFvmXccZC28ielhHK.IS9pgI02TiioWa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 7, 17, 17, 1, 50, 915, DateTimeKind.Local).AddTicks(9065), "Sharon27@gmail.com", "Mckayla", 10, 1, false, "Spinka", "$2a$11$FVlrf38PnrVvcI3q/WPDYuKrGXQoD.XKh1ccA2cVH80C7lisEC8QW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 2, 23, 32, 31, 193, DateTimeKind.Local).AddTicks(3950), "Sammie.Hyatt@gmail.com", "Geraldine", 4, "Steuber", "$2a$11$SawWwzH/DUIdHQnmwQVTk.u0.hB.7qCgfDCwVk/DnsuAR3VjfnU32" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 17, 20, 40, 21, 962, DateTimeKind.Local).AddTicks(9031), "John_Moore77@yahoo.com", "Ardella", 2, 4, true, "Lindgren", "$2a$11$ECr/0yrQL46ZwNG.DNrTkeJ3WNabFdb7m58eqAYX4bfgVWSVpkQo2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 15, 11, 40, 48, 29, DateTimeKind.Local).AddTicks(9793), "Lonny63@hotmail.com", "Frederic", 3, false, "Gutkowski", "$2a$11$o2o8MJF6A6I/NuMNYXQ48.1kWpuZXBVPXczEEoXBWA.8Z.WHpD8Ve" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 23, 7, 55, 53, 445, DateTimeKind.Local).AddTicks(162), "Audrey.Ratke@gmail.com", "Cecelia", 4, "Ledner", "$2a$11$RhKVYK/pwAUrf1HMqEqrZ.A5SCHbjB7RNinACkjGPKwPLtWDUnRpW" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Agences");

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
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 6, 13, 17, 4, 34, 548, DateTimeKind.Local).AddTicks(7973), 7, "https://picsum.photos/640/480/?image=885", "Wrangler" });

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
                columns: new[] { "CreatedAt", "Image", "Name" },
                values: new object[] { new DateTime(2022, 12, 4, 18, 14, 52, 789, DateTimeKind.Local).AddTicks(7149), "https://picsum.photos/640/480/?image=404", "Beetle" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Image", "Name" },
                values: new object[] { new DateTime(2022, 12, 1, 5, 30, 39, 855, DateTimeKind.Local).AddTicks(2310), "https://picsum.photos/640/480/?image=40", "Challenger" });

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
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 9, 17, 18, 22, 21, 58, DateTimeKind.Local).AddTicks(1421), 8, "https://picsum.photos/640/480/?image=62", "Fiesta" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 22, 21, 52, 18, 497, DateTimeKind.Local).AddTicks(426), "Howard.Jakubowski19@hotmail.com", "Braulio", 8, 2, false, "Schulist", "$2a$11$Y9LqetpOY/9RocIs4QCutuKMpXlrI91/lyWRy6Ks.Biwf5cwCErnW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 12, 16, 46, 51, 359, DateTimeKind.Local).AddTicks(9340), "Aurelio_Cummerata@yahoo.com", "Linwood", 5, 1, false, "Marquardt", "$2a$11$f/RZh4xTBGMpbLsulfNuPOo9gQ0Y5fxgHfgZ1mVOawKxTV7p8ijcS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 57, 34, 935, DateTimeKind.Local).AddTicks(4669), "Lew.Rippin81@gmail.com", "Berry", 2, 1, "Pollich", "$2a$11$mp8V/q8vuskI5MIQBqVSBu7SkaYdAox7GrnRqdOofEmbYN5EXQVj." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 25, 5, 50, 10, 252, DateTimeKind.Local).AddTicks(6927), "Rosina6@hotmail.com", "Kaycee", 4, false, "Hoeger", "$2a$11$Vx7D6KuiIe2k0IKlHoSu8O5tQIA0jK6y3vdJKhDeTR.PmWosKLttK" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 26, 1, 46, 48, 44, DateTimeKind.Local).AddTicks(6565), "Camryn_Osinski97@yahoo.com", "Hassan", 9, "Rolfson", "$2a$11$l4F3pmlnSVWEXdiHon3sTORJHURHoH4PSJT6kAt85SPL6g8k8Mb16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 16, 20, 25, 26, 656, DateTimeKind.Local).AddTicks(4255), "Marie2@yahoo.com", "Chadrick", 8, 1, false, "Goyette", "$2a$11$MNXsyNZwdWNG0d.8MQe33.Imn8wRKaQITEGau5Ylawph0wStiEn/W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 11, 10, 2, 51, 209, DateTimeKind.Local).AddTicks(7541), "Webster_Nicolas58@gmail.com", "Maxime", 2, true, "Bechtelar", "$2a$11$G/MJUE5l.fRnfJ.6fQm3E.jU/YGfmVnZ76ftyLdthGsJxWfr.W9Yu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 25, 14, 114, DateTimeKind.Local).AddTicks(856), "Lynn.Wehner@gmail.com", "Iliana", 7, "Mayer", "$2a$11$fu6BYrwg3.8c4E1DkuggauS19eFlCPL8kUCyPo7LPu7XHUL6oeWWy" });
        }
    }
}
