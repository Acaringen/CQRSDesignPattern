namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetMusteriByIDQuery
    {
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool Aktiflik { get; set; }
        public bool EArsivMi { get; set; }
    }
}
