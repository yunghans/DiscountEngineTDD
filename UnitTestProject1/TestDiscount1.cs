using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscountEngineTDD;

namespace DiscountEngineTest
{
    [TestClass]
    public class TestDiscount1
    {
        [TestMethod]
        public void D1NotAppliedWhenBuying1Item()
        {
            //setup
            Product p = new Product();
            p.Sku = "100.1";
            p.Name = "Umbrella";
            p.Price = 20;

            Order order = new Order();            
            order.Add(p,1);

            DiscountEngine de = new DiscountEngine();

            //exercise
            de.CalculateDiscount(order);

            //verify
            Assert.AreEqual(0, order.Discount);
        }

        [TestMethod]
        public void D1WhenBuying2ApplyOnlyOnSecondItem()
        {
            Product p = new Product();
            p.Sku = "100.1";
            p.Name = "Umbrella";
            p.Price = 20;

            Order order = new Order();
            order.Add(p, 2);

            DiscountEngine de = new DiscountEngine();
            de.CalculateDiscount(order);

            Assert.AreEqual(6, order.Discount);
        }
    }
}
