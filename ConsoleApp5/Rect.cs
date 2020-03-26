using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Rect
    {
        private double width;
        private double height;

        public Rect(double width, double height)
        {
            this.height = height;
            this.width = width;
        }

        public double Area()
        {
            return this.width * this.height;
        }
    }
}
