using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Cart
    {
        //created two private fields for cart id and items.
        private string? _cartId;
        private Dictionary<string, double>? _items;

        //constructer which set the _cartId and initialise the _items. 

        public Cart(string cartId) 
        {
            _cartId = cartId;
            _items = new Dictionary<string, double>();

        }

        //add items
        public void AddItems(string item,double price) 
        { 
            _items.Add(item, price);
        }
        //delete items
        public void RemoveItems(string item)
        {
            _items.Remove(item);
        }
        //get the total price
        public double GetTotal()
        {
            double total = 0;
            foreach (KeyValuePair<string,double> item in _items)
            {
                total += item.Value;
            }
            return total;
        }

        //Here the override ToString() method is used to display all the things in the cart
        //The ToString("F2") used inside the function is default system function the parameter passed
        //in it is the format specifer where F - fixed & 2 - two numbers after decimal.
        public override string ToString()
        {
            string result = "Cart ID :" + _cartId + "/n";
            foreach (KeyValuePair<string,double> items in _items)
            {
                result += items.Key + ": $" + items.Value.ToString("F2") + "\n";
            }
            result += "Total :$" + GetTotal().ToString("F2") + "\n";
            return result;
        }

    }
}
