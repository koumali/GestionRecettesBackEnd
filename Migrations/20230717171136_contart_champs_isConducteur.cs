using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class contart_champs_isConducteur : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConducteur",
                table: "Contrats",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedAt", "IdMarque", "Image", "Name" },
                values: new object[] { new DateTime(2023, 4, 24, 7, 30, 30, 423, DateTimeKind.Local).AddTicks(4879), 3, "https://picsum.photos/640/480/?image=378", "Altima" });

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
                columns: new[] { "CreatedAt", "Image", "Name" },
                values: new object[] { new DateTime(2023, 6, 27, 13, 55, 43, 294, DateTimeKind.Local).AddTicks(8131), "https://picsum.photos/640/480/?image=785", "Element" });

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
                columns: new[] { "CreatedAt", "IdMarque", "Image" },
                values: new object[] { new DateTime(2022, 10, 13, 23, 40, 25, 654, DateTimeKind.Local).AddTicks(8841), 7, "https://picsum.photos/640/480/?image=732" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 11, 15, 23, 41, 57, 31, DateTimeKind.Local).AddTicks(9074), "Manuela_Hoppe@yahoo.com", "Morgan", 4, 4, true, "Bahringer", "$2a$11$avNpB9AiinM.ZuAwEHCMSeFdGL/kE4oG/iyyk5x44dnbnthbEZJoW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 49, 59, 367, DateTimeKind.Local).AddTicks(5770), "Agustina32@hotmail.com", "Neha", 3, 2, "Hayes", "$2a$11$OmHESyS139XaAfDas5z4auVpwRqS4lnOzGNzQTikqs5YjGEs.xige" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 9, 13, 31, 12, 418, DateTimeKind.Local).AddTicks(4099), "Victor_Veum2@hotmail.com", "Tyrel", 7, 3, true, "Feest", "$2a$11$LYUy2WxpiLzMqwa094QBa.dXCTp9N6JIDvpHWeZIf7pZXDIZRPFGS" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 8, 2, 34, 40, 385, DateTimeKind.Local).AddTicks(3840), "Thomas32@yahoo.com", "Tressa", 10, 3, false, "Quigley", "$2a$11$CC7ZslUdPh53MoA1fB7No.ifwZW5xeLPL8fL.sw0rBq5RHrmOqpGS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 25, 9, 4, 10, 855, DateTimeKind.Local).AddTicks(4556), "Frederic_Hintz@hotmail.com", "Kenyon", 4, false, "Rippin", "$2a$11$1W466vVTdHe1BvScDZvKVuciL/IqAavgh2a69/nxlaXyTrnaMWbhe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 28, 12, 0, 29, 683, DateTimeKind.Local).AddTicks(8954), "Alverta.Powlowski@yahoo.com", "Juliana", 3, 3, "Wyman", "$2a$11$XPGqWKAr7xIPlLBX3cQhveJBdyfhGv320A0tPF6pi.PyoISFHMLb." });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConducteur",
                table: "Contrats");

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
                columns: new[] { "CreatedAt", "Image", "Name" },
                values: new object[] { new DateTime(2022, 10, 6, 12, 33, 29, 907, DateTimeKind.Local).AddTicks(3615), "https://picsum.photos/640/480/?image=360", "Camry" });

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
                columns: new[] { "CreatedAt", "IdMarque", "Image" },
                values: new object[] { new DateTime(2022, 12, 3, 3, 21, 55, 820, DateTimeKind.Local).AddTicks(2993), 6, "https://picsum.photos/640/480/?image=53" });

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
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 12, 16, 46, 51, 359, DateTimeKind.Local).AddTicks(9340), "Aurelio_Cummerata@yahoo.com", "Linwood", 5, 1, "Marquardt", "$2a$11$f/RZh4xTBGMpbLsulfNuPOo9gQ0Y5fxgHfgZ1mVOawKxTV7p8ijcS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 9, 21, 57, 34, 935, DateTimeKind.Local).AddTicks(4669), "Lew.Rippin81@gmail.com", "Berry", 2, 1, false, "Pollich", "$2a$11$mp8V/q8vuskI5MIQBqVSBu7SkaYdAox7GrnRqdOofEmbYN5EXQVj." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 25, 5, 50, 10, 252, DateTimeKind.Local).AddTicks(6927), "Rosina6@hotmail.com", "Kaycee", 4, 3, "Hoeger", "$2a$11$Vx7D6KuiIe2k0IKlHoSu8O5tQIA0jK6y3vdJKhDeTR.PmWosKLttK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 5, 13, 30, 19, 532, DateTimeKind.Local).AddTicks(3095), "Maximillian.Sauer@hotmail.com", "Ernest", 8, 1, true, "Miller", "$2a$11$4Wz73zWfCSBB7sK4TJ6/IeqSKwGi3DT1AVVWyRFTSLS4U85qAv7iq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 18, 5, 4, 30, 423, DateTimeKind.Local).AddTicks(734), "Manuela_Leannon50@yahoo.com", "Amani", 2, true, "Connelly", "$2a$11$MrPvHI0nqX3dFyVqgReOlu4AWlhKp.4A0HSbBmNxRXIlbkVkKORLW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 5, 26, 1, 46, 48, 44, DateTimeKind.Local).AddTicks(6565), "Camryn_Osinski97@yahoo.com", "Hassan", 9, 4, "Rolfson", "$2a$11$l4F3pmlnSVWEXdiHon3sTORJHURHoH4PSJT6kAt85SPL6g8k8Mb16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 16, 20, 25, 26, 656, DateTimeKind.Local).AddTicks(4255), "Marie2@yahoo.com", "Chadrick", 8, 1, "Goyette", "$2a$11$MNXsyNZwdWNG0d.8MQe33.Imn8wRKaQITEGau5Ylawph0wStiEn/W" });

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
    }
}
