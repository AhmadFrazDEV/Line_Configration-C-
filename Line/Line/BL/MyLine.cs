using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Line.BL;
namespace Point.BL
{
    class MyLine
    {
       private MyPoint begin;
        private MyPoint end;

        public MyPoint get_BP() { return begin; }
        public void set_BP(MyPoint begin) { this.begin = begin; }

        public MyPoint get_EP() { return end; }
        public void set_EP(MyPoint end) { this.end = end; }


        public MyLine()
        {
            
        }
        public MyLine(MyPoint begin , MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }

  

        public double getLenght()
        {
            MyPoint point = new MyPoint();
            double length;
            length = Math.Sqrt(Math.Pow((begin.getX() - point.getX()) , 2) +Math.Pow( (end.getY() - point.getY()) , 2));
            return length;
        }

        public double getGradient()
        {
            MyPoint point = new MyPoint();

            double gredient = (point.getY() - end.getY()) / point.getX() - begin.getX();
            return gredient;
        }
       
    }
}
