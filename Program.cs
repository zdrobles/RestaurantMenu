using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem yumyum = new MenuItem("Yumyum", 12.99, "main course", true, "yummy");
            MenuItem fries = new MenuItem("fries", 1.99, "appetizer", true, "hand-cut");

            List<MenuItem> itemList = new List<MenuItem>()
            {
                yumyum, fries
            };

            Menu theMenu = new Menu(itemList);
            Console.WriteLine(theMenu.LastUpdated.ToString("d"));
        }
    }
}
