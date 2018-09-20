namespace QuanlyHS_GV_THPT.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanlyHSGV : DbContext
    {
        public QuanlyHSGV()
            : base("name=QuanlyHSGV")
        {
        }

        public virtual DbSet<GIAOVIEN> GIAOVIENs { get; set; }
        public virtual DbSet<HOCSINH> HOCSINHs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THOIKHOABIEU> THOIKHOABIEUx { get; set; }
        public virtual DbSet<TOBM> TOBMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.THOIKHOABIEUx)
                .WithOptional(e => e.GIAOVIEN)
                .HasForeignKey(e => e.MAGV);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.THOIKHOABIEUx)
                .WithOptional(e => e.LOP)
                .HasForeignKey(e => e.MALOP);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<THOIKHOABIEU>()
                .Property(e => e.TIET)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
