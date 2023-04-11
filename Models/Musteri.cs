using System.ComponentModel.DataAnnotations.Schema;

namespace OtelRezervasyon2.Models
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string EPosta { get; set; }
        public string Telefon { get; set; }
        public Cinsiyet cinsiyet { get; set; }
        [NotMapped]
        public string AdSoyad
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }
        [NotMapped]
        public string TumBilgiler
        {
            get
            {
                return Ad + " " + Soyad + " " + Yas;
            }
        }
        public enum Cinsiyet
        {
            Kadin,
            Erkek,
        }

    }

}
