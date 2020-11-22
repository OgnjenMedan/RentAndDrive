using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.WebAPI.Database
{
    public partial class _190151Context
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            #region Drzave

            modelBuilder.Entity<Drzave>().HasData(new RentAndDrive.WebAPI.Database.Drzave()
            {
                DrzavaId = 1,
                Naziv = "Bosna i Hercegovina"
            });
            modelBuilder.Entity<Drzave>().HasData(new RentAndDrive.WebAPI.Database.Drzave()
            {
                DrzavaId = 2,
                Naziv = "Hrvatska"
            });
            modelBuilder.Entity<Drzave>().HasData(new RentAndDrive.WebAPI.Database.Drzave()
            {
                DrzavaId = 3,
                Naziv = "Srbija"
            });
            modelBuilder.Entity<Drzave>().HasData(new RentAndDrive.WebAPI.Database.Drzave()
            {
                DrzavaId = 4,
                Naziv = "Slovenija"
            });

            #endregion

            #region Gradovi

            modelBuilder.Entity<Gradovi>().HasData(new RentAndDrive.WebAPI.Database.Gradovi()
            {
                GradId = 1,
                Naziv = "Mostar",
                DrzavaId = 1
            });
            modelBuilder.Entity<Gradovi>().HasData(new RentAndDrive.WebAPI.Database.Gradovi()
            {
                GradId = 2,
                Naziv = "Sarajevo",
                DrzavaId = 1
            });
            modelBuilder.Entity<Gradovi>().HasData(new RentAndDrive.WebAPI.Database.Gradovi()
            {
                GradId = 3,
                Naziv = "Beograd",
                DrzavaId = 3
            });
            modelBuilder.Entity<Gradovi>().HasData(new RentAndDrive.WebAPI.Database.Gradovi()
            {
                GradId = 4,
                Naziv = "Zagreb",
                DrzavaId = 2
            });
            modelBuilder.Entity<Gradovi>().HasData(new RentAndDrive.WebAPI.Database.Gradovi()
            {
                GradId = 5,
                Naziv = "Ljubljana",
                DrzavaId = 4
            });

            #endregion

            #region Proizvodjaci

            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 1,
                Naziv = "Mercedes-Benz"
            });
            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 2,
                Naziv = "Audi"
            });
            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 3,
                Naziv = "BMW"
            });
            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 4,
                Naziv = "Porsche"
            });
            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 5,
                Naziv = "Citroen"
            });
            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 6,
                Naziv = "Renault"
            });
            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 7,
                Naziv = "Opel"
            });
            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 8,
                Naziv = "Ford"
            });
            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 9,
                Naziv = "Honda"
            });
            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 10,
                Naziv = "Hyundai"
            });
            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 11,
                Naziv = "Toyota"
            });
            modelBuilder.Entity<Proizvodjaci>().HasData(new RentAndDrive.WebAPI.Database.Proizvodjaci()
            {
                ProizvodjacId = 13,
                Naziv = "Ferrari"
            });



            #endregion

            #region Modeli
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 1,
                Naziv = "C200",
                ProizvodjacId = 1
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 2,
                Naziv = "C300",
                ProizvodjacId = 1
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 3,
                Naziv = "S500",
                ProizvodjacId = 1
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 4,
                Naziv = "A5",
                ProizvodjacId = 2
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 5,
                Naziv = "A3",
                ProizvodjacId = 2
            });

            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 6,
                Naziv = "318",
                ProizvodjacId = 3
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 7,
                Naziv = "535i",
                ProizvodjacId = 3
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 8,
                Naziv = "A8",
                ProizvodjacId = 2
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 9,
                Naziv = "A7",
                ProizvodjacId = 2
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 10,
                Naziv = "Astra",
                ProizvodjacId = 7
            });

            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 11,
                Naziv = "Corolla",
                ProizvodjacId = 11
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 12,
                Naziv = "C4",
                ProizvodjacId = 5
            });

            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 13,
                Naziv = "C3",
                ProizvodjacId = 5
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 14,
                Naziv = "Fiesta",
                ProizvodjacId = 8
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 15,
                Naziv = "Mondeo",
                ProizvodjacId = 8
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 16,
                Naziv = "A4",
                ProizvodjacId = 2
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 17,
                Naziv = "488",
                ProizvodjacId = 13
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 18,
                Naziv = "i30",
                ProizvodjacId = 10
            });
            modelBuilder.Entity<Modeli>().HasData(new RentAndDrive.WebAPI.Database.Modeli()
            {
                ModelId = 19,
                Naziv = "i40",
                ProizvodjacId = 10
            });
            #endregion

            #region Automobili

            #region auto1

            modelBuilder.Entity<Automobili>().HasData(new RentAndDrive.WebAPI.Database.Automobili()
            {
                AutomobilId = 9,
                ModelId = 4,
                Cijena = 120,
                GodinaProizvodnje = 2020,
                Gorivo = "Benzin",
                Snaga = 250,
                Transmisija = "Automatik",
                BrojVrata = 5,
                BrojSjedista = 5,
                Status = true,
                Slika = File.ReadAllBytes("img/AudiA5.jpg"),
                SlikaThumb = File.ReadAllBytes("img/AudiA5.jpg")
            });

            #endregion

            #region auto2
           
            modelBuilder.Entity<Automobili>().HasData(new RentAndDrive.WebAPI.Database.Automobili()
            {
                AutomobilId = 10,
                ModelId = 9,
                Cijena = 100,
                GodinaProizvodnje = 2020,
                Gorivo = "Benzin",
                Snaga = 350,
                Transmisija = "Automatik",
                BrojVrata = 5,
                BrojSjedista = 5,
                Status = true,
                Slika = File.ReadAllBytes("img/audiA7.jpg"),
                SlikaThumb = File.ReadAllBytes("img/audiA7.jpg")
            });

            #endregion

            #region auto3
           
            modelBuilder.Entity<Automobili>().HasData(new RentAndDrive.WebAPI.Database.Automobili()
            {
                AutomobilId = 11,
                ModelId = 2,
                Cijena = 140,
                GodinaProizvodnje = 2020,
                Gorivo = "Benzin",
                Snaga = 240,
                Transmisija = "Automatik",
                BrojVrata = 5,
                BrojSjedista = 5,
                Status = false,
                Slika = File.ReadAllBytes("img/mercedesc300.jpeg"),
                SlikaThumb = File.ReadAllBytes("img/mercedesc300.jpeg")
            });

            #endregion

            #region auto4
         
            modelBuilder.Entity<Automobili>().HasData(new RentAndDrive.WebAPI.Database.Automobili()
            {
                AutomobilId = 12,
                ModelId = 10,
                Cijena = 40,
                GodinaProizvodnje = 2020,
                Gorivo = "Dizel",
                Snaga = 110,
                Transmisija = "Manualni",
                BrojVrata = 5,
                BrojSjedista = 5,
                Status = true,
                Slika = File.ReadAllBytes("img/OpelAstra.jpeg"),
                SlikaThumb = File.ReadAllBytes("img/OpelAstra.jpeg")
            });

            #endregion

            #region auto5
        
            modelBuilder.Entity<Automobili>().HasData(new RentAndDrive.WebAPI.Database.Automobili()
            {
                AutomobilId = 13,
                ModelId = 3,
                Cijena = 200,
                GodinaProizvodnje = 2020,
                Gorivo = "Benzin",
                Snaga = 400,
                Transmisija = "Automatik",
                BrojVrata = 5,
                BrojSjedista = 5,
                Status = true,
                Slika = File.ReadAllBytes("img/mercedesS500.jpg"),
                SlikaThumb = File.ReadAllBytes("img/mercedesS500.jpg")
            });

            #endregion

            #region auto6
          
            modelBuilder.Entity<Automobili>().HasData(new RentAndDrive.WebAPI.Database.Automobili()
            {
                AutomobilId = 14,
                ModelId = 12,
                Cijena = 70,
                GodinaProizvodnje = 2020,
                Gorivo = "Dizel",
                Snaga = 160,
                Transmisija = "Automatik",
                BrojVrata = 5,
                BrojSjedista = 5,
                Status = false,
                Slika = File.ReadAllBytes("img/citroenC4.jpg"),
                SlikaThumb = File.ReadAllBytes("img/citroenC4.jpg")
            });

            #endregion

            #region auto7
           
            modelBuilder.Entity<Automobili>().HasData(new RentAndDrive.WebAPI.Database.Automobili()
            {
                AutomobilId = 15,
                ModelId = 7,
                Cijena = 150,
                GodinaProizvodnje = 2021,
                Gorivo = "Benzin",
                Snaga = 300,
                Transmisija = "Manualni",
                BrojVrata = 5,
                BrojSjedista = 5,
                Status = true,
                Slika = File.ReadAllBytes("img/bmw535i.jpg"),
                SlikaThumb = File.ReadAllBytes("img/bmw535i.jpg")
            });

            #endregion

            #region auto8
          
            modelBuilder.Entity<Automobili>().HasData(new RentAndDrive.WebAPI.Database.Automobili()
            {
                AutomobilId = 16,
                ModelId = 1,
                Cijena = 110,
                GodinaProizvodnje = 2018,
                Gorivo = "Dizel",
                Snaga = 160,
                Transmisija = "Automatik",
                BrojVrata = 5,
                BrojSjedista = 5,
                Status = true,
                Slika = File.ReadAllBytes("img/mercedesc200-2018.jpg"),
                SlikaThumb = File.ReadAllBytes("img/mercedesc200-2018.jpg")
            });

            #endregion

            #region auto9
            
            modelBuilder.Entity<Automobili>().HasData(new RentAndDrive.WebAPI.Database.Automobili()
            {
                AutomobilId = 17,
                ModelId = 1,
                Cijena = 130,
                GodinaProizvodnje = 2020,
                Gorivo = "Dizel",
                Snaga = 170,
                Transmisija = "Manualni",
                BrojVrata = 5,
                BrojSjedista = 5,
                Status = true,
                Slika = File.ReadAllBytes("img/MercedesC200.jpg"),
                SlikaThumb = File.ReadAllBytes("img/MercedesC200.jpg")
            });

            #endregion

            #endregion

            #region Uloge
            modelBuilder.Entity<Uloge>().HasData(new RentAndDrive.WebAPI.Database.Uloge()
            {
                UlogaId = 1,
                Naziv = "Administrator",
                Opis = "Administrator aplikacije RentAndDrive"
            });

            modelBuilder.Entity<Uloge>().HasData(new RentAndDrive.WebAPI.Database.Uloge()
            {
                UlogaId = 2,
                Naziv = "Manager",
                Opis = "Manager prodaje",
            });
            #endregion

            #region Korisnici - Radnici
            modelBuilder.Entity<Korisnici>().HasData(new RentAndDrive.WebAPI.Database.Korisnici()
            {
                KorisnikId = 8,
                Ime = "Admin",
                Prezime = "Admin",
                Email = "desktop@mail.com",
                Telefon = "+38711222333",
                KorisnickoIme = "desktop",
                LozinkaHash = "DyHmfUc4dY2AeLvmkjU5KVOKLpU=",
                LozinkaSalt = "6GVah6aJtuO7XJGw4a5yWg==",
                Status = true
            });

            modelBuilder.Entity<Korisnici>().HasData(new RentAndDrive.WebAPI.Database.Korisnici()
            {
                KorisnikId = 9,
                Ime = "manager",
                Prezime = "manager",
                Email = "manager@mail",
                Telefon = "+38763111222",
                KorisnickoIme = "manager",
                LozinkaHash = "1O/VErIwrPAiaxjIsLgMYF6q8sU=",
                LozinkaSalt = "0SbAPTaLujpWNXgyKSUpJw==",
                Status = true
            });

            #endregion

            #region KorisniciUloge

            modelBuilder.Entity<KorisniciUloge>().HasData(new RentAndDrive.WebAPI.Database.KorisniciUloge()
            {
                KorisnikUlogaId = 1,
                UlogaId = 1,
                KorisnikId = 8,
            });

            modelBuilder.Entity<KorisniciUloge>().HasData(new RentAndDrive.WebAPI.Database.KorisniciUloge()
            {
                KorisnikUlogaId = 2,
                UlogaId = 2,
                KorisnikId = 9,
            });

            #endregion

            #region Kupci

            modelBuilder.Entity<Kupci>().HasData(new RentAndDrive.WebAPI.Database.Kupci()
            {
                KupacId = 1,
                Ime = "mobile",
                Prezime = "mobile",
                Email = "mobile@edu.fit.ba",
                Telefon = "+38761222333",
                KorisnickoIme = "mobile",
                LozinkaHash = "HQbg6wym9g7OwCBKKbwIPLN+zzA=",
                LozinkaSalt = "3w8lqvSnxnz99CPRpBo5EA==",
                Status = true,
                GradId = 1,
                DatumRegistracije = new DateTime(2020, 1, 1)
            });

            modelBuilder.Entity<Kupci>().HasData(new RentAndDrive.WebAPI.Database.Kupci()
            {
                KupacId = 2,
                Ime = "kupac1",
                Prezime = "kupac1",
                Email = "kupac1@edu.fit.ba",
                Telefon = "+38761222222",
                KorisnickoIme = "kupac1",
                LozinkaHash = "bKNSuWqIGVDwXsPjCvc2g9G6tT4=",
                LozinkaSalt = "Lkh7D6GFxBRyKT9hNn2jHQ==",
                Status = true,
                GradId = 1,
                DatumRegistracije = new DateTime(2020, 1, 1)
            });

            #endregion

            #region Ocjene

            modelBuilder.Entity<Ocjene>().HasData(new RentAndDrive.WebAPI.Database.Ocjene()
            {
                OcjenaId = 10,
                AutomobilId = 13,
                KupacId = 1,
                Datum = new DateTime(2020, 11, 22),
                Ocjena = 9
            });

            modelBuilder.Entity<Ocjene>().HasData(new RentAndDrive.WebAPI.Database.Ocjene()
            {
                OcjenaId = 11,
                AutomobilId = 17,
                KupacId = 1,
                Datum = new DateTime(2020, 11, 22),
                Ocjena = 8
            });

            modelBuilder.Entity<Ocjene>().HasData(new RentAndDrive.WebAPI.Database.Ocjene()
            {
                OcjenaId = 12,
                AutomobilId = 9,
                KupacId = 1,
                Datum = new DateTime(2020, 11, 22),
                Ocjena = 10
            });

            modelBuilder.Entity<Ocjene>().HasData(new RentAndDrive.WebAPI.Database.Ocjene()
            {
                OcjenaId = 13,
                AutomobilId = 13,
                KupacId = 2,
                Datum = new DateTime(2020, 11, 22),
                Ocjena = 10
            });

            modelBuilder.Entity<Ocjene>().HasData(new RentAndDrive.WebAPI.Database.Ocjene()
            {
                OcjenaId = 14,
                AutomobilId = 9,
                KupacId = 2,
                Datum = new DateTime(2020, 11, 22),
                Ocjena = 8
            });

            modelBuilder.Entity<Ocjene>().HasData(new RentAndDrive.WebAPI.Database.Ocjene()
            {
                OcjenaId = 15,
                AutomobilId = 15,
                KupacId = 2,
                Datum = new DateTime(2020, 11, 22),
                Ocjena = 6
            });

            modelBuilder.Entity<Ocjene>().HasData(new RentAndDrive.WebAPI.Database.Ocjene()
            {
                OcjenaId = 16,
                AutomobilId = 12,
                KupacId = 2,
                Datum = new DateTime(2020, 11, 22),
                Ocjena = 5
            });

            modelBuilder.Entity<Ocjene>().HasData(new RentAndDrive.WebAPI.Database.Ocjene()
            {
                OcjenaId = 17,
                AutomobilId = 17,
                KupacId = 2,
                Datum = new DateTime(2020, 11, 22),
                Ocjena = 9
            });

            #endregion

            #region Rezervacije
            modelBuilder.Entity<Rezervacije>().HasData(new RentAndDrive.WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 1009,
                KupacId = 1,
                AutomobilId = 9,
                DatumKreiranjaRezervacije = new DateTime(2019, 01, 22),
                DatumPreuzimanja = new DateTime(2019, 01, 23),
                DatumPovrata = new DateTime(2019, 01, 27),
                Napomena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Status = true
            });

            modelBuilder.Entity<Rezervacije>().HasData(new RentAndDrive.WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 1011,
                KupacId = 1,
                AutomobilId = 13,
                DatumKreiranjaRezervacije = new DateTime(2019, 02, 22),
                DatumPreuzimanja = new DateTime(2019, 02, 23),
                DatumPovrata = new DateTime(2019, 02, 27),
                Napomena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Status = true
            });

            modelBuilder.Entity<Rezervacije>().HasData(new RentAndDrive.WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 1013,
                KupacId = 1,
                AutomobilId = 17,
                DatumKreiranjaRezervacije = new DateTime(2019, 03, 22),
                DatumPreuzimanja = new DateTime(2019, 03, 23),
                DatumPovrata = new DateTime(2019, 03, 27),
                Napomena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Status = true
            });

            modelBuilder.Entity<Rezervacije>().HasData(new RentAndDrive.WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 1017,
                KupacId = 2,
                AutomobilId = 13,
                DatumKreiranjaRezervacije = new DateTime(2019, 04, 22),
                DatumPreuzimanja = new DateTime(2019, 04, 23),
                DatumPovrata = new DateTime(2019, 04, 27),
                Napomena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Status = true
            });

            modelBuilder.Entity<Rezervacije>().HasData(new RentAndDrive.WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 1018,
                KupacId = 2,
                AutomobilId = 17,
                DatumKreiranjaRezervacije = new DateTime(2019, 05, 22),
                DatumPreuzimanja = new DateTime(2019, 05, 23),
                DatumPovrata = new DateTime(2019, 05, 27),
                Napomena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Status = true
            });

            modelBuilder.Entity<Rezervacije>().HasData(new RentAndDrive.WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 1019,
                KupacId = 2,
                AutomobilId = 12,
                DatumKreiranjaRezervacije = new DateTime(2019, 06, 22),
                DatumPreuzimanja = new DateTime(2019, 06, 23),
                DatumPovrata = new DateTime(2019, 06, 27),
                Napomena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Status = true
            });

            modelBuilder.Entity<Rezervacije>().HasData(new RentAndDrive.WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 1020,
                KupacId = 2,
                AutomobilId = 15,
                DatumKreiranjaRezervacije = new DateTime(2019, 07, 22),
                DatumPreuzimanja = new DateTime(2019, 07, 23),
                DatumPovrata = new DateTime(2019, 07, 27),
                Napomena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Status = true
            });

            modelBuilder.Entity<Rezervacije>().HasData(new RentAndDrive.WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 1021,
                KupacId = 2,
                AutomobilId = 9,
                DatumKreiranjaRezervacije = new DateTime(2019, 08, 22),
                DatumPreuzimanja = new DateTime(2019, 08, 23),
                DatumPovrata = new DateTime(2019, 08, 27),
                Napomena = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Status = true
            });


            #endregion

            #region Racuni

            modelBuilder.Entity<Racuni>().HasData(new RentAndDrive.WebAPI.Database.Racuni()
            {
                RacunId = 1010,
                RezervacijaId = 1009,
                BrojRacuna = "N0d41V6DcEiLrHgWLDNiOw",
                DatumKreiranjaRacuna = new DateTime(2020, 01, 01),
                TrajanjeRerezvacije = 4,
                IznosRezervacijeAutomobila = 480,
                Pdv = 0.17m,
                IznosSaPdv = 561.60m,
            });

            modelBuilder.Entity<Racuni>().HasData(new RentAndDrive.WebAPI.Database.Racuni()
            {
                RacunId = 1012,
                RezervacijaId = 1011,
                BrojRacuna = "nUHw4YUaO0yl1QIy79jURw",
                DatumKreiranjaRacuna = new DateTime(2020, 01, 01),

                TrajanjeRerezvacije = 5,
                IznosRezervacijeAutomobila = 1000,
                Pdv = 0.17m,
                IznosSaPdv = 1170.00m,
            });

            modelBuilder.Entity<Racuni>().HasData(new RentAndDrive.WebAPI.Database.Racuni()
            {
                RacunId = 1014,
                RezervacijaId = 1013,
                BrojRacuna = "8bFoFhrPw0y0x6D2jBwGTA",
                DatumKreiranjaRacuna = new DateTime(2020, 01, 01),

                TrajanjeRerezvacije = 2,
                IznosRezervacijeAutomobila = 260,
                Pdv = 0.17m,
                IznosSaPdv = 304.20m,
            });

            modelBuilder.Entity<Racuni>().HasData(new RentAndDrive.WebAPI.Database.Racuni()
            {
                RacunId = 1018,
                RezervacijaId = 1017,
                BrojRacuna = "lswznQB2UE67CegR8jyww",
                DatumKreiranjaRacuna = new DateTime(2020, 01, 01),

                TrajanjeRerezvacije = 1,
                IznosRezervacijeAutomobila = 200,
                Pdv = 0.17m,
                IznosSaPdv = 234.00m,
            });

            modelBuilder.Entity<Racuni>().HasData(new RentAndDrive.WebAPI.Database.Racuni()
            {
                RacunId = 1019,
                RezervacijaId = 1018,
                BrojRacuna = "yZHLuhde1UWnpbabDaUudA",
                DatumKreiranjaRacuna = new DateTime(2020, 01, 01),

                TrajanjeRerezvacije = 3,
                IznosRezervacijeAutomobila = 390,
                Pdv = 0.17m,
                IznosSaPdv = 456.30m,
            });

            modelBuilder.Entity<Racuni>().HasData(new RentAndDrive.WebAPI.Database.Racuni()
            {
                RacunId = 1020,
                RezervacijaId = 1019,
                BrojRacuna = "Zl3yjuFysEiOGmSzNzGrEA",
                DatumKreiranjaRacuna = new DateTime(2020, 01, 01),
                TrajanjeRerezvacije = 4,
                IznosRezervacijeAutomobila = 160,
                Pdv = 0.17m,
                IznosSaPdv = 187.20m,
            });

            modelBuilder.Entity<Racuni>().HasData(new RentAndDrive.WebAPI.Database.Racuni()
            {
                RacunId = 1021,
                RezervacijaId = 1020,
                BrojRacuna = "yZHLuhde1UWnpbabDaUudA",
                DatumKreiranjaRacuna = new DateTime(2020, 01, 01),

                TrajanjeRerezvacije = 7,
                IznosRezervacijeAutomobila = 1050,
                Pdv = 0.17m,
                IznosSaPdv = 1228.50m,
            });

            modelBuilder.Entity<Racuni>().HasData(new RentAndDrive.WebAPI.Database.Racuni()
            {
                RacunId = 1022,
                RezervacijaId = 1021,
                BrojRacuna = "Zl3yjuFysEiOGmSzNzGrEA",
                DatumKreiranjaRacuna = new DateTime(2020, 01, 01),

                TrajanjeRerezvacije = 7,
                IznosRezervacijeAutomobila = 840,
                Pdv = 0.17m,
                IznosSaPdv = 982.80m,
            });
            #endregion


        }
    }
}
