using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AbySalto.Junior.Infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class ArticleDataDump : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Rajčica, mozzarella", "Pizza Margherita", 8.50m },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Šunka, gljive", "Pizza Capricciosa", 9.50m },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Kulen, sir, paprika", "Pizza Slavonska", 10.00m },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "10 komada, lepinja, luk", "Ćevapi", 8.00m },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Miješano meso, lepinja", "Pljeskavica", 7.50m },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Grill piletina", "Pileći file", 9.00m },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Prženi krumpirići", "Pomfrit", 3.00m },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Tjestenina s mesnim umakom", "Spaghetti Bolognese", 9.50m },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Panceta, vrhnje", "Carbonara", 9.80m },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Čokoladni namaz", "Palačinke Nutella", 5.00m },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Voćna marmelada", "Palačinke marmelada", 4.50m },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Sezonsko povrće", "Miješana salata", 3.50m },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Sir, rajčica, paprika", "Šopska salata", 4.00m },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "Domaća juha", "Juha dana", 3.50m },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "0.33l", "Coca Cola", 2.50m },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "0.33l", "Fanta", 2.50m },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "0.33l", "Sprite", 2.50m },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "0.5l", "Mineralna voda", 2.00m },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "0.5l", "Negazirana voda", 2.00m },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "Kratka kava", "Espresso", 1.80m },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "Kava s mlijekom", "Cappuccino", 2.20m },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "Kava s puno mlijeka", "Latte", 2.50m },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "0.5l", "Pivo", 3.00m },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "Čaša", "Bijelo vino", 3.50m },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "Čaša", "Crno vino", 3.50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"));
        }
    }
}
