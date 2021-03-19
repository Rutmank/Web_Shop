using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shop.Data.Interfaces;
using Web_Shop.ViewModels;

namespace Web_Shop.Controllers
{
    public class ProductsController : Controller { // Наследует класс Контроллер

        private readonly IAllProducts _allProducts; // Переменные, передающие интерфейсы 
        private readonly IProductCategory _allCategories;

        public ProductsController(IAllProducts iAllProducts, IProductCategory iproductCategory) // Передается интерфейс, а также класс, который его реализует
        {
            _allProducts = iAllProducts;
            _allCategories = iproductCategory;
        }

        public ViewResult List() // ViewResult возвращает HTML страницу. Функция возвращает список всех товаров
        {
            ProductsListViewModel obj = new ProductsListViewModel(); // Объект класса 
            obj.allProducts = _allProducts.Products; // Добавлются данные в объект



            return View(); // Переменная передается в шаблок
        }

    }
}
