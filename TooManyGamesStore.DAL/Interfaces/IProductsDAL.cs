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
        async Product GetProductById(int id);

    }
}
