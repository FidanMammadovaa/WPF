﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWorkONWPF.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public uint Quantity { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
