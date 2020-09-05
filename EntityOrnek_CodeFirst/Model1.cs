namespace EntityOrnek_CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<TblDersler> TblDersler { get; set; }
        public virtual DbSet<TblKulupler> TblKulupler { get; set; }
        public virtual DbSet<TblNotlar> TblNotlar { get; set; }
        public virtual DbSet<TblOgrenci> TblOgrenci { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblDersler>()
                .Property(e => e.DersAd)
                .IsUnicode(false);

            modelBuilder.Entity<TblDersler>()
                .HasMany(e => e.TblNotlar)
                .WithOptional(e => e.TblDersler)
                .HasForeignKey(e => e.DersID);

            modelBuilder.Entity<TblKulupler>()
                .Property(e => e.KulupAdi)
                .IsUnicode(false);

            modelBuilder.Entity<TblNotlar>()
                .Property(e => e.Ortalama)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TblOgrenci>()
                .Property(e => e.Ad)
                .IsUnicode(false);

            modelBuilder.Entity<TblOgrenci>()
                .Property(e => e.Soyad)
                .IsUnicode(false);

            modelBuilder.Entity<TblOgrenci>()
                .Property(e => e.Foto)
                .IsUnicode(false);
            modelBuilder.Entity<TblOgrenci>()
                .Property(e => e.Sehir)
                .IsUnicode(false);

            modelBuilder.Entity<TblOgrenci>()
                .HasMany(e => e.TblNotlar)
                .WithOptional(e => e.TblOgrenci)
                .HasForeignKey(e => e.OgrID);
        }
    }
}
