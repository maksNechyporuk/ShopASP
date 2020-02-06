﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Main.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public uint Price { get; set; }
        public string Img { get; set; }
        public virtual CategoryPhone Category { get; set; }
    }
}
