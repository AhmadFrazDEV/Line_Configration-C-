using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.BL
{
    class MyPoint
    {
        private int x;
        private int y;

        public int getX() { return x; }
        public void setX(int x) { this.x = x; }

        public int getY() { return y; }
        public void setY(int y) { this.y = y; }

        public MyPoint()
        {
            x = 0;
            y = 0;
        }
        public MyPoint(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public void DrawLine()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Write("*");
                }
            }
        }
       

      

        public void setxy(int x , int y)
        {
            this.x = x;
            this.y = y;
        }

        public double distancewithCoordinates(int x1 , int y1)
        {
        
            //----------> Using Distance Formula
            double L = Math.Sqrt((Math.Pow((x1 - x), 2)) + (Math.Pow((y1 - y), 2)));
            return L;
        }
        public double distancewithObjexts(MyPoint newPoint)
        {
           
            //----------> Using Distance Formula
            double L = Math.Sqrt((Math.Pow((newPoint.x - x), 2)) + (Math.Pow((newPoint.y - y), 2)));
            return L;
        }

        public double distanceFromZero()
        {
            double L;
            return L = (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
        }
    }
}
