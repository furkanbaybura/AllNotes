using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK16CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class ArabalarEF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Muhendisler",
                columns: table => new
                {
                    MühendisTekilAnahtar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muhendisler", x => x.MühendisTekilAnahtar);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(39)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plakalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numarasi = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plakalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseNumber = table.Column<int>(type: "int", nullable: false),
                    KisiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arabalar_People_KisiId",
                        column: x => x.KisiId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arabalar_Plakalar_LicenseNumber",
                        column: x => x.LicenseNumber,
                        principalTable: "Plakalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArabaMuhendis",
                columns: table => new
                {
                    ArabalarId = table.Column<int>(type: "int", nullable: false),
                    MuhendislerMühendisTekilAnahtar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaMuhendis", x => new { x.ArabalarId, x.MuhendislerMühendisTekilAnahtar });
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Arabalar_ArabalarId",
                        column: x => x.ArabalarId,
                        principalTable: "Arabalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Muhendisler_MuhendislerMühendisTekilAnahtar",
                        column: x => x.MuhendislerMühendisTekilAnahtar,
                        principalTable: "Muhendisler",
                        principalColumn: "MühendisTekilAnahtar",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_KisiId",
                table: "Arabalar",
                column: "KisiId");

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_LicenseNumber",
                table: "Arabalar",
                column: "LicenseNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArabaMuhendis_MuhendislerMühendisTekilAnahtar",
                table: "ArabaMuhendis",
                column: "MuhendislerMühendisTekilAnahtar");

            migrationBuilder.CreateIndex(
                name: "IX_Plakalar_Numarasi",
                table: "Plakalar",
                column: "Numarasi",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArabaMuhendis");

            migrationBuilder.DropTable(
                name: "Arabalar");

            migrationBuilder.DropTable(
                name: "Muhendisler");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Plakalar");
        }
    }
}
