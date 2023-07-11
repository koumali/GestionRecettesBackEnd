using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class added_ispublic_column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isPublic",
                table: "Offres",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "42357 Adams Way", "Chelseafort", new DateTime(2022, 9, 25, 1, 19, 23, 680, DateTimeKind.Local).AddTicks(6227), "Georgianna.Wisoky6@gmail.com", -41.988599999999998, -27.675000000000001, "Principal Group Assistant", "314-819-6083", "84552" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "9640 Trantow Meadow", "Konopelskifurt", new DateTime(2022, 8, 13, 8, 47, 54, 724, DateTimeKind.Local).AddTicks(8293), "Tianna86@hotmail.com", -54.637700000000002, 64.6203, "Forward Factors Strategist", "1-738-284-9963 x5442", "74382" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3564 Chester Plain", "East Albertfurt", new DateTime(2023, 3, 18, 18, 4, 12, 5, DateTimeKind.Local).AddTicks(9139), "Bertrand.Gutmann63@hotmail.com", 77.494900000000001, -19.206199999999999, "International Creative Specialist", "(545) 898-7688", "73125" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "28597 Turcotte Fall", "New Braxtonport", new DateTime(2023, 4, 16, 3, 53, 19, 976, DateTimeKind.Local).AddTicks(2191), "Ramona.Pacocha@gmail.com", 88.236400000000003, -156.1352, "Chief Identity Assistant", "(927) 527-3006", "50730-9532" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "80098 Olson Village", "Port Sheridanbury", new DateTime(2022, 8, 31, 1, 22, 28, 65, DateTimeKind.Local).AddTicks(5047), "Adelbert_Gerlach66@hotmail.com", 77.659099999999995, -34.9773, "Regional Data Analyst", "355.453.7251", "48280-9645" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1024 Vandervort Union", "East Hudson", new DateTime(2023, 4, 17, 9, 6, 12, 291, DateTimeKind.Local).AddTicks(6323), "Ignacio1@hotmail.com", -8.6000999999999994, -155.7364, "Internal Accounts Strategist", "730-460-6455", "80626-5256" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "24076 Wilderman Mission", "Rosenbaummouth", new DateTime(2023, 1, 3, 18, 51, 56, 722, DateTimeKind.Local).AddTicks(2245), "Lenore20@gmail.com", -37.361499999999999, -148.0334, "Internal Data Developer", "1-221-997-6310 x3215", "38389-6916" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "582 Schumm Flat", "Hackettburgh", new DateTime(2023, 5, 29, 1, 15, 0, 976, DateTimeKind.Local).AddTicks(5533), "Colleen_McClure47@yahoo.com", -89.906099999999995, -10.010899999999999, "Central Brand Orchestrator", "(481) 636-0398 x9194", "72350" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "166 Fausto Via", "Port Horacestad", new DateTime(2022, 9, 8, 15, 19, 25, 134, DateTimeKind.Local).AddTicks(3806), "Crawford38@yahoo.com", 54.662300000000002, -57.753500000000003, "Senior Brand Supervisor", "454-325-1666 x0253", "97108" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "889 Afton Ways", "South Aryanna", new DateTime(2022, 7, 11, 20, 54, 24, 361, DateTimeKind.Local).AddTicks(6700), "Cleve.Fay@yahoo.com", 54.5471, 90.205100000000002, "Principal Optimization Consultant", "(316) 964-7358 x1228", "98453-3417" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 1, 15, 56, 29, 139, DateTimeKind.Local).AddTicks(2967), "Honda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 17, 12, 45, 56, 861, DateTimeKind.Local).AddTicks(4707), "Dodge" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 15, 0, 17, 20, 932, DateTimeKind.Local).AddTicks(9197), "Cadillac" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 19, 17, 28, 0, 42, DateTimeKind.Local).AddTicks(3467), "Mercedes Benz" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 14, 11, 38, 56, 902, DateTimeKind.Local).AddTicks(6594), "Mazda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 23, 3, 0, 51, 370, DateTimeKind.Local).AddTicks(6959), "Volvo" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 23, 22, 36, 55, 965, DateTimeKind.Local).AddTicks(4061), "Dodge" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 15, 12, 50, 28, 78, DateTimeKind.Local).AddTicks(606), "Smart" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 19, 6, 44, 41, 2, DateTimeKind.Local).AddTicks(9135), "Lamborghini" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 21, 3, 59, 47, 541, DateTimeKind.Local).AddTicks(1803), "Ford" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 12, 9, 1, 48, 21, 374, DateTimeKind.Local).AddTicks(4461), 3, "CTS" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 4, 25, 15, 53, 50, 75, DateTimeKind.Local).AddTicks(2200), 10, "CTS" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 2, 22, 9, 35, 43, 565, DateTimeKind.Local).AddTicks(528), 9, "Beetle" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 25, 22, 36, 33, 233, DateTimeKind.Local).AddTicks(8708), "Element" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 1, 23, 2, 27, 47, 180, DateTimeKind.Local).AddTicks(5589), 3, "Civic" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 6, 1, 15, 47, 19, 256, DateTimeKind.Local).AddTicks(2390), 3, "Focus" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 2, 5, 8, 42, 21, 648, DateTimeKind.Local).AddTicks(3186), 4, "A4" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 7, 5, 10, 14, 50, 495, DateTimeKind.Local).AddTicks(3637), 1, "Spyder" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 6, 20, 14, 35, 31, 72, DateTimeKind.Local).AddTicks(6777), 2, "CX-9" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 2, 15, 22, 18, 59, 332, DateTimeKind.Local).AddTicks(5806), 9, "Aventador" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 29, 10, 56, 34, 585, DateTimeKind.Local).AddTicks(1686), "Nash_Kling52@hotmail.com", "Chaz", 9, 1, "Feest", "$2a$11$Fy1TVJB.BGkjRN1GWPsaX.9BqhfQT5Q53K0iQYOHRKbo1yR9h450m" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 14, 17, 10, 25, 267, DateTimeKind.Local).AddTicks(490), "Casper.Will@yahoo.com", "Jeffrey", 8, 2, "Schuster", "$2a$11$g6Gmc6TZ2Y1LMVhrYeJ4QeqJ92xwSGaLPLgU.tlTgxSRY76e4MZoi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 2, 33, 16, 913, DateTimeKind.Local).AddTicks(4135), "Oswald_Treutel65@hotmail.com", "Marilou", 9, 1, true, "Nader", "$2a$11$S.oUOLowbRREDmP4q9Q0O.xoCjjXtf2I5YbeWfA3d/zY6TOSNPesu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 17, 22, 5, 52, 145, DateTimeKind.Local).AddTicks(5260), "Verner_Murazik56@hotmail.com", "Richmond", 1, 3, "Bogisich", "$2a$11$mnWr6CeoJNsljdWn2sbb0.XtJ2SrF278YGOzwgLUhwI0yjpNXx4zi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 3, 18, 23, 8, 158, DateTimeKind.Local).AddTicks(3083), "Milton.Bradtke2@yahoo.com", "Dayna", 1, "Quigley", "$2a$11$EoCqGAlFig90z.oUsy4X9eeFL6g.zZmIQs0Rnn/mbfZr0gnWTaVhW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 21, 3, 40, 53, 55, DateTimeKind.Local).AddTicks(5560), "Annetta_Donnelly@hotmail.com", "Isabell", 5, 2, "Hegmann", "$2a$11$OSNDtsB.2fxzm.B0MkafWuyKchIk2dD7QEHlliQB1HMn0pBz99Pfy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 19, 7, 57, 40, 374, DateTimeKind.Local).AddTicks(8950), "Elna_Crist99@gmail.com", "Alva", 8, 4, "Windler", "$2a$11$elaZSQQ.LUNGI4tHITvx.usdqsoYMQ7LnOnK4YOkFB5dKV2ijIkGS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 1, 3, 3, 23, 841, DateTimeKind.Local).AddTicks(9832), "Esperanza83@yahoo.com", "Sam", 10, 4, "Farrell", "$2a$11$hPy9t5tby2RxRLwVYR.rSuexGWqwmzllqX/B7XsotTMRwhbv8lMym" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 4, 0, 42, 47, 105, DateTimeKind.Local).AddTicks(6377), "Amir.Abernathy14@hotmail.com", "Rod", 1, 4, true, "Krajcik", "$2a$11$t.Elvv4ANg0rSJAQ/ohGa.RwLsj8.FkwI/KbiYOoWm/1oJoSyZjNu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 23, 13, 13, 5, 419, DateTimeKind.Local).AddTicks(1999), "Crawford_Schuppe@gmail.com", "Camille", 4, false, "Wisozk", "$2a$11$29jyucECiIFiLhcul2ycJO/WjnCwwhCS6mPHYHxijB5M2sn1nGvnu" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isPublic",
                table: "Offres");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "79629 Oberbrunner Avenue", "North Gordon", new DateTime(2022, 12, 22, 14, 17, 52, 767, DateTimeKind.Local).AddTicks(7126), "Hester83@gmail.com", 47.193199999999997, -7.8311999999999999, "Central Division Administrator", "453-531-5494", "91781" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "788 Ottilie Isle", "Ortizfurt", new DateTime(2022, 12, 19, 23, 10, 37, 16, DateTimeKind.Local).AddTicks(8168), "Daron73@gmail.com", -43.854700000000001, -62.965499999999999, "Senior Brand Agent", "1-463-861-1675", "04133" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0414 Dayne Oval", "Vandervortland", new DateTime(2022, 11, 13, 6, 15, 28, 162, DateTimeKind.Local).AddTicks(3680), "Zita.Wolff59@hotmail.com", 8.7499000000000002, -82.788499999999999, "International Applications Producer", "678-904-0850 x03777", "36813-0200" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2856 Ryan Ridges", "South Rosanna", new DateTime(2023, 5, 22, 10, 43, 9, 687, DateTimeKind.Local).AddTicks(9412), "Jesse.Green60@hotmail.com", 89.936300000000003, 161.69290000000001, "Central Functionality Orchestrator", "257-391-0723", "71988-7227" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "552 Reilly Springs", "Rossiefort", new DateTime(2022, 7, 28, 16, 34, 18, 577, DateTimeKind.Local).AddTicks(7686), "Corrine92@gmail.com", -15.3253, 111.7672, "Global Interactions Analyst", "1-430-430-2458", "82811" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "8915 Strosin Vista", "West Reginaldview", new DateTime(2023, 1, 26, 10, 36, 59, 351, DateTimeKind.Local).AddTicks(4775), "Bert_Gerlach6@hotmail.com", 11.6127, -54.220700000000001, "Forward Mobility Planner", "(224) 667-0420 x3841", "18824" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0759 Marlene Burg", "Runtechester", new DateTime(2022, 12, 6, 8, 2, 26, 36, DateTimeKind.Local).AddTicks(8773), "Zane.Prohaska@gmail.com", 75.878799999999998, 14.2905, "Chief Directives Engineer", "633-811-4567 x51615", "52943" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "479 Cheyenne Cove", "Abigailborough", new DateTime(2022, 10, 22, 11, 17, 32, 755, DateTimeKind.Local).AddTicks(8925), "Damian.Bernier12@hotmail.com", -20.214700000000001, 33.482199999999999, "District Communications Specialist", "731-646-7323 x47982", "41704-8688" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3244 Johnathon Knolls", "Torpside", new DateTime(2022, 7, 26, 19, 12, 56, 663, DateTimeKind.Local).AddTicks(1916), "Nyasia99@hotmail.com", -52.965400000000002, 127.89790000000001, "Dynamic Data Engineer", "1-443-567-3739 x0840", "79166-0611" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "8494 Leffler Ways", "Lisettechester", new DateTime(2022, 8, 5, 4, 3, 9, 645, DateTimeKind.Local).AddTicks(5695), "Trevor.Brown54@yahoo.com", -75.372500000000002, -21.748200000000001, "District Operations Liaison", "985.456.3678", "91201-4489" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 30, 3, 50, 16, 892, DateTimeKind.Local).AddTicks(4327), "BMW" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 10, 20, 43, 29, 632, DateTimeKind.Local).AddTicks(9737), "Rolls Royce" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 29, 19, 7, 47, 477, DateTimeKind.Local).AddTicks(2022), "Mercedes Benz" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 29, 4, 54, 56, 530, DateTimeKind.Local).AddTicks(2958), "Smart" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 5, 16, 31, 33, 801, DateTimeKind.Local).AddTicks(7298), "Volvo" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 3, 7, 29, 8, 615, DateTimeKind.Local).AddTicks(4438), "Polestar" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 22, 22, 37, 45, 40, DateTimeKind.Local).AddTicks(7140), "BMW" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 28, 12, 22, 51, 431, DateTimeKind.Local).AddTicks(1757), "Ferrari" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 17, 19, 43, 32, 72, DateTimeKind.Local).AddTicks(1690), "Kia" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 2, 19, 2, 5, 34, 103, DateTimeKind.Local).AddTicks(4550), "Smart" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 4, 7, 10, 32, 19, 580, DateTimeKind.Local).AddTicks(7699), 5, "Corvette" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 5, 12, 14, 23, 22, 230, DateTimeKind.Local).AddTicks(4861), 4, "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 8, 22, 10, 9, 21, 490, DateTimeKind.Local).AddTicks(7367), 3, "Accord" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 2, 12, 5, 28, 20, 649, DateTimeKind.Local).AddTicks(2808), "Corvette" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 6, 13, 3, 19, 13, 701, DateTimeKind.Local).AddTicks(4978), 9, "Countach" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 9, 4, 9, 11, 23, 503, DateTimeKind.Local).AddTicks(766), 2, "Explorer" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2022, 9, 30, 7, 47, 29, 224, DateTimeKind.Local).AddTicks(8582), 2, "2" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 5, 10, 7, 5, 12, 395, DateTimeKind.Local).AddTicks(7790), 5, "Expedition" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 7, 4, 16, 56, 56, 839, DateTimeKind.Local).AddTicks(8075), 10, "911" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Name" },
                values: new object[] { new DateTime(2023, 4, 1, 13, 27, 54, 191, DateTimeKind.Local).AddTicks(2647), 8, "Wrangler" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 12, 6, 19, 19, 484, DateTimeKind.Local).AddTicks(7899), "Darrick.Swift@hotmail.com", "Kailee", 5, 4, "Kris", "$2a$11$KQFqoWGSF04NsMpLbtKtMuq93MGnMmJWk9qtcY/I2P.p9itVpOd5K" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 27, 1, 29, 40, 261, DateTimeKind.Local).AddTicks(1914), "Moriah.Collins@gmail.com", "Adelia", 2, 4, "Simonis", "$2a$11$61YmrWpHzTaWP7mJ3DB1TeX99jKOE.tgXg0lk.s4xx4NL.eVjGxsC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 7, 29, 3, 56, 40, 794, DateTimeKind.Local).AddTicks(57), "Alisha54@hotmail.com", "Destin", 10, 4, false, "Green", "$2a$11$9.6g2zMNKTSoD/yE6QHqpO4pd1ipSEU43LAdLbNTR0sApJEaojXGW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 18, 4, 47, 17, 216, DateTimeKind.Local).AddTicks(1845), "Misty73@gmail.com", "Rose", 7, 2, "Homenick", "$2a$11$GjtQldAb4V1q0HjaIoDBvuFhu5iMIbV2BVMDDFzxyThjokNLNBQGq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 16, 14, 52, 48, 390, DateTimeKind.Local).AddTicks(6925), "Melody26@hotmail.com", "Glenda", 4, "Rath", "$2a$11$YOP3jD31p39IED/wqRCJzeqMLPtfKTsOwWfGlVXUO9nzBT4nWmbzy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 10, 8, 46, 46, 121, DateTimeKind.Local).AddTicks(9544), "Yadira.VonRueden@gmail.com", "Jacklyn", 3, 4, "Berge", "$2a$11$73H1AL/wFkvBFNhuMdUEau95UzJejkqN3FlNVGl6TUYqslNMR0XVm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 20, 15, 0, 47, 266, DateTimeKind.Local).AddTicks(2028), "Laisha12@gmail.com", "Freddie", 4, 2, "Denesik", "$2a$11$T2hQPeemviYIIeqrHF2zTeC7gBUhz2jFGWJFlbT0Zlyg.diSMcfPy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 25, 1, 17, 39, 170, DateTimeKind.Local).AddTicks(4787), "Viviane_Hodkiewicz@hotmail.com", "Adelle", 2, 3, "Aufderhar", "$2a$11$afVivWzjIyAix9iEyi.YQ.rE9w3M2tWWtcqCBEqcH18gGkzsG2mvO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 4, 15, 28, 47, 596, DateTimeKind.Local).AddTicks(6402), "Evan.Kilback93@hotmail.com", "Anissa", 8, 3, false, "Rau", "$2a$11$5rYEy9lSCQvNYpahY1pyqOygQjjOS87/dEeFhm7qxJp5GtmLxX.gG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 7, 19, 0, 17, 5, 875, DateTimeKind.Local).AddTicks(9347), "Norwood_Frami45@yahoo.com", "Francesco", 2, true, "Daugherty", "$2a$11$oj47kJwhn6ZcQ8zPDzJEfuxDiCPL.tFO8Kc7PePo95k4NhgDX.que" });
        }
    }
}
