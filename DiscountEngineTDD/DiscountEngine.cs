using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountEngineTDD
{
    public class DiscountEngine
    {
        public void CalculateDiscount(Order o)
        {
            double discount = 0;
            foreach (OrderItem oi in o.Items)
            {
                if (oi.Qty > 1)
                {
                    discount += oi.Product.Price * (oi.Qty / 2) * 30/100;
                }
            }
            o.Discount = discount;
        }
    }
}
