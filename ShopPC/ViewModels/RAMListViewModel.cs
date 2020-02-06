﻿using Shop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class RAMListViewModel
    {
        public IEnumerable<RAM> Products { get; set; }
        public string currentCategory { get; set; }
    }
}
