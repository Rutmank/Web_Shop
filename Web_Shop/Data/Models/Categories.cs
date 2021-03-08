using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shop.Data.Models
{
    public class Categories
    {
        public int id { set; get; } // Поле id

        public string categoryName { set; get; } // Поле имения

        public string description { set; get; } // Поле описания

        public List<Product> products { set; get; } // Указание, какие именно товары входят в данную категорию

    }
}
