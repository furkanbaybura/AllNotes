using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCore.CodeFirst.ConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class YeniKitapvekitapTurleri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookTypesTwo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTypesTwo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BooksTwo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksTwo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BooksTwo_BookTypesTwo_BookTypeId",
                        column: x => x.BookTypeId,
                        principalTable: "BookTypesTwo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BooksTwo_BookTypeId",
                table: "BooksTwo",
                column: "BookTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksTwo");

            migrationBuilder.DropTable(
                name: "BookTypesTwo");
        }
    }
}
