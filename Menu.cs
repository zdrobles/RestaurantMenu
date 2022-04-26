using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    internal class Menu
    {
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(List<MenuItem> items)
        {
            Items = items;
            LastUpdated = DateTime.Now;
        }

        //Only adds a MenuItem if the list does not contain an item with the same itemName
        //updates LastUpdated to the current time
        //return bool indicating if the add was successful or not
        public bool Add(MenuItem item)
        {
            if (Items.FindIndex(m => m.ItemName.ToLower() == item.ItemName.ToLower()) < 0)
            {
                Items.Add(item);
                LastUpdated = DateTime.Now;
                return true;
            }
            return false;
        }

        //remove a MenuItem with a given MenuItem
        //return bool indicating if the remove was successful or not
        public bool Remove(MenuItem item)
        {
            int index = Items.FindIndex(m => m.ItemName.ToLower() == item.ItemName.ToLower());
            if (index >= 0)
            {
                Items.RemoveAt(index);
                return true;
            }
            return false;
        }

        //remove a MenuItem with a given string as the itemName
        public bool Remove(string itemName)
        {
            int index = Items.FindIndex(m => m.ItemName.ToLower() == itemName.ToLower());
            if (index >= 0)
            {
                Items.RemoveAt(index);
                return true;
            }
            return false;
        }
        
        public string ShowLastUpdate()
        {
            return $"The menu was last updated on: {LastUpdated.ToString("d")}";
        }

        public override string ToString()
        {
            Items.Sort();//sort the MenuItem list before displaying
            string theString = "";

            foreach (MenuItem item in Items)
            {
                theString += item + "\n";
            }

            return theString;
        }

    }
}
