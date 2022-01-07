﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Laba
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class Figure
    {
        public abstract double GetArea();
        public abstract double GetPerimetr();
        public abstract string Name { get; set; }
    }

    class Rectangular : Figure
    {
        string name;
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width * Height;
        }
        public override double GetPerimetr()
        {
            return Width * 2 + Height * 2;
        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
