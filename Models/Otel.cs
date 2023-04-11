using System.ComponentModel.DataAnnotations.Schema;

namespace OtelRezervasyon2.Models
{
    public class Otel
    {
        public int OtelId { get; set; }
        public string Ad { get; set; }
        public Star Yildiz { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public Kategori Kategori { get; set; }
        [ForeignKey("KategoriId")]
        public ICollection<Fotograf> Foto { get; set; }
        public int Kapasite { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }
        [NotMapped]
        public string TamAdres
        {
            get
            {
                return Adres + " " + Ilce + " " + Sehir;
            }
        }
        public double DenizeUzaklik { get; set; }
        public double MerkezeUzaklik { get; set; }
        public double HavaAlaniUzaklik { get; set; }
    }

    public enum Star
    {
        None = 0,
        Bir,
        Iki,
        Uc,
        Dort,
        Bes,
        Alti,
        Yedi
    }

}
