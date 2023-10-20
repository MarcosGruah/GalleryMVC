using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GalleryMVC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyForGameGenreRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("227dd2b7-b1c1-465d-a9ed-2fdfcccc10ee"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("422eb0eb-0ffb-4d2c-aae0-fc16469ee91a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("45b13b93-d65c-46e9-b0d9-bd67f0a96cb1"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("46489170-424c-4b84-bf04-b95fbab4e808"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4a2087f2-4160-4c81-a483-f37a0922d443"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4d5450ca-6149-4957-987c-9ce996dab04a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6aa1c0a4-0934-4e51-a33b-e1a197bce73d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("76732f24-ed23-46c5-993b-573ed3544175"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7edb1882-dd74-4bdb-a141-d7eef4eedd6e"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("8a68792a-8c57-4680-b89f-4fd146570e45"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c6ed4b98-0556-435f-8940-f7d486286cbd"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("dd02828e-3806-468b-b3ce-7c42558a9ce7"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("fe4e43e1-0c16-4e88-a962-d0c9d4cf4b1e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1fe45c37-7610-41ba-bf04-b2fe44834b88"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("233e98c9-d1e9-4d9a-b792-0989972e010c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2b7e813e-b596-4814-9e17-cc3f6f8d3511"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4dca4171-1a21-47cd-bc37-b9730b46c6c0"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8a4b0785-7a97-4966-b33c-25ffcf2b96e5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("96198011-bb28-4b09-8b40-249b8e8c5c67"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b3b45281-cce0-42d4-8ad3-d8ece0a2e55f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c9d4ab26-bf24-4533-a3fd-0b9778f6ab11"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<Guid>(
                name: "GenreId",
                table: "Games",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Genres_GenreId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_GenreId",
                table: "Games");

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

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Games");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "CreatedDate", "Developer", "LastEditedDate", "Price", "Publisher", "Title" },
                values: new object[,]
                {
                    { new Guid("227dd2b7-b1c1-465d-a9ed-2fdfcccc10ee"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5594), "ConcernedApe", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5594), 14.99m, "ConcernedApe", "Stardew Valley" },
                    { new Guid("422eb0eb-0ffb-4d2c-aae0-fc16469ee91a"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5572), "Klei Entertainment", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5573), 9.99m, "Klei Entertainment", "Don't Starve" },
                    { new Guid("45b13b93-d65c-46e9-b0d9-bd67f0a96cb1"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5586), "Bethesda Game Studios", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5587), 19.99m, "Bethesda Softworks", "The Elder Scrolls V: Skyrim" },
                    { new Guid("46489170-424c-4b84-bf04-b95fbab4e808"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5581), "CD PROJEKT RED", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5581), 39.99m, "CD PROJEKT RED", "The Witcher 3: Wild Hunt" },
                    { new Guid("4a2087f2-4160-4c81-a483-f37a0922d443"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5591), "Larian Studios", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5592), 44.99m, "Larian Studios", "Divinity: Original Sin 2" },
                    { new Guid("4d5450ca-6149-4957-987c-9ce996dab04a"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5575), "Wube Software LTD.", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5576), 35.00m, "Wube Software LTD.", "Factorio" },
                    { new Guid("6aa1c0a4-0934-4e51-a33b-e1a197bce73d"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5596), "FromSoftware", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5597), 59.99m, "Activision", "Sekiro: Shadows Die Twice" },
                    { new Guid("76732f24-ed23-46c5-993b-573ed3544175"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5569), "Larian Studios", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5569), 59.99m, "Larian Studios", "Baldur's Gate 3" },
                    { new Guid("7edb1882-dd74-4bdb-a141-d7eef4eedd6e"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5557), "CD PROJEKT RED", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5559), 59.99m, "CD PROJEKT RED", "Cyberpunk 2077" },
                    { new Guid("8a68792a-8c57-4680-b89f-4fd146570e45"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5563), "Bethesda Game Studios", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5563), 69.99m, "Bethesda Softworks", "Starfield" },
                    { new Guid("c6ed4b98-0556-435f-8940-f7d486286cbd"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5566), "Valve", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5567), 0m, "Valve", "Dota 2" },
                    { new Guid("dd02828e-3806-468b-b3ce-7c42558a9ce7"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5589), "Valve", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5589), 0m, "Valve", "Counter-Strike 2" },
                    { new Guid("fe4e43e1-0c16-4e88-a962-d0c9d4cf4b1e"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5578), "Klei Entertainment", new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5578), 24.99m, "Klei Entertainment", "Oxygen Not Included" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "LastEditedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("1fe45c37-7610-41ba-bf04-b2fe44834b88"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5830), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5830), "Shooter" },
                    { new Guid("233e98c9-d1e9-4d9a-b792-0989972e010c"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5776), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5777), "Free to Play" },
                    { new Guid("2b7e813e-b596-4814-9e17-cc3f6f8d3511"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5825), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5826), "Indie" },
                    { new Guid("4dca4171-1a21-47cd-bc37-b9730b46c6c0"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5768), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5768), "Action" },
                    { new Guid("8a4b0785-7a97-4966-b33c-25ffcf2b96e5"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5770), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5771), "Strategy" },
                    { new Guid("96198011-bb28-4b09-8b40-249b8e8c5c67"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5765), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5765), "RPG" },
                    { new Guid("b3b45281-cce0-42d4-8ad3-d8ece0a2e55f"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5828), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5828), "Simulation" },
                    { new Guid("c9d4ab26-bf24-4533-a3fd-0b9778f6ab11"), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5778), new DateTime(2023, 10, 18, 19, 44, 25, 714, DateTimeKind.Utc).AddTicks(5779), "Adventure" }
                });
        }
    }
}
