using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountEngineTDD
{
    public class Order
    {

        List<OrderItem> items = new List<OrderItem>();

        public List<OrderItem> Items
        {
            get
            {
                return items;
            }
        }

        public double Discount { get; set; }

        public void Add(Product prod, int qty){
            OrderItem oi = new OrderItem();

            oi.Product = prod;
            oi.Qty = qty;

            items.Add(oi);
        }
    }
    public class OrderItem{
        public Product Product{get;set;}
        public int Qty{get;set;}
    }
}
