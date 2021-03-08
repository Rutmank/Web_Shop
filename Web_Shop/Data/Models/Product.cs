using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shop.Data.Models
{
    public class Product
    {
        public int id { set; get; } // Id товара

        public string name  { set; get; } // Имя товара

        public string shortDesc { set; get; } // Короткое описаниа товара

        public string longDesc { set; get; } // Длинное описание товара

        public string img { set; get; } // Внутрь url изображения товара

        public ushort price { set; get; } // Цена товара. ushort - потому что цена всегда положительная

        public bool isFacourite { set; get; } // Указание товара на главную страницу

        public int availlable { set; get; } // Количество товара 

        public int categoryID { set; get; } // Прикрепление товара к определенной категории 

        public virtual Categories Category { set; get; } // Создается объект со всеми доступными категориями из categories
    }
}
