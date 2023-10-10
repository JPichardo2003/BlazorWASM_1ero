using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWASM_1ero.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aportes",
                columns: table => new
                {
                    AporteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Persona = table.Column<string>(type: "TEXT", nullable: false),
                    Observación = table.Column<string>(type: "TEXT", nullable: false),
                    Monto = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aportes", x => x.AporteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aportes");
        }
    }
}
