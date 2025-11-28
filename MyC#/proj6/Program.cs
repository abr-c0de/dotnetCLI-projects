
using ShoppingCart;

Cart cart1 = new Cart("12hgh67y");

cart1.AddItems("mango", 2.5);
cart1.AddItems("orange", 2);
cart1.AddItems("apple", 3.3);
cart1.AddItems("banana", 1.8);

cart1.RemoveItems("orange");
//cart1.GetTotal();

Console.WriteLine(cart1.GetTotal());


