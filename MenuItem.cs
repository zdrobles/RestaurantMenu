using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    internal class MenuItem: IComparable<MenuItem>
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; }
        public bool IsNew { get; set; }

        public MenuItem(string itemName, double price, string category, bool isNew, string description)
        {
            ItemName = itemName;
            Price = price;
            Category = category;
            Description = description;
            IsNew = isNew;
        }

        //private because only intend to use in ToString()
        //returns an empty string if not new
        private string checkNew()
        {
            return IsNew ? "NEW! " : "";
        }

        public int CompareTo(MenuItem compareItem)
        {
            // A null value means that this object is greater.
            if (compareItem == null)
                return 1;

            else
                return ItemName.CompareTo(compareItem.ItemName);
        }

        public override string ToString()
        {
            return $"{checkNew()}\tItem: {ItemName}\tPrice: {Price}\tDescription: {Description}";
        }

        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   ItemName == item.ItemName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ItemName);
        }
    }
}
