﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec4
{
    public class Complex
    {
        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }
        public double Re { get; set; }
        public double Im { get; set; }
        public override string ToString()
        {
            return $"{Re}+{Im}";
        }
    }
}
