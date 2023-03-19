namespace _01_SirketApi.Entity.Entity
{
    public class Cocuk
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public char Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public int PersonelId { get; set; }

    }
}
