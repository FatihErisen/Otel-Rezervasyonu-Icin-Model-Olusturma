using System.ComponentModel.DataAnnotations.Schema;

namespace OtelRezervasyon2.Models
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public Musteri Musteri { get; set; }
        [ForeignKey("MusteriId")]
        public Otel Otel { get; set; }
        [ForeignKey("OtelId")]
        public int YetiskinSayisi { get; set; }
        public int CocukSayisi { get; set; }
        public DateTime GirisTar { get; set; }
        public DateTime CikisTarihi { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public double ToplamUcret { get; set; }
        public bool Onay { get; set; }
        public RezervasyonDurum durum { get; set; }
    }
    public enum RezervasyonDurum
    {
        Onaylandi,
        Reddedildi,
        MusteriIptal,
        OtelIptal,
        Diger,
    }

}
