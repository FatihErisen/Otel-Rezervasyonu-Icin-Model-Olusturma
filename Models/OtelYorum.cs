using System.ComponentModel.DataAnnotations.Schema;

namespace OtelRezervasyon2.Models
{
    public class OtelYorum
    {
        public int OtelYorumId { get; set; }
        public Otel Otel { get; set; }
        [ForeignKey("OtelId")]
        public Musteri Musteri { get; set; }
        [ForeignKey("MusteriId")]
        public string Yorum { get; set; }
        public Star Yildiz { get; set; }
        public Durum Durum { get; set; }

    }
    public enum Durum
    {
        OnayBekliyor,
        Yayinlandi,
        KullaniciTarafindanSilindi,
        Reddedildi
    }

}
