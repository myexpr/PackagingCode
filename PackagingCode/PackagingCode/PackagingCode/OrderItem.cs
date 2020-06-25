using System;
using System.Collections.Generic;
using System.Text;

namespace packagingcode
{
    public class OrderItem
    {
        public IProduct product { get; set; }

        public int Qty { get; set; }

        public decimal total { get; set; }

        public decimal discount { get; set; }

    }
}
