using OnlineMarket.Data.Models;
using System.Collections.Generic;

namespace OnlineMarket.ViewModels
{
    public class ProductsListViewMoles
    {
        public IEnumerable<Products> AllProducts { get; set; }
        public string productsCategories { get; set; }
    }
}
