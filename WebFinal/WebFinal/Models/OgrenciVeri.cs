﻿namespace WebFinal.Models
{
    public class OgrenciVeri
    {
        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>()
        {
            new Ogrenci()
            {
                Id = 1,
                Ad = "Kerem",
                Soyad = "Vatan",
                KayitTarih = "15/09/2019",
                ÖgrenciNo = "20200108012",
                DTarih = "14 / 02 / 2001",
                Bolum = "bilgisayar Progamciligi",
            },
            new Ogrenci()
            {
                Id = 2,
                Ad = "Ali Berkay",
                Soyad = "Demir",
                KayitTarih = "18/09/2019",
                ÖgrenciNo = "20200108001",
                DTarih = "01 / 01 / 2000",
                Bolum = "bilgisayar Progamciligi",
            },
            new Ogrenci()
            {
                Id = 3,
                Ad = "Abdulkadir",
                Soyad = "Ömür",
                KayitTarih = "14/09/2019",
                ÖgrenciNo = "20200108061",
                DTarih = "01 / 01 / 2001",
                Bolum = "bilgisayar Progamciligi",
            },
            new Ogrenci()
            {
                Id = 4,
                Ad = "Marek",
                Soyad = "Hamsik",
                KayitTarih = "16/09/2019",
                ÖgrenciNo = "20200108012",
                DTarih = "01 / 01 / 2001",
                Bolum = "bilgisayar Progamciligi",
            }
        };

    }
}
