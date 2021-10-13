﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dobocan_Vlad_Lab2EB.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int BookID { get; set; }

        public Customer Customer { get; set; }
        public Book Book { get; set; }
    }
}
