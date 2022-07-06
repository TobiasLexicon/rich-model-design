using System;
using ObjectDesign.StoreExample;

namespace ObjectDesign.Data
{
    public static class InstantiatedValues
    {
        static List<Product> products = new();

        public static void AddProduct(Product product)
        {
            products.Add(product);
        }

        public static List<Product> GetProducts()
        {
            return products;
        }

        public static int NextProductId()
        {
            return products.Max(p => p.Id) + 1;
        }
    }
}

