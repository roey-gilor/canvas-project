using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCanvas
{
    internal class MyButton
    {
        protected Point topLeft;
        protected Point buttomRight;
        private int width;
        private int height;
        internal MyButton(Point topLeft, Point buttomRight)
        {
            this.topLeft = topLeft;
            this.buttomRight = buttomRight;
            this.height = this.topLeft.Y - this.buttomRight.Y;
            this.width = this.buttomRight.X - this.topLeft.X;
        }
        internal int Width { get
            {
                return width;
            }
        }
        internal int Height { get
            {
                return height;
            }
                }
        internal bool SetTopLeft(Point topLeft)
        {
            if (topLeft.Y < this.buttomRight.Y || topLeft.X > this.buttomRight.X)
                return false;
            this.topLeft = topLeft;
            this.height = this.topLeft.Y - this.buttomRight.Y;
            this.width = this.buttomRight.X - this.topLeft.X;
            return true;
        }
        internal bool SetButtomRight(Point buttomRight)
        {
            if (buttomRight.Y > this.topLeft.Y || buttomRight.X < this.topLeft.X)
                return false;
            this.buttomRight = buttomRight;
            this.height = this.topLeft.Y - this.buttomRight.Y;
            this.width = this.buttomRight.X - this.topLeft.X;
            return true;
        }
        internal Point TopLeft
        {
            get
            {
                return this.topLeft;
            }
        }
        internal Point ButtomRight
        {
            get
            {
                return this.buttomRight;
            }
        }
        public override string ToString()
        {
            return "Top Left Buttom " + this.topLeft.ToString() + " Buttom Right " + buttomRight.ToString();
        }
    }
}
