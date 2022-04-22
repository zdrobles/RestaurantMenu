using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    internal class MenuItem
    {
        public string ItemName { get; set; }
        public double Price {get; set;}
        public string Description {get; set;}
        public string Category {get;}
        public bool IsNew {get; set;}

        public MenuItem(string itemName, double price, string category, bool isNew, string description)
        {
            ItemName = itemName;
            Price = price;
            Category = category;
            Description = description;
            IsNew = isNew;
        }
    }
}
