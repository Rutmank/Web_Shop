using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shop.Data.Models;

namespace Web_Shop.Data.Interfaces
{
    interface IProductCategory
    {

        IEnumerable<Categories> AllCategories { get; } // Функция, получающая данные из раздела категорий

    }
}
