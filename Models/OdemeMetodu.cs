namespace OtelRezervasyon2.Models
{
    public class OdemeMetodu
    {
        public int OdemeMetoduId { get; set; }
        public OdemeMetot Metot { get; set; }

    }
    public enum OdemeMetot
    {
        Nakit,
        KrediKartı,
        EFT_Havale,
        HediyeCeki,
    }

}
