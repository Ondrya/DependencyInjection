using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class ValidateOrder
    {
        internal bool CheckAllDetails(Order order)
        {
            return order.Id > 0;
        }
    }
}
