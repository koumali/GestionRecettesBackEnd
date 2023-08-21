using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class add_moteur_gearbox_toLongTermRontals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gearbox",
                table: "long_term_rentals",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Moteur",
                table: "long_term_rentals",
                type: "longtext",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3997 Skiles Track", "Eveville", new DateTime(2023, 1, 7, 1, 58, 11, 474, DateTimeKind.Local).AddTicks(9169), "Adrienne_Batz@hotmail.com", -13.338200000000001, -172.4392, "Global Data Agent", "915-557-9627 x2020", "74654" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "078 Legros Garden", "East Orphachester", new DateTime(2022, 11, 23, 1, 6, 13, 189, DateTimeKind.Local).AddTicks(7835), "Anya_Schroeder@yahoo.com", 57.449599999999997, 57.203200000000002, "National Infrastructure Developer", "251-215-9043", "20806" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "6067 Larkin View", "Hobartside", new DateTime(2023, 7, 30, 5, 7, 15, 930, DateTimeKind.Local).AddTicks(4171), "Laurine9@yahoo.com", -4.0521000000000003, -117.03830000000001, "Lead Response Specialist", "507-296-7434", "23065" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "258 Kuhlman Causeway", "West Haydenmouth", new DateTime(2022, 8, 31, 0, 23, 59, 175, DateTimeKind.Local).AddTicks(1262), "Audie.Thompson@hotmail.com", 61.891500000000001, -4.0331999999999999, "Central Accounts Assistant", "601-763-8891", "54509" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "437 Wilburn Manor", "Stromanfurt", new DateTime(2022, 9, 27, 18, 27, 34, 98, DateTimeKind.Local).AddTicks(4299), "Joel_Hickle@gmail.com", 84.596599999999995, -77.456000000000003, "Chief Operations Engineer", "(304) 421-5818", "71908-9084" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0322 Ledner Street", "North Cynthia", new DateTime(2023, 6, 8, 12, 2, 44, 583, DateTimeKind.Local).AddTicks(1134), "Shayna27@gmail.com", -65.199299999999994, -64.309899999999999, "Regional Interactions Officer", "261.659.1349", "93582" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "045 Jalen Ways", "New Krystinaville", new DateTime(2022, 8, 30, 8, 21, 27, 216, DateTimeKind.Local).AddTicks(1975), "Taya76@gmail.com", 17.637899999999998, -23.491800000000001, "Principal Implementation Designer", "256-617-9176 x96551", "17141" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "56328 Wilkinson Fork", "Boyerstad", new DateTime(2022, 9, 19, 20, 41, 20, 440, DateTimeKind.Local).AddTicks(7669), "Seamus29@yahoo.com", 76.165000000000006, 149.77590000000001, "Investor Tactics Liaison", "(233) 643-2797", "44174-6500" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "011 Yundt Pines", "Lake Adeletown", new DateTime(2022, 11, 25, 17, 32, 59, 809, DateTimeKind.Local).AddTicks(9765), "Emmy.Rath@yahoo.com", 11.594799999999999, -166.8467, "Direct Creative Administrator", "355-663-3209", "09305" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "438 Johnston Parks", "Wizafurt", new DateTime(2022, 9, 26, 19, 23, 18, 56, DateTimeKind.Local).AddTicks(2867), "Milan_Pagac@hotmail.com", 72.724900000000005, 134.54060000000001, "Regional Implementation Planner", "603-294-9996 x9787", "85332" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "72010 Annetta Road", "223 Odessa Islands", new DateTime(2022, 11, 19, 21, 41, 7, 440, DateTimeKind.Local).AddTicks(1182), "Lucas7@yahoo.com", "Renee", "Hermiston", "https://picsum.photos/640/480/?image=538", "https://picsum.photos/640/480/?image=441", "512.689.0855", "Lake Dylanburgh", "51301-8822" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "43419 Darlene Corners", "0859 Kari Rapids", new DateTime(2022, 9, 16, 2, 10, 52, 747, DateTimeKind.Local).AddTicks(699), "Larissa15@gmail.com", "Elta", "Daniel", "https://picsum.photos/640/480/?image=12", "https://picsum.photos/640/480/?image=909", "(500) 864-6605 x64462", "West Brookeburgh", "36486-4602" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "346 Collins Center", "4210 Smith Junction", new DateTime(2023, 6, 27, 3, 3, 32, 855, DateTimeKind.Local).AddTicks(2087), "Cleta29@hotmail.com", "Stella", "Will", "https://picsum.photos/640/480/?image=54", "https://picsum.photos/640/480/?image=40", "714.737.3554", "Garthburgh", "37524" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "199 Lori Coves", "3313 Tia Knoll", new DateTime(2022, 10, 17, 17, 27, 8, 35, DateTimeKind.Local).AddTicks(2641), "Shirley_Gibson81@hotmail.com", "Silas", "Green", "https://picsum.photos/640/480/?image=1019", "https://picsum.photos/640/480/?image=199", "975.542.7935 x17374", "Dareview", "64356" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "79652 Vandervort Road", "96544 Ethyl Keys", new DateTime(2022, 11, 6, 7, 56, 14, 725, DateTimeKind.Local).AddTicks(7948), "Regan9@hotmail.com", "Carlee", "Weimann", "https://picsum.photos/640/480/?image=729", "https://picsum.photos/640/480/?image=1051", "(536) 609-8582 x8292", "North Dannie", "07764-2465" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "67937 Rosario Junction", "6531 Roberto Canyon", new DateTime(2022, 8, 24, 7, 12, 59, 529, DateTimeKind.Local).AddTicks(7027), "Edmund56@yahoo.com", "Christelle", "Leannon", "https://picsum.photos/640/480/?image=112", "https://picsum.photos/640/480/?image=105", "(374) 827-0745 x92312", "Corwinhaven", "82443" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "988 Halvorson Branch", "1295 Pouros Summit", new DateTime(2023, 4, 22, 9, 33, 30, 320, DateTimeKind.Local).AddTicks(6142), "Esmeralda_Grady@hotmail.com", "Kayli", "Kulas", "https://picsum.photos/640/480/?image=635", "https://picsum.photos/640/480/?image=1046", "706.986.6226", "Kshlerinberg", "39233" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "83992 Alison Lane", "2343 Stark Forges", new DateTime(2023, 2, 7, 9, 18, 43, 358, DateTimeKind.Local).AddTicks(8605), "Rebeka79@gmail.com", "Nigel", "Stracke", "https://picsum.photos/640/480/?image=820", "https://picsum.photos/640/480/?image=356", "(419) 518-5316 x440", "West Lauryn", "40399-4569" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "47134 Kayley Turnpike", "88443 Nya Branch", new DateTime(2023, 7, 17, 15, 10, 20, 871, DateTimeKind.Local).AddTicks(1765), "Victoria.Anderson92@hotmail.com", "Alisa", "Robel", "https://picsum.photos/640/480/?image=141", "https://picsum.photos/640/480/?image=341", "887.896.6249 x84046", "Ziemestad", "65635" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "716 Hassie Circle", "28221 Leannon Squares", new DateTime(2023, 4, 18, 17, 0, 29, 959, DateTimeKind.Local).AddTicks(3035), "Savannah.Kutch@gmail.com", "Gilda", "Goldner", "https://picsum.photos/640/480/?image=967", "https://picsum.photos/640/480/?image=631", "391-207-1561", "South Bryanafort", "91923" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 2, 4, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                column: "IdClient",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 9, 8 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 2, 2, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 7, 9, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 4, 1, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 3, 16, 3, 256, DateTimeKind.Local).AddTicks(1822), new DateTime(2023, 8, 21, 23, 54, 36, 573, DateTimeKind.Local).AddTicks(8313), new DateTime(2024, 7, 2, 13, 12, 50, 140, DateTimeKind.Local).AddTicks(1837), 4, 5.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 11, 43, 45, 761, DateTimeKind.Local).AddTicks(8492), new DateTime(2023, 8, 22, 8, 57, 15, 926, DateTimeKind.Local).AddTicks(1686), new DateTime(2024, 2, 13, 5, 54, 30, 942, DateTimeKind.Local).AddTicks(2667), 5, 10.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 19, 24, 16, 680, DateTimeKind.Local).AddTicks(3422), new DateTime(2023, 8, 22, 13, 8, 54, 308, DateTimeKind.Local).AddTicks(1129), new DateTime(2023, 11, 8, 15, 32, 35, 686, DateTimeKind.Local).AddTicks(7603), 4, 9.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 21, 23, 3, 87, DateTimeKind.Local).AddTicks(2048), new DateTime(2023, 8, 22, 9, 9, 18, 911, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 3, 19, 23, 30, 0, 704, DateTimeKind.Local).AddTicks(590), 4, 8.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 4, 51, 5, 867, DateTimeKind.Local).AddTicks(5449), new DateTime(2023, 8, 22, 3, 25, 5, 23, DateTimeKind.Local).AddTicks(3963), new DateTime(2024, 5, 18, 3, 28, 49, 733, DateTimeKind.Local).AddTicks(368), 7, 6.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 5, 49, 0, 380, DateTimeKind.Local).AddTicks(157), new DateTime(2023, 8, 22, 1, 11, 43, 339, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 2, 28, 3, 54, 1, 691, DateTimeKind.Local).AddTicks(2149), 2, 5.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 21, 9, 34, 881, DateTimeKind.Local).AddTicks(1895), new DateTime(2023, 8, 21, 19, 25, 35, 380, DateTimeKind.Local).AddTicks(5145), new DateTime(2024, 6, 11, 8, 48, 6, 19, DateTimeKind.Local).AddTicks(6013), 7, 3.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 23, 52, 20, 604, DateTimeKind.Local).AddTicks(26), new DateTime(2023, 8, 22, 11, 27, 22, 176, DateTimeKind.Local).AddTicks(2828), new DateTime(2024, 6, 17, 4, 26, 14, 799, DateTimeKind.Local).AddTicks(4127), 3, 6.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 19, 52, 28, 982, DateTimeKind.Local).AddTicks(2816), new DateTime(2023, 8, 22, 5, 46, 14, 150, DateTimeKind.Local).AddTicks(8982), new DateTime(2023, 10, 1, 23, 46, 29, 138, DateTimeKind.Local).AddTicks(4263), 8, 3.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 21, 7, 2, 4, 537, DateTimeKind.Local).AddTicks(9496), new DateTime(2023, 8, 21, 22, 53, 28, 749, DateTimeKind.Local).AddTicks(4453), new DateTime(2023, 9, 21, 17, 51, 8, 987, DateTimeKind.Local).AddTicks(5579), 5, 1.0 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 18, 7, 23, 700, DateTimeKind.Local).AddTicks(8008), new DateTime(2023, 8, 22, 9, 31, 10, 631, DateTimeKind.Local).AddTicks(8444), new DateTime(2024, 5, 7, 0, 55, 18, 478, DateTimeKind.Local).AddTicks(2222), 7, "5beefbb7-a331-4011-866e-538df46c0481", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 15, 20, 43, 683, DateTimeKind.Local).AddTicks(8726), new DateTime(2023, 8, 21, 21, 26, 31, 769, DateTimeKind.Local).AddTicks(8496), new DateTime(2023, 10, 23, 1, 36, 47, 293, DateTimeKind.Local).AddTicks(1180), 7, "22c46dd9-26af-4d33-b1a7-3a47ee1db0bb", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 2, 59, 59, 606, DateTimeKind.Local).AddTicks(4129), new DateTime(2023, 8, 22, 10, 8, 32, 1, DateTimeKind.Local).AddTicks(2905), new DateTime(2024, 1, 26, 6, 19, 1, 194, DateTimeKind.Local).AddTicks(4422), 7, "e352f5a6-c6e9-453d-b1c3-afba7f81f576", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 18, 25, 46, 287, DateTimeKind.Local).AddTicks(9796), new DateTime(2023, 8, 21, 22, 32, 30, 125, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 6, 8, 5, 10, 32, 399, DateTimeKind.Local).AddTicks(2488), "0d2cb33b-93e6-4c82-93ed-525d96ba7c9d", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 14, 27, 54, 745, DateTimeKind.Local).AddTicks(3447), new DateTime(2023, 8, 22, 5, 13, 19, 98, DateTimeKind.Local).AddTicks(2537), new DateTime(2024, 3, 1, 23, 41, 55, 149, DateTimeKind.Local).AddTicks(6552), 3, "da594d40-1210-458f-b7c5-74bba3108496" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 21, 7, 47, 21, 966, DateTimeKind.Local).AddTicks(3804), new DateTime(2023, 8, 22, 12, 43, 12, 83, DateTimeKind.Local).AddTicks(5308), new DateTime(2023, 12, 21, 14, 25, 28, 962, DateTimeKind.Local).AddTicks(6713), 6, "d62c0c2b-8b82-484d-b6a7-8612f6c953a5" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 19, 35, 17, 314, DateTimeKind.Local).AddTicks(77), new DateTime(2023, 8, 21, 23, 36, 14, 832, DateTimeKind.Local).AddTicks(3700), new DateTime(2023, 11, 26, 22, 21, 15, 144, DateTimeKind.Local).AddTicks(6944), 6, "7340f7fa-a63c-490b-a85a-d280a6a4c284", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 12, 2, 17, 256, DateTimeKind.Local).AddTicks(4172), new DateTime(2023, 8, 22, 15, 18, 30, 109, DateTimeKind.Local).AddTicks(1810), new DateTime(2024, 1, 14, 4, 7, 37, 675, DateTimeKind.Local).AddTicks(3648), 1, "0d5a5e42-bfce-4abe-adc8-10d0df7ac6ee", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 9, 48, 19, 210, DateTimeKind.Local).AddTicks(4905), new DateTime(2023, 8, 22, 10, 14, 34, 233, DateTimeKind.Local).AddTicks(2498), new DateTime(2023, 11, 4, 22, 28, 54, 117, DateTimeKind.Local).AddTicks(6183), 4, "9ff72d9d-264d-4cbb-b78c-99b80cdfcf56", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 21, 18, 5, 29, 867, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 8, 21, 22, 54, 0, 514, DateTimeKind.Local).AddTicks(3348), new DateTime(2024, 5, 14, 19, 16, 8, 792, DateTimeKind.Local).AddTicks(1566), 1, "d9a47f25-bc67-487b-b489-df237307274b", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 3, 21, 33, 23, 111, DateTimeKind.Local).AddTicks(6843), "Eliane4@hotmail.com", "Mckenzie", true, "Considine", "$2a$11$W7RAvQeuxUu5G7mPB8oIievC7x1DNUi5fkMup.9PkO3S6AvIOVg7e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 1, 6, 46, 58, 76, DateTimeKind.Local).AddTicks(2489), "Keon75@gmail.com", "Nicolette", 1, true, "Braun", "$2a$11$v/pA7HrgX721sven8XW93uVTVckM.1dIFfHX.9WmaWluAzoR7qf1u" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 7, 20, 38, 23, 978, DateTimeKind.Local).AddTicks(7369), "Manley24@gmail.com", "Serenity", 5, "Skiles", "$2a$11$m2QxKJBbLnHoBPzOH7FVTu8zLhN9pkuGhKO/BYvukOcOEsJqPt0ua" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 2, 15, 2, 51, 345, DateTimeKind.Local).AddTicks(2819), "Savannah62@hotmail.com", "Kailee", 3, "Becker", "$2a$11$1XzKeXWwpmjwvQ7MjDeHKusPz.wOHJiY/Xo3IZm3Bi1iKf2kkyNCe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 18, 1, 51, 13, 386, DateTimeKind.Local).AddTicks(2250), "Trenton_Swift83@gmail.com", "Dora", 1, 1, false, "Haley", "$2a$11$AkPkPW63bUwBB82WfsMKsOnrnLf2pq7txHCmctfCYybPZoyZnOZf2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 29, 20, 1, 55, 650, DateTimeKind.Local).AddTicks(751), "Nasir.Okuneva@hotmail.com", "Gene", 3, 2, false, "Barton", "$2a$11$vSKxAostSfaK391X15GPOOj9gWM/NitRDKy/uaX3dPe9p1juUjf8a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 14, 31, 294, DateTimeKind.Local).AddTicks(7511), "Howard74@yahoo.com", "Gerard", 10, 1, false, "Kuhlman", "$2a$11$lU54/UOSOAv5/g9e6P5pyusyEoRBWeJEXhp1E5S0tDRGszOiJaUTO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 22, 3, 39, 21, 83, DateTimeKind.Local).AddTicks(1115), "Anastasia_Goldner9@yahoo.com", "Naomie", 7, "Herzog", "$2a$11$JQyzp74wwtIggnxkDQ9YTembMVocgQcGPZKvsA4wXwbM4HnUePbnu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 15, 14, 25, 37, 948, DateTimeKind.Local).AddTicks(5655), "Rachel.Walsh@gmail.com", "Leopold", 2, false, "Johnston", "$2a$11$9TqIO8xghAWTmKZvMtau9ucPPOaFKKQ4ktVhYxqVNNmlTHD8VSRgW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 21, 19, 59, 52, 736, DateTimeKind.Local).AddTicks(3518), "Dagmar32@gmail.com", "Jeff", 1, true, "Cruickshank", "$2a$11$WQd8wGa/VmQv9RuZ535dauYfyy0CMN/b5hlXvGFVeN/NwcyiEAjee" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 9, 30, 10, 28, 12, 586, DateTimeKind.Local).AddTicks(332), "siozrkusva", 10, 31, 3885, "jhinwbjujo", "apexxohnjf", "bcsuskpcbe", 4, 1.0, "udthlcoknk" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 3, 25, 2, 19, 19, 753, DateTimeKind.Local).AddTicks(4635), "qkmgjllyvd", 1, 55, 661, "zerzbpvqfu", "wfqzkwpfur", "ntjbpkmusl", 8, 10, 7.0, "zsnxedsxgw" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 5, 10, 19, 2, 16, 355, DateTimeKind.Local).AddTicks(7935), "iwpzpbjnbv", 192, 8957, "iwhgmhwjst", "dqeftcvjmf", "uisqltlrpe", 1, 2.0, "rmyjmffsru" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { new DateTime(2023, 8, 18, 5, 45, 24, 689, DateTimeKind.Local).AddTicks(5484), "zasmsidahv", 156, 7068, "comfxynepq", "auuppbmjxr", "nxiihlyyvn", 6, 2, "mbexqbzagf" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { false, new DateTime(2023, 3, 9, 6, 10, 8, 353, DateTimeKind.Local).AddTicks(6454), "bzwkppsajn", 9, 292, 2155, "jnckdstmyn", "ypppwqiyhf", "fbespfazut", 10, 3, "lqbdrvtfmg" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 11, 2, 18, 23, 59, 856, DateTimeKind.Local).AddTicks(8064), "alplamwtzo", 2, 83, 9095, "vnlejwziws", "nfwszcqdsg", "ivwztfgesy", 7, 7, 9.0, "lybzpwufkb" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 10, 18, 3, 14, 5, 719, DateTimeKind.Local).AddTicks(8988), "udhxeakgkj", 45, 6697, "ppwrdykadj", "ffjjfxukst", "vhngyjuyoh", 5, 6, 7.0, "skjfczmcts" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2022, 10, 8, 18, 36, 8, 67, DateTimeKind.Local).AddTicks(5388), "iixapdlihs", 1, 83, 2851, "qwgydvakbv", "sciwuvnmhl", "lvuvpdbttd", 5, 3, 10.0, "npztksspar" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, false, new DateTime(2022, 10, 18, 8, 34, 13, 933, DateTimeKind.Local).AddTicks(5385), "hkxmvrnfax", 8, 258, 9323, "mhicbzrmxs", "hxzpwycehg", "jbkdvczzkh", 10, 5, 7.0, "kxmwfuhanf" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 1, 5, 23, 57, 33, 418, DateTimeKind.Local).AddTicks(6000), "jezyybvhok", 51, 8519, "eocewwcjuk", "yhbxzrnsyo", "xbqlqpxigd", 10, 5, 9.0, "fsjmqcccsu" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 31, 18, 8, 50, 120, DateTimeKind.Local).AddTicks(516), "wrkxywpyfo", 32, "sauwqfllxa", "zewzfozdkl", "Kunze", 27, "Connelly Inc", "Linwood", "258-579-2975 x993", "Upton", "Port Rollinside", "79160" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 10, 18, 12, 50, 624, DateTimeKind.Local).AddTicks(1523), "eymhqmzzou", 325, "fqebadpifh", "ihvyqdrzem", "Ferry", 20, "Simonis - Runolfsdottir", "Columbus", "940-651-0030", "Spencer", "Lambertmouth", "86026-2952" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 27, 16, 42, 2, 398, DateTimeKind.Local).AddTicks(791), "bgyeazaxjo", 302, "emmmjevpqe", "glinodguud", "Robel", 28, "Jacobi, Dooley and Zulauf", "Gracie", "217-609-7069", "Larson", "Hillsburgh", "95914" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 24, 14, 12, 17, 344, DateTimeKind.Local).AddTicks(3339), "ytledxgkgp", 232, "woxascnfmg", "valrvvfgvs", "Schinner", 33, "Jones - Quitzon", "Lila", "760.256.7060 x07610", "Mraz", "Lake Ericview", "40551" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 1, 17, 43, 54, 618, DateTimeKind.Local).AddTicks(2865), "ysbzoeudcv", 77, "lsqzyjifka", "blzjxvdtkf", "Dooley", "Beer LLC", "Bridgette", "(305) 634-4655 x783", "Hagenes", "Amymouth", "85081-1716" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 17, 17, 7, 8, 644, DateTimeKind.Local).AddTicks(6713), "qvwkzotfxl", 286, "uiuwegxosc", "qcasxlgzgj", "VonRueden", 21, "Batz, Willms and Goyette", "Orion", "1-378-209-9134", "Howell", "Titusport", "98751" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 20, 8, 22, 17, 328, DateTimeKind.Local).AddTicks(848), "lldwzoytpk", 2, "mrubhwnjra", "jsbdizunwo", "Bruen", 27, "Muller Inc", "Hunter", "(524) 527-7932", "Dibbert", "North Akeemberg", "74549-1903" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 14, 8, 35, 52, 32, DateTimeKind.Local).AddTicks(8324), "shjtidhucz", 309, "fhpqyxehjb", "edyzedixvv", "Collier", 24, "Nikolaus - Feil", "Blanche", "758.225.5769 x209", "D'Amore", "Silasland", "73424-9505" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 7, 20, 37, 57, 917, DateTimeKind.Local).AddTicks(8352), "lclbskejmq", 171, "goslkiaicp", "uuuyygrnpq", "Kutch", 32, "Fahey, Hirthe and Heaney", "Leilani", "332-762-4767", "Lubowitz", "Lazaroland", "06860" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Moteur", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 26, 0, 24, 18, 498, DateTimeKind.Local).AddTicks(9152), "vvysvdgbfi", 257, "oyxraxvyfj", "wqquyjnmzo", "Koch", 20, "Hauck Inc", "Samara", "(570) 461-4306", "Ullrich", "Electaport", "72435-8596" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gearbox",
                table: "long_term_rentals");

            migrationBuilder.DropColumn(
                name: "Moteur",
                table: "long_term_rentals");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "107 Bruen Freeway", "Port Maxineside", new DateTime(2023, 3, 31, 14, 22, 50, 244, DateTimeKind.Local).AddTicks(8674), "Lonzo43@gmail.com", 77.183300000000003, 97.7958, "Central Mobility Associate", "773.213.5357", "16678-1857" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3571 Oliver Coves", "Dellafurt", new DateTime(2022, 10, 21, 9, 7, 27, 156, DateTimeKind.Local).AddTicks(7835), "Stone36@gmail.com", 47.3157, 67.239099999999993, "Direct Communications Orchestrator", "1-881-207-8141 x37857", "71118-3765" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4288 Tyra Forest", "New Queenshire", new DateTime(2023, 4, 27, 2, 23, 13, 677, DateTimeKind.Local).AddTicks(6346), "Hal_Mertz@yahoo.com", -28.0395, 77.130499999999998, "International Marketing Engineer", "1-868-576-4018 x31343", "79903" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "554 Drake Land", "North Conrad", new DateTime(2023, 6, 1, 5, 18, 31, 36, DateTimeKind.Local).AddTicks(7313), "Bernadette_Maggio61@yahoo.com", 38.091299999999997, 96.870800000000003, "Global Optimization Liaison", "1-687-853-1117 x30146", "54306" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3424 Balistreri Expressway", "New Chaneltown", new DateTime(2022, 12, 22, 12, 51, 13, 52, DateTimeKind.Local).AddTicks(3021), "Adrianna.Lesch2@gmail.com", 88.018699999999995, 89.467399999999998, "Lead Research Coordinator", "1-707-829-0375 x640", "01226-7947" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "627 Braden Track", "North Justina", new DateTime(2023, 7, 24, 19, 48, 54, 402, DateTimeKind.Local).AddTicks(5796), "Armand_Zemlak60@gmail.com", 17.315300000000001, -6.3228999999999997, "Investor Data Liaison", "1-977-228-2225 x5457", "45246-0500" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "9533 Janice Extension", "Thaliaburgh", new DateTime(2023, 1, 22, 22, 8, 9, 624, DateTimeKind.Local).AddTicks(7385), "Americo.Barrows@yahoo.com", -84.463099999999997, -146.20949999999999, "Regional Quality Manager", "(814) 513-5286 x41489", "85437-9807" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "734 Nienow Ways", "New Unique", new DateTime(2023, 7, 6, 23, 29, 52, 105, DateTimeKind.Local).AddTicks(6720), "Osborne_Dibbert7@hotmail.com", 20.6782, -77.658799999999999, "Direct Interactions Facilitator", "605-725-1601 x266", "57835" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "73974 Abbie Mission", "Reytown", new DateTime(2022, 9, 20, 5, 18, 24, 505, DateTimeKind.Local).AddTicks(5510), "Hiram_Quitzon@gmail.com", -39.194600000000001, 122.43989999999999, "Legacy Configuration Technician", "291.224.3895 x614", "22569-7286" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "15882 Domenico Prairie", "Luisafurt", new DateTime(2022, 12, 4, 5, 5, 11, 30, DateTimeKind.Local).AddTicks(5204), "Carolina.Breitenberg@yahoo.com", -36.308, -73.584299999999999, "Senior Usability Supervisor", "986.695.3976", "17006" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "39901 Craig Light", "21397 Yesenia Freeway", new DateTime(2023, 6, 9, 17, 37, 2, 271, DateTimeKind.Local).AddTicks(7950), "Aurelia.Luettgen27@gmail.com", "Alexandro", "Morissette", "https://picsum.photos/640/480/?image=412", "https://picsum.photos/640/480/?image=962", "(667) 737-7521 x23287", "Trevionland", "95098-9660" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "5193 Harris Spurs", "9299 Connelly Shoals", new DateTime(2023, 7, 4, 17, 20, 2, 83, DateTimeKind.Local).AddTicks(5071), "Ricardo81@gmail.com", "Princess", "Lockman", "https://picsum.photos/640/480/?image=151", "https://picsum.photos/640/480/?image=9", "421.932.4112", "Danniefort", "50175-5111" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "1514 Tromp Divide", "111 Jaylin Turnpike", new DateTime(2023, 2, 2, 21, 19, 28, 406, DateTimeKind.Local).AddTicks(1893), "Anabelle.Swaniawski10@hotmail.com", "Jett", "Upton", "https://picsum.photos/640/480/?image=309", "https://picsum.photos/640/480/?image=1050", "(968) 958-5259 x34990", "Lake Lafayetteton", "71341" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "505 Ebert Isle", "41110 Kulas Hollow", new DateTime(2023, 5, 13, 5, 10, 2, 319, DateTimeKind.Local).AddTicks(518), "Lawson10@hotmail.com", "Camden", "Dibbert", "https://picsum.photos/640/480/?image=802", "https://picsum.photos/640/480/?image=531", "1-780-291-8929", "Jeromeside", "21158-1147" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "42764 Elnora Ridges", "3375 Eldridge Ridge", new DateTime(2022, 11, 29, 14, 22, 8, 226, DateTimeKind.Local).AddTicks(3542), "Brannon70@gmail.com", "Kaela", "Stanton", "https://picsum.photos/640/480/?image=478", "https://picsum.photos/640/480/?image=89", "(822) 885-1498", "Pagacfort", "43663-0277" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "54337 Rosenbaum Avenue", "12274 Alivia Greens", new DateTime(2022, 9, 30, 12, 2, 34, 219, DateTimeKind.Local).AddTicks(9133), "Alessia_Blick51@gmail.com", "Reyes", "Kiehn", "https://picsum.photos/640/480/?image=587", "https://picsum.photos/640/480/?image=409", "913.737.3251", "New Serenitytown", "75283-9049" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "2869 Kub Square", "2004 Giovanni Mall", new DateTime(2023, 7, 24, 10, 36, 57, 221, DateTimeKind.Local).AddTicks(9636), "Melyssa13@gmail.com", "Lessie", "Upton", "https://picsum.photos/640/480/?image=214", "https://picsum.photos/640/480/?image=363", "1-403-800-9841 x747", "Schultzchester", "44253" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "5516 Harvey Stream", "3835 Frami Parkways", new DateTime(2022, 10, 17, 16, 6, 11, 889, DateTimeKind.Local).AddTicks(1194), "Elliot_Fahey@hotmail.com", "Justine", "Prosacco", "https://picsum.photos/640/480/?image=775", "https://picsum.photos/640/480/?image=178", "1-922-226-3310 x5174", "Kennedytown", "02951" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "554 Chadd Landing", "3373 Prohaska Locks", new DateTime(2022, 8, 25, 5, 4, 16, 150, DateTimeKind.Local).AddTicks(2497), "Alexandrine.Pacocha@hotmail.com", "Tara", "Kris", "https://picsum.photos/640/480/?image=994", "https://picsum.photos/640/480/?image=79", "325.567.7205 x746", "D'Amoreport", "87622" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adresse", "Adresse2", "CreatedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "Ville", "ZipCode" },
                values: new object[] { "9510 Bruen Branch", "7014 Dietrich Point", new DateTime(2023, 7, 29, 18, 37, 16, 217, DateTimeKind.Local).AddTicks(2679), "Davin76@gmail.com", "Brendan", "Schiller", "https://picsum.photos/640/480/?image=76", "https://picsum.photos/640/480/?image=774", "696.204.0074 x467", "Vernton", "85022-0915" });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 8, 2, true });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3,
                column: "IdClient",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 6, 4 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 10, 10, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdClient", "IdReservation" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 1, 2, false });

            migrationBuilder.UpdateData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdClient", "IdReservation", "IsConducteur" },
                values: new object[] { 10, 3, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 1, 41, 38, 842, DateTimeKind.Local).AddTicks(3303), new DateTime(2023, 8, 21, 23, 21, 54, 211, DateTimeKind.Local).AddTicks(5412), new DateTime(2023, 9, 7, 22, 16, 50, 954, DateTimeKind.Local).AddTicks(3221), 6, 7.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 21, 0, 11, 21, 628, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 8, 21, 16, 34, 1, 553, DateTimeKind.Local).AddTicks(8099), new DateTime(2023, 8, 27, 21, 21, 5, 642, DateTimeKind.Local).AddTicks(755), 2, 6.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 17, 23, 4, 775, DateTimeKind.Local).AddTicks(775), new DateTime(2023, 8, 21, 11, 26, 31, 931, DateTimeKind.Local).AddTicks(5545), new DateTime(2023, 10, 31, 1, 58, 41, 909, DateTimeKind.Local).AddTicks(1220), 2, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 21, 32, 23, 873, DateTimeKind.Local).AddTicks(5993), new DateTime(2023, 8, 21, 14, 28, 28, 494, DateTimeKind.Local).AddTicks(5361), new DateTime(2023, 12, 5, 22, 4, 51, 956, DateTimeKind.Local).AddTicks(2324), 8, 4.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 6, 0, 37, 228, DateTimeKind.Local).AddTicks(1693), new DateTime(2023, 8, 21, 20, 58, 51, 386, DateTimeKind.Local).AddTicks(6228), new DateTime(2024, 2, 23, 2, 29, 35, 415, DateTimeKind.Local).AddTicks(6256), 3, 9.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 1, 45, 44, 495, DateTimeKind.Local).AddTicks(620), new DateTime(2023, 8, 21, 18, 43, 53, 577, DateTimeKind.Local).AddTicks(6029), new DateTime(2023, 12, 24, 13, 54, 55, 697, DateTimeKind.Local).AddTicks(8308), 3, 2.0 });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 1, 46, 53, 83, DateTimeKind.Local).AddTicks(638), new DateTime(2023, 8, 21, 6, 19, 1, 255, DateTimeKind.Local).AddTicks(7209), new DateTime(2023, 9, 22, 0, 26, 18, 612, DateTimeKind.Local).AddTicks(4224), 6, 8.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 3, 28, 28, 686, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 8, 21, 1, 24, 55, 193, DateTimeKind.Local).AddTicks(4075), new DateTime(2024, 3, 3, 17, 54, 2, 265, DateTimeKind.Local).AddTicks(313), 6, 1.0, true });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix", "isPublic" },
                values: new object[] { new DateTime(2023, 8, 20, 16, 56, 55, 445, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 8, 21, 2, 58, 32, 551, DateTimeKind.Local).AddTicks(7997), new DateTime(2024, 4, 1, 23, 0, 38, 180, DateTimeKind.Local).AddTicks(8016), 6, 4.0, false });

            migrationBuilder.UpdateData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDebut", "DateFin", "IdVehicule", "Prix" },
                values: new object[] { new DateTime(2023, 8, 20, 7, 57, 59, 232, DateTimeKind.Local).AddTicks(2028), new DateTime(2023, 8, 21, 1, 33, 58, 867, DateTimeKind.Local).AddTicks(5087), new DateTime(2024, 6, 25, 19, 24, 39, 334, DateTimeKind.Local).AddTicks(3933), 8, 6.0 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 9, 4, 14, 646, DateTimeKind.Local).AddTicks(6237), new DateTime(2023, 8, 21, 15, 55, 59, 572, DateTimeKind.Local).AddTicks(2382), new DateTime(2024, 6, 30, 10, 34, 30, 540, DateTimeKind.Local).AddTicks(4204), 6, "1fdfed46-c7a9-400e-a9cb-c4e815184b8b", "Confirmé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 3, 30, 48, 355, DateTimeKind.Local).AddTicks(1741), new DateTime(2023, 8, 21, 16, 37, 22, 273, DateTimeKind.Local).AddTicks(2915), new DateTime(2023, 11, 19, 18, 17, 37, 581, DateTimeKind.Local).AddTicks(4606), 10, "1c71f826-68f4-4455-b272-eaf638ace731", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 10, 10, 23, 798, DateTimeKind.Local).AddTicks(4880), new DateTime(2023, 8, 21, 18, 52, 13, 517, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 12, 18, 14, 26, 0, 82, DateTimeKind.Local).AddTicks(5413), 8, "773212ac-560e-4984-8bf9-8b92692fcc74", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 18, 37, 30, 344, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 8, 21, 14, 13, 9, 971, DateTimeKind.Local).AddTicks(5206), new DateTime(2023, 11, 24, 16, 49, 15, 238, DateTimeKind.Local).AddTicks(3481), "d46adf9e-8814-4899-ad93-9b8c25875358", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 20, 0, 53, 45, 873, DateTimeKind.Local).AddTicks(3277), new DateTime(2023, 8, 21, 10, 24, 22, 333, DateTimeKind.Local).AddTicks(6375), new DateTime(2024, 5, 7, 3, 12, 48, 131, DateTimeKind.Local).AddTicks(1270), 6, "dbcb5932-7ade-4778-85f2-edd2e6e53910" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation" },
                values: new object[] { new DateTime(2023, 8, 20, 6, 41, 5, 521, DateTimeKind.Local).AddTicks(6697), new DateTime(2023, 8, 21, 20, 27, 46, 865, DateTimeKind.Local).AddTicks(8959), new DateTime(2024, 4, 29, 2, 12, 46, 416, DateTimeKind.Local).AddTicks(9048), 2, "46697912-3cf8-4d6c-9305-7cdfb45d49bd" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 20, 36, 10, 475, DateTimeKind.Local).AddTicks(7444), new DateTime(2023, 8, 21, 3, 46, 24, 996, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 2, 22, 13, 21, 29, 760, DateTimeKind.Local).AddTicks(5379), 10, "920f7ec7-9592-475a-8618-dfc9addd1fef", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 9, 38, 49, 984, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 8, 21, 0, 52, 10, 890, DateTimeKind.Local).AddTicks(8394), new DateTime(2023, 9, 13, 21, 7, 59, 797, DateTimeKind.Local).AddTicks(8335), 5, "289d4337-8610-4c71-846c-9f4de679ca17", "Annulé" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 5, 43, 18, 597, DateTimeKind.Local).AddTicks(1529), new DateTime(2023, 8, 21, 13, 56, 38, 291, DateTimeKind.Local).AddTicks(3194), new DateTime(2023, 12, 6, 21, 42, 11, 219, DateTimeKind.Local).AddTicks(2975), 10, "f7530e2d-aa18-4b08-8ed0-7f3676062e91", "Enattente" });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DateDepart", "DateRetour", "IdVehicule", "NumeroReservation", "Status" },
                values: new object[] { new DateTime(2023, 8, 20, 23, 35, 37, 388, DateTimeKind.Local).AddTicks(1684), new DateTime(2023, 8, 21, 23, 33, 11, 535, DateTimeKind.Local).AddTicks(552), new DateTime(2024, 7, 24, 23, 17, 15, 204, DateTimeKind.Local).AddTicks(460), 9, "5ca081e6-e0d5-4501-994b-cb0ca2d517fe", "Expiré" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 28, 23, 10, 56, 111, DateTimeKind.Local).AddTicks(8592), "Marjorie3@gmail.com", "Avis", false, "Emard", "$2a$11$ExGK1Hiv.Z8FlIXFICahCuRR6AGpI4QetpHGcEMQwmo0ANAH9FZdW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 26, 5, 15, 32, 466, DateTimeKind.Local).AddTicks(4114), "Braxton.Huel95@gmail.com", "Emelia", 7, false, "Stanton", "$2a$11$EuLA1RVblObl7LviIMSZLOwdX7.ov6PDpvwwJo5OVUaNkDGkZwVpe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 15, 2, 52, 11, 449, DateTimeKind.Local).AddTicks(5128), "Rodrick17@hotmail.com", "Angelo", 6, "Schiller", "$2a$11$x2n5UZabnhbbypBCiP7lHe3s/xEQcI8BLandjMBxq3nEHkJxDN9uy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 4, 21, 4, 43, 237, DateTimeKind.Local).AddTicks(2380), "Florence12@hotmail.com", "Zola", 6, "O'Kon", "$2a$11$O03pqqeVepqn9wPcIrkcOuySi/jN.thut9U/S/KZqgmqJBHvC.y7u" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 12, 0, 59, 37, 398, DateTimeKind.Local).AddTicks(872), "Zachary61@yahoo.com", "Zoey", 6, 2, true, "Larkin", "$2a$11$TiXoygOkmMf8.OMf.7yijezEkk5bgkIt/RSzOQNPF/mtwH.q9FMIW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 25, 15, 53, 36, 878, DateTimeKind.Local).AddTicks(135), "Cleta94@hotmail.com", "Odessa", 8, 1, true, "Shanahan", "$2a$11$kPSVwwtB6UHehxurMiMbY.120Ldr1ML5.uGreGQ.0rP7vVxdQOgCS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 28, 2, 21, 20, 652, DateTimeKind.Local).AddTicks(8404), "Audie.Anderson@hotmail.com", "Jessie", 3, 2, true, "Walker", "$2a$11$PGUxhJdLDxr9GVOK0I7.TOwaJQClv9KLKhrN4QxGWYCJuhPvB2mUO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 1, 19, 56, 57, 675, DateTimeKind.Local).AddTicks(8264), "Zoe51@hotmail.com", "Emmet", 2, "Bahringer", "$2a$11$JLhhpjPAbjyygqAEdoKROu5dD0jutSkDu7zLVWTvKcS/S76XhfWzK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 8, 17, 11, 28, 45, 855, DateTimeKind.Local).AddTicks(7004), "Dennis.Anderson@hotmail.com", "Sammie", 1, true, "Muller", "$2a$11$KUJW7pBOqJRqxSpWzN5buOe9GUJyT3BT8HRzJr0GVam7F0uR0W0qK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 14, 6, 39, 0, 30, DateTimeKind.Local).AddTicks(1562), "Mollie.Bradtke@gmail.com", "Manuela", 8, false, "Dooley", "$2a$11$YyGX.1lNyGh6jogY1DCoA.wt8n0OxDa5R334J9Jl6KFt6le2MGVX2" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 10, 7, 18, 13, 14, 211, DateTimeKind.Local).AddTicks(8819), "qvipfieddk", 9, 172, 1616, "hotvydttkm", "rirlryopfs", "ubmnhgxpbw", 5, 7.0, "lwmtzweyty" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2022, 12, 13, 18, 48, 12, 89, DateTimeKind.Local).AddTicks(3732), "pfcszqljqv", 5, 18, 648, "jrkewfzixf", "vwvdeivzse", "vnxdzboldi", 2, 1, 3.0, "bxihbyipyg" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 4, 14, 17, 16, 17, 791, DateTimeKind.Local).AddTicks(6585), "rosvtkynsx", 73, 6550, "velzlwkuwv", "nhboccwpfj", "jfwrsorxrn", 8, 4.0, "clftazkrif" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { new DateTime(2022, 11, 21, 11, 8, 53, 911, DateTimeKind.Local).AddTicks(2464), "flffdtlhae", 278, 516, "arlnoxlknp", "muucaeozow", "laymmfecfg", 2, 8, "hvjixbezgl" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Type" },
                values: new object[] { true, new DateTime(2022, 9, 12, 21, 16, 40, 726, DateTimeKind.Local).AddTicks(1050), "ueriqwncso", 6, 125, 3491, "cstguweppm", "ioeywgrvjc", "fblhsotdfl", 1, 1, "mrjcumeswl" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { new DateTime(2023, 1, 26, 9, 42, 1, 603, DateTimeKind.Local).AddTicks(333), "uadxwtxtmk", 1, 210, 5341, "mipbzuqulm", "upgeujaqkb", "bytkyicozk", 6, 9, 8.0, "owrvlcywif" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, new DateTime(2023, 5, 31, 23, 30, 3, 99, DateTimeKind.Local).AddTicks(8058), "mccurduolc", 104, 9838, "vmgxlaukwx", "fzhysyapot", "vnxdxydwod", 4, 2, 1.0, "vjktuvxlnh" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2023, 8, 20, 1, 17, 37, 924, DateTimeKind.Local).AddTicks(5494), "nvvvrhsgdy", 4, 148, 3170, "xtfevitwrq", "srcwwmtlol", "xmrlpqddlb", 7, 9, 7.0, "yyytgrhsny" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Airbag", "Climat", "CreatedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { true, true, new DateTime(2023, 3, 3, 2, 57, 6, 927, DateTimeKind.Local).AddTicks(4529), "wgsyblpayt", 3, 190, 1878, "deyssxqjgz", "vqgrshnnvr", "veppizrqef", 6, 2, 6.0, "mzqhipfuwb" });

            migrationBuilder.UpdateData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Airbag", "CreatedAt", "Gearbox", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type" },
                values: new object[] { false, new DateTime(2022, 11, 25, 20, 59, 49, 338, DateTimeKind.Local).AddTicks(4169), "imtnofruiz", 309, 47, "nlaulhtloq", "poknflunok", "vlqxlqrewv", 3, 3, 5.0, "hqysqaqejj" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 20, 2, 4, 45, 671, DateTimeKind.Local).AddTicks(3814), 28, "fskyvzpgat", "Predovic", 30, "Turner LLC", "Dayana", "1-370-513-2786", "Rippin", "West Adanmouth", "12269" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 30, 4, 14, 12, 274, DateTimeKind.Local).AddTicks(4569), 323, "szvxwpfotr", "Conn", 18, "Larkin and Sons", "Martine", "418-734-4926 x6216", "Runolfsdottir", "South Candacefort", "85336" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 24, 16, 8, 6, 564, DateTimeKind.Local).AddTicks(6235), 78, "typfjkllrs", "Stroman", 30, "Abernathy Group", "Heather", "511.653.2127 x274", "Carter", "Schinnerport", "39568" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 8, 0, 28, 27, 70, DateTimeKind.Local).AddTicks(1407), 224, "tfikdyypck", "Skiles", 32, "Hintz, Schmeler and Kemmer", "Mac", "575-283-4242 x66055", "Lynch", "Alfville", "22457-7585" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 1, 3, 40, 45, 226, DateTimeKind.Local).AddTicks(5619), 218, "zwhfrknqbd", "Franecki", "Lynch - Prosacco", "Keegan", "(647) 457-8672 x5869", "Wiza", "New Jamey", "92584" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 23, 13, 40, 24, 918, DateTimeKind.Local).AddTicks(1383), 72, "ddzolluifs", "Feest", 19, "Collins - Willms", "Yesenia", "(616) 662-2376", "Langworth", "Julianshire", "78019-0275" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 31, 5, 31, 55, 326, DateTimeKind.Local).AddTicks(7909), 185, "jregvvrlir", "Bartoletti", 22, "O'Conner - Carroll", "Russel", "320-754-5711 x6849", "Predovic", "East Percyland", "42293-3633" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 29, 23, 28, 28, 765, DateTimeKind.Local).AddTicks(7342), 23, "fmaulkkxii", "Bartell", 21, "Steuber Group", "Dameon", "284.315.1863 x0547", "Gusikowski", "Antwanburgh", "54661-4510" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 21, 17, 37, 15, 309, DateTimeKind.Local).AddTicks(8749), 179, "zmywprmibh", "Grant", 18, "Fadel and Sons", "Norval", "773-279-9710", "Kemmer", "Lake Erika", "06681-0677" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdModele", "NumeroReservation", "description", "duree", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 26, 2, 26, 23, 68, DateTimeKind.Local).AddTicks(6130), 285, "fyrauvngoo", "Leuschke", 31, "Dietrich and Sons", "Burley", "466.688.0418", "Buckridge", "New Mikefurt", "21309-5917" });
        }
    }
}
