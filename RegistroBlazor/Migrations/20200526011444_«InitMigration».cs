using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroBlazor.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    notasId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<DateTime>(nullable: false),
                    ruta = table.Column<string>(nullable: false),
                    importancia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.notasId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notas");
        }
    }
}
