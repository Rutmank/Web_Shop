using System;
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
                        shortDesc="Cow's milk 2.5%", 
                        longDesc="Same great milk taste packaged in a convenient size", 
                        img="https://gazetaschk.ru/wp-content/uploads/2019/09/milk-cows.jpg", 
                        price = 1.25, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryProducts.AllCategories.First()
                    },

                    new Product{
                        name="Butter",
                        shortDesc="Butter 200gm",
                        longDesc="Made from pure, sweet natural cream, collected from the milk of grass-fed cattle of rural Bangladesh.",
                        img="https://shop.aarongdairy.net/wp-content/uploads/2020/04/butter-100-150x150.jpg",
                        price = 2.1,
                        isFavourite = true,
                        available = false,
                        Category = _categoryProducts.AllCategories.First()
                    },

                    new Product{
                        name="Amber Cheese",
                        shortDesc="Thise Organic Thyborøn Amber Cheese",
                        longDesc="Thise Thyborøn amber cheese is made from milk from the Thyborøn area.",
                        img="https://nordicexpatshop.com/pub/media/catalog/product/cache/a75b4628650e2182ad447c229a356118/t/h/thise-ravost-250g.jpg",
                        price = 8.5,
                        isFavourite = false,
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
