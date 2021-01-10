﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoPets.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFullfiller { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; } // Navigation property
    }
}
