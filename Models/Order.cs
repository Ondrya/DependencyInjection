using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
        public int Status { get; set; }
        public List<OrderDetail> Details { get; set; }
    }
}
