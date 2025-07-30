using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReservaApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEquipamento = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    NomePessoa = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    DataReservado = table.Column<DateTime>(type: "SMALLDATETIME", maxLength: 60, nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "SMALLDATETIME", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamento", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NomeEquipamento",
                table: "Equipamento",
                column: "NomeEquipamento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipamento");
        }
    }
}
