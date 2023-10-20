using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GalleryMVC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changedDbSeedingStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1d9f7152-23d3-43d5-8ffc-94c77fee6892"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1e70550e-baf5-486f-a844-077e981f68fa"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("5f5c0555-6060-4934-b26b-b18c4e89409a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6501f156-c9b8-4660-8113-9c312795dc7b"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("73a3f799-d562-4045-875c-d6c998a41ccf"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b3fb3b64-1bff-41e2-8e2e-e23990bdaed8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("b42eac5f-d04c-42ab-84f0-90bde24684a4"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c39a5af6-b09d-45d7-afa2-d5ce2ab8f02a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d6675e62-1943-4728-a860-90cfcaa3122d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d7325c69-f141-4cce-9b63-5b0cc5676a0c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e4e7b7b0-516c-4683-80e3-44efc5af9adb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("ee92e02a-5e08-43a6-aebd-6633ce425045"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f431d3fb-715d-4488-bc54-83c60a08ceb0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1c631646-4fe5-45b9-9616-df78f3a72a00"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("41efab7c-d555-42fb-b5b7-8f26335a83dc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("56b65229-1ed4-45ef-a14f-217d9c9e44e0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("682ee567-144d-42fb-8177-1be81802a4e6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6adc91b5-302f-41cf-bb36-ea76bdd9ae19"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("751115f6-9c16-4502-a75a-2464dfa4e1c5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a440ac27-a6ec-4af2-b873-f8a94be0bf08"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ed0ba1ca-87c7-4438-b519-cadd2f948a19"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "LastEditedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0eb1e1f2-b5de-4d69-8237-4d28ab4c90ff"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2784), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2784), "Adventure" },
                    { new Guid("33a3db15-80a6-4e8a-b6cc-2500fc6bfa75"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2789), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2790), "Shooter" },
                    { new Guid("4bb407a1-128f-40e2-8363-5ff17312c87d"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2781), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2782), "Free to Play" },
                    { new Guid("5719e94d-9c86-48b1-85c6-5cdd84e2e1db"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2777), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2777), "Action" },
                    { new Guid("7c3148a0-15f4-4e97-9d2f-1c035ab1e97a"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2779), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2780), "Strategy" },
                    { new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2773), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2774), "RPG" },
                    { new Guid("dd7d7e7f-ccd4-4a7f-86a1-2722e0e0a340"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2788), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2788), "Simulation" },
                    { new Guid("fae50298-4855-41de-a3ab-79eb15904f5d"), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2786), new DateTime(2023, 10, 20, 15, 18, 18, 438, DateTimeKind.Utc).AddTicks(2786), "Indie" }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0eb1e1f2-b5de-4d69-8237-4d28ab4c90ff"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4bb407a1-128f-40e2-8363-5ff17312c87d"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5719e94d-9c86-48b1-85c6-5cdd84e2e1db"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("33a3db15-80a6-4e8a-b6cc-2500fc6bfa75"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7c3148a0-15f4-4e97-9d2f-1c035ab1e97a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c1f30a98-144f-4ef1-9b41-07d7a946a92c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dd7d7e7f-ccd4-4a7f-86a1-2722e0e0a340"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fae50298-4855-41de-a3ab-79eb15904f5d"));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "LastEditedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("1c631646-4fe5-45b9-9616-df78f3a72a00"), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(214), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(215), "Free to Play" },
                    { new Guid("41efab7c-d555-42fb-b5b7-8f26335a83dc"), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(222), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(223), "Simulation" },
                    { new Guid("56b65229-1ed4-45ef-a14f-217d9c9e44e0"), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(217), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(217), "Adventure" },
                    { new Guid("682ee567-144d-42fb-8177-1be81802a4e6"), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(220), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(220), "Indie" },
                    { new Guid("6adc91b5-302f-41cf-bb36-ea76bdd9ae19"), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(212), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(212), "Strategy" },
                    { new Guid("751115f6-9c16-4502-a75a-2464dfa4e1c5"), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(205), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(206), "RPG" },
                    { new Guid("a440ac27-a6ec-4af2-b873-f8a94be0bf08"), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(208), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(209), "Action" },
                    { new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(199), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(200), "TestId" },
                    { new Guid("ed0ba1ca-87c7-4438-b519-cadd2f948a19"), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(230), new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(230), "Shooter" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Developer", "GenreId", "LastEditedDate", "Price", "Publisher", "Title" },
                values: new object[,]
                {
                    { new Guid("1d9f7152-23d3-43d5-8ffc-94c77fee6892"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9960), "Klei Entertainment", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9961), 9.99m, "Klei Entertainment", "Don't Starve" },
                    { new Guid("1e70550e-baf5-486f-a844-077e981f68fa"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9980), "Valve", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9981), 0m, "Valve", "Counter-Strike 2" },
                    { new Guid("5f5c0555-6060-4934-b26b-b18c4e89409a"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9984), "Larian Studios", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9985), 44.99m, "Larian Studios", "Divinity: Original Sin 2" },
                    { new Guid("6501f156-c9b8-4660-8113-9c312795dc7b"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9995), "FromSoftware", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9995), 59.99m, "Activision", "Sekiro: Shadows Die Twice" },
                    { new Guid("73a3f799-d562-4045-875c-d6c998a41ccf"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9977), "Bethesda Game Studios", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9978), 19.99m, "Bethesda Softworks", "The Elder Scrolls V: Skyrim" },
                    { new Guid("b3fb3b64-1bff-41e2-8e2e-e23990bdaed8"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9964), "Wube Software LTD.", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9965), 35.00m, "Wube Software LTD.", "Factorio" },
                    { new Guid("b42eac5f-d04c-42ab-84f0-90bde24684a4"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9929), "Bethesda Game Studios", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9930), 69.99m, "Bethesda Softworks", "Starfield" },
                    { new Guid("c39a5af6-b09d-45d7-afa2-d5ce2ab8f02a"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9933), "Valve", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9934), 0m, "Valve", "Dota 2" },
                    { new Guid("d6675e62-1943-4728-a860-90cfcaa3122d"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9987), "ConcernedApe", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9988), 14.99m, "ConcernedApe", "Stardew Valley" },
                    { new Guid("d7325c69-f141-4cce-9b63-5b0cc5676a0c"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9937), "Larian Studios", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9937), 59.99m, "Larian Studios", "Baldur's Gate 3" },
                    { new Guid("e4e7b7b0-516c-4683-80e3-44efc5af9adb"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9973), "CD PROJEKT RED", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9974), 39.99m, "CD PROJEKT RED", "The Witcher 3: Wild Hunt" },
                    { new Guid("ee92e02a-5e08-43a6-aebd-6633ce425045"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9967), "Klei Entertainment", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9968), 24.99m, "Klei Entertainment", "Oxygen Not Included" },
                    { new Guid("f431d3fb-715d-4488-bc54-83c60a08ceb0"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9922), "CD PROJEKT RED", new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"), new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9924), 59.99m, "CD PROJEKT RED", "Cyberpunk 2077" }
                });
        }
    }
}
