using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForeignKeyType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiamGia",
                columns: table => new
                {
                    GiamGiaID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaGiamGia = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TienMin = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    TienMax = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    PhanTramGiam = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    NgayBatDau = table.Column<DateOnly>(type: "date", nullable: true),
                    NgayKetThuc = table.Column<DateOnly>(type: "date", nullable: true),
                    TrangThai = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GiamGia__40AD8FA711F40A98", x => x.GiamGiaID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    KhachHangID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgaySinh = table.Column<DateOnly>(type: "date", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DienThoai = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TrangThai = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KhachHan__880F211B2C151D95", x => x.KhachHangID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    LoaiSanPhamID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LoaiSanP__AFC7DC85DA5791AA", x => x.LoaiSanPhamID);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaNhaCungCap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenNhaCungCap = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SoDienThoai = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TrangThai = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhaCungC__53DA92056D3B48EC", x => x.MaNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    NhanVienID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgaySinh = table.Column<DateOnly>(type: "date", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DienThoai = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TrangThai = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhanVien__E27FD7EAC2C53589", x => x.NhanVienID);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    SanPhamID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LoaiSanPhamID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaNhaCungCap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gia = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    Anh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NgayCapNhat = table.Column<DateOnly>(type: "date", nullable: true),
                    TrangThai = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SanPham__05180FF475534720", x => x.SanPhamID);
                    table.ForeignKey(
                        name: "FK__SanPham__LoaiSan__3F466844",
                        column: x => x.LoaiSanPhamID,
                        principalTable: "LoaiSanPham",
                        principalColumn: "LoaiSanPhamID");
                    table.ForeignKey(
                        name: "FK__SanPham__MaNhaCu__403A8C7D",
                        column: x => x.MaNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "MaNhaCungCap");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    HoaDonID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KhachHangID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NhanVienID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiamGiaID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HinhThucThanhToan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    TrangThai = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDon__6956CE69E93AA7D5", x => x.HoaDonID);
                    table.ForeignKey(
                        name: "FK__HoaDon__GiamGiaI__46E78A0C",
                        column: x => x.GiamGiaID,
                        principalTable: "GiamGia",
                        principalColumn: "GiamGiaID");
                    table.ForeignKey(
                        name: "FK__HoaDon__KhachHan__44FF419A",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHang",
                        principalColumn: "KhachHangID");
                    table.ForeignKey(
                        name: "FK__HoaDon__NhanVien__45F365D3",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "NhanVienID");
                });

            migrationBuilder.CreateTable(
                name: "DoanhThu",
                columns: table => new
                {
                    DoanhThuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngay = table.Column<DateOnly>(type: "date", nullable: true),
                    TongDoanhThu = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    HoaDonID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DoanhThu__D2C18FB110B2BE0D", x => x.DoanhThuID);
                    table.ForeignKey(
                        name: "FK__DoanhThu__HoaDon__4D94879B",
                        column: x => x.HoaDonID,
                        principalTable: "HoaDon",
                        principalColumn: "HoaDonID");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    HoaDonChiTietID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HoaDonID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 50, nullable: true),
                    SanPhamID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    DonGia = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDonCh__603A404A7EC4FAC0", x => x.HoaDonChiTietID);
                    table.ForeignKey(
                        name: "FK__HoaDonChi__HoaDo__49C3F6B7",
                        column: x => x.HoaDonID,
                        principalTable: "HoaDon",
                        principalColumn: "HoaDonID");
                    table.ForeignKey(
                        name: "FK__HoaDonChi__SanPh__4AB81AF0",
                        column: x => x.SanPhamID,
                        principalTable: "SanPham",
                        principalColumn: "SanPhamID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoanhThu_HoaDonID",
                table: "DoanhThu",
                column: "HoaDonID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_GiamGiaID",
                table: "HoaDon",
                column: "GiamGiaID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangID",
                table: "HoaDon",
                column: "KhachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienID",
                table: "HoaDon",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_HoaDonID",
                table: "HoaDonChiTiet",
                column: "HoaDonID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_SanPhamID",
                table: "HoaDonChiTiet",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "UQ__NhanVien__536C85E4E5DD5949",
                table: "NhanVien",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSanPhamID",
                table: "SanPham",
                column: "LoaiSanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaNhaCungCap",
                table: "SanPham",
                column: "MaNhaCungCap");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoanhThu");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "GiamGia");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "NhaCungCap");
        }
    }
}
