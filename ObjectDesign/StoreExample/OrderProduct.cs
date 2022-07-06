using System;
namespace ObjectDesign.StoreExample
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public bool Credit { get; set; }
        public decimal Price { get; set; }
        public Product Product { get; set; }

        public OrderProduct()
        {
            Credit = false;           
       }

        public OrderProduct(int id, decimal price, Product product) : this()
        {
            Id = id;
            Price = price;
            Product = product;
        }
    }
}

