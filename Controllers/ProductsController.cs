using Microsoft.AspNetCore.Mvc;
using OnlineMarket.Data.Interfaces;
using OnlineMarket.ViewModels;

namespace OnlineMarket.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IAllProducts allProducts;
        private readonly IProductsCategory allProductsCategories;
        public ProductsController(IAllProducts iallProducts, IProductsCategory iproductsCategory )
        {
            allProducts = iallProducts;
            allProductsCategories = iproductsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с товарами";
            ProductsListViewMoles obj = new ProductsListViewMoles();
            obj.AllProducts = allProducts.Products;
            obj.productsCategories = "Товары";
        return View();
        }
    }
}
