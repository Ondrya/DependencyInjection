using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class PrintOrder
    {
        internal void PrintAllDetails(Order order)
        {
            Console.WriteLine($"OrderID : {order.Id}");
            Console.WriteLine($"CustomerID : {order.CustomerId}");

            foreach (var orderDetail in order.Details)
            {
                Console.WriteLine($"Product Name : {orderDetail.Item.ProductName} (Price : {orderDetail.Item.Price})(Quantity : {orderDetail.Quantity})");
            }

            Console.WriteLine($"TotalAmount : {order.TotalAmount}");
        }
    }
}
