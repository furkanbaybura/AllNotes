using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Ev_Exercise.Migrations
{
    /// <inheritdoc />
    public partial class son : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KisiAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Daireler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KisiId = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daireler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Daireler_Kisiler_KisiId",
                        column: x => x.KisiId,
                        principalTable: "Kisiler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tapular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TapuAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaireId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tapular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tapular_Daireler_DaireId",
                        column: x => x.DaireId,
                        principalTable: "Daireler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Daireler_KisiId",
                table: "Daireler",
                column: "KisiId");

            migrationBuilder.CreateIndex(
                name: "IX_Tapular_DaireId",
                table: "Tapular",
                column: "DaireId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tapular");

            migrationBuilder.DropTable(
                name: "Daireler");

            migrationBuilder.DropTable(
                name: "Kisiler");
        }
    }
}
