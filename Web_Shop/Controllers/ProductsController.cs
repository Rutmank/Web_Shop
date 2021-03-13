using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shop.Data.Interfaces;

namespace Web_Shop.Controllers
{
    public class ProductsController : Controller { // Наследует класс Контроллер

        private readonly IAllProducts _allProducts;
        private readonly IProductCategory _allCategories;

        public ProductsController(IAllProducts iAllProducts, IProductCategory iproductCategory)
        {
            _allProducts = iAllProducts;
            _allCategories = iproductCategory;
        }

    }
}
