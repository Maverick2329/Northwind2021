﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Models.Model
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
