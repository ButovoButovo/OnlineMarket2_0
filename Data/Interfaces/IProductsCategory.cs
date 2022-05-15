using OnlineMarket.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarket.Data.Interfaces
{
    public interface IProductsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
