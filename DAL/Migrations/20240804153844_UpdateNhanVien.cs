using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNhanVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "NgaySinh",
                table: "NhanVien");

            migrationBuilder.AddColumn<byte>(
                name: "ChucVu",
                table: "NhanVien",
                type: "tinyint",
                unicode: false,
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChucVu",
                table: "NhanVien");

            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "NhanVien",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "NhanVien",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "NgaySinh",
                table: "NhanVien",
                type: "date",
                nullable: true);
        }
    }
}
