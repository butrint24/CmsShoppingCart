﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CmsShoppingCart.Models
{
    public class Category
    {
        public int Id{ get; set; }
        [Required, MinLength(2, ErrorMessage ="Minimum length is 2")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage ="Only letteres are allowed")]
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        public int Sorting { get; set; }
    }
}