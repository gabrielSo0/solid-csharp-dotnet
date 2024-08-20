using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using violatingSRP.Models;

namespace violatingSRP.Services
{
    public interface IProductService
    {
        Product GetProductDetail(int id);
        void AddProduct(Product product);
    }
}