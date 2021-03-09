﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shop.Data.Interfaces;
using Web_Shop.Data.Models;

namespace Web_Shop.Data.Mocks
{
    public class MockProducts : IAllProducts // Реализует интерфейс в виде конкретного продукта
    {

        private readonly IProductCategory _categoryProducts = new MockCategory(); //Переменная позволяет указывать, к какой категории принадлежит товар
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product{
                        name="Milk Valio", 
                        shortDesc="", 
                        longDesc="", 
                        img="", 
                        price = 1.25, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryProducts.AllCategories.First()
                    },
                };
            }
        }
        public IEnumerable<Product> getFavouriteProducts { get; set; }

        public Product getObjectProduct(int productID)
        {
            throw new NotImplementedException();
        }
    }
}