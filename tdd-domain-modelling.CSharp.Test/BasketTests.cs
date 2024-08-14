using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    internal class BasketTests
    {
        [Test]
        public void AddNewItemBasket() 
        {
            Basket basket = new Basket();
            string item = "teddybear";
            int value = 50;

            bool IsItemAdded = basket.add(item, value);

            Assert.That(IsItemAdded, Is.True);
        }
        [Test]
        public void AddExcistingItemBasket()
        {
            Basket basket = new Basket();
            string item = "ball";
            int value = 50;

            basket.add(item, value);
            bool IsItemAdded = basket.add(item, value);
            
            Assert.That(IsItemAdded, Is.False);
        }

        [Test]
        public void SumTotalPrice()
        {
            Basket basket = new Basket();
            string item1 = "teddybear";
            int item1Value = 80;
            string item2 = "ball";
            int item2Value = 50;
            int expectedTotal = 130;

            basket.add(item1, item1Value);
            basket.add(item2, item2Value);
            int actualTotal = basket.total();

            Assert.That(actualTotal, Is.EqualTo(expectedTotal));

        }
    }
}
