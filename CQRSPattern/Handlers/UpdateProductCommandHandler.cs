using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Commands
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var product = _context.Products.Find(command.ProductID);
            if (product != null)
            {
                product.Name = command.Name;
                product.Price = command.Price;
                product.Stock = command.Stock;
                product.Description = command.Description;
                product.Status = true;
                _context.SaveChanges();
            }
        }
    }
}
