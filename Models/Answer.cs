﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IlCicerone.Models
{
    public class Answer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Css { get; set; }
    }
}
