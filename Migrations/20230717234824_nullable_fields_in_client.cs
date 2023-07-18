using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class nullable_fields_in_client : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Ville",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "PermisVerso",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "PermisRecto",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Adresse2",
                table: "Clients",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Adresse",
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
                columns: new[] { "CreatedAt", "Image", "Name" },
                values: new object[] { new DateTime(2023, 1, 19, 2, 26, 57, 442, DateTimeKind.Local).AddTicks(8903), "https://picsum.photos/640/480/?image=749", "CX-9" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 12, 13, 18, 12, 423, DateTimeKind.Local).AddTicks(3915), "Jamil43@gmail.com", "Bernardo", 7, "Hartmann", "$2a$11$uwG4172EoyN/1jfr0W5Q1OMUbXvCTB2pwDaNyvLm6g7..DcmoBtja" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 27, 16, 32, 31, 619, DateTimeKind.Local).AddTicks(4060), "Kip.Johns60@hotmail.com", "Sonny", false, "Tremblay", "$2a$11$kEJSvadXHaex2JS9f3KUl.7rd8pGDU2Xlb.YYy.ZItYdUYmRON46G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 10, 5, 45, 35, 289, DateTimeKind.Local).AddTicks(3431), "Haylie.Padberg75@gmail.com", "Jerrold", 2, 4, "Green", "$2a$11$vmTlYYuxRPvR7iF5D/WBKOwRIgJv3UsLrJel4U6539RPs20i90wEW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 21, 9, 53, 43, 735, DateTimeKind.Local).AddTicks(4108), "Annabel_Schneider59@yahoo.com", "Scottie", 7, 4, "Conn", "$2a$11$KR3DDNOZ6DRwEYiTAQS8uOaIms4RaACuq5otlCJbmP6Fk/x3xHPWi" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 11, 12, 5, 8, 363, DateTimeKind.Local).AddTicks(8547), "Branson_Windler44@gmail.com", "Carter", 2, 4, true, "Swift", "$2a$11$H3AQqG.nJitsVmvlN2tIUegdIlvZ22Pyiy2KFGfd0ZFsjGgk9STAq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 22, 9, 666, DateTimeKind.Local).AddTicks(3944), "Jackeline95@hotmail.com", "Bobbie", 2, 3, "Erdman", "$2a$11$KqyXpTIUL6v2fZL/H.CV8.VbRqVItpb7wkEx0y3TjkrABHidzrKcO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 28, 16, 36, 21, 36, DateTimeKind.Local).AddTicks(7396), "Emil.Altenwerth57@gmail.com", "Ophelia", 1, 2, true, "Reichert", "$2a$11$ETq5EE2erlyzsdILQUs79.fRcT7TiaQB36TchPtmqAmWi8byS9r6G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 20, 6, 46, 5, 464, DateTimeKind.Local).AddTicks(9559), "Jaylin.Johnston51@gmail.com", "Nicolette", 4, 1, true, "Nienow", "$2a$11$cR1av.1IRraUz5x6RqeyAOaywWCfYmQ0Ch38DhAvnXpN9VLact8Ky" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Clients",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

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
                name: "PermisVerso",
                table: "Clients",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PermisRecto",
                table: "Clients",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adresse2",
                table: "Clients",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adresse",
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
                values: new object[] { "36346 Heidenreich Trail", "Mitchellville", new DateTime(2022, 9, 30, 10, 3, 27, 551, DateTimeKind.Local).AddTicks(8682), "Josephine_Vandervort21@hotmail.com", 57.352400000000003, -61.440199999999997, "Legacy Implementation Facilitator", "(916) 707-8241", "41634" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "42823 Hegmann Manors", "Gloverland", new DateTime(2023, 4, 17, 22, 7, 24, 103, DateTimeKind.Local).AddTicks(2048), "Pearl_Volkman@yahoo.com", -82.5334, -76.043400000000005, "Chief Accounts Associate", "976.852.8344 x5712", "30979" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "156 August Parkway", "Port Eltonside", new DateTime(2023, 4, 30, 9, 27, 36, 70, DateTimeKind.Local).AddTicks(9651), "Laverna.Zboncak@hotmail.com", 31.337700000000002, 140.00579999999999, "Dynamic Functionality Administrator", "1-970-416-8379 x3589", "40883" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3436 Maribel Plaza", "Uptonfurt", new DateTime(2023, 1, 21, 5, 13, 5, 168, DateTimeKind.Local).AddTicks(4495), "Rahul8@hotmail.com", 19.221499999999999, -175.23480000000001, "Regional Marketing Facilitator", "666-649-5784", "32997" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "006 Emmett Centers", "Wildermanshire", new DateTime(2022, 11, 27, 10, 7, 54, 330, DateTimeKind.Local).AddTicks(1034), "Vladimir39@hotmail.com", -82.410799999999995, 156.40799999999999, "Regional Functionality Planner", "384-237-2411 x12571", "06966" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "845 Alexanne Via", "Johanshire", new DateTime(2022, 10, 5, 16, 12, 34, 664, DateTimeKind.Local).AddTicks(7497), "Minnie1@yahoo.com", 9.5236999999999998, -23.294899999999998, "District Integration Strategist", "1-622-207-0889", "22907-2184" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "784 Hoppe Lock", "West Lamar", new DateTime(2022, 10, 12, 19, 33, 0, 258, DateTimeKind.Local).AddTicks(6636), "Zelda_Casper75@gmail.com", 87.396299999999997, -4.9683000000000002, "Dynamic Implementation Executive", "1-717-737-6686", "24097" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "3612 Harmon Land", "South Aryanna", new DateTime(2023, 2, 7, 15, 39, 22, 686, DateTimeKind.Local).AddTicks(6741), "Hailee41@gmail.com", 76.628399999999999, -81.446899999999999, "Future Applications Officer", "967-914-7336 x9765", "82195" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2010 Denis Squares", "East Willowside", new DateTime(2022, 11, 23, 21, 28, 22, 353, DateTimeKind.Local).AddTicks(2628), "Clifford.Treutel88@gmail.com", -77.353800000000007, -50.784599999999998, "District Web Officer", "1-501-297-4504", "18165" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "678 Adelbert Villages", "Uptonstad", new DateTime(2022, 11, 12, 4, 2, 37, 505, DateTimeKind.Local).AddTicks(9025), "Ole_Cronin@hotmail.com", -8.6935000000000002, -70.441599999999994, "Direct Web Orchestrator", "1-805-846-6846 x07216", "96189-7826" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 6, 14, 20, 2, 822, DateTimeKind.Local).AddTicks(299), "Hyundai" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 5, 11, 37, 21, 338, DateTimeKind.Local).AddTicks(2261), "Toyota" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 10, 18, 15, 23, 6, 379, DateTimeKind.Local).AddTicks(1490), "Chrysler" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 23, 11, 57, 6, 45, DateTimeKind.Local).AddTicks(6589), "Lamborghini" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 26, 13, 37, 17, 622, DateTimeKind.Local).AddTicks(2759), "Nissan" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 11, 12, 2, 51, 46, 258, DateTimeKind.Local).AddTicks(435), "Audi" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 38, 58, 981, DateTimeKind.Local).AddTicks(384), "Smart" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 27, 6, 32, 1, 797, DateTimeKind.Local).AddTicks(3090), "Mazda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 24, 17, 33, 23, 943, DateTimeKind.Local).AddTicks(6071), "Chevrolet" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 17, 7, 12, 41, 922, DateTimeKind.Local).AddTicks(5323), "Jeep" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 3, 18, 11, 13, 27, 544, DateTimeKind.Local).AddTicks(2571), 9, "https://picsum.photos/640/480/?image=477", "Accord" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 7, 4, 5, 39, 13, 553, DateTimeKind.Local).AddTicks(4917), 2, "https://picsum.photos/640/480/?image=57", "Golf" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 7, 26, 2, 17, 24, 651, DateTimeKind.Local).AddTicks(9559), 1, "https://picsum.photos/640/480/?image=423", "Spyder" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 11, 14, 2, 20, 31, 733, DateTimeKind.Local).AddTicks(4558), 3, "https://picsum.photos/640/480/?image=645", "V90" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 2, 16, 21, 21, 41, 262, DateTimeKind.Local).AddTicks(6091), 8, "https://picsum.photos/640/480/?image=297", "LeBaron" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Image", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 7, 30, 30, 423, DateTimeKind.Local).AddTicks(4879), "https://picsum.photos/640/480/?image=378", "Altima" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 6, 9, 11, 34, 14, 532, DateTimeKind.Local).AddTicks(1872), 4, "https://picsum.photos/640/480/?image=55", "Countach" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 55, 43, 294, DateTimeKind.Local).AddTicks(8131), 7, "https://picsum.photos/640/480/?image=785", "Element" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 5, 17, 16, 32, 52, 777, DateTimeKind.Local).AddTicks(4069), 6, "https://picsum.photos/640/480/?image=423", "Malibu" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 13, 23, 40, 25, 654, DateTimeKind.Local).AddTicks(8841), 7, "https://picsum.photos/640/480/?image=732", "CTS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 15, 23, 41, 57, 31, DateTimeKind.Local).AddTicks(9074), "Manuela_Hoppe@yahoo.com", "Morgan", 4, true, "Bahringer", "$2a$11$avNpB9AiinM.ZuAwEHCMSeFdGL/kE4oG/iyyk5x44dnbnthbEZJoW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 49, 59, 367, DateTimeKind.Local).AddTicks(5770), "Agustina32@hotmail.com", "Neha", 3, "Hayes", "$2a$11$OmHESyS139XaAfDas5z4auVpwRqS4lnOzGNzQTikqs5YjGEs.xige" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 9, 13, 31, 12, 418, DateTimeKind.Local).AddTicks(4099), "Victor_Veum2@hotmail.com", "Tyrel", true, "Feest", "$2a$11$LYUy2WxpiLzMqwa094QBa.dXCTp9N6JIDvpHWeZIf7pZXDIZRPFGS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 9, 7, 54, 7, 6, DateTimeKind.Local).AddTicks(4218), "Clint_Bahringer26@yahoo.com", "Anna", 7, 2, "Borer", "$2a$11$9rvuAAVoJ4WddpoXnm7eYuB.kd0bD/g1QaeNIltNDBfO3T9izOiTW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 8, 2, 34, 40, 385, DateTimeKind.Local).AddTicks(3840), "Thomas32@yahoo.com", "Tressa", 10, 3, "Quigley", "$2a$11$CC7ZslUdPh53MoA1fB7No.ifwZW5xeLPL8fL.sw0rBq5RHrmOqpGS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 25, 9, 4, 10, 855, DateTimeKind.Local).AddTicks(4556), "Frederic_Hintz@hotmail.com", "Kenyon", 4, 4, false, "Rippin", "$2a$11$1W466vVTdHe1BvScDZvKVuciL/IqAavgh2a69/nxlaXyTrnaMWbhe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 28, 12, 0, 29, 683, DateTimeKind.Local).AddTicks(8954), "Alverta.Powlowski@yahoo.com", "Juliana", 3, 3, false, "Wyman", "$2a$11$XPGqWKAr7xIPlLBX3cQhveJBdyfhGv320A0tPF6pi.PyoISFHMLb." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 23, 22, 23, 43, 237, DateTimeKind.Local).AddTicks(9366), "Tad.Schaefer@gmail.com", "Erica", 10, 4, "Conn", "$2a$11$FYwTP5xuBqQ8NSd3hS3vv.kHVnRMNPaWC2T5NF5nyS4jvSCkOcR9S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 3, 21, 0, 1, 557, DateTimeKind.Local).AddTicks(2501), "Maye17@gmail.com", "Sabina", 6, 1, false, "Heaney", "$2a$11$b66nuFO2oEm1wbJGgQ1a0uuau8m8aqnKjCvTPg/Sy5T.tXTKbkZoW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 19, 6, 54, 3, 8, DateTimeKind.Local).AddTicks(2328), "Lue.Will79@gmail.com", "Vinnie", 2, 3, false, "Cummings", "$2a$11$jlkjneHEMYLKGHWJALgZIuc0ZgtsVHi9WEGbh39Cy1HItd4AC2vwi" });
        }
    }
}
