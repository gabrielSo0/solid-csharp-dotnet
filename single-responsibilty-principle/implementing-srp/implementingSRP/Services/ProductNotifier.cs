using implementingSRP.Models;
using implementingSRP.Services.Interfaces;

namespace implementingSRP.Services
{
    public class ProductNotifier : IProductNotifier
    {
        private readonly IEmailService _emailService;
        public ProductNotifier(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void NotifyProductAdded(Product product)
        {
            _emailService.SendEmail("admin@company.com", "New Product Added", $"Product {product.Name} was added.");
        }
    }
}