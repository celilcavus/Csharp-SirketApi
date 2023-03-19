namespace _01_SirketApi.Entity.Entity
{
    public class Personel
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime dogumTarihi { get; set; }
        public DateTime baslamaTarihi { get; set; }
        public int BirimNo { get; set; }
        public int UnvanNo { get; set; }
        public byte CalismaSaati { get; set; }
        public decimal Maas { get; set; }
        public decimal Prim { get; set; }
    }
}
