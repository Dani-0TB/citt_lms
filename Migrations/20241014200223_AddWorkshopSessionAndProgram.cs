using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace citt_lms.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkshopSessionAndProgram : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "PrimerNombre",
                keyValue: null,
                column: "PrimerNombre",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                table: "Users",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ApellidoMaterno",
                table: "Users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ApellidoPaterno",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CarreraId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SegundoNombre",
                table: "Users",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "SemestreCarrera",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CarreraId",
                table: "Users",
                column: "CarreraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Carrera_CarreraId",
                table: "Users",
                column: "CarreraId",
                principalTable: "Carrera",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Carrera_CarreraId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Carrera");

            migrationBuilder.DropIndex(
                name: "IX_Users_CarreraId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ApellidoMaterno",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ApellidoPaterno",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CarreraId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SegundoNombre",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SemestreCarrera",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                table: "Users",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
