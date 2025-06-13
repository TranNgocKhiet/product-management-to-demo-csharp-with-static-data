using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> listProducts;
        static ProductDAO()
        {
            Product chai = new Product(1, "Chai", 3, 12, 18);
            Product chang = new Product(2, "Chang", 1, 23, 19);
            Product aniseed = new Product(3, "Aniseed Syrup", 2, 23, 10);
            Product chef = new Product(4, "Chef Anton's Cajun Seasoning", 2, 34, 22);
            Product chefMix = new Product(5, " Chef's Anton Gumbo Mix", 2, 45, 34);
            Product grandma = new Product(6, "Grandma's Boysenberry Spread", 2, 21, 25);
            Product uncle = new Product(7, "Uncle Bob's Organic Dried Pears", 7, 22, 36);
            Product northwood = new Product(8, "Northwoods Cranberry Sauce", 2, 10, 46);
            Product mishi = new Product(9, "Mishi Kobe Niku", 6, 12, 97);
            Product ikura = new Product(10, "Ikura", 8, 13, 32);

            listProducts = new List<Product> { chai, chang, aniseed, chef, chefMix, grandma, uncle, northwood, mishi, ikura };
        }

        public static List<Product> GetProducts()
        {
            return listProducts;
        }

        public static void SaveProducts(Product p)
        {
            listProducts.Add(p);
        }

        public static void UpdateProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    p.ProductId = product.ProductId;
                    p.ProductName = product.ProductName;
                    p.UnitPrice = product.UnitPrice;
                    p.UnitsInStock = product.UnitsInStock;
                    p.CategoryId = product.CategoryId;
                }
            }
        }

        public static void DeleteProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    listProducts.Remove(p);
                }
            }
        }

        public static Product GetProductById(int id)
        {
            foreach (Product p in listProducts.ToList())
                if (p.ProductId == id)
                {
                    return p;
                }
            return null;
        }
    }
}
