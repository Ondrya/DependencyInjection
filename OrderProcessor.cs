using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class OrderProcessor
    {
        Order _order;

        public OrderProcessor(Order order)
        {
            _order = order;
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Process started.");

            var validateOrder = new ValidateOrder(); //Dependency
            if (validateOrder.CheckAllDetails(_order))
            {
                //Processsing Order.
                foreach (var orderDetail in _order.Details)
                {
                    _order.TotalAmount += orderDetail.Item.Price * orderDetail.Quantity;
                }

                var printOrder = new PrintOrder(); //Dependency
                printOrder.PrintAllDetails(_order);

                Console.WriteLine($"Order: {_order.Id} has been processed.");
            }
            else
            {
                Console.WriteLine($"Order: {_order.Id} processing faild.");
            }

            Console.WriteLine("Process ended.");
        }
    }
}
