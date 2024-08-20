using implementingSRP.Models;

namespace implementingSRP.Services.Interfaces
{
    public interface IProductLogger
    {
        void LogRetrieval(int id);
        void LogAddition(Product product);
    }
}