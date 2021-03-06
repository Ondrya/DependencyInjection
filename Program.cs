using System;
using System.Collections.Generic;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Products
            var productPen = new Product() { Id = 1, ProductName = "Pen", Price = 10 };
            var productNotebook = new Product() { Id = 2, ProductName = "Notebook", Price = 35 };

            //OrderDetail
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            orderDetails.Add(new OrderDetail()
            {
                OrderDetailId = 1,
                OrderId = 1,
                Item = productPen,
                Quantity = 1
            });
            orderDetails.Add(new OrderDetail()
            {
                OrderDetailId = 2,
                OrderId = 1,
                Item = productNotebook,
                Quantity = 1
            });


            //Order
            Order order = new Order();
            order.Id = 1;
            order.Details = orderDetails;
            order.CustomerId = 1001;

            OrderProcessor orderProcessor = new OrderProcessor(order);
            orderProcessor.ProcessOrder();
        }
    }
}
