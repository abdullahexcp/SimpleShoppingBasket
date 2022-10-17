using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleShoppingBasket
{
    public class Basket
    {
        private readonly List<Item> items;
        //write minimum code to pass test 1
        //public double Total => 0.0;

        //write minimum code to pass test 2
        //public double Total => items.Count > 0 ? items[0].Price : 0;

        //write minimum code to pass test 3
        //public double Total => items.Aggregate(0, (double sum,Item item) => sum + item.Price);

        //write minimum code to pass test 4
        //public double Total => items.Aggregate(0, (double sum,Item item) => sum + item.Quantity * item.Price);

        //Refactor code for test 4
        public double Total => items.Aggregate(0, (double sum, Item item) => sum + item.Subtotal());

        public Basket(List<Item> items)
        {
            this.items = items;

            //write failing test 1
            //throw new NotImplementedException();
        }
    }
}