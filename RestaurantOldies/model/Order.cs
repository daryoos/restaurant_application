﻿using System;
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
    }
}
