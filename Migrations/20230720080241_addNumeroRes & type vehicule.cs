using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class addNumeroRestypevehicule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Vehicules",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "NumeroReservation",
                table: "Reservations",
                type: "longtext",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "02345 Buddy Extension", "Clemensside", new DateTime(2023, 3, 14, 16, 34, 44, 546, DateTimeKind.Local).AddTicks(5700), "Lia25@hotmail.com", -37.971699999999998, 134.755, "Regional Configuration Agent", "293-234-2937 x5445", "01803" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "097 Beverly Station", "East Leopold", new DateTime(2023, 3, 17, 13, 22, 2, 177, DateTimeKind.Local).AddTicks(4806), "Luisa_Kozey61@gmail.com", -83.804500000000004, 151.42060000000001, "Legacy Group Orchestrator", "1-754-968-6448", "18382" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "5243 Julian Creek", "Maureenbury", new DateTime(2022, 10, 30, 11, 16, 13, 896, DateTimeKind.Local).AddTicks(1760), "Malvina59@yahoo.com", 59.216799999999999, -31.1814, "Lead Functionality Coordinator", "(758) 951-4900 x9167", "33670" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "5163 Orie Unions", "West Verla", new DateTime(2023, 1, 9, 7, 54, 29, 209, DateTimeKind.Local).AddTicks(7360), "Eda_Bailey24@hotmail.com", -8.2265999999999995, 73.871799999999993, "Internal Accounts Agent", "233-288-4849", "79337" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0776 Victor Plaza", "Port Erik", new DateTime(2023, 1, 29, 8, 37, 15, 71, DateTimeKind.Local).AddTicks(329), "Alejandra_Medhurst@hotmail.com", 78.331900000000005, 7.6292, "Direct Accountability Director", "646-930-0876 x5618", "85288-2260" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3545 Delphine Junction", "North Torrey", new DateTime(2023, 1, 30, 0, 53, 46, 842, DateTimeKind.Local).AddTicks(5207), "April52@gmail.com", 70.183899999999994, 9.0546000000000006, "District Accountability Facilitator", "1-402-416-9521", "59220-2959" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "80637 Hayley Mill", "Lake Eunamouth", new DateTime(2023, 2, 5, 10, 31, 38, 948, DateTimeKind.Local).AddTicks(1332), "Clotilde.Hagenes89@hotmail.com", 8.4265000000000008, -54.054699999999997, "Human Usability Planner", "741-501-2137 x1676", "03951-4989" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "7223 Bartell Canyon", "Sylvestershire", new DateTime(2023, 7, 17, 22, 38, 14, 581, DateTimeKind.Local).AddTicks(2727), "Marge_Feest@yahoo.com", 36.812199999999997, 7.6092000000000004, "District Branding Specialist", "759-328-2306 x20505", "20119-9575" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "342 Velma Roads", "North Rickport", new DateTime(2023, 3, 8, 21, 25, 9, 260, DateTimeKind.Local).AddTicks(7481), "Jacynthe_Monahan@hotmail.com", 5.7934999999999999, 82.649199999999993, "Internal Functionality Architect", "1-856-750-5839 x93104", "56385-8813" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "294 Mylene Pines", "New Lysanneberg", new DateTime(2023, 2, 6, 17, 58, 12, 854, DateTimeKind.Local).AddTicks(9089), "Rashad.Farrell@yahoo.com", -54.098300000000002, 69.399500000000003, "Senior Assurance Executive", "717.830.2784", "98119-2655" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 11, 6, 55, 10, 551, DateTimeKind.Local).AddTicks(4309), "Fiat" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 22, 10, 21, 12, 750, DateTimeKind.Local).AddTicks(5972), "Dodge" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 9, 18, 13, 4, 297, DateTimeKind.Local), "Aston Martin" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 18, 8, 47, 5, 246, DateTimeKind.Local).AddTicks(5985), "Lamborghini" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 2, 17, 46, 15, 240, DateTimeKind.Local).AddTicks(1912), "Jeep" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 5, 13, 9, 46, 261, DateTimeKind.Local).AddTicks(2584), "Mini" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 20, 11, 40, 43, 194, DateTimeKind.Local).AddTicks(5733), "Chevrolet" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 3, 0, 25, 33, 701, DateTimeKind.Local).AddTicks(5178), "Cadillac" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 22, 15, 43, 17, 535, DateTimeKind.Local).AddTicks(2524), "Maserati" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 2, 15, 17, 52, 47, 389, DateTimeKind.Local).AddTicks(8973), "Dodge" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 8, 21, 11, 16, 55, 426, DateTimeKind.Local).AddTicks(5891), 6, "https://picsum.photos/640/480/?image=953", "Grand Caravan" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 4, 18, 41, 36, 490, DateTimeKind.Local).AddTicks(9384), "https://picsum.photos/640/480/?image=537", "Malibu" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 3, 16, 1, 56, 29, 453, DateTimeKind.Local).AddTicks(3523), 9, "https://picsum.photos/640/480/?image=381", "Aventador" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 16, 16, 36, 20, 194, DateTimeKind.Local).AddTicks(2677), 9, "https://picsum.photos/640/480/?image=795", "F-150" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 27, 7, 57, 55, 93, DateTimeKind.Local).AddTicks(7378), 10, "https://picsum.photos/640/480/?image=916", "Camaro" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 4, 7, 9, 51, 42, 626, DateTimeKind.Local).AddTicks(9310), 7, "https://picsum.photos/640/480/?image=298", "Wrangler" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 11, 12, 23, 44, 26, 40, DateTimeKind.Local).AddTicks(638), 8, "https://picsum.photos/640/480/?image=486", "Roadster" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 9, 14, 15, 11, 45, 710, DateTimeKind.Local).AddTicks(6037), 3, "https://picsum.photos/640/480/?image=922", "Grand Cherokee" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 4, 6, 18, 41, 13, 426, DateTimeKind.Local).AddTicks(7249), 2, "https://picsum.photos/640/480/?image=981", "Challenger" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 6, 12, 13, 36, 39, 396, DateTimeKind.Local).AddTicks(872), 9, "https://picsum.photos/640/480/?image=974", "2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 9, 14, 19, 43, 967, DateTimeKind.Local).AddTicks(1026), "Gerhard.Schultz@yahoo.com", "Kayla", 2, 3, true, "Schumm", "$2a$11$3Dxrn7UFpn.Z8t7Xcg.tEe9ku9s6NrFNWZ.b22FU0jt1A22eFHLOK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 13, 3, 35, 31, 620, DateTimeKind.Local).AddTicks(817), "Justina84@yahoo.com", "Duncan", 10, 4, "Littel", "$2a$11$Bgd89CI5tJlxm92C7ZQqOe9jFLHs.Tbph54bVy3zdM7GjTxdFh5Ie" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 24, 13, 8, 10, 850, DateTimeKind.Local).AddTicks(7977), "Shaun_Runolfsdottir@hotmail.com", "Billie", 7, true, "Balistreri", "$2a$11$z.Z2phh5Bq1t6PyI507sbut0e02doD4D8hhZCgt6LtR9ePgqG7Rni" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 3, 31, 440, DateTimeKind.Local).AddTicks(8556), "Maxwell_Ernser@hotmail.com", "Sherman", false, "MacGyver", "$2a$11$QoDkdwKMWJsEmI5hMkKDIOWbe3.0L1k/bvOg.WVEsJ72kXdyKkJNu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 5, 23, 15, 57, 482, DateTimeKind.Local).AddTicks(6911), "Nathanael_Runolfsdottir79@yahoo.com", "Pinkie", 6, 4, "Weissnat", "$2a$11$oNPKaw7b2lwR.8QXi.L0NuvKcz2NuiUSGNRclPyrtGgg5BOVFpwaO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 29, 7, 37, 2, 821, DateTimeKind.Local).AddTicks(6810), "Sabrina.Hane@hotmail.com", "Jacinto", 3, 1, "Schuppe", "$2a$11$GcVMqKTT/xWprrlobH/ecezjL8wtJk644gF7MRqpszknXTlzZyi0G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 16, 17, 51, 50, 491, DateTimeKind.Local).AddTicks(750), "Abagail.Weissnat42@gmail.com", "Jessy", 8, 2, false, "Schulist", "$2a$11$8FviMiYT.MNMfdqJUiBsKO9xrOyABBmfOXgrc7buk.fNqhJTTvUD." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 12, 19, 43, 43, 455, DateTimeKind.Local).AddTicks(1162), "Dillon.Kub@hotmail.com", "Doug", 7, false, "Pfeffer", "$2a$11$2lM46ODXvBYqjbb6Xv1GzuOxBeBrykbtPnYRBDoFSFfTiu/0Wb6DC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 19, 7, 319, DateTimeKind.Local).AddTicks(3625), "Jennings_Steuber@hotmail.com", "Rick", "Marquardt", "$2a$11$T741uu.07DVTO3TRhhbixeNlQtsSbttZBCC0eLMbKGTJG7ocMcFw6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 30, 12, 39, 30, 860, DateTimeKind.Local).AddTicks(6018), "Aubrey_Wilkinson@yahoo.com", "Mohammed", 2, 4, "Rice", "$2a$11$E4UPohnGm1ftdnZWUxco/O2g2R3lIKsyvHy1OJnYAO2rCxtMoMZlu" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 21, 8, 10, 57, 101, DateTimeKind.Local).AddTicks(7290), "Glover", "Rae_Bayer42@gmail.com", "Fay LLC", "Taylor", "492.244.0405", "Kozey", "Ottoborough", "38664-0623" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 48, 32, 968, DateTimeKind.Local).AddTicks(5158), "Hartmann", "Katharina_Sipes0@yahoo.com", "Luettgen LLC", "Ben", "(425) 329-4223 x96935", "Douglas", "East Nickolas", "08226-9278" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 3, 7, 39, 47, 820, DateTimeKind.Local).AddTicks(8611), "Considine", "Katarina.Ortiz86@yahoo.com", "Hayes - Thiel", "Emilie", "(205) 391-9377", "Crooks", "Shakiraborough", "85837-3327" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 29, 1, 40, 29, 909, DateTimeKind.Local).AddTicks(193), "Kiehn", "Gus37@gmail.com", "Quigley Inc", "Nona", "(447) 568-6477 x4561", "Ryan", "Pourosberg", "14920" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 30, 19, 43, 44, 75, DateTimeKind.Local).AddTicks(1455), "Toy", "Emory.Gleichner@gmail.com", "Altenwerth, Wyman and Kuhn", "Jason", "(374) 752-4846 x71682", "Nolan", "Yundthaven", "41601" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 23, 1, 7, 18, 994, DateTimeKind.Local).AddTicks(4191), "Kunde", "Aiden11@yahoo.com", "Kreiger and Sons", "Daphney", "(410) 684-2195 x867", "Emmerich", "West Jamel", "94849-6659" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 9, 23, 3, 21, 614, DateTimeKind.Local).AddTicks(6747), "Kutch", "Rae_Padberg12@gmail.com", "Kirlin and Sons", "Paris", "1-581-266-2234", "Kuvalis", "Adamschester", "66607" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 8, 0, 25, 52, 988, DateTimeKind.Local).AddTicks(2997), "O'Hara", "Tanya23@yahoo.com", "Kemmer Inc", "Kristopher", "(571) 896-8724", "Bradtke", "Lake Karen", "97210" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 28, 27, 294, DateTimeKind.Local).AddTicks(5965), "Hickle", "Osvaldo34@yahoo.com", "Williamson, Russel and Donnelly", "Kurt", "(644) 449-7704 x13595", "Stokes", "Granthaven", "75187-1573" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 28, 21, 48, 11, 598, DateTimeKind.Local).AddTicks(4793), "Morissette", "Clair44@gmail.com", "Runolfsdottir - Kuhlman", "Elza", "567.659.6766 x183", "Rempel", "Karianemouth", "65130-6902" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Vehicules");

            migrationBuilder.DropColumn(
                name: "NumeroReservation",
                table: "Reservations");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "25444 Fay Branch", "Elizachester", new DateTime(2022, 8, 27, 9, 25, 1, 654, DateTimeKind.Local).AddTicks(4410), "Aurelia.Wisozk@hotmail.com", -55.760300000000001, 29.863099999999999, "Senior Usability Engineer", "679.929.1547", "50997" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "20666 Dicki Lights", "Bogantown", new DateTime(2022, 9, 25, 16, 49, 18, 623, DateTimeKind.Local).AddTicks(1404), "Kurtis_OHara@hotmail.com", 22.901299999999999, 177.05680000000001, "National Optimization Designer", "(769) 938-7457 x251", "57782" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "5945 Frederic Rest", "Port Mariafurt", new DateTime(2023, 1, 16, 1, 0, 49, 713, DateTimeKind.Local).AddTicks(2664), "Norris_Schiller69@yahoo.com", -12.9749, -106.277, "Central Applications Officer", "352.839.4837", "51916-9450" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "81434 Kennith Track", "Port Terrencemouth", new DateTime(2022, 11, 17, 5, 55, 26, 721, DateTimeKind.Local).AddTicks(2571), "Nia82@hotmail.com", 21.6648, 84.4392, "Forward Paradigm Director", "865.779.9934 x425", "64261" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "27271 Stehr Island", "Sporerland", new DateTime(2023, 5, 12, 13, 56, 51, 656, DateTimeKind.Local).AddTicks(9757), "Thad.Lakin47@hotmail.com", -74.077299999999994, 83.936999999999998, "Senior Program Specialist", "754-449-8481 x81848", "14492-2546" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "415 Ratke Squares", "New Tierra", new DateTime(2023, 4, 14, 17, 50, 17, 668, DateTimeKind.Local).AddTicks(6213), "Amani_Dooley@yahoo.com", -11.2212, 104.7272, "Global Program Consultant", "474-829-0478 x897", "43834-3285" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "872 Ocie Forges", "North Elisaton", new DateTime(2023, 2, 22, 4, 19, 4, 62, DateTimeKind.Local).AddTicks(1372), "Ramona95@yahoo.com", -48.526200000000003, 172.899, "Senior Accountability Analyst", "(366) 730-0601", "09196" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "41763 Lauryn Bypass", "Christiansenshire", new DateTime(2022, 11, 18, 1, 16, 51, 392, DateTimeKind.Local).AddTicks(674), "Broderick.Mann@yahoo.com", 18.828199999999999, 17.020299999999999, "Dynamic Integration Executive", "(982) 658-7116 x55455", "98818-9897" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "768 Rodrigo Pine", "East Emil", new DateTime(2022, 9, 25, 12, 42, 53, 521, DateTimeKind.Local).AddTicks(8047), "Georgianna.OConnell51@yahoo.com", -55.349899999999998, 105.9289, "Investor Factors Developer", "(518) 384-2569", "03797-8792" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "448 VonRueden Parkway", "New Anabelle", new DateTime(2022, 12, 7, 15, 56, 42, 776, DateTimeKind.Local).AddTicks(7062), "Ray87@yahoo.com", -26.860700000000001, -161.87450000000001, "Regional Marketing Technician", "1-413-637-2288", "53313" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 2, 4, 52, 3, 913, DateTimeKind.Local).AddTicks(3290), "Mini" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 2, 4, 32, 7, 67, DateTimeKind.Local).AddTicks(4145), "BMW" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 4, 14, 52, 16, 518, DateTimeKind.Local).AddTicks(939), "Ferrari" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 19, 21, 36, 43, 833, DateTimeKind.Local).AddTicks(4951), "Jaguar" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 19, 12, 10, 11, 98, DateTimeKind.Local).AddTicks(6732), "Polestar" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 11, 8, 38, 22, 530, DateTimeKind.Local).AddTicks(6043), "Ford" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 10, 13, 50, 59, 904, DateTimeKind.Local).AddTicks(5284), "Hyundai" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 2, 14, 5, 50, 46, 847, DateTimeKind.Local).AddTicks(7774), "Mercedes Benz" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 24, 5, 58, 30, 584, DateTimeKind.Local).AddTicks(2601), "Kia" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 4, 7, 37, 45, 998, DateTimeKind.Local).AddTicks(3370), "Smart" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 9, 24, 6, 54, 57, 33, DateTimeKind.Local).AddTicks(1712), 9, "https://picsum.photos/640/480/?image=889", "Challenger" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Image", "Name" },
                values: new object[] { new DateTime(2023, 5, 9, 11, 4, 50, 862, DateTimeKind.Local).AddTicks(2687), "https://picsum.photos/640/480/?image=575", "Model T" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 8, 17, 19, 57, 55, 183, DateTimeKind.Local).AddTicks(9951), 1, "https://picsum.photos/640/480/?image=349", "Focus" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 1, 3, 1, 18, 19, 215, DateTimeKind.Local).AddTicks(3173), 6, "https://picsum.photos/640/480/?image=364", "XC90" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 9, 26, 15, 4, 13, 243, DateTimeKind.Local).AddTicks(9727), 8, "https://picsum.photos/640/480/?image=587", "Mustang" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 9, 10, 5, 4, 52, 200, DateTimeKind.Local).AddTicks(7034), 9, "https://picsum.photos/640/480/?image=372", "Grand Cherokee" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 22, 5, 22, 30, 501, DateTimeKind.Local).AddTicks(7361), 10, "https://picsum.photos/640/480/?image=870", "Focus" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 23, 7, 20, 48, 448, DateTimeKind.Local).AddTicks(453), 5, "https://picsum.photos/640/480/?image=151", "Fortwo" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 6, 5, 19, 45, 2, 257, DateTimeKind.Local).AddTicks(3610), 8, "https://picsum.photos/640/480/?image=19", "Sentra" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 9, 25, 19, 17, 46, 95, DateTimeKind.Local).AddTicks(9092), 2, "https://picsum.photos/640/480/?image=188", "Colorado" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 3, 14, 21, 50, 722, DateTimeKind.Local).AddTicks(3246), "Merle_Nitzsche@yahoo.com", "Francesca", 10, 1, false, "Kuhlman", "$2a$11$lYJ51LGmWiLOTOA5EV6xYu2yEpAGtoaZYa46IoGrfB84cBW5KVZlG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 22, 14, 15, 29, 456, DateTimeKind.Local).AddTicks(5675), "Eliane.Beer@gmail.com", "Leonard", 7, 3, "Treutel", "$2a$11$uMBJwhYaK3YBX.g7t2tZsOlWOF/2ATGSuy2lsLPMv4cX0n7fa60Eu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 2, 22, 26, 31, 452, DateTimeKind.Local).AddTicks(6812), "Maudie.Corwin19@gmail.com", "Terry", 9, false, "Erdman", "$2a$11$FGfbcy6nVSmYiDKcafuUlOi5Oqk8qLNaG3YK7aIFey1eN3MFNuocu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 1, 1, 23, 8, 801, DateTimeKind.Local).AddTicks(1438), "Sabrina_Murray87@gmail.com", "Cydney", true, "Schuster", "$2a$11$d7BekGMIu3LJAuZ1TY.JDOwz/2HK6ubCH3sUpwanFmednYSOwvG3e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 2, 9, 16, 23, 439, DateTimeKind.Local).AddTicks(9114), "Jarrett91@yahoo.com", "Dallin", 4, 2, "Rutherford", "$2a$11$4aOhxaHVccKtjfuN8d0Sb.swJNFM4gAxQkJ2wTRusdcSrVB0x.iKu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 29, 11, 17, 43, 742, DateTimeKind.Local).AddTicks(3711), "Flavie_Erdman@yahoo.com", "Ariel", 8, 4, "Klocko", "$2a$11$WhUNSxpngBclRn/VlN82Murp/PEnvfA/RgdOJ/O9kMVQ./wlKFwsW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 11, 10, 43, 10, 552, DateTimeKind.Local).AddTicks(389), "Clementine95@hotmail.com", "Bianka", 1, 3, true, "Weber", "$2a$11$zn/bgJJFFtxuiFQvWwVJier70S63.1hmx47.RTVWbhxxoYkac4D3W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 29, 22, 22, 16, 502, DateTimeKind.Local).AddTicks(3017), "Laverne.Flatley@hotmail.com", "Keanu", 9, true, "Emmerich", "$2a$11$jkA9zmuLHlv2.JeP4hJbHOSCk7VchYCeSAmrGS5NC6qef1H8Foymq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 21, 13, 2, 12, 957, DateTimeKind.Local).AddTicks(7921), "Juston.Bartell87@hotmail.com", "Elaina", "Lueilwitz", "$2a$11$r9T.NX78MQiSkUh1Ozkj2uEbJUeYcLBq7xmWDctPlw7Xx790Jpqyi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 17, 16, 47, 37, 71, DateTimeKind.Local).AddTicks(914), "Colten52@yahoo.com", "Ahmed", 4, 3, "Cremin", "$2a$11$urH8f8wQmF9U8wGu1zyKTOr9qRKk4XLEQlCV7Oj3/ZoT4NrhW7beu" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 17, 5, 14, 9, 227, DateTimeKind.Local).AddTicks(2345), "White", "Otis.Prosacco57@hotmail.com", "Blanda - Walter", "Nels", "(590) 818-5604", "Pagac", "Lake Jesusburgh", "58928" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 8, 21, 2, 17, 988, DateTimeKind.Local).AddTicks(2657), "Harber", "Buddy_Williamson@yahoo.com", "Toy - Roob", "Tremaine", "468-562-0871", "VonRueden", "Titomouth", "06262-9958" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 10, 20, 22, 58, 796, DateTimeKind.Local).AddTicks(8670), "Sawayn", "Richie_Bayer@gmail.com", "O'Keefe and Sons", "Frederick", "933-233-3901 x6126", "Wolff", "Port Jaydetown", "74010-2732" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 7, 24, 20, 10, 36, 154, DateTimeKind.Local).AddTicks(7717), "Dooley", "Neha49@hotmail.com", "Witting, Stroman and Mueller", "Ivory", "(934) 516-1672", "Witting", "Dickensburgh", "60364" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 6, 1, 10, 21, 79, DateTimeKind.Local).AddTicks(9695), "Schamberger", "Monroe49@hotmail.com", "Hartmann - Grady", "Maxwell", "211-247-9966", "Koch", "New Maggiemouth", "94305" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 20, 19, 26, 6, 844, DateTimeKind.Local).AddTicks(7219), "Bechtelar", "Haley94@hotmail.com", "Gaylord and Sons", "Haley", "551.418.4030 x73881", "Murray", "West Hipolitotown", "06311-4891" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 19, 5, 0, 40, 189, DateTimeKind.Local).AddTicks(9770), "Wintheiser", "Daniella.Ruecker@yahoo.com", "McGlynn, Kerluke and Satterfield", "Halie", "919-995-1789", "Keebler", "Claymouth", "08507" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 19, 17, 1, 38, 660, DateTimeKind.Local).AddTicks(8534), "Rutherford", "Nicolas_Stoltenberg@hotmail.com", "Reynolds - Swaniawski", "Ubaldo", "418.311.7533", "Mayert", "Bartonhaven", "06074" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 25, 13, 11, 43, 656, DateTimeKind.Local).AddTicks(2182), "Cole", "Raul34@gmail.com", "Hodkiewicz - Hyatt", "Malcolm", "649-404-1676", "Hirthe", "East Carolanne", "78112-9669" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 13, 6, 0, 36, 510, DateTimeKind.Local).AddTicks(5366), "Kessler", "Floy_Christiansen@gmail.com", "Legros - Blick", "Maci", "539.755.9221", "Schmitt", "Maeganbury", "13609-5128" });
        }
    }
}
