using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK16CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class iki : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlakaId",
                table: "Arabalar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Plakalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numarasi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plakalar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_PlakaId",
                table: "Arabalar",
                column: "PlakaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Arabalar_Plakalar_PlakaId",
                table: "Arabalar",
                column: "PlakaId",
                principalTable: "Plakalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arabalar_Plakalar_PlakaId",
                table: "Arabalar");

            migrationBuilder.DropTable(
                name: "Plakalar");

            migrationBuilder.DropIndex(
                name: "IX_Arabalar_PlakaId",
                table: "Arabalar");

            migrationBuilder.DropColumn(
                name: "PlakaId",
                table: "Arabalar");
        }
    }
}
