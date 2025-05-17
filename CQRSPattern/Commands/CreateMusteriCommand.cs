namespace DesignPattern.CQRS.CQRSPattern.Commands
{
    public class CreateMusteriCommand
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string SoyAd{ get; set; }
        public bool EArsivMi { get; set; }
        public bool Aktiflik { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}
