using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] categories = { "Appetizer", "Entree", "Beverage", "Dessert" };
            MenuItem yumyum = new MenuItem("Yumyum", 12.99, categories[1], true, "yummy");
            MenuItem fries = new MenuItem("fries", 1.99, categories[0], false, "hand-cut");

            List<MenuItem> itemList = new List<MenuItem>()
            {
                yumyum, fries
            };

            Menu theMenu = new Menu(itemList);

            theMenu.Add(yumyum);//expect: not to add the same MenuItem to the list
            theMenu.Add(new MenuItem("fries", .99, categories[0], true, "!hand-cut"));//expect: not to add a MenuItem with the same itemName to the list
            theMenu.Add(new MenuItem("Tiramisu", 7.00, categories[3], true, "MUST TRY"));
            theMenu.Add(new MenuItem("Milkshake", 12.99, categories[2], false, "milky"));
            theMenu.Add(new MenuItem("milkshake", 11.99, categories[3], true, "creamy"));//checks case-sensitivity

            //testing ToString override on a MenuItem
            //Console.WriteLine(yumyum);
            //Console.WriteLine(theMenu.Items[0]);

            Console.WriteLine(theMenu.ShowLastUpdate());
            Console.WriteLine(theMenu);
        }// end Main
    }
}
