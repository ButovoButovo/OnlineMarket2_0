using OnlineMarket.Data.Interfaces;
using OnlineMarket.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarket.Data.mocks
{
    public class MockProducts : IAllProducts
    {
        private readonly IProductsCategory _categoryProducts = new MockCategory();
        public IEnumerable<Products> Products
        {
            get
            {
                return new List<Products>
                {
                    new Products 
                    { 
                        name = "Молоток", 
                        shortDescription = "", 
                        longDescription = "", 
                        image = "", 
                        price = 300, 
                        isFavourite = true,
                        available = true,
                        Category = _categoryProducts.AllCategories.First(),
                    },
                                        new Products
                    {
                        name = "Отвёртка",
                        shortDescription = "",
                        longDescription = "",
                        image = "",
                        price = 100,
                        isFavourite = false,
                        available = true,
                        Category = _categoryProducts.AllCategories.First(),
                    }

                };
            }
        }
        public IEnumerable<Products> GetFavouriteProducts { get ; set ; }

        public Products getObjectProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
