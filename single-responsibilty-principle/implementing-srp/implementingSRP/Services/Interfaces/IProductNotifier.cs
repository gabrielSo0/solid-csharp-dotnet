using implementingSRP.Models;

namespace implementingSRP.Services.Interfaces
{
    public interface IProductNotifier
    {
        void NotifyProductAdded(Product product);
    }
}