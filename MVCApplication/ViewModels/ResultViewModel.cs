﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.ViewModels
{

    public class ResultViewModel
    {
        [Required]
        public String NewElement1 { get; set; }
        [Required]
        public double NewElement2 { get; set; }
        public Dictionary<string, double> TheDictionary { get; set; }

      
    }
}


