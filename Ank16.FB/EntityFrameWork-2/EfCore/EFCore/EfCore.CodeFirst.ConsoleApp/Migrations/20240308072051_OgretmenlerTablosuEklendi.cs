using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore.CodeFirst.ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class OgretmenlerTablosuEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Öğretmenler",
                columns: table => new
                {
                    No = table.Column<byte>(type: "tinyint", nullable: false),
                    EPosta = table.Column<string>(type: "varchar(50)", nullable: false),
                    Adı = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Soyadı = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    DoğumTarihi = table.Column<DateOnly>(name: "Doğum Tarihi", type: "date", nullable: false),
                    Dersler = table.Column<string>(type: "ntext", nullable: false),
                    Adres = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Öğretmenler", x => x.No);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Öğretmenler");
        }
    }
}
