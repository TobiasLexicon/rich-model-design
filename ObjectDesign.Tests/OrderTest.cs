using System;
using System.Collections.Generic;
using ObjectDesign.StoreExample;
using Xunit;

namespace ObjectDesign.Tests
{
    public class OrderTest
    {


        [Fact]
        public void DetermineShippingCostTest1()
        {
            //arrange
            List<OrderProduct> products = new();
            products.Add(new OrderProduct(1, 139, new Product(1, "Powerdrill")));
            products.Add(new OrderProduct(2, 219, new Product(2, "Vacuumpump")));
            products.Add(new OrderProduct(3, 89, new Product(3, "Nail")));

            //act
            decimal result = Order.DetermineShippingCost(products);

            //assert
            Assert.Equal(79, result);
        }

        //[Theory]
        //[InlineData(OrderTest.product1, 79)]
        //public void DetermineShippingCostTest2(OrderProduct product, int value)
        //{
        //    List<OrderProduct> products = new();
        //    products.Add(new OrderProduct(1, 139, new Product(1, "Powerdrill")));
        //    products.Add(new OrderProduct(2, 219, new Product(2, "Vacuumpump")));
        //    products.Add(new OrderProduct(3, 89, new Product(3, "Nail")));

        //    //act
        //    decimal result = Order.DetermineShippingCost(products);

        //    //assert
        //    Assert.Equal(79, result);
        //}

        [Fact]
        public void RemoveItemTest1()
        {
            //arrange
            List<OrderProduct> products2 = new();
            products2.Add(new OrderProduct(1, 139, new Product(1, "Powerdrill")));
            products2.Add(new OrderProduct(2, 219, new Product(2, "Vacuumpump")));
            OrderProduct productToRemove = new OrderProduct(3, 89, new Product(3, "Nail"));
            products2.Add(productToRemove);
            Order order = new Order(products2);

            //act
            bool success = order.RemoveItem(productToRemove);

            //assert
            Assert.True(success);
        }

        [Fact]
        public void RemoveItemTest2()
        {
            //arrange
            List<OrderProduct> products3 = new();
            products3.Add(new OrderProduct(1, 139, new Product(1, "Powerdrill")));
            products3.Add(new OrderProduct(2, 219, new Product(2, "Vacuumpump")));
            OrderProduct productToRemove = new OrderProduct(3, 89, new Product(3, "Nail"));
            products3.Add(productToRemove);
            Order order = new Order(products3);

            //act
            bool success = order.RemoveItem(productToRemove);

            //assert
            Assert.True(order.PackingItems().Count == 2);
        }


    }
}

