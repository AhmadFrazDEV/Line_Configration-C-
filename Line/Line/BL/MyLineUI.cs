using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Line.BL;
using Point.BL;
namespace Line.BL
{
    class MyLineUI
    {
        public static MyLine makeLine()
        {
            WriteLine("Enter Begin Point: ");
            MyPoint begin = MyPointUI.inputPoint();
            WriteLine("Enter End Point: ");
            MyPoint end = MyPointUI.inputPoint();
            MyLine input = new MyLine(begin, end);
            return input;
        }
    }
}
