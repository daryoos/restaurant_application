using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOldies.model
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }

        public Item(string name, float price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public Item(int id, string name, float price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
