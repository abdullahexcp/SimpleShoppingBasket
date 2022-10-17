using System;

namespace SimpleShoppingBasket
{
    public class Item
    {
        public Item(int quantity, double price)
        {
            Quantity = quantity;//write minimum code to pass test 4
            Price = price;//write minimum code to pass test 2
            //throw new NotImplementedException(); //failing test 1
        }

        //Refactor code for test 4 >>> encapsulate props
        /*public*/
        int Quantity { get; }//write minimum code to pass test 4
        /*public*/
        double Price { get; }//write minimum code to pass test 2


        //Refactor code for test 4
        public double Subtotal()
        {
            return Quantity * Price;
        }
    }
}