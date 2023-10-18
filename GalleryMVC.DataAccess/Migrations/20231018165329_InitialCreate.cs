using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GalleryMVC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
