using System;
using System.Collections.Generic;
using System.Text;

namespace SENG8040_Assignment1
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public int GetLength()
        {
            return length;
        }
        public int setLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int GetWidth()
        {
            return width;
        }
        public int setWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetPerimeter()
        {
            int Perimeter = 2 * (length + width);
            return Perimeter;
        }
        public int GetArea()
        {
            int Area = (length * width);
            return Area;
        }






    }
}
