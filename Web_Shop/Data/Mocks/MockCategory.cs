using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shop.Data.Interfaces;
using Web_Shop.Data.Models;

namespace Web_Shop.Data.Mocks
{
    public class MockCategory : IProductCategory // Данный класс реалезует созданный интерфейс в виде категорий
    {
        public IEnumerable<Categories> AllCategories
        { // Реализация интерефейса
            get
            {
                return new List<Categories> // Возвращает лист с категориями 
                {
                    new Categories { categoryName = "Dairy products", description = "Milk, kefir, cottage cheese" }, // Созданные категории с описанием
                    new Categories { categoryName = "Bakery", description = "Bread and bread products" }
                };
            }
        }
    }
}
