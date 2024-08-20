using implementingSRP.Models;

namespace implementingSRP.Services.Interfaces
{
    public interface IProductService
    {
        Product GetProductDetail(int id);
        void AddProduct(Product product);
    }
}