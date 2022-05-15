using OnlineMarket.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarket.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Products> Products { get; }
        IEnumerable<Products> GetFavouriteProducts { set; get; }
        Products getObjectProduct(int productId);


    }
}
