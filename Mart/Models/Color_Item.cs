﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mart.Models
{
    public class Color_Item
    {
        public int  ItemId { get; set; }
        public Item Item { get; set; }  
        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
}
