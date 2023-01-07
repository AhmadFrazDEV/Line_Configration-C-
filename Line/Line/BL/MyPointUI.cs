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
    class MyPointUI
    {
      public static  MyLine UpgradeBegin = new MyLine();

        public static MyPoint inputPoint()
        {
            Write("Enter x coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Write("Enter y coordinate: ");
            int y = int.Parse(Console.ReadLine());
            MyPoint input = new MyPoint(x, y);
            return input;
        }

        public static void UpdateTheBegningPoint()
        {
            MyPoint Upgrade = new MyPoint();
            WriteLine("Upgrading Begning Point.....");
            Write("Enter the X coordinate : ");
            int x = int.Parse(ReadLine());
            Write("Enter the Y coordinate : ");
            int y = int.Parse(ReadLine());
            Upgrade.setX(x);
            Upgrade.setY(y);
          //  MyLine UpgradeBegin = new MyLine();
            UpgradeBegin.set_BP(Upgrade);
            Write("Upgraded Points Are : ({0} , {1})", UpgradeBegin.get_BP().getX(), UpgradeBegin.get_BP().getY());
        }

        public static void UpdateTheEndPoint()
        {
            MyPoint Upgrade = new MyPoint();
            WriteLine("Upgrading End Point....");
            WriteLine();
            Write("Enter the X coordinate : ");
            int x = int.Parse(ReadLine());
            Write("Enter the Y coordinate : ");
            int y = int.Parse(ReadLine());
            Upgrade.setX(x);
            Upgrade.setY(y);
           // MyLine UpgradeBegin = new MyLine();
            UpgradeBegin.set_EP(Upgrade);
        }

        public static void showUpdateBegningPoint()
        {
            
            Write("Upgraded Points Are : ({0} , {1})", UpgradeBegin.get_BP().getX(), UpgradeBegin.get_BP().getY());

        }

        public static void showUpdateEndingPoint()
        {
            MyLine U = new MyLine();
            Write("Updated Begning Point is ------> {0}", U.get_EP());
        }
        public static void showUpdatedPoint(MyPoint previousPoint, MyPoint newPoint)
        {
            WriteLine("Previous Point Was: ({0},{1})", previousPoint.getX(), previousPoint.getY());
            WriteLine("Updated Point: ({0},{1})", newPoint.getX(), newPoint.getY());
        }
    }
}
