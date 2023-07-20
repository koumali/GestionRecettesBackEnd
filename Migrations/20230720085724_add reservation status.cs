using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class addreservationstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Reservations",
                type: "longtext",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "0445 Wellington Parkways", "Emardbury", new DateTime(2022, 11, 1, 15, 17, 55, 349, DateTimeKind.Local).AddTicks(7440), "Ara.Schinner39@hotmail.com", -60.778399999999998, 48.852899999999998, "Human Branding Supervisor", "(449) 950-4294 x6980", "81689" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "766 Maggie Wall", "Kinghaven", new DateTime(2022, 9, 3, 2, 34, 8, 978, DateTimeKind.Local).AddTicks(6942), "Mariah64@hotmail.com", -33.176499999999997, 169.66489999999999, "Investor Factors Officer", "668.989.2987 x682", "34294" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "257 Dicki Turnpike", "Ryanhaven", new DateTime(2023, 4, 2, 21, 41, 25, 921, DateTimeKind.Local).AddTicks(5735), "Elisha93@hotmail.com", -74.825100000000006, -20.726099999999999, "Regional Mobility Strategist", "995.382.1856 x537", "34051" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1844 Keven Cape", "North Chandler", new DateTime(2022, 10, 24, 15, 5, 22, 579, DateTimeKind.Local).AddTicks(7706), "Celia_Miller32@gmail.com", -3.6095999999999999, 173.8854, "Lead Marketing Developer", "(248) 994-9686", "47057" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "53892 Macejkovic Street", "Nicolasmouth", new DateTime(2022, 10, 14, 18, 24, 23, 614, DateTimeKind.Local).AddTicks(6065), "Madilyn66@gmail.com", -78.401499999999999, -104.4246, "District Directives Orchestrator", "1-899-962-1265 x79245", "06974-9152" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "59226 Heller Cliffs", "Larissaview", new DateTime(2022, 8, 27, 17, 15, 45, 38, DateTimeKind.Local).AddTicks(8927), "Adrien.Spencer@gmail.com", -89.090699999999998, 56.706800000000001, "Corporate Functionality Director", "1-277-463-9570", "53557-4959" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "88010 Vicente Skyway", "Lakinville", new DateTime(2023, 1, 21, 19, 20, 34, 415, DateTimeKind.Local).AddTicks(7251), "Kane.Monahan@hotmail.com", 87.370900000000006, -56.964199999999998, "Direct Configuration Supervisor", "1-779-261-2752", "52507-3566" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "8398 Schoen Lodge", "Port Melissaberg", new DateTime(2022, 11, 4, 23, 19, 55, 746, DateTimeKind.Local).AddTicks(2396), "Jonas75@yahoo.com", -53.265599999999999, -151.2603, "Senior Group Planner", "540-639-6728 x650", "32907-6003" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "152 Cordia Springs", "East Isabellview", new DateTime(2023, 6, 13, 20, 22, 31, 864, DateTimeKind.Local).AddTicks(1821), "Brandy_Nolan48@hotmail.com", -47.644599999999997, 37.328000000000003, "National Accountability Planner", "1-974-232-2567 x92366", "80202-4340" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "06017 Hammes Villages", "Pietrostad", new DateTime(2023, 7, 11, 6, 27, 33, 96, DateTimeKind.Local).AddTicks(3688), "Mallie.Beier63@hotmail.com", 25.148499999999999, 121.9709, "Senior Mobility Consultant", "1-234-726-0065 x72870", "11854-6772" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 18, 16, 0, 23, 210, DateTimeKind.Local).AddTicks(5005), "Polestar" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 9, 25, 10, 41, 23, 384, DateTimeKind.Local).AddTicks(6217), "Mazda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 28, 21, 13, 6, 146, DateTimeKind.Local).AddTicks(2401), "Jeep" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 31, 3, 38, 23, 220, DateTimeKind.Local).AddTicks(8180), "Kia" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 2, 21, 16, 40, 25, 577, DateTimeKind.Local).AddTicks(2053), "Bugatti" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 3, 13, 23, 24, 9, 64, DateTimeKind.Local).AddTicks(6406), "Porsche" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 44, 36, 668, DateTimeKind.Local).AddTicks(6700), "Rolls Royce" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 18, 9, 27, 40, 12, DateTimeKind.Local).AddTicks(7885), "Rolls Royce" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 6, 8, 11, 18, 25, 353, DateTimeKind.Local).AddTicks(4129), "Honda" });

            migrationBuilder.UpdateData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 12, 16, 8, 1, 49, 792, DateTimeKind.Local).AddTicks(5482), "BMW" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 2, 23, 5, 33, 41, 97, DateTimeKind.Local).AddTicks(7897), 3, "https://picsum.photos/640/480/?image=721", "El Camino" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 7, 6, 5, 41, 27, 595, DateTimeKind.Local).AddTicks(8695), 2, "https://picsum.photos/640/480/?image=936", "Element" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 12, 11, 3, 8, 22, 8, DateTimeKind.Local).AddTicks(6015), 4, "https://picsum.photos/640/480/?image=131", "Model 3" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 12, 20, 4, 4, 1, 698, DateTimeKind.Local).AddTicks(5233), 7, "https://picsum.photos/640/480/?image=488", "Alpine" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 12, 28, 10, 14, 57, 524, DateTimeKind.Local).AddTicks(7708), 1, "https://picsum.photos/640/480/?image=49", "2" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 13, 22, 11, 13, 699, DateTimeKind.Local).AddTicks(4456), 4, "https://picsum.photos/640/480/?image=244", "Challenger" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 11, 10, 5, 47, 24, 761, DateTimeKind.Local).AddTicks(8707), 7, "https://picsum.photos/640/480/?image=200", "Taurus" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 4, 4, 4, 40, 40, 982, DateTimeKind.Local).AddTicks(3333), 8, "https://picsum.photos/640/480/?image=526", "Prius" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 4, 2, 10, 29, 7, 339, DateTimeKind.Local).AddTicks(165), 6, "https://picsum.photos/640/480/?image=1012", "LeBaron" });

            migrationBuilder.UpdateData(
                table: "Modeles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 3, 18, 2, 16, 8, 498, DateTimeKind.Local).AddTicks(1519), 10, "https://picsum.photos/640/480/?image=56", "Explorer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 6, 12, 33, 13, 801, DateTimeKind.Local).AddTicks(2143), "Deven_Reichert15@gmail.com", "Melany", 4, 2, false, "Murphy", "$2a$11$GViT07o2P.F1ugMqFOZjfeacl6THyDaBzIyrWP9hFIjTNU1s4jBAu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 14, 16, 0, 4, 491, DateTimeKind.Local).AddTicks(9955), "Benton77@yahoo.com", "Kaycee", 3, 2, "Beer", "$2a$11$F6N.A6z0QWN/YM4A9jYDq.Uidt7lSt0Z2gmo7LURjkpwsFImKjJoO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 14, 9, 58, 26, 278, DateTimeKind.Local).AddTicks(11), "Jennings_Christiansen6@yahoo.com", "Kenya", 10, 2, "Bauch", "$2a$11$8QLk0x7pdmvxZarHkKrxuuJB3snUQgEmf/3MIZZfCYIED07K5IvQC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 19, 1, 46, 18, 102, DateTimeKind.Local).AddTicks(5173), "Tara.Upton@hotmail.com", "Joy", 9, 1, true, "Windler", "$2a$11$8x8D6tmz935J.39IoNjsCO8ZZ28Wl5TrCIZn6BXuczoDdeSpy8KvW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 10, 11, 22, 51, 968, DateTimeKind.Local).AddTicks(9699), "Icie.McLaughlin@gmail.com", "Daija", 1, 1, "Funk", "$2a$11$FXAQ1TwIz84LlcJxUXCUeurjCRiDpUGQnRAH23GLoM5DthD3X9oVK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 7, 19, 5, 9, 23, 216, DateTimeKind.Local).AddTicks(1025), "Cheyanne84@hotmail.com", "Ross", 4, 4, "Boyer", "$2a$11$qQ1pC140z80omwqsxKtRfO2hbYJRd.W6xCPidmPxot5H6CMZpm1wu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 6, 5, 1, 39, 323, DateTimeKind.Local).AddTicks(8406), "Avis.Kiehn90@gmail.com", "Mercedes", 9, "Jakubowski", "$2a$11$mewwBGkk1SZt7nMqzyH.NO9Vsw537OO3w.xz/eoPhyOHVO18NUetS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 9, 29, 16, 12, 21, 930, DateTimeKind.Local).AddTicks(4863), "Thaddeus.Brakus28@hotmail.com", "Taylor", 5, 4, true, "Braun", "$2a$11$PkhkAc.QnbVTLNgTJZwL9.BS2dA5ry57mrd4Su8vdF2QnSIbNbgya" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 11, 9, 49, 57, 982, DateTimeKind.Local).AddTicks(773), "Jan.OHara@hotmail.com", "Pamela", 2, "Gerlach", "$2a$11$PKI2NBn1byzj1J3.hB4EnOi0d740l5Ad0ZxrV4QGYykWRjbHXeQje" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 4, 16, 3, 5, 5, DateTimeKind.Local).AddTicks(5001), "Tyreek_Bradtke1@hotmail.com", "Zachary", 6, 3, false, "Kutch", "$2a$11$a65kqUADhRs.y/kxCqTJAObGacfi1zeEXeIidrBpzJ0qpDl2YclOe" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 21, 6, 14, 41, 551, DateTimeKind.Local).AddTicks(6145), "Boyle", "Micah.Ferry92@gmail.com", "Kreiger, Grady and Kohler", "Roy", "463.657.0785", "Schmidt", "Irvingchester", "51172-8069" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 23, 21, 9, 52, 914, DateTimeKind.Local).AddTicks(3374), "Kuhic", "Malvina.Kutch@gmail.com", "Lehner, O'Kon and McDermott", "Erick", "697-860-8148 x7344", "Yundt", "West Holdenmouth", "69062-3382" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 11, 37, 867, DateTimeKind.Local).AddTicks(4976), "Bergstrom", "Obie_Herzog6@hotmail.com", "Schumm Inc", "Winona", "548.926.6884", "Fritsch", "Considineburgh", "37898" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 36, 43, 644, DateTimeKind.Local).AddTicks(9223), "McGlynn", "Shyanne92@yahoo.com", "Gerlach Group", "Sylvan", "1-814-658-5861", "Lebsack", "Carterstad", "19005" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 27, 13, 13, 12, 599, DateTimeKind.Local).AddTicks(4531), "Legros", "Jane53@hotmail.com", "Sauer - Hettinger", "Madonna", "463.223.9731 x787", "Bernier", "Einoborough", "71531-9460" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 11, 7, 25, 53, 889, DateTimeKind.Local).AddTicks(4133), "Moen", "Domenic.Mitchell@gmail.com", "Kiehn - Hilpert", "Berniece", "(951) 766-2999", "Windler", "Johnstonton", "80392" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 10, 16, 9, 9, 46, 210, DateTimeKind.Local).AddTicks(4215), "Jacobson", "Clemmie_Torp89@yahoo.com", "Senger, Hyatt and Wilkinson", "Gerry", "(283) 315-7153", "Donnelly", "Millstown", "24535-4842" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 9, 7, 6, 12, 670, DateTimeKind.Local).AddTicks(9168), "Upton", "Fay_Ritchie@hotmail.com", "Pagac Group", "Nels", "1-775-341-7315 x1274", "Howe", "Darlenemouth", "44108-2399" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 23, 17, 37, 14, 269, DateTimeKind.Local).AddTicks(1838), "White", "Jarret_McClure@hotmail.com", "Mosciski Group", "Jabari", "1-382-301-5104 x9851", "Connelly", "West Yasmine", "73821-9683" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 19, 20, 2, 4, 845, DateTimeKind.Local).AddTicks(9931), "Yost", "Raegan_Crona@hotmail.com", "Jacobi - Ferry", "Hadley", "719-709-1527 x56410", "Howell", "New Luzburgh", "12850-8674" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reservations");

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
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 4, 18, 41, 36, 490, DateTimeKind.Local).AddTicks(9384), 3, "https://picsum.photos/640/480/?image=537", "Malibu" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 8, 24, 13, 8, 10, 850, DateTimeKind.Local).AddTicks(7977), "Shaun_Runolfsdottir@hotmail.com", "Billie", 7, 1, "Balistreri", "$2a$11$z.Z2phh5Bq1t6PyI507sbut0e02doD4D8hhZCgt6LtR9ePgqG7Rni" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 3, 31, 440, DateTimeKind.Local).AddTicks(8556), "Maxwell_Ernser@hotmail.com", "Sherman", 7, 3, false, "MacGyver", "$2a$11$QoDkdwKMWJsEmI5hMkKDIOWbe3.0L1k/bvOg.WVEsJ72kXdyKkJNu" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 6, 16, 17, 51, 50, 491, DateTimeKind.Local).AddTicks(750), "Abagail.Weissnat42@gmail.com", "Jessy", 8, "Schulist", "$2a$11$8FviMiYT.MNMfdqJUiBsKO9xrOyABBmfOXgrc7buk.fNqhJTTvUD." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 12, 19, 43, 43, 455, DateTimeKind.Local).AddTicks(1162), "Dillon.Kub@hotmail.com", "Doug", 7, 1, false, "Pfeffer", "$2a$11$2lM46ODXvBYqjbb6Xv1GzuOxBeBrykbtPnYRBDoFSFfTiu/0Wb6DC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 12, 13, 19, 7, 319, DateTimeKind.Local).AddTicks(3625), "Jennings_Steuber@hotmail.com", "Rick", 3, "Marquardt", "$2a$11$T741uu.07DVTO3TRhhbixeNlQtsSbttZBCC0eLMbKGTJG7ocMcFw6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 30, 12, 39, 30, 860, DateTimeKind.Local).AddTicks(6018), "Aubrey_Wilkinson@yahoo.com", "Mohammed", 2, 4, true, "Rice", "$2a$11$E4UPohnGm1ftdnZWUxco/O2g2R3lIKsyvHy1OJnYAO2rCxtMoMZlu" });

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
    }
}
