using System;
using System.Linq;

namespace ObjectDesign.StoreExample
{
    public class Order
    {
        List<OrderProduct> Products { get; set; }

        public Order(List<OrderProduct> products)
        {
            Products = products;
        }

        public decimal GetTotalCost()
        {
            decimal totalCost = 0;
            foreach(OrderProduct product in PackingItems())
            {
                totalCost += product.Price;
            }
            return totalCost;
        }

        public bool RemoveItem(OrderProduct product)
        {
            bool success = false;
            if(Products.Contains(product))
            {
                product.Credit = true;
                Products.Add(product);
                success = true;
            }
            return success;
        }

        public List<OrderProduct> PackingItems()
        {
            List<OrderProduct> reducedProducts = Products.ToList();
            foreach (OrderProduct product in Products)
            {
                if(product.Credit == true)
                {
                    reducedProducts.Remove(product);
                    reducedProducts.Remove(reducedProducts.Find(p => p.Id == product.Id));
                }
            }
            return reducedProducts;
        }

        public decimal GetShippingCost()
        {
            return DetermineShippingCost(Products);
        }

        public static decimal DetermineShippingCost(List<OrderProduct> products)
        {
            decimal totalCost = 0;
            foreach (OrderProduct product in products)
            {
                totalCost += product.Price;
            }
            if(totalCost >= 600)
            {
                return 0;
            }

            return 79;
        }
    }
}

