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
        public int totalCost { get; set; }
        public string status { get; set; }
        public DateTime date { get; set; }
    }
}
