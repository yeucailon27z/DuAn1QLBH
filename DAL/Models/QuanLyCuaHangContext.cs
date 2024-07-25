using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class QuanLyCuaHangContext : DbContext
{
    public QuanLyCuaHangContext()
    {
    }

    public QuanLyCuaHangContext(DbContextOptions<QuanLyCuaHangContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DoanhThu> DoanhThus { get; set; }

    public virtual DbSet<GiamGium> GiamGia { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-Q6N4J46;Database=QuanLyCuaHang;User Id=sa;Password=123456;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DoanhThu>(entity =>
        {
            entity.HasKey(e => e.DoanhThuId).HasName("PK__DoanhThu__D2C18FB1812186F6");

            entity.ToTable("DoanhThu");

            entity.Property(e => e.DoanhThuId).HasColumnName("DoanhThuID");
            entity.Property(e => e.TongDoanhThu).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<GiamGium>(entity =>
        {
            entity.HasKey(e => e.GiamGiaId).HasName("PK__GiamGia__40AD8FA7DB28A688");

            entity.Property(e => e.GiamGiaId).HasColumnName("GiamGiaID");
            entity.Property(e => e.MaGiamGia)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MoTa).HasMaxLength(100);
            entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDon__6956CE6964FEB9F8");

            entity.ToTable("HoaDon");

            entity.Property(e => e.HoaDonId).HasColumnName("HoaDonID");
            entity.Property(e => e.GiamGiaId).HasColumnName("GiamGiaID");
            entity.Property(e => e.HinhThucThanhToan).HasMaxLength(50);
            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.NhanVienId).HasColumnName("NhanVienID");
            entity.Property(e => e.TongTien).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.GiamGia).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.GiamGiaId)
                .HasConstraintName("FK__HoaDon__GiamGiaI__4CA06362");

            entity.HasOne(d => d.KhachHang).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.KhachHangId)
                .HasConstraintName("FK__HoaDon__KhachHan__4AB81AF0");

            entity.HasOne(d => d.NhanVien).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.NhanVienId)
                .HasConstraintName("FK__HoaDon__NhanVien__4BAC3F29");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.HoaDonChiTietId).HasName("PK__HoaDonCh__603A404A3A649649");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.HoaDonChiTietId).HasColumnName("HoaDonChiTietID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.HoaDonId).HasColumnName("HoaDonID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.HoaDon).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.HoaDonId)
                .HasConstraintName("FK__HoaDonChi__HoaDo__4F7CD00D");

            entity.HasOne(d => d.SanPham).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__HoaDonChi__SanPh__5070F446");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.KhachHangId).HasName("PK__KhachHan__880F211BD54C3968");

            entity.ToTable("KhachHang");

            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoTen).HasMaxLength(50);
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.LoaiSanPhamId).HasName("PK__LoaiSanP__AFC7DC85EF3BDB35");

            entity.ToTable("LoaiSanPham");

            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MoTa).HasMaxLength(100);
            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNhaCungCap).HasName("PK__NhaCungC__53DA920568CFDC61");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TenNhaCungCap)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.NhanVienId).HasName("PK__NhanVien__E27FD7EA1366E41D");

            entity.ToTable("NhanVien");

            entity.HasIndex(e => e.Username, "UQ__NhanVien__536C85E4927CCF77").IsUnique();

            entity.Property(e => e.NhanVienId).HasColumnName("NhanVienID");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF498C329B5");

            entity.ToTable("SanPham");

            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.Anh).HasMaxLength(100);
            entity.Property(e => e.Gia).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.LoaiSanPhamId).HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.Mota).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(100);

            entity.HasOne(d => d.LoaiSanPham).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.LoaiSanPhamId)
                .HasConstraintName("FK__SanPham__LoaiSan__44FF419A");

            entity.HasOne(d => d.MaNhaCungCapNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaNhaCungCap)
                .HasConstraintName("FK__SanPham__MaNhaCu__45F365D3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
