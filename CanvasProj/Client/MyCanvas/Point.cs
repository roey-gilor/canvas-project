using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCanvas
{
    internal class Point
    {
        
        private int x;
        private int y;
        internal Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int X
        {
            get { return this.x; }
            set
            {
                if (value > 0 && value < Canvas.maxWidth)
                    this.x = value;
                else
                    Console.WriteLine("Value not allowed");
            }
        }
        internal int Y
        {
            get { return this.y; }
            set
            {
                if (value > 0 && value < Canvas.maxHeight)
                    this.y = value;
                else
                    Console.WriteLine("Value not allowed");
            }
        }

        public override string ToString()
        {
            return "x: " + this.X + " y: " + this.Y;
        }

    }
}
