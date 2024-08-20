using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using implementingSRP.Models;

namespace implementingSRP.Repository
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        void SaveProduct(Product product);
    }
}