using violatingSRP.Models;
using violatingSRP.Repository;

namespace violatingSRP.Services
{
    public class ProductService : IProductService
    {

        /*
            Multiple Responsibilities:
            - Business Logic: The ProductService is responsible for managing the product-related business logic, 
            which is its primary responsibility.
            - Email Notifications: By including email notification functionality, the ProductService is 
            now also responsible for handling communication with the admin.
            - Logging: The service is responsible for logging activities, which is a separate concern

            
            This means the class now has multiple reasons to change:
            - If the way emails are sent changes.
            - If the logging mechanism is modified.
            - If business rules for products are updated.

            The ProductService is becoming more complex as it takes on additional responsibilities. 
            This can make the class harder to understand, test, and maintain.

            You can add private methods to deal with more business rules, as this is the class to deal with it,
            but always be carefull with the mixing of responsibilities. Always think about the implementation and how
            you can improve it.

            *** The refactory is inside "implementing-srp" folder.
        */

        private readonly IProductRepository _productRepository;
        private readonly IEmailService _emailService;
        private readonly ILogger _logger;
        public ProductService(IProductRepository productRepository, IEmailService emailService, ILogger logger)
        {
            _productRepository = productRepository;
            _emailService = emailService;
            _logger = logger;
        }

        public Product GetProductDetail(int id)
        {
            _logger.Log($"Fetching product with ID: {id}");
            var product = _productRepository.GetProductById(id);
            _logger.Log($"Product fetched: {product.Name}");
            return product;
        }

        public void AddProduct(Product product)
        {
            _productRepository.SaveProduct(product);
            _emailService.SendEmail("admin@company.com", "New Product Added", $"Product {product.Name} was added.");
            _logger.Log($"Product added: {product.Name}");
        }

        // Additional business logic methods
    }
}