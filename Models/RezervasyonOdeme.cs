using System.ComponentModel.DataAnnotations.Schema;

namespace OtelRezervasyon2.Models
{
    public class RezervasyonOdeme
    {
        public int RezervasyonOdemeId { get; set; }
        public Rezervasyon Rezervasyon { get; set; }
        [ForeignKey("RezervasyonId")]
        public double Fiyat { get; set; }
        public double ToplamUcret { get; set; }
        public OdemeMetodu Metot { get; set; }
        [ForeignKey("OdemeMetoduID")]
        public string KartNo { get; set; }
        public string SonKullanmaTarihi { get; set; }
        public int CVV { get; set; }
        public OdemeDurum durum { get; set; }

    }
    public enum OdemeDurum
    {
        Onaylandi,
        YetersizBakiye,
        Reddedildi,
        DigerHatalar,

    }
}

