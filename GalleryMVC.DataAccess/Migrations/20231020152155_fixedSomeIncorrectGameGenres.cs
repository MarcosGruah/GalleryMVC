using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GalleryMVC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fixedSomeIncorrectGameGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1a44e54b-cc42-4672-be48-d40e62928b03"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1abacd23-8c2e-4b13-92a0-fa7e7589c793"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("27eb01e7-f523-499d-940d-9940095ffe39"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3a86f77a-9bbf-401f-9ae9-d4b869bc1825"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3e2704c4-ae5a-4779-b889-ae939775a474"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4c2b6e55-51eb-41f3-9414-622a5c69c28a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("758ca8e4-36dc-46b2-937a-88eebc03299c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("91d720ff-bdb6-46e3-aa5b-9be64d6b4b3c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("94b5c79b-c58b-4b04-910b-9b80b6c7751e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("995dfc0f-fa56-4b20-bc9d-9d4fd8115c44"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a7264679-cb6c-4c70-87f5-5f6a67de71da"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ded931a1-34fb-4ae6-812b-c8f04bbcaf96"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f39978fc-fdf7-4614-ac08-aa2a7cecca5d"));

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Developer", "GenreId", "LastEditedDate", "Price", "Publisher", "Title" },
                values: new object[,]
                {
                    { new Guid("06f4e51b-3ec4-4e62-84de-dcc20b1fe05c"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(329), "Larian Studios", new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(329), 44.99m, "Larian Studios", "Divinity: Original Sin 2" },
                    { new Guid("0b6a2dd3-d667-4045-9ba7-78a7a5bcf06e"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(284), "CD PROJEKT RED", new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(287), 59.99m, "CD PROJEKT RED", "Cyberpunk 2077" },
                    { new Guid("2703cfa9-3a20-454e-a5f3-fea1392aae3a"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(300), "Larian Studios", new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(301), 59.99m, "Larian Studios", "Baldur's Gate 3" },
                    { new Guid("2d99f6cf-7855-4f0e-b7e3-93ebd700b78c"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(325), "Valve", new Guid("33a3db15-80a6-4e8a-b6cc-2500fc6bfa75"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(326), 0m, "Valve", "Counter-Strike 2" },
                    { new Guid("2db1159d-f307-43ec-a486-6afc1f8e3e8d"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(297), "Valve", new Guid("4bb407a1-128f-40e2-8363-5ff17312c87d"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(298), 0m, "Valve", "Dota 2" },
                    { new Guid("38d97e98-b7e9-4938-af8b-767e9bbe3969"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(315), "CD PROJEKT RED", new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(316), 39.99m, "CD PROJEKT RED", "The Witcher 3: Wild Hunt" },
                    { new Guid("552673b8-3767-45e0-8245-5e5648a0f87a"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(312), "Klei Entertainment", new Guid("fae50298-4855-41de-a3ab-79eb15904f5d"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(312), 24.99m, "Klei Entertainment", "Oxygen Not Included" },
                    { new Guid("68cb7a60-5c15-4e90-9b76-c6d57bac50e4"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(304), "Klei Entertainment", new Guid("fae50298-4855-41de-a3ab-79eb15904f5d"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(305), 9.99m, "Klei Entertainment", "Don't Starve" },
                    { new Guid("a5f64243-b802-4621-b2e6-7a1730ba22f6"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(308), "Wube Software LTD.", new Guid("dd7d7e7f-ccd4-4a7f-86a1-2722e0e0a340"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(308), 35.00m, "Wube Software LTD.", "Factorio" },
                    { new Guid("b6489611-f8ac-44be-a83a-1e87d7be99a0"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(322), "Bethesda Game Studios", new Guid("7c3148a0-15f4-4e97-9d2f-1c035ab1e97a"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(322), 19.99m, "Bethesda Softworks", "The Elder Scrolls V: Skyrim" },
                    { new Guid("b7805a50-ddbb-45f6-a09a-d58a323879dc"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(293), "Bethesda Game Studios", new Guid("7c3148a0-15f4-4e97-9d2f-1c035ab1e97a"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(293), 69.99m, "Bethesda Softworks", "Starfield" },
                    { new Guid("e4e7c258-031d-448a-8acf-86232c747e3d"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(332), "ConcernedApe", new Guid("fae50298-4855-41de-a3ab-79eb15904f5d"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(332), 14.99m, "ConcernedApe", "Stardew Valley" },
                    { new Guid("ea787761-8fc6-4a8d-9401-4f53e2b20036"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(336), "FromSoftware", new Guid("0eb1e1f2-b5de-4d69-8237-4d28ab4c90ff"), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(336), 59.99m, "Activision", "Sekiro: Shadows Die Twice" }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0eb1e1f2-b5de-4d69-8237-4d28ab4c90ff"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(502), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("33a3db15-80a6-4e8a-b6cc-2500fc6bfa75"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(508), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4bb407a1-128f-40e2-8363-5ff17312c87d"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(500), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5719e94d-9c86-48b1-85c6-5cdd84e2e1db"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(496), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7c3148a0-15f4-4e97-9d2f-1c035ab1e97a"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(498), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(493), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dd7d7e7f-ccd4-4a7f-86a1-2722e0e0a340"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(506), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fae50298-4855-41de-a3ab-79eb15904f5d"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(504), new DateTime(2023, 10, 20, 15, 21, 54, 779, DateTimeKind.Utc).AddTicks(505) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("06f4e51b-3ec4-4e62-84de-dcc20b1fe05c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0b6a2dd3-d667-4045-9ba7-78a7a5bcf06e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2703cfa9-3a20-454e-a5f3-fea1392aae3a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2d99f6cf-7855-4f0e-b7e3-93ebd700b78c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2db1159d-f307-43ec-a486-6afc1f8e3e8d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("38d97e98-b7e9-4938-af8b-767e9bbe3969"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("552673b8-3767-45e0-8245-5e5648a0f87a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("68cb7a60-5c15-4e90-9b76-c6d57bac50e4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a5f64243-b802-4621-b2e6-7a1730ba22f6"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b6489611-f8ac-44be-a83a-1e87d7be99a0"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b7805a50-ddbb-45f6-a09a-d58a323879dc"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e4e7c258-031d-448a-8acf-86232c747e3d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ea787761-8fc6-4a8d-9401-4f53e2b20036"));

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Developer", "GenreId", "LastEditedDate", "Price", "Publisher", "Title" },
                values: new object[,]
                {
                    { new Guid("1a44e54b-cc42-4672-be48-d40e62928b03"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2596), "Klei Entertainment", new Guid("fae50298-4855-41de-a3ab-79eb15904f5d"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2596), 24.99m, "Klei Entertainment", "Oxygen Not Included" },
                    { new Guid("1abacd23-8c2e-4b13-92a0-fa7e7589c793"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2615), "ConcernedApe", new Guid("fae50298-4855-41de-a3ab-79eb15904f5d"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2615), 14.99m, "ConcernedApe", "Stardew Valley" },
                    { new Guid("27eb01e7-f523-499d-940d-9940095ffe39"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2592), "Wube Software LTD.", new Guid("dd7d7e7f-ccd4-4a7f-86a1-2722e0e0a340"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2592), 35.00m, "Wube Software LTD.", "Factorio" },
                    { new Guid("3a86f77a-9bbf-401f-9ae9-d4b869bc1825"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2566), "CD PROJEKT RED", new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2571), 59.99m, "CD PROJEKT RED", "Cyberpunk 2077" },
                    { new Guid("3e2704c4-ae5a-4779-b889-ae939775a474"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2588), "Klei Entertainment", new Guid("fae50298-4855-41de-a3ab-79eb15904f5d"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2588), 9.99m, "Klei Entertainment", "Don't Starve" },
                    { new Guid("4c2b6e55-51eb-41f3-9414-622a5c69c28a"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2581), "Valve", new Guid("33a3db15-80a6-4e8a-b6cc-2500fc6bfa75"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2581), 0m, "Valve", "Dota 2" },
                    { new Guid("758ca8e4-36dc-46b2-937a-88eebc03299c"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2605), "Bethesda Game Studios", new Guid("7c3148a0-15f4-4e97-9d2f-1c035ab1e97a"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2606), 19.99m, "Bethesda Softworks", "The Elder Scrolls V: Skyrim" },
                    { new Guid("91d720ff-bdb6-46e3-aa5b-9be64d6b4b3c"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2612), "Larian Studios", new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2612), 44.99m, "Larian Studios", "Divinity: Original Sin 2" },
                    { new Guid("94b5c79b-c58b-4b04-910b-9b80b6c7751e"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2576), "Bethesda Game Studios", new Guid("7c3148a0-15f4-4e97-9d2f-1c035ab1e97a"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2577), 69.99m, "Bethesda Softworks", "Starfield" },
                    { new Guid("995dfc0f-fa56-4b20-bc9d-9d4fd8115c44"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2599), "CD PROJEKT RED", new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2599), 39.99m, "CD PROJEKT RED", "The Witcher 3: Wild Hunt" },
                    { new Guid("a7264679-cb6c-4c70-87f5-5f6a67de71da"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2618), "FromSoftware", new Guid("33a3db15-80a6-4e8a-b6cc-2500fc6bfa75"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2618), 59.99m, "Activision", "Sekiro: Shadows Die Twice" },
                    { new Guid("ded931a1-34fb-4ae6-812b-c8f04bbcaf96"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2584), "Larian Studios", new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2585), 59.99m, "Larian Studios", "Baldur's Gate 3" },
                    { new Guid("f39978fc-fdf7-4614-ac08-aa2a7cecca5d"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2609), "Valve", new Guid("33a3db15-80a6-4e8a-b6cc-2500fc6bfa75"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2609), 0m, "Valve", "Counter-Strike 2" }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0eb1e1f2-b5de-4d69-8237-4d28ab4c90ff"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2784), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("33a3db15-80a6-4e8a-b6cc-2500fc6bfa75"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2789), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4bb407a1-128f-40e2-8363-5ff17312c87d"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2781), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5719e94d-9c86-48b1-85c6-5cdd84e2e1db"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2777), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7c3148a0-15f4-4e97-9d2f-1c035ab1e97a"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2779), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2773), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dd7d7e7f-ccd4-4a7f-86a1-2722e0e0a340"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2788), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fae50298-4855-41de-a3ab-79eb15904f5d"),
                columns: new[] { "CreatedDate", "LastEditedDate" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2786), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2786) });
        }
    }
}
