using NUnit.Framework;
using System.Collections.Generic;

namespace SimpleShoppingBasket.Test
{
    public class BasketTests
    {

        [Test,Order(1)]
        public void TotalPriceOfEmptyBasket()
        {
            //act
            var basket = new Basket(new List<Item>());
            var expected = 0;
            Assert.AreEqual(expected, basket.Total);
        }

        [Test, Order(2)]
        public void TotalPriceOfSingleItem()
        {
            var basket = new Basket(new List<Item>() { new Item(1, 100) });
            var expected = 100;
            Assert.AreEqual(expected, basket.Total);
        }

        [Test, Order(3)]
        public void TotalPriceOfThreeItems()
        {
            var basket = new Basket(new List<Item>() { new Item(1, 100), new Item(1, 300), new Item(1, 50) });
            var expected = 450;
            Assert.AreEqual(expected, basket.Total);
        }

        [Test, Order(4)]
        public void TotalPriceOfQuantityThree()
        {
            var basket = new Basket(new List<Item>() { new Item(3, 100)});
            var expected = 300;
            Assert.AreEqual(expected, basket.Total);
        }
    }
}