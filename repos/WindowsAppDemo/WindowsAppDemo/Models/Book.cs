﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppDemo.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }     
        public int YearPublished { get; set; }
        public string Genre { get; set; }
        public override string ToString()
        {
            return $"{Title} by {Author} {YearPublished}";
        }
    }
    
}
