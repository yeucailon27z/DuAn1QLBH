using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class Da1quanLyCuaHangContext : DbContext
{
    public Da1quanLyCuaHangContext()
    {
    }

    public Da1quanLyCuaHangContext(DbContextOptions<Da1quanLyCuaHangContext> options)
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
        => optionsBuilder.UseSqlServer("Server=DESKTOP-Q6N4J46;Database=DA1QuanLyCuaHang_5;User Id=sa;Password=123456;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DoanhThu>(entity =>
        {
            entity.HasKey(e => e.DoanhThuId).HasName("PK__DoanhThu__D2C18FB110B2BE0D");

            entity.ToTable("DoanhThu");

            entity.Property(e => e.DoanhThuId).HasColumnName("DoanhThuID");
            entity.Property(e => e.HoaDonId)
                .HasMaxLength(50)
                .HasColumnName("HoaDonID");
            entity.Property(e => e.TongDoanhThu).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.HoaDon).WithMany(p => p.DoanhThus)
                .HasForeignKey(d => d.HoaDonId)
                .HasConstraintName("FK__DoanhThu__HoaDon__4D94879B");
        });

        modelBuilder.Entity<GiamGium>(entity =>
        {
            entity.HasKey(e => e.GiamGiaId).HasName("PK__GiamGia__40AD8FA711F40A98");

            entity.Property(e => e.GiamGiaId)
                .HasMaxLength(50)
                .HasColumnName("GiamGiaID");
            entity.Property(e => e.MaGiamGia)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MoTa).HasMaxLength(100);
            entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TienMax).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TienMin).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDon__6956CE69E93AA7D5");

            entity.ToTable("HoaDon");

            entity.Property(e => e.HoaDonId)
                .HasMaxLength(50)
                .HasColumnName("HoaDonID");
            entity.Property(e => e.GiamGiaId)
                .HasMaxLength(50)
                .HasColumnName("GiamGiaID");
            entity.Property(e => e.HinhThucThanhToan).HasMaxLength(50);
            entity.Property(e => e.KhachHangId)
                .HasMaxLength(50)
                .HasColumnName("KhachHangID");
            entity.Property(e => e.NhanVienId)
                .HasMaxLength(50)
                .HasColumnName("NhanVienID");
            entity.Property(e => e.TongTien).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.GiamGia).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.GiamGiaId)
                .HasConstraintName("FK__HoaDon__GiamGiaI__46E78A0C");

            entity.HasOne(d => d.KhachHang).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.KhachHangId)
                .HasConstraintName("FK__HoaDon__KhachHan__44FF419A");

            entity.HasOne(d => d.NhanVien).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.NhanVienId)
                .HasConstraintName("FK__HoaDon__NhanVien__45F365D3");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.HoaDonChiTietID).HasName("PK__HoaDonCh__603A404A7EC4FAC0");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.HoaDonChiTietID)
                .HasMaxLength(50)
                .HasColumnName("HoaDonChiTietID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.HoaDonID)
                .HasMaxLength(50)
                .HasColumnName("HoaDonID");
            entity.Property(e => e.SanPhamID)
                .HasMaxLength(50)
                .HasColumnName("SanPhamID");

            entity.HasOne(d => d.HoaDon).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.HoaDonID)
                .HasConstraintName("FK__HoaDonChi__HoaDo__49C3F6B7");

            entity.HasOne(d => d.SanPham).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.SanPhamID)
                .HasConstraintName("FK__HoaDonChi__SanPh__4AB81AF0");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.KhachHangId).HasName("PK__KhachHan__880F211B2C151D95");

            entity.ToTable("KhachHang");

            entity.Property(e => e.KhachHangId)
                .HasMaxLength(50)
                .HasColumnName("KhachHangID");
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
            entity.HasKey(e => e.LoaiSanPhamId).HasName("PK__LoaiSanP__AFC7DC85DA5791AA");

            entity.ToTable("LoaiSanPham");

            entity.Property(e => e.LoaiSanPhamId)
                .HasMaxLength(50)
                .HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MoTa).HasMaxLength(100);
            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNhaCungCap).HasName("PK__NhaCungC__53DA92056D3B48EC");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.MaNhaCungCap).HasMaxLength(50);
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
            entity.HasKey(e => e.NhanVienId).HasName("PK__NhanVien__E27FD7EAC2C53589");

            entity.ToTable("NhanVien");

            entity.HasIndex(e => e.Username, "UQ__NhanVien__536C85E4E5DD5949").IsUnique();

            entity.Property(e => e.NhanVienId)
                .HasMaxLength(50)
                .HasColumnName("NhanVienID");
            entity.Property(e => e.DienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ChucVu)
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
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF475534720");

            entity.ToTable("SanPham");

            entity.Property(e => e.SanPhamId)
                .HasMaxLength(50)
                .HasColumnName("SanPhamID");
            entity.Property(e => e.Anh).HasMaxLength(100);
            entity.Property(e => e.Gia).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.LoaiSanPhamId)
                .HasMaxLength(50)
                .HasColumnName("LoaiSanPhamID");
            entity.Property(e => e.MaNhaCungCap).HasMaxLength(50);
            entity.Property(e => e.MoTa).HasMaxLength(200);
            entity.Property(e => e.TenSanPham).HasMaxLength(100);

            entity.HasOne(d => d.LoaiSanPham).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.LoaiSanPhamId)
                .HasConstraintName("FK__SanPham__LoaiSan__3F466844");

            entity.HasOne(d => d.MaNhaCungCapNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaNhaCungCap)
                .HasConstraintName("FK__SanPham__MaNhaCu__403A8C7D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
