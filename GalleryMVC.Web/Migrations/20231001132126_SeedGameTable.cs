using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GalleryMVC.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedGameTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name" },
                values: new object[,]
                {
                    { new Guid("28826e39-c217-46d4-a22a-37c26cdd48eb"), "Factorio" },
                    { new Guid("37c04cdf-36ec-4f36-a962-b94d05fce803"), "Baldur's Gate 3" },
                    { new Guid("53db647b-80c1-4f85-80b3-0572fa579655"), "Counter-Strike 2" },
                    { new Guid("daf2e7e3-93c6-4ae9-bbab-bcb2ffac0ca8"), "World of Warcraft" },
                    { new Guid("e916c02f-53eb-43c0-bfbc-eaf714917cb7"), "Eve Online" },
                    { new Guid("ec7d7fb4-4688-48c4-9b49-018f68fc2c27"), "Dota 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: new Guid("28826e39-c217-46d4-a22a-37c26cdd48eb"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: new Guid("37c04cdf-36ec-4f36-a962-b94d05fce803"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: new Guid("53db647b-80c1-4f85-80b3-0572fa579655"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: new Guid("daf2e7e3-93c6-4ae9-bbab-bcb2ffac0ca8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: new Guid("e916c02f-53eb-43c0-bfbc-eaf714917cb7"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: new Guid("ec7d7fb4-4688-48c4-9b49-018f68fc2c27"));
        }
    }
}
