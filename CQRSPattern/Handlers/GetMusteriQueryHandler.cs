using DesignPattern.CQRS.DAL;
using DesignPattern.CQRS.CQRSPattern.Queries;

public class GetMusteriQueryHandler
{
    private readonly Context _context;

    public GetMusteriQueryHandler(Context context)
    {
        _context = context;
    }

    public List<GetMusteriByIDQuery> Handle()
    {
        return _context.Musteriler.Select(m => new GetMusteriByIDQuery
        {
            Ad = m.Ad,
            SoyAd = m.SoyAd,
            Email = m.Email,
            Telefon = m.Telefon,
            Aktiflik = m.Aktiflik,
            EArsivMi = m.EArsivMi
        }).ToList();
    }
}
