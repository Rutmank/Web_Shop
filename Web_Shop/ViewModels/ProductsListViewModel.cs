using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shop.Data.Models;

namespace Web_Shop.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> allProducts { get; set; } // Получает товары

        public string currCategory { get; set; } // Переменная, куда помещается категория, с которой идет работа
    }
}
