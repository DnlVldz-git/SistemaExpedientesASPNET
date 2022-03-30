using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlExpedientes.Data.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    ApellidoPat = table.Column<string>(nullable: false),
                    ApellidoMat = table.Column<string>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    RFC = table.Column<string>(nullable: true),
                    TipoSangre = table.Column<string>(nullable: false),
                    FechaNac = table.Column<DateTime>(nullable: false),
                    Alcoholismo = table.Column<bool>(nullable: false),
                    Tabaquismo = table.Column<bool>(nullable: false),
                    Toxicomanía = table.Column<bool>(nullable: false),
                    Dirección = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    CURP = table.Column<string>(nullable: false),
                    Aseguradora = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
