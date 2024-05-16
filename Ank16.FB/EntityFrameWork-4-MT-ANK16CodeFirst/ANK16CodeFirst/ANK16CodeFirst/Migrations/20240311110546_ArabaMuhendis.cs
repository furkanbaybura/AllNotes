using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK16CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class ArabaMuhendis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KisiId",
                table: "Arabalar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Muhendis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muhendis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArabaMuhendis",
                columns: table => new
                {
                    ArabalarId = table.Column<int>(type: "int", nullable: false),
                    MuhendislerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaMuhendis", x => new { x.ArabalarId, x.MuhendislerId });
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Arabalar_ArabalarId",
                        column: x => x.ArabalarId,
                        principalTable: "Arabalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Muhendis_MuhendislerId",
                        column: x => x.MuhendislerId,
                        principalTable: "Muhendis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_KisiId",
                table: "Arabalar",
                column: "KisiId");

            migrationBuilder.CreateIndex(
                name: "IX_ArabaMuhendis_MuhendislerId",
                table: "ArabaMuhendis",
                column: "MuhendislerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arabalar_Kisi_KisiId",
                table: "Arabalar",
                column: "KisiId",
                principalTable: "Kisi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arabalar_Kisi_KisiId",
                table: "Arabalar");

            migrationBuilder.DropTable(
                name: "ArabaMuhendis");

            migrationBuilder.DropTable(
                name: "Kisi");

            migrationBuilder.DropTable(
                name: "Muhendis");

            migrationBuilder.DropIndex(
                name: "IX_Arabalar_KisiId",
                table: "Arabalar");

            migrationBuilder.DropColumn(
                name: "KisiId",
                table: "Arabalar");
        }
    }
}
