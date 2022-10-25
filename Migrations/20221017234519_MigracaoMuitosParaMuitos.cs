using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "Armas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemHabilidades",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemHabilidades", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 17, 151, 61, 194, 199, 134, 29, 192, 53, 52, 178, 244, 43, 208, 236, 153, 234, 100, 208, 168, 73, 59, 237, 130, 215, 167, 57, 74, 117, 214, 115, 163, 80, 141, 190, 126, 121, 197, 16, 158, 53, 164, 221, 249, 222, 248, 56, 117, 140, 185, 119, 191, 88, 231, 234, 114, 110, 35, 127, 202, 134, 215, 71, 105 }, new byte[] { 155, 166, 28, 174, 60, 80, 98, 91, 75, 184, 241, 233, 179, 95, 167, 244, 192, 172, 87, 169, 229, 128, 68, 194, 243, 143, 15, 0, 150, 163, 230, 153, 3, 97, 205, 140, 67, 138, 71, 70, 187, 179, 166, 199, 166, 35, 57, 239, 24, 31, 48, 84, 250, 116, 210, 251, 53, 16, 71, 141, 182, 21, 139, 22, 209, 155, 18, 24, 78, 45, 53, 228, 62, 108, 110, 246, 157, 79, 51, 136, 211, 184, 12, 82, 159, 244, 79, 168, 200, 41, 215, 41, 18, 34, 168, 215, 231, 227, 85, 149, 228, 144, 174, 72, 76, 123, 31, 151, 117, 40, 196, 162, 243, 192, 178, 147, 116, 99, 49, 85, 199, 30, 118, 235, 110, 109, 215, 254 } });

            migrationBuilder.InsertData(
                table: "PersonagemHabilidades",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHabilidades_HabilidadeId",
                table: "PersonagemHabilidades",
                column: "HabilidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas");

            migrationBuilder.DropTable(
                name: "PersonagemHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "Armas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 157, 92, 169, 68, 28, 30, 175, 127, 158, 146, 210, 26, 143, 205, 0, 60, 165, 147, 215, 123, 153, 30, 151, 37, 97, 199, 63, 226, 110, 140, 233, 111, 188, 115, 167, 240, 88, 34, 139, 118, 111, 60, 232, 101, 128, 73, 241, 203, 154, 128, 254, 4, 77, 43, 171, 171, 54, 150, 150, 96, 139, 221, 50, 220 }, new byte[] { 64, 185, 75, 201, 95, 189, 195, 81, 145, 31, 27, 7, 10, 200, 8, 234, 42, 49, 92, 32, 13, 16, 232, 167, 239, 96, 116, 109, 151, 244, 232, 14, 69, 8, 94, 95, 37, 120, 1, 207, 80, 220, 9, 64, 38, 200, 157, 90, 134, 152, 117, 63, 71, 102, 240, 77, 223, 112, 24, 231, 230, 175, 254, 117, 190, 113, 15, 102, 177, 97, 197, 152, 16, 68, 163, 67, 128, 221, 23, 156, 197, 1, 172, 233, 34, 211, 228, 199, 245, 208, 156, 238, 188, 62, 185, 146, 83, 183, 35, 110, 193, 152, 224, 35, 117, 15, 240, 92, 94, 255, 41, 10, 165, 146, 119, 193, 250, 22, 33, 165, 225, 171, 159, 187, 230, 191, 199, 247 } });
        }
    }
}
