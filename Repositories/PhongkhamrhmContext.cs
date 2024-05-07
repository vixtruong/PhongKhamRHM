using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Repositories.Entities;

public partial class PhongkhamrhmContext : DbContext
{
    public PhongkhamrhmContext()
    {
    }

    public PhongkhamrhmContext(DbContextOptions<PhongkhamrhmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bacsi> Bacsis { get; set; }

    public virtual DbSet<Benhnhan> Benhnhans { get; set; }

    public virtual DbSet<Calamviec> Calamviecs { get; set; }

    public virtual DbSet<Chitietpkb> Chitietpkbs { get; set; }

    public virtual DbSet<Chitiettoathuoc> Chitiettoathuocs { get; set; }

    public virtual DbSet<Chitietvatlieutieuhao> Chitietvatlieutieuhaos { get; set; }

    public virtual DbSet<Chuphongkham> Chuphongkhams { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Hosobenhan> Hosobenhans { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Kythuat> Kythuats { get; set; }

    public virtual DbSet<Letan> Letans { get; set; }

    public virtual DbSet<Lichhen> Lichhens { get; set; }

    public virtual DbSet<Phieukhambenh> Phieukhambenhs { get; set; }

    public virtual DbSet<Phuta> Phutas { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Thuoc> Thuocs { get; set; }

    public virtual DbSet<Toathuoc> Toathuocs { get; set; }

    public virtual DbSet<Vatlieu> Vatlieus { get; set; }

    public virtual DbSet<Vitribenh> Vitribenhs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());


    private string? GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DBDefault"];
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.MaKhoa).HasName("PK__KHOA__22F417703DF9FB3F");

            entity.ToTable("KHOA");
            entity.Property(e => e.MaKhoa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAKHOA");
            entity.Property(e => e.TenKhoa).HasMaxLength(50);
        });

        modelBuilder.Entity<Bacsi>(entity =>
        {
            entity.HasKey(e => e.MaBs).HasName("PK__BACSI__27247596214798D4");

            entity.ToTable("BACSI");

            entity.Property(e => e.MaBs)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaBS");
            entity.Property(e => e.Gioitinh).HasMaxLength(3);
            entity.Property(e => e.Hoten).HasMaxLength(40);
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<Benhnhan>(entity =>
        {
            entity.HasKey(e => e.MaBn).HasName("PK__BENHNHAN__272475AD9B799666");

            entity.ToTable("BENHNHAN");

            entity.Property(e => e.MaBn)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaBN");
            entity.Property(e => e.Hoten).HasMaxLength(40);
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<Calamviec>(entity =>
        {
            entity.HasKey(e => e.MaCa).HasName("PK__CALAMVIE__27258E7BB64F36AA");

            entity.ToTable("CALAMVIEC");

            entity.Property(e => e.MaCa)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MaBs)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaBS");
            entity.Property(e => e.MaPt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaPT");

            entity.HasOne(d => d.MaBsNavigation).WithMany(p => p.Calamviecs)
                .HasForeignKey(d => d.MaBs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CALAMVIEC__MaPT__30F848ED");

            entity.HasOne(d => d.MaPtNavigation).WithMany(p => p.Calamviecs)
                .HasForeignKey(d => d.MaPt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CALAMVIEC__MaPT__31EC6D26");
        });

        modelBuilder.Entity<Chitietpkb>(entity =>
        {
            entity.HasKey(e => e.MaCtpkb).HasName("PK__CHITIETP__5A2D4E0E53C74D88");

            entity.ToTable("CHITIETPKB");

            entity.Property(e => e.MaCtpkb).HasColumnName("MaCTPKB");
            entity.Property(e => e.MaPkb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaPKB");
            entity.Property(e => e.MaVt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaVT");
            entity.Property(e => e.Thanhtien).HasColumnName("thanhtien");

            entity.HasOne(d => d.MaPkbNavigation).WithMany(p => p.Chitietpkbs)
                .HasForeignKey(d => d.MaPkb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FL_CTPKB_PKB");

            entity.HasOne(d => d.MaVtNavigation).WithMany(p => p.Chitietpkbs)
                .HasForeignKey(d => d.MaVt)
                .HasConstraintName("FK__CHITIETPKB__MaVT__47DBAE45");
        });

        modelBuilder.Entity<Chitiettoathuoc>(entity =>
        {
            entity.HasKey(e => e.Macttt).HasName("PK__CHITIETT__00ACEA44C522878D");

            entity.ToTable("CHITIETTOATHUOC");

            entity.Property(e => e.MaThuoc)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MaToa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Thanhtien).HasColumnName("thanhtien");

            entity.HasOne(d => d.MaThuocNavigation).WithMany(p => p.Chitiettoathuocs)
                .HasForeignKey(d => d.MaThuoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CHITIETTO__MaThu__52593CB8");

            entity.HasOne(d => d.MaToaNavigation).WithMany(p => p.Chitiettoathuocs)
                .HasForeignKey(d => d.MaToa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CTTT_TOATHUOC");
        });

        modelBuilder.Entity<Chitietvatlieutieuhao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHITIETV__3213E83F42AFBC50");

            entity.ToTable("CHITIETVATLIEUTIEUHAO");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaPkb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaPKB");
            entity.Property(e => e.MaVl)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Soluong).HasColumnName("soluong");

            entity.HasOne(d => d.MaPkbNavigation).WithMany(p => p.Chitietvatlieutieuhaos)
                .HasForeignKey(d => d.MaPkb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CHITIETVA__MaPKB__3E1D39E1");

            entity.HasOne(d => d.MaVlNavigation).WithMany(p => p.Chitietvatlieutieuhaos)
                .HasForeignKey(d => d.MaVl)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CHITIETVAT__MaVl__3F115E1A");
        });

        modelBuilder.Entity<Chuphongkham>(entity =>
        {
            entity.HasKey(e => e.MaCpk).HasName("PK__CHUPHONG__3DCEE2E5E3B32480");

            entity.ToTable("CHUPHONGKHAM");

            entity.Property(e => e.MaCpk)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaCPK");
            entity.Property(e => e.Hoten).HasMaxLength(40);
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HOADON__2725A6E030F40DC0");

            entity.ToTable("HOADON");

            entity.Property(e => e.MaHd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaHD");
            entity.Property(e => e.MaBn)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaBN");
            entity.Property(e => e.MaLt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaLT");
            entity.Property(e => e.Mapkb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("mapkb");
            entity.Property(e => e.Phuongthuc)
                .HasMaxLength(50)
                .HasDefaultValue("Tiền mặt");

            entity.HasOne(d => d.MaBnNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.MaBn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HD_BN");

            entity.HasOne(d => d.MaLtNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.MaLt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MaLT__60A75C0F");

            entity.HasOne(d => d.MapkbNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Mapkb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HD_PKB");
        });

        modelBuilder.Entity<Hosobenhan>(entity =>
        {
            entity.HasKey(e => e.MaHs).HasName("PK_HSBA");

            entity.ToTable("HOSOBENHAN");

            entity.Property(e => e.MaBn)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaBN");
            entity.Property(e => e.Tinhtrang)
                .HasMaxLength(100)
                .IsFixedLength();

            entity.HasOne(d => d.MaBnNavigation).WithMany(p => p.Hosobenhans)
                .HasForeignKey(d => d.MaBn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HSBA_BN");
        });

        modelBuilder.Entity<Kythuat>(entity =>
        {
            entity.HasKey(e => e.MaKt).HasName("PK__KYTHUAT__2725CF12190F66D1");

            entity.ToTable("KYTHUAT");

            entity.Property(e => e.MaKt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaKT");
            entity.Property(e => e.TenKt)
                .HasMaxLength(30)
                .HasColumnName("TenKT");
        });

        modelBuilder.Entity<Letan>(entity =>
        {
            entity.HasKey(e => e.MaLt).HasName("PK__LETAN__2725C773EE2E0EF7");

            entity.ToTable("LETAN");

            entity.Property(e => e.MaLt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaLT");
            entity.Property(e => e.Gioitinh).HasMaxLength(3);
            entity.Property(e => e.Hoten).HasMaxLength(40);
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<Lichhen>(entity =>
        {
            entity.HasKey(e => e.MaLh).HasName("PK__LICHHEN__2725C77F782867A7");

            entity.ToTable("LICHHEN");

            entity.Property(e => e.MaLh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaLH");
            entity.Property(e => e.LoaiBenhNhan)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.MaBn)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaBN");
            entity.Property(e => e.MaBs)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaBS");
            entity.Property(e => e.Nhucaukham).HasMaxLength(300);

            entity.HasOne(d => d.MaBnNavigation).WithMany(p => p.Lichhens)
                .HasForeignKey(d => d.MaBn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LICHHEN__MaBN__3B75D760");

            entity.HasOne(d => d.MaBsNavigation).WithMany(p => p.Lichhens)
                .HasForeignKey(d => d.MaBs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LICHHEN__MaBN__3A81B327");
        });

        modelBuilder.Entity<Phieukhambenh>(entity =>
        {
            entity.HasKey(e => e.MaPkb).HasName("PK_Mapkb");

            entity.ToTable("PHIEUKHAMBENH");

            entity.Property(e => e.MaPkb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaPKB");
            entity.Property(e => e.MaBn)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaBN");
            entity.Property(e => e.MaBs)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaBS");
            entity.Property(e => e.Tinhtrang)
                .HasMaxLength(100)
                .IsFixedLength();

            entity.HasOne(d => d.MaBnNavigation).WithMany(p => p.Phieukhambenhs)
                .HasForeignKey(d => d.MaBn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PKB_BN");

            entity.HasOne(d => d.MaBsNavigation).WithMany(p => p.Phieukhambenhs)
                .HasForeignKey(d => d.MaBs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PKB_BS");
        });

        modelBuilder.Entity<Phuta>(entity =>
        {
            entity.HasKey(e => e.MaPt).HasName("PK__PHUTA__2725E7F6C0D0D413");

            entity.ToTable("PHUTA");

            entity.Property(e => e.MaPt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaPT");
            entity.Property(e => e.Gioitinh).HasMaxLength(3);
            entity.Property(e => e.Hoten).HasMaxLength(40);
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.Sdt).HasName("PK__TAIKHOAN__CA1930A46104603B");

            entity.ToTable("TAIKHOAN");

            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Chucvu)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Matkhau)
                .HasMaxLength(24)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Thuoc>(entity =>
        {
            entity.HasKey(e => e.MaThuoc).HasName("PK__THUOC__4BB1F6204CBEB0D1");

            entity.ToTable("THUOC");

            entity.Property(e => e.MaThuoc)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Dvt)
                .HasMaxLength(10)
                .HasColumnName("DVT");
            entity.Property(e => e.Tenthuoc).HasMaxLength(30);
        });

        modelBuilder.Entity<Toathuoc>(entity =>
        {
            entity.HasKey(e => e.MaToa).HasName("PK__TOATHUOC__314934442D8C7F3D");

            entity.ToTable("TOATHUOC");

            entity.Property(e => e.MaToa)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaBs)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaBS");
            entity.Property(e => e.MaPkb)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaPKB");

            entity.HasOne(d => d.MaPkbNavigation).WithMany(p => p.Toathuocs)
                .HasForeignKey(d => d.MaPkb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PK_TOATHUOC_PKB");
        });

        modelBuilder.Entity<Vatlieu>(entity =>
        {
            entity.HasKey(e => e.MaVl).HasName("PK__Vatlieu__27251036C6A3F5CC");

            entity.ToTable("Vatlieu");

            entity.Property(e => e.MaVl)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MaVL");
            entity.Property(e => e.Dvt).HasMaxLength(20);
            entity.Property(e => e.TenVl).HasMaxLength(50);
        });

        modelBuilder.Entity<Vitribenh>(entity =>
        {
            entity.HasKey(e => e.MaVt).HasName("PK__VITRIBEN__2725103EFE3DF633");

            entity.ToTable("VITRIBENH");

            entity.Property(e => e.MaVt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaVT");
            entity.Property(e => e.Dvt)
                .HasMaxLength(10)
                .HasColumnName("DVT");
            entity.Property(e => e.MaKt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("MaKT");
            entity.Property(e => e.TenVt)
                .HasMaxLength(30)
                .HasColumnName("TenVT");

            entity.HasOne(d => d.MaKtNavigation).WithMany(p => p.Vitribenhs)
                .HasForeignKey(d => d.MaKt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VITRIBENH__MaKT__4222D4EF");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
