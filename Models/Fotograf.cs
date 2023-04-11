using System.ComponentModel.DataAnnotations.Schema;

namespace OtelRezervasyon2.Models
{
    public class Fotograf
    {
        public int FotografId { get; set; }
        public Otel otel { get; set; }
        [ForeignKey("OtelID")]
        public string DosyaAdi { get; set; }
        public string DosyaYolu { get; set; }
    }

}
