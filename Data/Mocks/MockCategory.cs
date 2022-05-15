using OnlineMarket.Data.Interfaces;
using OnlineMarket.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarket.Data.mocks
{
    public class MockCategory : IProductsCategory //Интерфейс для работы с категориями
    {
        public IEnumerable<Category> AllCategories 
        {
            get 
            { 
                return new List<Category> 
                {
                    new Category { categoryName = "Для дома и быта", description = "Всё для дома и быта"},
                    new Category { categoryName = "Сад и огород", description = "Всё для сада и огорода"}
                };
            }
        }
    }
}
