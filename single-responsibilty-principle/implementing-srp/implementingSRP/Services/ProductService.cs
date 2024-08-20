using implementingSRP.Models;
using implementingSRP.Repository;
using implementingSRP.Services.Interfaces;

namespace implementingSRP.Services
{
    public class ProductService : IProductService
    {

        /*
            Single Responsibility:
            - Each class has a single responsibility: ProductService handles business logic, ProductNotifier handles notifications, 
            and ProductLogger handles logging. This makes each class simpler and easier to maintain.

            Loose Coupling:
            - Changes to the email notification logic or logging mechanisms won’t affect the ProductService. 
            This reduces the risk of introducing bugs when modifications are made.

            Improved Testability:
            - You can independently test the ProductService, ProductNotifier, and ProductLogger. 
            Each can be mocked or stubbed in isolation, leading to more focused and reliable unit tests.
        */

        private readonly IProductRepository _productRepository;
        private readonly IProductNotifier _productNotifier;
        private readonly IProductLogger _productLogger;
        public ProductService(IProductRepository productRepository, IProductNotifier productNotifier, IProductLogger productLogger)
        {
            _productRepository = productRepository;
            _productNotifier = productNotifier;
            _productLogger = productLogger;
        }

        public Product GetProductDetail(int id)
        {
            _productLogger.LogRetrieval(id);
            var product = _productRepository.GetProductById(id);
            return product;
        }

        public void AddProduct(Product product)
        {
            _productRepository.SaveProduct(product);
            _productNotifier.NotifyProductAdded(product);
            _productLogger.LogAddition(product);
        }

        // Additional business logic methods
    }
}