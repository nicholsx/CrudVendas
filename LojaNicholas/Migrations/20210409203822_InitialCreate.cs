using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaNicholas.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CdCl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DsNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdVend = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DsLim = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CdVend = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DsNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CdTab = table.Column<int>(type: "int", nullable: false),
                    DtNasc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendedoresID = table.Column<int>(type: "int", nullable: false),
                    ClientesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.EnrollmentID);
                    table.ForeignKey(
                        name: "FK_Enrollments_Clientes_ClientesID",
                        column: x => x.ClientesID,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Vendedores_VendedoresID",
                        column: x => x.VendedoresID,
                        principalTable: "Vendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_ClientesID",
                table: "Enrollments",
                column: "ClientesID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_VendedoresID",
                table: "Enrollments",
                column: "VendedoresID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Vendedores");
        }
    }
}
