using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore.CodeFirst.ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class DerslerTablosuEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    DersAdı = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Credit = table.Column<byte>(type: "tinyint", nullable: false),
                    DersAciklama = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersBaslangicTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dersler");
        }
    }
}
