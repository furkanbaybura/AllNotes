using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK16CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arabalar_People_KisiId",
                table: "Arabalar");

            migrationBuilder.DropForeignKey(
                name: "FK_ArabaMuhendis_Muhendisler_MuhendislerMühendisTekilAnahtar",
                table: "ArabaMuhendis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Muhendisler",
                table: "Muhendisler");

            migrationBuilder.RenameTable(
                name: "Muhendisler",
                newName: "Engineer");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "People",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "People",
                newName: "KisiTekilAnahtar");

            migrationBuilder.RenameColumn(
                name: "KisiId",
                table: "Arabalar",
                newName: "PersonNo");

            migrationBuilder.RenameIndex(
                name: "IX_Arabalar_KisiId",
                table: "Arabalar",
                newName: "IX_Arabalar_PersonNo");

            migrationBuilder.AddColumn<long>(
                name: "TcKimlikNo",
                table: "People",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "Marka",
                table: "Arabalar",
                type: "nvarchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engineer",
                table: "Engineer",
                column: "MühendisTekilAnahtar");

            migrationBuilder.CreateIndex(
                name: "IX_People_TcKimlikNo",
                table: "People",
                column: "TcKimlikNo",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Arabalar_People_PersonNo",
                table: "Arabalar",
                column: "PersonNo",
                principalTable: "People",
                principalColumn: "KisiTekilAnahtar",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArabaMuhendis_Engineer_MuhendislerMühendisTekilAnahtar",
                table: "ArabaMuhendis",
                column: "MuhendislerMühendisTekilAnahtar",
                principalTable: "Engineer",
                principalColumn: "MühendisTekilAnahtar",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arabalar_People_PersonNo",
                table: "Arabalar");

            migrationBuilder.DropForeignKey(
                name: "FK_ArabaMuhendis_Engineer_MuhendislerMühendisTekilAnahtar",
                table: "ArabaMuhendis");

            migrationBuilder.DropIndex(
                name: "IX_People_TcKimlikNo",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engineer",
                table: "Engineer");

            migrationBuilder.DropColumn(
                name: "TcKimlikNo",
                table: "People");

            migrationBuilder.RenameTable(
                name: "Engineer",
                newName: "Muhendisler");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "People",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "KisiTekilAnahtar",
                table: "People",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PersonNo",
                table: "Arabalar",
                newName: "KisiId");

            migrationBuilder.RenameIndex(
                name: "IX_Arabalar_PersonNo",
                table: "Arabalar",
                newName: "IX_Arabalar_KisiId");

            migrationBuilder.AlterColumn<string>(
                name: "Marka",
                table: "Arabalar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Muhendisler",
                table: "Muhendisler",
                column: "MühendisTekilAnahtar");

            migrationBuilder.AddForeignKey(
                name: "FK_Arabalar_People_KisiId",
                table: "Arabalar",
                column: "KisiId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArabaMuhendis_Muhendisler_MuhendislerMühendisTekilAnahtar",
                table: "ArabaMuhendis",
                column: "MuhendislerMühendisTekilAnahtar",
                principalTable: "Muhendisler",
                principalColumn: "MühendisTekilAnahtar",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
