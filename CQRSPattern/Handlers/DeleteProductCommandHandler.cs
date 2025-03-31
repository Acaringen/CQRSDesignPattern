using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class DeleteProductCommandHandler
    {
        private readonly Context _context;
        public DeleteProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.ProductID == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
