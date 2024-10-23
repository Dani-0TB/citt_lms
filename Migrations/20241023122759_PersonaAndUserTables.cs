using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace citt_lms.Migrations
{
    /// <inheritdoc />
    public partial class PersonaAndUserTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Carreras_CarreraId",
                table: "Users");

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
                name: "PrimerNombre",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SegundoNombre",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SemestreCarrera",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "PrimerNombre",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_CarreraId",
                table: "Users",
                column: "CarreraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Carreras_CarreraId",
                table: "Users",
                column: "CarreraId",
                principalTable: "Carreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
