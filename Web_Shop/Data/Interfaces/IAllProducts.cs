using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shop.Data.Models;

namespace Web_Shop.Data.Interfaces
{
    interface IAllProducts
    {

        IEnumerable<Product> Products { get; } // Получает и возвращает список продуктов 

        IEnumerable<Product> getFavouriteProducts { get; set; } // Получает и возвращает избранные продукты

        Product getObjectProduct(int productID); // Возвращает номер продукта на основе класса продуктов

    }
}
