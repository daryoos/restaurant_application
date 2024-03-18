using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOldies.model
{
    public class Bill
    {
        public int id { get; set; }
        public float totalCost { get; set; }
        public string status { get; set; }
        public string date { get; set; }

        public Bill()
        {
            this.totalCost = 0;
            this.status = "new order";
        }

        public Bill(float totalCost, string status, string date)
        {
            this.totalCost = totalCost;
            this.status = status;
            this.date = date;
        }

        public Bill(int id, float totalCost, string status, string date)
        {
            this.id = id;
            this.totalCost = totalCost;
            this.status = status;
            this.date = date;
        }
    }
}
