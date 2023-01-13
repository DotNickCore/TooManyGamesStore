using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooManyGamesStore.BL.Models;

namespace TooManyGamesStore.DAL.Interfaces
{
    public interface IProductsDAL
    {
        Product GetProductById(int id);
        List<Product> GetAllProducts();
        List<Product> GetAvailableProducts();
    }
}
