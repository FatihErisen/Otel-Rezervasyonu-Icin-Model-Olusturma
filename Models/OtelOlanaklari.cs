using System.ComponentModel.DataAnnotations.Schema;

namespace OtelRezervasyon2.Models
{
    public class OtelOlanaklari
    {
        public int OtelOlanaklariID { get; set; }
        public Otel Otel { get; set; }
        [ForeignKey("OtelId")]
        public bool UcretsizIptal { get; set; }
        public bool TumGunServis { get; set; }
        public bool WIFI { get; set; }
        public bool AlakartRestoran { get; set; }
        public bool YikamaServisi { get; set; }
        public bool UcretsizOtopark { get; set; }
        public bool ToplantıOdasi { get; set; }
        public bool LobiBar { get; set; }
        public bool HavuzBar { get; set; }
        public bool SporSalonu { get; set; }
        public bool AcikHavuz { get; set; }
        public bool KapaliHavuz { get; set; }
    }

}
