﻿using System;
using System.Collections.Generic;

namespace EFCore_NorthwindDB
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
