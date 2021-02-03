﻿using IlCicerone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IlCicerone.Models.Home
{
    public class Item
    {
        public Article Article { get; set; }
        public int Quantity { get; set; }
    }
}