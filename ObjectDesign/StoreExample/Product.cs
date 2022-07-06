using System;
namespace ObjectDesign.StoreExample
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }



        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }


    }
}

