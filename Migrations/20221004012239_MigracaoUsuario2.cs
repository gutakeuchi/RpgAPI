﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    public partial class MigracaoUsuario2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 157, 92, 169, 68, 28, 30, 175, 127, 158, 146, 210, 26, 143, 205, 0, 60, 165, 147, 215, 123, 153, 30, 151, 37, 97, 199, 63, 226, 110, 140, 233, 111, 188, 115, 167, 240, 88, 34, 139, 118, 111, 60, 232, 101, 128, 73, 241, 203, 154, 128, 254, 4, 77, 43, 171, 171, 54, 150, 150, 96, 139, 221, 50, 220 }, new byte[] { 64, 185, 75, 201, 95, 189, 195, 81, 145, 31, 27, 7, 10, 200, 8, 234, 42, 49, 92, 32, 13, 16, 232, 167, 239, 96, 116, 109, 151, 244, 232, 14, 69, 8, 94, 95, 37, 120, 1, 207, 80, 220, 9, 64, 38, 200, 157, 90, 134, 152, 117, 63, 71, 102, 240, 77, 223, 112, 24, 231, 230, 175, 254, 117, 190, 113, 15, 102, 177, 97, 197, 152, 16, 68, 163, 67, 128, 221, 23, 156, 197, 1, 172, 233, 34, 211, 228, 199, 245, 208, 156, 238, 188, 62, 185, 146, 83, 183, 35, 110, 193, 152, 224, 35, 117, 15, 240, 92, 94, 255, 41, 10, 165, 146, 119, 193, 250, 22, 33, 165, 225, 171, 159, 187, 230, 191, 199, 247 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 66, 69, 98, 215, 96, 180, 3, 216, 211, 166, 10, 87, 147, 245, 170, 53, 188, 167, 110, 178, 56, 141, 80, 155, 167, 191, 54, 87, 19, 47, 160, 91, 124, 6, 246, 0, 27, 225, 70, 176, 44, 67, 204, 42, 3, 205, 47, 145, 96, 64, 72, 204, 56, 181, 255, 82, 178, 93, 165, 83, 170, 6, 236, 198 }, new byte[] { 47, 238, 209, 107, 92, 88, 253, 233, 106, 63, 87, 123, 48, 228, 69, 111, 164, 46, 146, 2, 218, 4, 83, 70, 212, 126, 8, 88, 100, 102, 69, 228, 85, 246, 15, 114, 212, 28, 12, 52, 187, 228, 94, 97, 249, 6, 231, 18, 60, 41, 21, 231, 176, 203, 98, 209, 240, 5, 215, 185, 78, 67, 48, 139, 59, 216, 78, 241, 204, 63, 99, 203, 184, 68, 142, 7, 74, 84, 196, 125, 103, 218, 85, 91, 214, 52, 139, 103, 192, 236, 248, 249, 25, 87, 150, 7, 149, 65, 118, 204, 188, 119, 197, 13, 30, 153, 57, 48, 230, 55, 91, 91, 203, 219, 84, 221, 198, 43, 230, 14, 150, 52, 133, 139, 188, 17, 6, 205 } });
        }
    }
}
