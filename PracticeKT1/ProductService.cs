using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeKT1
{
    class ProductService
    {
        internal static int id = 101 ;

        private List<Product> products = new List<Product>
        {
            new Product(id++,"LG LED Television",ProductCategories.Electronics,55000,15),
            new Product(id++,"Lenovo I5 Slimpad",ProductCategories.Electronics,75000,9),
            new Product(id++,"Iphone 16 pro",ProductCategories.Electronics,55000,20),
            new Product(id++,"T-shirt",ProductCategories.Clothing,500,5),
            new Product(id++,"Jeans Pant",ProductCategories.Clothing,1200,13),
            new Product(id++,"Harry Potter",ProductCategories.Books,215,70),
            new Product(id++,"Lord of the Flies",ProductCategories.Books,175,3),
            new Product(id++,"The Canterville ghost",ProductCategories.Books,219,6),
            new Product(id++,"Gulliver's Travel",ProductCategories.Books,55000,18),
            new Product(id++,"Bajaj Mixer Grinder",ProductCategories.HomeAppliances,2500,5),
            new Product(id++,"Lao Paulo Crockery Set",ProductCategories.HomeAppliances,3200,3),
        };

        public int GetAddProductId()
        {
            return id++;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public void UpdateProductName(int id,string name)
        {
            var product = products.FirstOrDefault(a => a.ProductID==id);
            product.ProductName = name;
        }

        public void UpdateProductPrice(int id, decimal price)
        {
            var product = products.FirstOrDefault(a => a.ProductID == id);
            product.ProductPrice = price;
        }

        public void UpdateProductStock(int id, int quantity)
        {
            var product = products.FirstOrDefault(a => a.ProductID == id);
            product.ProductStockQuantity = quantity;
        }

        public int GetProductId(string name)
        {
            var product = products.FirstOrDefault(a => a.ProductName.Equals(name));
            return product.ProductID;
        }

        public Product GetProductById(int id)
        {
            Product product = products.Find(a => a.ProductID == id);
            return product;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public void ViewAllProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ProductID} {product.ProductName} {product.ProductPrice} {product.ProductCategory} {product.ProductStockQuantity}");
            }
        }
        public List<Product> GetProducts(ProductCategories category , bool sortByPrice = false)
        {
            var query = products.AsQueryable();
            if (!category.Equals(null))
            {
                query = query.Where(p => p.ProductCategory.Equals(category));
            }
            if (sortByPrice)
            {
                query = query.OrderBy(p => p.ProductPrice);
            }
            return query.ToList();
        }


       
    }
}
