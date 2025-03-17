using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    public delegate void NotifyUser(string message);

    class InventoryServices
    {
        private ProductService _productService;
        private InventoryResponses _inventoryResponses;
        public InventoryServices(ProductService productService, InventoryResponses inventoryResponses)
        {
            _productService = productService;
            _inventoryResponses = inventoryResponses;
        }

        public event NotifyUser NotifyOnLowStock ;
        public static event NotifyUser NotifyPurchase;
        public void CheckOnAllStocks()
        {
            NotifyOnLowStock += _inventoryResponses.LowStocksWarning;

            foreach (var product in _productService.GetAllProducts())
            {
                if (product.ProductStockQuantity < 5)
                {
                    NotifyOnLowStock?.Invoke($"{product.ProductCategory} - {product.ProductName}");
                    if(product.ProductStockQuantity == 0)
                    {
                        throw new OutOfStockException();
                    }
                }
            }
        }


        public void CheckOnStocks(ProductCategories Category)
        {
            NotifyOnLowStock += _inventoryResponses.LowStocksWarning;

            List<Product> products = _productService.GetProducts(Category);

            foreach(var product in products)
            {
                if (product.ProductStockQuantity < 5)
                {
                    NotifyOnLowStock?.Invoke($"{product.ProductName}");
                }
            }
        }

        public void AddProduct(string name,ProductCategories category,decimal price,int stock)
        {
            _productService.AddProduct(new Product(_productService.GetAddProductId(),name,category,price,stock));
        }

    }
}
