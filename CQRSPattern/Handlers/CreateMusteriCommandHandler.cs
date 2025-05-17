using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateMusteriCommandHandler
    {
        private readonly Context _context;

        public CreateMusteriCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateMusteriCommand command)
        {
            var musteri = new Musteri
            {
                Id = command.Id,
                Ad = command.Ad,
                SoyAd = command.SoyAd,
                EArsivMi = command.EArsivMi,
                Aktiflik = command.Aktiflik,
                Email = command.Email,
                Telefon = command.Telefon
            };

            _context.Musteriler.Add(musteri);
            _context.SaveChanges();
        }
    }
}