using implementingSRP.Models;
using implementingSRP.Services.Interfaces;

namespace implementingSRP.Services
{
    public class ProductLogger : IProductLogger
    {
        private readonly ILogger _logger;

        public ProductLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void LogRetrieval(int productId)
        {
            _logger.Log($"Fetching product with ID: {productId}");
        }

        public void LogAddition(Product product)
        {
            _logger.Log($"Product added: {product.Name}");
        }
    }
}