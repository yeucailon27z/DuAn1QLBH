using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class da1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__HoaDonChi__HoaDo__49C3F6B7",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK__HoaDonChi__SanPh__4AB81AF0",
                table: "HoaDonChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonChiTiet_SanPhamID1",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "SanPhamID1",
                table: "HoaDonChiTiet");

            migrationBuilder.AlterColumn<string>(
                name: "SanPhamID",
                table: "HoaDonChiTiet",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HoaDonID",
                table: "HoaDonChiTiet",
                type: "uniqueidentifier",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_HoaDonID",
                table: "HoaDonChiTiet",
                column: "HoaDonID");

            migrationBuilder.AddForeignKey(
                name: "FK__HoaDonChi__HoaDo__49C3F6B7",
                table: "HoaDonChiTiet",
                column: "HoaDonID",
                principalTable: "HoaDon",
                principalColumn: "HoaDonID");

            migrationBuilder.AddForeignKey(
                name: "FK__HoaDonChi__SanPh__4AB81AF0",
                table: "HoaDonChiTiet",
                column: "SanPhamID",
                principalTable: "SanPham",
                principalColumn: "SanPhamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__HoaDonChi__HoaDo__49C3F6B7",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK__HoaDonChi__SanPh__4AB81AF0",
                table: "HoaDonChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonChiTiet_HoaDonID",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "HoaDonID",
                table: "HoaDonChiTiet");

            migrationBuilder.AlterColumn<Guid>(
                name: "SanPhamID",
                table: "HoaDonChiTiet",
                type: "uniqueidentifier",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SanPhamID1",
                table: "HoaDonChiTiet",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_SanPhamID1",
                table: "HoaDonChiTiet",
                column: "SanPhamID1");

            migrationBuilder.AddForeignKey(
                name: "FK__HoaDonChi__HoaDo__49C3F6B7",
                table: "HoaDonChiTiet",
                column: "SanPhamID",
                principalTable: "HoaDon",
                principalColumn: "HoaDonID");

            migrationBuilder.AddForeignKey(
                name: "FK__HoaDonChi__SanPh__4AB81AF0",
                table: "HoaDonChiTiet",
                column: "SanPhamID1",
                principalTable: "SanPham",
                principalColumn: "SanPhamID");
        }
    }
}
