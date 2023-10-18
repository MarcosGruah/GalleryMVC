using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GalleryMVC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCreateDateAndLastEidtedDateAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("09bf6c7d-39aa-4a61-98ac-56bea91e6faa"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("20077903-161a-44db-89de-c6684ae7e54d"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2b6ccb7e-33f4-44c6-ba81-f5b557f0eab9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("3955d5a2-d278-4514-a128-3753696128df"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("620441b4-9dd7-4b43-b045-d812f9cea10a"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("670f2e23-94e4-4f51-9dd1-57fae8c91f80"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("7cb71ee8-c2d6-4e84-8f51-37fec48fa104"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a20e924d-28b0-4259-8d81-ca15af01ecd9"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("a6dec3cb-b081-4684-8408-85d479aa0448"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("aa1ffc19-9bc2-45e8-ad4b-1921d1988c45"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("c4a57d79-1564-4c8c-a809-3f4cd5a58623"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d928e878-2672-4234-bd83-82d03108e952"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("f4a9f91c-23aa-4924-868a-0d203502ffdc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0389e44f-1f5a-4d6e-9423-3951322f5fd1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("06398b44-7d13-4b77-8904-d44a1268301f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2a22b6c9-52bf-4cd3-9b7a-23c71910a122"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8117cb3b-ee33-4c6c-bf78-7cf9ea58d502"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("8ec62502-42a6-4908-8035-b2587ede74f8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("eb36bf4f-5116-484b-befb-df343e136b2e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f1f300c5-1945-4656-ab9c-00daf2dcedab"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f51ad048-169a-476d-8f01-df37dfac66dd"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Genres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEditedDate",
                table: "Genres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEditedDate",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "LastEditedDate",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "LastEditedDate",
                table: "Games");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Developer", "Price", "Publisher", "Title" },
                values: new object[,]
                {
                    { new Guid("09bf6c7d-39aa-4a61-98ac-56bea91e6faa"), "Valve", 0m, "Valve", "Counter-Strike 2" },
                    { new Guid("20077903-161a-44db-89de-c6684ae7e54d"), "CD PROJEKT RED", 59.99m, "CD PROJEKT RED", "Cyberpunk 2077" },
                    { new Guid("2b6ccb7e-33f4-44c6-ba81-f5b557f0eab9"), "Klei Entertainment", 9.99m, "Klei Entertainment", "Don't Starve" },
                    { new Guid("3955d5a2-d278-4514-a128-3753696128df"), "Larian Studios", 59.99m, "Larian Studios", "Baldur's Gate 3" },
                    { new Guid("620441b4-9dd7-4b43-b045-d812f9cea10a"), "Larian Studios", 44.99m, "Larian Studios", "Divinity: Original Sin 2" },
                    { new Guid("670f2e23-94e4-4f51-9dd1-57fae8c91f80"), "Valve", 0m, "Valve", "Dota 2" },
                    { new Guid("7cb71ee8-c2d6-4e84-8f51-37fec48fa104"), "Klei Entertainment", 24.99m, "Klei Entertainment", "Oxygen Not Included" },
                    { new Guid("a20e924d-28b0-4259-8d81-ca15af01ecd9"), "FromSoftware", 59.99m, "Activision", "Sekiro: Shadows Die Twice" },
                    { new Guid("a6dec3cb-b081-4684-8408-85d479aa0448"), "ConcernedApe", 14.99m, "ConcernedApe", "Stardew Valley" },
                    { new Guid("aa1ffc19-9bc2-45e8-ad4b-1921d1988c45"), "CD PROJEKT RED", 39.99m, "CD PROJEKT RED", "The Witcher 3: Wild Hunt" },
                    { new Guid("c4a57d79-1564-4c8c-a809-3f4cd5a58623"), "Bethesda Game Studios", 19.99m, "Bethesda Softworks", "The Elder Scrolls V: Skyrim" },
                    { new Guid("d928e878-2672-4234-bd83-82d03108e952"), "Wube Software LTD.", 35.00m, "Wube Software LTD.", "Factorio" },
                    { new Guid("f4a9f91c-23aa-4924-868a-0d203502ffdc"), "Bethesda Game Studios", 69.99m, "Bethesda Softworks", "Starfield" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0389e44f-1f5a-4d6e-9423-3951322f5fd1"), "Indie" },
                    { new Guid("06398b44-7d13-4b77-8904-d44a1268301f"), "Free to Play" },
                    { new Guid("2a22b6c9-52bf-4cd3-9b7a-23c71910a122"), "Simulation" },
                    { new Guid("8117cb3b-ee33-4c6c-bf78-7cf9ea58d502"), "Shooter" },
                    { new Guid("8ec62502-42a6-4908-8035-b2587ede74f8"), "RPG" },
                    { new Guid("eb36bf4f-5116-484b-befb-df343e136b2e"), "Strategy" },
                    { new Guid("f1f300c5-1945-4656-ab9c-00daf2dcedab"), "Adventure" },
                    { new Guid("f51ad048-169a-476d-8f01-df37dfac66dd"), "Action" }
                });
        }
    }
}
