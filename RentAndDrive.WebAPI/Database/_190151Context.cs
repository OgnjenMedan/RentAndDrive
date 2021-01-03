using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RentAndDrive.WebAPI.Database
{
    public partial class _190151Context : DbContext
    {
        public _190151Context()
        {
        }

        public _190151Context(DbContextOptions<_190151Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Automobili> Automobili { get; set; }
        public virtual DbSet<Drzave> Drzave { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<Kupci> Kupci { get; set; }
        public virtual DbSet<Modeli> Modeli { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Proizvodjaci> Proizvodjaci { get; set; }
        public virtual DbSet<Racuni> Racuni { get; set; }
        public virtual DbSet<RegistracijeAutomobila> RegistracijeAutomobila { get; set; }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=RentAndDriveDocker;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automobili>(entity =>
            {
                entity.HasKey(e => e.AutomobilId);

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gorivo)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Slika).IsRequired();

                entity.Property(e => e.SlikaThumb).IsRequired();

                entity.Property(e => e.Transmisija)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Automobili)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Automobili_Modeli");
            });

            modelBuilder.Entity<Drzave>(entity =>
            {
                entity.HasKey(e => e.DrzavaId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Gradovi>(entity =>
            {
                entity.HasKey(e => e.GradId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Gradovi)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gradovi_Drzave");
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogaId);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_KorisniciUloge_Korisnici");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_KorisniciUloge_Uloge");
            });

            modelBuilder.Entity<Kupci>(entity =>
            {
                entity.HasKey(e => e.KupacId);

                entity.Property(e => e.DatumRegistracije).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Kupci)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .IsRequired(false)
                    .HasConstraintName("FK_Kupci_Gradovi");
            });

            modelBuilder.Entity<Modeli>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Proizvodjac)
                    .WithMany(p => p.Modeli)
                    .HasForeignKey(d => d.ProizvodjacId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Modeli_Proizvodjaci");
            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.HasOne(d => d.Automobil)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.AutomobilId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ocjene_Automobili");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjene_Kupci");
            });

            modelBuilder.Entity<Proizvodjaci>(entity =>
            {
                entity.HasKey(e => e.ProizvodjacId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Racuni>(entity =>
            {
                entity.HasKey(e => e.RacunId);

                entity.Property(e => e.BrojRacuna)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DatumKreiranjaRacuna).HasColumnType("datetime");

                entity.Property(e => e.IznosRezervacijeAutomobila).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IznosSaPdv)
                    .HasColumnName("IznosSaPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Pdv)
                    .HasColumnName("PDV")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.Racuni)
                    .HasForeignKey(d => d.RezervacijaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Racuni_Rezervacije");
            });

            modelBuilder.Entity<RegistracijeAutomobila>(entity =>
            {
                entity.HasKey(e => e.RegistracijaId);

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KrajRegistracije).HasColumnType("datetime");

                entity.Property(e => e.PocetakRegistracije).HasColumnType("datetime");

                entity.Property(e => e.RegistarskeTablice)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.Automobil)
                    .WithMany(p => p.RegistracijeAutomobila)
                    .HasForeignKey(d => d.AutomobilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistracijeAutomobila_Automobili");

                entity.HasOne(d => d.Radnik)
                    .WithMany(p => p.RegistracijeAutomobila)
                    .HasForeignKey(d => d.RadnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistracijeAutomobila_Korisnici");
            });

            modelBuilder.Entity<Rezervacije>(entity =>
            {
                entity.HasKey(e => e.RezervacijaId);

                entity.Property(e => e.DatumKreiranjaRezervacije).HasColumnType("datetime");

                entity.Property(e => e.DatumPovrata).HasColumnType("datetime");

                entity.Property(e => e.DatumPreuzimanja).HasColumnType("datetime");

                entity.Property(e => e.Napomena)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Automobil)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.AutomobilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Automobili");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Kupci");
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Opis).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
