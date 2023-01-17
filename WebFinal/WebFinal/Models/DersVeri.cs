namespace WebFinal.Models
{
    public class DersVeri
    {
        public static List<Ders> Dersler = new List<Ders>()
        {
            new Ders()
            {
                Id = 1,
                Ad = "Matematik",
                Kredisi = "2",
                OkulYönetimId = "4",

            },
            new Ders()
            {
                Id = 2,
                Ad = "Görsel Progamlama",
                Kredisi = "2",
                OkulYönetimId = "3",
            },
            new Ders()
            {
                Id = 3,
                Ad = "Deniz liman islemeciligi",
                Kredisi = "2",
                OkulYönetimId = "3",
            },
            new Ders()
            {
                Id = 4,
                Ad = "Bilgi Güvenliği",
                Kredisi = "1",
                OkulYönetimId = "2",
            },
        };
    }
}
