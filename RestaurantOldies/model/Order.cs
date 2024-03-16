using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOldies.model
{
    public class Order
    {
        public int id { get; set; }
        public int billId { get; set; }
        public int itemId { get; set; }
        public int quantity { get; set; }

        public Order(int billId, int itemId, int quantity)
        {
            this.billId = billId;
            this.itemId = itemId;
            this.quantity = quantity;
        }

        public Order(int id, int billId, int itemId, int quantity)
        {
            this.id = id;
            this.billId = billId;
            this.itemId = itemId;
            this.quantity = quantity;
        }
    }
}
