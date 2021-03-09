using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shop.Data.Interfaces;
using Web_Shop.Data.Models;

namespace Web_Shop.Data.Mocks
{
    public class MockProducts : IAllProducts
    {
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product{name:"Milk Valio", }
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
