using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutomotiveApi.Migrations
{
    /// <inheritdoc />
    public partial class clientForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "clientId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "8592 Strosin Turnpike", "Novamouth", new DateTime(2022, 9, 9, 0, 46, 16, 681, DateTimeKind.Local).AddTicks(8592), "Matt_Donnelly@gmail.com", -85.689700000000002, 18.318999999999999, "District Markets Producer", "894-733-5565 x896", "43697-5331" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "1910 Dereck Path", "New Aurelia", new DateTime(2023, 3, 3, 0, 27, 38, 307, DateTimeKind.Local).AddTicks(6316), "Ambrose.Gerhold79@yahoo.com", 78.408299999999997, 159.32159999999999, "National Functionality Technician", "709.932.6661", "20540" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "573 Wilhelmine Extension", "East Cleoraton", new DateTime(2023, 3, 5, 23, 58, 6, 522, DateTimeKind.Local).AddTicks(951), "Mozell72@gmail.com", -68.078100000000006, 4.0495000000000001, "Direct Accounts Consultant", "357-464-6536 x49197", "56068-0333" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "41099 Thiel Avenue", "Torptown", new DateTime(2023, 7, 16, 22, 3, 14, 642, DateTimeKind.Local).AddTicks(985), "Marge_Metz54@yahoo.com", 3.1023000000000001, -35.161700000000003, "Investor Research Agent", "536-988-7124 x0050", "24833-2047" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "757 Hauck Squares", "Kuhnstad", new DateTime(2022, 8, 7, 1, 1, 25, 377, DateTimeKind.Local).AddTicks(7231), "Shanie.Wyman71@hotmail.com", -71.416899999999998, -38.8506, "Principal Integration Engineer", "(902) 655-7380 x353", "86352-5995" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "58997 Geoffrey Ports", "Port Julianamouth", new DateTime(2022, 12, 22, 2, 54, 15, 92, DateTimeKind.Local).AddTicks(5409), "Burnice70@gmail.com", 68.468999999999994, -69.039599999999993, "National Infrastructure Officer", "1-929-331-8522", "51776-9477" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "08331 Shana Stravenue", "Mannbury", new DateTime(2023, 6, 18, 13, 17, 49, 59, DateTimeKind.Local).AddTicks(4279), "Danial_Runolfsdottir95@hotmail.com", 49.382100000000001, -128.70679999999999, "Future Interactions Analyst", "1-503-714-2178 x24906", "75902" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "40993 Dashawn Mountains", "Judytown", new DateTime(2023, 4, 19, 12, 6, 10, 341, DateTimeKind.Local).AddTicks(4706), "Maurine.Zboncak65@yahoo.com", -73.670000000000002, -163.3357, "Lead Security Producer", "1-555-308-5342 x91436", "90483" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "85071 Cletus Mountains", "West Stefan", new DateTime(2022, 12, 7, 12, 27, 12, 763, DateTimeKind.Local).AddTicks(4829), "Carolyne80@gmail.com", -50.916499999999999, -57.000599999999999, "Customer Program Analyst", "(591) 470-9890 x74676", "28012" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "547 Bernhard Summit", "North Reanna", new DateTime(2023, 3, 7, 17, 29, 43, 756, DateTimeKind.Local).AddTicks(3322), "Shirley44@hotmail.com", -54.479700000000001, 53.9206, "Regional Communications Architect", "879-288-2524", "84907" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Adresse", "Adresse2", "CreatedAt", "DeletedAt", "Email", "FirstName", "LastName", "PermisRecto", "PermisVerso", "Tel", "UpdatedAt", "Ville", "ZipCode" },
                values: new object[,]
                {
                    { 1, "7831 Lilla Club", "9766 Blick Square", new DateTime(2022, 8, 16, 4, 57, 3, 251, DateTimeKind.Local).AddTicks(1518), null, "Conner52@gmail.com", "Jessie", "Brekke", "https://picsum.photos/640/480/?image=964", "https://picsum.photos/640/480/?image=953", "280.503.7636 x28860", null, "South Vilmaville", "28708-4603" },
                    { 2, "1666 Clay Union", "7281 Jedidiah Island", new DateTime(2023, 2, 3, 14, 44, 26, 818, DateTimeKind.Local).AddTicks(7116), null, "Katelin25@hotmail.com", "Aylin", "Altenwerth", "https://picsum.photos/640/480/?image=298", "https://picsum.photos/640/480/?image=1068", "(552) 781-6296 x7411", null, "Reichertview", "19693" },
                    { 3, "063 Luettgen Manor", "947 Quinten Freeway", new DateTime(2023, 2, 4, 12, 35, 45, 9, DateTimeKind.Local).AddTicks(93), null, "Olga99@gmail.com", "Kevon", "Hammes", "https://picsum.photos/640/480/?image=687", "https://picsum.photos/640/480/?image=613", "590.484.6732 x5572", null, "Geovannymouth", "84453" },
                    { 4, "50969 Gulgowski Views", "3164 Rodriguez Fords", new DateTime(2022, 8, 21, 9, 8, 27, 300, DateTimeKind.Local).AddTicks(1981), null, "Edmond.Kreiger49@hotmail.com", "Noe", "Bergnaum", "https://picsum.photos/640/480/?image=123", "https://picsum.photos/640/480/?image=44", "821.860.1867", null, "Port Vladimirburgh", "65661" },
                    { 5, "9232 Sibyl Parks", "495 Precious Locks", new DateTime(2022, 9, 29, 7, 45, 20, 531, DateTimeKind.Local).AddTicks(4382), null, "Gabriella75@gmail.com", "Griffin", "Beatty", "https://picsum.photos/640/480/?image=528", "https://picsum.photos/640/480/?image=1073", "862.338.2396", null, "Ebertberg", "64739" },
                    { 6, "748 Stoltenberg Valleys", "79149 Eryn Loop", new DateTime(2023, 3, 10, 7, 16, 47, 219, DateTimeKind.Local).AddTicks(5996), null, "Laverna32@gmail.com", "Jo", "Deckow", "https://picsum.photos/640/480/?image=897", "https://picsum.photos/640/480/?image=895", "1-269-949-7446 x93706", null, "East Dallinton", "79117-6336" },
                    { 7, "764 Gutkowski Road", "085 Conn Drive", new DateTime(2022, 8, 26, 3, 29, 23, 826, DateTimeKind.Local).AddTicks(2350), null, "Ova9@yahoo.com", "Ruth", "Jakubowski", "https://picsum.photos/640/480/?image=455", "https://picsum.photos/640/480/?image=227", "(621) 240-4792 x7567", null, "South Zane", "06258-0592" },
                    { 8, "69396 Baylee Cove", "457 Jarrell Street", new DateTime(2023, 2, 12, 12, 0, 17, 840, DateTimeKind.Local).AddTicks(6775), null, "Ellie.Wolf@gmail.com", "Audie", "Rath", "https://picsum.photos/640/480/?image=500", "https://picsum.photos/640/480/?image=325", "(466) 456-0900 x06161", null, "Marcellabury", "22138-8771" },
                    { 9, "844 Amber Gateway", "17481 Kirlin Fort", new DateTime(2023, 2, 14, 3, 14, 25, 963, DateTimeKind.Local).AddTicks(9424), null, "Wyatt83@hotmail.com", "Robert", "Murazik", "https://picsum.photos/640/480/?image=538", "https://picsum.photos/640/480/?image=126", "(974) 820-2306 x639", null, "New Valentinebury", "81955-3613" },
                    { 10, "761 Emmie Springs", "002 Noble Land", new DateTime(2022, 8, 10, 11, 25, 26, 748, DateTimeKind.Local).AddTicks(8843), null, "Leland.Lueilwitz@hotmail.com", "Breana", "Mertz", "https://picsum.photos/640/480/?image=424", "https://picsum.photos/640/480/?image=135", "(380) 229-6754 x2060", null, "Hesselburgh", "51854-2404" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password", "clientId" },
                values: new object[] { new DateTime(2022, 8, 24, 1, 33, 11, 899, DateTimeKind.Local).AddTicks(203), "Corine45@hotmail.com", "Rigoberto", 1, 1, "McKenzie", "$2a$11$9XiShkndreJv9gM2nCvHiexDx.1DjQRRCRXFFfbrBctMILaET6qOS", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password", "clientId" },
                values: new object[] { new DateTime(2022, 11, 6, 21, 49, 7, 48, DateTimeKind.Local).AddTicks(3606), "Estella.Strosin@hotmail.com", "Sherman", 9, "Kris", "$2a$11$ngtN6rkDwUR8oekvdtZAWujw/xlONuBWpRuZ1UDOg/CMgamJNEfMe", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "clientId" },
                values: new object[] { new DateTime(2023, 3, 18, 14, 51, 40, 651, DateTimeKind.Local).AddTicks(2496), "Marisol.Hahn@yahoo.com", "Betsy", 7, 1, true, "Robel", "$2a$11$1ANwL5wZBgJmX/uN45PJtuavOI6Gzmx4BWNa8cZx73Q5.GpblUV8K", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "clientId" },
                values: new object[] { new DateTime(2023, 5, 29, 7, 34, 40, 116, DateTimeKind.Local).AddTicks(8736), "David.Gottlieb43@yahoo.com", "Vida", 1, 3, true, "Mohr", "$2a$11$kzeU648pjeZZXGB/wSn5Lu9DEdJCNFVvcgxr1lusVKFt7X.vWo0DS", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "clientId" },
                values: new object[] { new DateTime(2023, 1, 4, 10, 30, 7, 718, DateTimeKind.Local).AddTicks(3753), "Matteo97@hotmail.com", "Joanne", 6, 4, true, "Ondricka", "$2a$11$zIybia6X6DB.bYPRsYZQ/.XLYTNkk3mzEpFyvb3qJhUlr8QCxx7Pu", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password", "clientId" },
                values: new object[] { new DateTime(2023, 3, 9, 18, 34, 58, 679, DateTimeKind.Local).AddTicks(2271), "Bridget_Beahan2@yahoo.com", "Fausto", 3, "Rolfson", "$2a$11$rveBZ0cgBfrUwqtm7rt2/OjTCwy.HoW81qV5vyaL4I/acVjVhMgVm", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "clientId" },
                values: new object[] { new DateTime(2023, 6, 6, 14, 57, 51, 696, DateTimeKind.Local).AddTicks(6420), "Nickolas42@yahoo.com", "Orrin", 5, 1, true, "Leannon", "$2a$11$O2dme/d87QYR.xfpn8eDV.dsiJVQRqixBKXrNOHW.LYDgQMrZ.a82", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password", "clientId" },
                values: new object[] { new DateTime(2023, 6, 23, 18, 25, 2, 167, DateTimeKind.Local).AddTicks(4014), "Madelynn_Bruen@gmail.com", "Caroline", 3, "Torphy", "$2a$11$N9pG78b4ZCC.7Fn.h4jzxelveXII3RcZhpZBHMFzf6u35.E7sxE7q", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password", "clientId" },
                values: new object[] { new DateTime(2022, 12, 12, 15, 56, 20, 629, DateTimeKind.Local).AddTicks(3277), "Brandy34@yahoo.com", "Christy", 5, "Bartoletti", "$2a$11$imFZ614yPqKkP3iE7eqUCOyN38HoaOUgDLTOaWnBUgwppjhbGr2yO", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password", "clientId" },
                values: new object[] { new DateTime(2023, 2, 13, 2, 36, 19, 534, DateTimeKind.Local).AddTicks(9693), "Abdiel8@gmail.com", "Freda", 4, 4, false, "Okuneva", "$2a$11$SZpGSLYZ7F8MmFlANImVmedL3i3rozICLJ0QDbyC/bkzA18U/hQyW", null });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Id", "Airbag", "Climat", "CreatedAt", "DeletedAt", "Gearbox", "IdAgence", "IdModele", "Km", "Matricule", "Moteur", "Name", "NbPassager", "NbPort", "Prix", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, false, false, new DateTime(2022, 9, 15, 7, 19, 42, 582, DateTimeKind.Local).AddTicks(1700), null, "zlrcbrifnp", 2, 10740, 6838, "qyfpykcaqm", "ngrfiqgbcd", "lgpxqmdvmm", 6, 5, 5.0, "pmjssqekzo", null },
                    { 2, true, true, new DateTime(2023, 5, 23, 5, 9, 50, 876, DateTimeKind.Local).AddTicks(3961), null, "bcwbrmnmos", 3, 113, 4597, "hfqfeicxxb", "poqdsdljed", "axmgxdsuui", 8, 7, 4.0, "axbucfjvul", null },
                    { 3, true, true, new DateTime(2022, 8, 18, 18, 47, 25, 69, DateTimeKind.Local).AddTicks(4324), null, "mrrhavfsoj", 1, 10324, 1305, "gkzwdammre", "ulnqafemng", "qtjtjrdfvz", 10, 1, 8.0, "wuvyaqetzt", null },
                    { 4, true, true, new DateTime(2023, 1, 30, 23, 46, 9, 323, DateTimeKind.Local).AddTicks(6507), null, "asalxshdlu", 10, 57, 9712, "zhdzpnkivg", "mlhsjutdnc", "iepnwfzexv", 1, 4, 10.0, "vdvzqbpduu", null },
                    { 5, true, false, new DateTime(2023, 2, 11, 1, 29, 53, 839, DateTimeKind.Local).AddTicks(2014), null, "uybqezsuih", 10, 10847, 9663, "xajjellkjj", "glgjupjztg", "xjsyadmwpa", 8, 1, 9.0, "gjezjppbri", null },
                    { 6, false, false, new DateTime(2022, 11, 9, 14, 57, 45, 150, DateTimeKind.Local).AddTicks(5796), null, "qwldhumitl", 8, 64, 4906, "inbvzbxwkf", "ckdpaamyfd", "wnphtnuxkz", 8, 8, 10.0, "funjtspsbe", null },
                    { 7, false, true, new DateTime(2023, 1, 14, 19, 47, 23, 673, DateTimeKind.Local).AddTicks(4545), null, "dujaghszih", 10, 10324, 5107, "lcaltjxkgz", "oiezdqhabs", "slqhccbjnj", 1, 10, 3.0, "pdielrqdgp", null },
                    { 8, true, false, new DateTime(2022, 11, 25, 6, 54, 18, 518, DateTimeKind.Local).AddTicks(771), null, "srxpxaiqom", 9, 10847, 8673, "mlquojmgya", "pblqszbshn", "jxzippfyru", 4, 2, 8.0, "ukjigmdwkn", null },
                    { 9, false, false, new DateTime(2023, 4, 22, 2, 46, 42, 838, DateTimeKind.Local).AddTicks(9412), null, "fotnizefos", 8, 10324, 9131, "vzqqcjrfqa", "tolzdxnoew", "ovygaxfsmw", 5, 1, 6.0, "rxalghritd", null },
                    { 10, true, true, new DateTime(2022, 8, 16, 21, 44, 13, 546, DateTimeKind.Local).AddTicks(8436), null, "xpwmouspbv", 8, 10230, 4986, "oosvjkzkox", "bzfgzhoatb", "epaileronm", 8, 7, 2.0, "bhwjchofjd", null }
                });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 17, 13, 37, 33, 113, DateTimeKind.Local).AddTicks(2368), "Hane", "Israel36@gmail.com", "Ebert, Jacobi and Quitzon", "Mafalda", "904.487.9320 x65088", "Feest", "Krisport", "67864" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 25, 5, 19, 5, 108, DateTimeKind.Local).AddTicks(2309), "Hermann", "Mollie_Heller@hotmail.com", "Hahn and Sons", "Lacy", "1-921-308-2381", "Leffler", "Port Toy", "67043-1940" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 11, 10, 44, 21, 858, DateTimeKind.Local).AddTicks(2508), "Altenwerth", "Orval_Rowe19@gmail.com", "Sanford Group", "Deanna", "728-682-4975 x12851", "Runolfsdottir", "Port Ally", "82911" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 6, 25, 6, 11, 30, 85, DateTimeKind.Local).AddTicks(4677), "Predovic", "Jessie.Gutmann76@gmail.com", "Howe - Aufderhar", "Mossie", "593.728.4155", "Mohr", "Emiliaton", "03306-0467" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 2, 5, 6, 19, 58, 695, DateTimeKind.Local).AddTicks(8501), "Moen", "Louisa_Von@hotmail.com", "Ledner - Swift", "Maximilian", "973-963-0553 x674", "Romaguera", "Lake Miguelville", "87164" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 18, 11, 41, 46, 530, DateTimeKind.Local).AddTicks(2625), "Green", "Maye88@gmail.com", "Kemmer Group", "Joel", "880.903.4838", "Beatty", "East Eulahmouth", "02099-7026" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 11, 16, 5, 40, 415, DateTimeKind.Local).AddTicks(6764), "Daniel", "Elyse31@yahoo.com", "Lang, Wiza and Monahan", "Valerie", "401-960-0077", "Hand", "Johnsonside", "88003" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 7, 16, 14, 40, 274, DateTimeKind.Local).AddTicks(4003), "Lueilwitz", "Una_Hyatt@gmail.com", "Bauch Inc", "Henry", "1-517-800-3095 x8728", "Lang", "Goodwintown", "36541" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 55, 35, 872, DateTimeKind.Local).AddTicks(7372), "Ledner", "Mallie.Buckridge38@hotmail.com", "Turner and Sons", "Cristopher", "767-347-9394 x436", "Murazik", "Reginaldshire", "22166-0957" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 5, 5, 10, 53, 0, 120, DateTimeKind.Local).AddTicks(5463), "Abbott", "Tyshawn50@hotmail.com", "Champlin - Schaden", "Gudrun", "(446) 383-6677", "Daugherty", "South Lois", "53523" });

            migrationBuilder.InsertData(
                table: "Offres",
                columns: new[] { "Id", "CreatedAt", "DateDebut", "DateFin", "DeletedAt", "IdVehicule", "Prix", "UpdatedAt", "isPublic" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 14, 1, 12, 26, 347, DateTimeKind.Local).AddTicks(9162), new DateTime(2023, 3, 23, 18, 25, 44, 773, DateTimeKind.Local).AddTicks(1902), new DateTime(2022, 8, 1, 17, 38, 38, 715, DateTimeKind.Local).AddTicks(7407), null, 3, 6.0, null, false },
                    { 2, new DateTime(2022, 7, 30, 14, 49, 7, 650, DateTimeKind.Local).AddTicks(2276), new DateTime(2022, 11, 20, 19, 44, 10, 336, DateTimeKind.Local).AddTicks(9486), new DateTime(2022, 11, 10, 12, 5, 28, 49, DateTimeKind.Local).AddTicks(4963), null, 10, 9.0, null, false },
                    { 3, new DateTime(2023, 5, 1, 7, 33, 35, 195, DateTimeKind.Local).AddTicks(331), new DateTime(2022, 12, 29, 15, 16, 28, 509, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 9, 13, 12, 43, 53, 444, DateTimeKind.Local).AddTicks(4272), null, 5, 4.0, null, false },
                    { 4, new DateTime(2022, 9, 26, 5, 27, 6, 586, DateTimeKind.Local).AddTicks(8894), new DateTime(2023, 4, 11, 13, 0, 31, 433, DateTimeKind.Local).AddTicks(4203), new DateTime(2023, 6, 20, 15, 24, 49, 662, DateTimeKind.Local).AddTicks(767), null, 7, 8.0, null, false },
                    { 5, new DateTime(2023, 2, 25, 4, 21, 4, 670, DateTimeKind.Local).AddTicks(5736), new DateTime(2023, 1, 25, 22, 42, 11, 350, DateTimeKind.Local).AddTicks(6337), new DateTime(2023, 1, 8, 6, 13, 43, 840, DateTimeKind.Local).AddTicks(6961), null, 1, 10.0, null, false },
                    { 6, new DateTime(2023, 3, 10, 20, 59, 22, 458, DateTimeKind.Local).AddTicks(1263), new DateTime(2023, 7, 5, 22, 29, 23, 63, DateTimeKind.Local).AddTicks(5474), new DateTime(2023, 1, 5, 22, 18, 56, 684, DateTimeKind.Local).AddTicks(4120), null, 7, 6.0, null, false },
                    { 7, new DateTime(2022, 9, 21, 2, 33, 21, 47, DateTimeKind.Local).AddTicks(7821), new DateTime(2023, 6, 3, 18, 19, 14, 282, DateTimeKind.Local).AddTicks(5639), new DateTime(2022, 10, 22, 8, 59, 15, 728, DateTimeKind.Local).AddTicks(2867), null, 2, 7.0, null, false },
                    { 8, new DateTime(2022, 8, 13, 19, 53, 59, 202, DateTimeKind.Local).AddTicks(7865), new DateTime(2023, 3, 19, 11, 43, 22, 274, DateTimeKind.Local).AddTicks(5187), new DateTime(2022, 9, 26, 6, 46, 47, 608, DateTimeKind.Local).AddTicks(6527), null, 6, 9.0, null, false },
                    { 9, new DateTime(2022, 11, 5, 2, 20, 33, 560, DateTimeKind.Local).AddTicks(4510), new DateTime(2022, 12, 15, 16, 29, 47, 988, DateTimeKind.Local).AddTicks(9434), new DateTime(2022, 11, 28, 4, 57, 15, 333, DateTimeKind.Local).AddTicks(7080), null, 6, 1.0, null, false },
                    { 10, new DateTime(2023, 3, 17, 14, 27, 11, 562, DateTimeKind.Local).AddTicks(6574), new DateTime(2023, 2, 2, 2, 22, 50, 933, DateTimeKind.Local).AddTicks(855), new DateTime(2022, 11, 10, 20, 25, 47, 139, DateTimeKind.Local).AddTicks(1879), null, 2, 1.0, null, false }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "CreatedAt", "DateDepart", "DateRetour", "DeletedAt", "IdVehicule", "NumeroReservation", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 3, 17, 26, 59, 539, DateTimeKind.Local).AddTicks(8539), new DateTime(2023, 5, 23, 5, 18, 56, 118, DateTimeKind.Local).AddTicks(7062), new DateTime(2022, 12, 19, 6, 41, 34, 342, DateTimeKind.Local).AddTicks(895), null, 6, "2f980916-0ed1-443d-95c5-590ee4f0d1bd", "canceled", null },
                    { 2, new DateTime(2023, 1, 17, 9, 9, 11, 483, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 7, 18, 12, 26, 58, 987, DateTimeKind.Local).AddTicks(6138), new DateTime(2022, 9, 28, 17, 56, 30, 468, DateTimeKind.Local).AddTicks(6521), null, 9, "e0510ccf-86c7-49d3-9dcd-fa8200f735f7", "pending", null },
                    { 3, new DateTime(2023, 4, 19, 16, 32, 21, 599, DateTimeKind.Local).AddTicks(7284), new DateTime(2022, 11, 7, 10, 28, 44, 588, DateTimeKind.Local).AddTicks(2699), new DateTime(2022, 10, 21, 2, 45, 30, 620, DateTimeKind.Local).AddTicks(7203), null, 8, "36382e2f-0dec-4649-871d-5058a13291b4", "canceled", null },
                    { 4, new DateTime(2023, 6, 7, 22, 59, 37, 867, DateTimeKind.Local).AddTicks(6096), new DateTime(2023, 4, 19, 12, 56, 27, 964, DateTimeKind.Local).AddTicks(7537), new DateTime(2023, 3, 21, 22, 31, 31, 279, DateTimeKind.Local).AddTicks(6246), null, 7, "07b6f517-e2f5-48e9-95ae-9ab2bad4b469", "confirmed", null },
                    { 5, new DateTime(2022, 9, 1, 0, 36, 0, 432, DateTimeKind.Local).AddTicks(1987), new DateTime(2023, 4, 13, 8, 39, 38, 161, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 6, 11, 6, 16, 4, 160, DateTimeKind.Local).AddTicks(3281), null, 5, "4d0b611d-0b7e-48c1-ace5-b0680c71ff98", "confirmed", null },
                    { 6, new DateTime(2022, 9, 24, 23, 6, 29, 356, DateTimeKind.Local).AddTicks(1393), new DateTime(2023, 3, 1, 11, 24, 55, 565, DateTimeKind.Local).AddTicks(2222), new DateTime(2023, 2, 6, 16, 48, 28, 5, DateTimeKind.Local).AddTicks(4730), null, 1, "dbd6e492-a8d5-4b47-b826-6d3923fe620b", "pending", null },
                    { 7, new DateTime(2023, 7, 2, 2, 1, 58, 408, DateTimeKind.Local).AddTicks(9212), new DateTime(2022, 11, 20, 17, 0, 35, 119, DateTimeKind.Local).AddTicks(7391), new DateTime(2022, 9, 1, 23, 55, 42, 878, DateTimeKind.Local).AddTicks(1377), null, 1, "f53ce5b8-086e-4d3a-aaec-6ea0d9c5ba76", "canceled", null },
                    { 8, new DateTime(2022, 10, 27, 7, 33, 10, 133, DateTimeKind.Local).AddTicks(7892), new DateTime(2023, 3, 16, 7, 55, 52, 278, DateTimeKind.Local).AddTicks(5542), new DateTime(2022, 11, 30, 9, 28, 8, 373, DateTimeKind.Local).AddTicks(6469), null, 9, "18d0d83f-07f3-4016-8679-05b79fd78e07", "confirmed", null },
                    { 9, new DateTime(2023, 1, 15, 18, 18, 54, 767, DateTimeKind.Local).AddTicks(2365), new DateTime(2023, 2, 7, 20, 20, 42, 304, DateTimeKind.Local).AddTicks(8199), new DateTime(2023, 3, 11, 11, 18, 59, 878, DateTimeKind.Local).AddTicks(7718), null, 10, "aa919fbe-4ae5-463d-8c97-cd78d00926e6", "canceled", null },
                    { 10, new DateTime(2022, 12, 13, 15, 0, 31, 947, DateTimeKind.Local).AddTicks(4760), new DateTime(2022, 8, 16, 11, 20, 42, 363, DateTimeKind.Local).AddTicks(1238), new DateTime(2022, 12, 2, 18, 2, 51, 609, DateTimeKind.Local).AddTicks(3723), null, 5, "a0be7348-87cf-46cd-b0de-28b0c6044852", "canceled", null }
                });

            migrationBuilder.InsertData(
                table: "Contrats",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IdClient", "IdReservation", "IsConducteur", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 8, false, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 10, true, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 1, false, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 10, false, null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 10, false, null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 9, false, null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 4, true, null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 10, true, null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 2, true, null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 10, false, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_clientId",
                table: "Users",
                column: "clientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_id_client",
                table: "Users",
                column: "clientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_id_client",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_clientId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contrats",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Offres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "clientId",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "2852 Mckenna Flat", "Port Teresastad", new DateTime(2022, 10, 1, 5, 21, 29, 159, DateTimeKind.Local).AddTicks(6398), "Reba.Borer@hotmail.com", 38.128399999999999, -138.5625, "Forward Optimization Representative", "680-827-2007 x984", "25010-0913" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "74948 Armstrong Summit", "Opheliastad", new DateTime(2023, 4, 8, 20, 1, 29, 153, DateTimeKind.Local).AddTicks(3547), "Leatha_Ortiz9@yahoo.com", -32.507800000000003, 124.5993, "Direct Paradigm Engineer", "1-963-629-4926 x65546", "77995" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "234 Stanford Creek", "Lake Jadon", new DateTime(2023, 7, 1, 16, 48, 49, 891, DateTimeKind.Local).AddTicks(6433), "Gail19@gmail.com", -84.376300000000001, -87.305300000000003, "Investor Usability Strategist", "1-576-434-6351 x3308", "68945" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "76016 King Freeway", "Lueilwitzside", new DateTime(2022, 8, 26, 7, 36, 5, 991, DateTimeKind.Local).AddTicks(6861), "Reid.Botsford44@hotmail.com", 19.9313, 171.93100000000001, "National Branding Liaison", "905.927.9545 x7866", "37935" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "7872 Ethel Shore", "Connmouth", new DateTime(2023, 6, 21, 3, 42, 19, 593, DateTimeKind.Local).AddTicks(388), "Joan.Reinger@hotmail.com", -66.491799999999998, -36.542700000000004, "International Mobility Specialist", "690-918-9378 x588", "11012" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "9195 Schinner Corners", "McDermottberg", new DateTime(2023, 3, 15, 1, 43, 29, 230, DateTimeKind.Local).AddTicks(5935), "Theodora_Connelly@yahoo.com", 39.416200000000003, 177.60910000000001, "National Paradigm Designer", "1-618-475-8263", "89644" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "35381 Cassin Land", "Waylonside", new DateTime(2023, 6, 10, 7, 40, 19, 645, DateTimeKind.Local).AddTicks(8228), "Kaylie15@gmail.com", -80.288499999999999, -46.557000000000002, "Corporate Solutions Consultant", "324.207.1502", "23112-8639" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "517 Mercedes Summit", "East Lenna", new DateTime(2023, 1, 2, 3, 16, 21, 675, DateTimeKind.Local).AddTicks(7790), "Kobe_Mayer@yahoo.com", -44.275500000000001, 139.35040000000001, "Central Mobility Specialist", "1-994-330-5083 x508", "47370" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "999 Jennifer Point", "North Vanessa", new DateTime(2023, 5, 28, 8, 17, 50, 311, DateTimeKind.Local).AddTicks(2470), "Randal9@hotmail.com", -40.517899999999997, -17.9422, "Legacy Identity Technician", "628.427.0820", "52009-7085" });

            migrationBuilder.UpdateData(
                table: "Agences",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "CreatedAt", "Email", "Latitude", "Longitude", "Name", "Tel", "ZipCode" },
                values: new object[] { "4620 Brekke Summit", "East Ravenmouth", new DateTime(2022, 10, 20, 22, 27, 51, 289, DateTimeKind.Local).AddTicks(9510), "Elsie.Herman52@yahoo.com", 23.700800000000001, -54.462800000000001, "District Infrastructure Director", "(944) 349-2435", "60302" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 10, 28, 23, 16, 51, 985, DateTimeKind.Local).AddTicks(658), "Jett77@gmail.com", "Ressie", 3, 2, "Emard", "$2a$11$psxAYQ39Eho8gZhHD6TgneW7emiSK4ZTednh3pE.23F0ivs7Y3hD2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 17, 4, 10, 50, 129, DateTimeKind.Local).AddTicks(7220), "Lenny2@gmail.com", "Roselyn", 4, "Gusikowski", "$2a$11$JAtEWmVjVxufR3bJ.NNnAup7mPijNyqyCu8etx9S3bagjsLHGhhn2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 29, 16, 34, 15, 222, DateTimeKind.Local).AddTicks(3222), "Oleta.Howe@hotmail.com", "Romaine", 10, 2, false, "Upton", "$2a$11$LdKqHtRDUkt/UgWHkwPFx.jUhkRHMr5o.l0Cr.jA39bQT3n0Qs/S." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 14, 11, 9, 58, 470, DateTimeKind.Local).AddTicks(758), "Cornelius.DAmore@gmail.com", "Westley", 4, 1, false, "Prohaska", "$2a$11$9I8iCmd1WVdZMAgNTkMseOp79eGf2oLk/dQ/0WjQFlKNA.n/m7YI2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 2, 16, 6, 39, 51, 870, DateTimeKind.Local).AddTicks(7689), "Dovie53@yahoo.com", "Nico", 4, 3, false, "Cormier", "$2a$11$8g/Ci0m7.vQ59ldb/jVj0Ozj7nIzTgOLeFuQL3uUCBe2tjWcR7zj2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdRole", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 3, 27, 16, 28, 24, 371, DateTimeKind.Local).AddTicks(9379), "Jayson_Walter@hotmail.com", "Johnathon", 2, "Heaney", "$2a$11$yP8zrb3CrpPS1SiX563w3.IhszBef/lh0kvCIf1UnNSTbrruIrZL6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 4, 8, 16, 23, 55, 535, DateTimeKind.Local).AddTicks(3737), "Randi79@gmail.com", "Keegan", 1, 4, false, "Sporer", "$2a$11$j3jvWMj/F2W373XhZNRG1.RFdVIN9F8AkYeBiMjyP/ztFF074Mp0y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2023, 1, 7, 15, 24, 2, 73, DateTimeKind.Local).AddTicks(3387), "Stacey_Wisozk@hotmail.com", "Reyna", 4, "O'Connell", "$2a$11$xG8sOQR5PG9mStPHS.2Tg.u07NaFZlZZ5GozAfSjXGHnnTlzcymQW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 7, 25, 15, 47, 25, 317, DateTimeKind.Local).AddTicks(6643), "Blaise45@yahoo.com", "Aniya", 8, "Mraz", "$2a$11$gsSI2lq4/V4jEMFcylUchO8eedcwZjMJiLWdt2Ejm2n6P5zgXAdGq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Email", "FirstName", "IdAgence", "IdRole", "IsActive", "LastName", "Password" },
                values: new object[] { new DateTime(2022, 12, 17, 23, 18, 55, 123, DateTimeKind.Local).AddTicks(1628), "Loma_Schumm34@gmail.com", "Bertrand", 9, 2, true, "Towne", "$2a$11$V6snPf1W9qMrNk6rEEyftevaRxvxWWDAd.fp5IYE0Gdfz5FMZhkYm" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 11, 7, 1, 12, 18, 41, DateTimeKind.Local).AddTicks(5932), "Christiansen", "Allison.Terry28@yahoo.com", "Macejkovic Inc", "Estrella", "700-562-2468 x29880", "Little", "Lake Antwonland", "74833-1724" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 14, 23, 3, 10, 772, DateTimeKind.Local).AddTicks(2134), "Walker", "Garrett.Hoppe@yahoo.com", "Cronin, Lemke and Gutkowski", "Sheldon", "1-947-285-5946 x41388", "Berge", "Grimesshire", "93887-4198" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 8, 12, 21, 16, 56, 686, DateTimeKind.Local).AddTicks(3997), "Baumbach", "Mckayla.Gerhold82@gmail.com", "Parisian and Sons", "Presley", "(213) 470-0098", "Conn", "Martatown", "84045-9546" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 3, 21, 8, 29, 9, 338, DateTimeKind.Local).AddTicks(512), "Wuckert", "Casey49@gmail.com", "Barrows LLC", "Jaycee", "(377) 946-0698", "Blick", "East Keagan", "78330" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 8, 5, 10, 31, 18, 741, DateTimeKind.Local).AddTicks(3266), "Mohr", "Josefa_Padberg@yahoo.com", "Bradtke - Marquardt", "Lyla", "529.262.4049 x30114", "Lowe", "South Arjun", "49598" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 1, 4, 21, 23, 28, 392, DateTimeKind.Local).AddTicks(5037), "Waters", "Sherwood.Franecki@hotmail.com", "Daniel, Donnelly and Wiza", "Hilbert", "402-398-9179 x92727", "Bahringer", "McKenziechester", "04213-6524" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 12, 25, 14, 7, 5, 393, DateTimeKind.Local).AddTicks(6326), "Wintheiser", "Rogelio_Swift91@yahoo.com", "Bashirian LLC", "Winona", "358-911-5726 x837", "Abshire", "East Zion", "73151-9634" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 22, 14, 20, 3, 930, DateTimeKind.Local).AddTicks(6212), "Miller", "Amparo.Hand@yahoo.com", "Hermann, Jast and Howell", "Alexys", "1-728-752-9761 x64134", "Shields", "South Orphabury", "65774" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2023, 7, 4, 6, 39, 47, 438, DateTimeKind.Local).AddTicks(9860), "Bergstrom", "Josue.Mraz74@gmail.com", "Hansen, Douglas and Veum", "Cordelia", "1-848-749-4087 x80568", "Marks", "Lornahaven", "42219-7632" });

            migrationBuilder.UpdateData(
                table: "long_term_rentals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "description", "email", "entreprise", "nom", "phone", "prenom", "ville", "zip" },
                values: new object[] { new DateTime(2022, 9, 27, 0, 34, 51, 77, DateTimeKind.Local).AddTicks(4287), "Schuppe", "Marilyne_Yost@hotmail.com", "Barton - Deckow", "Adalberto", "(695) 549-3166 x499", "Block", "Kingborough", "36030-7565" });
        }
    }
}
