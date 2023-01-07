using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Line.BL;
using Point.BL;

namespace Line
{
    class Program
    {
        MyLine obj = new MyLine();
        static void Main(string[] args)
        {
            int opt;
            LestStart();
            do
            {
                opt = menu();
                if (opt == 1)
                {
                     MyLineUI.makeLine();
                    clearScreen();
                }
                if (opt == 2)
                {
                    MyPointUI.UpdateTheBegningPoint();
                    clearScreen();
                }
                if(opt == 3)
                {
                    MyPointUI.UpdateTheEndPoint();
                }
                if(opt == 4)
                {
                    MyPointUI.showUpdateBegningPoint();
                }
                if (opt == 5) { MyPointUI.showUpdateEndingPoint(); }
                if(opt == 6) { getLength(); }
                if(opt == 7) { getGradient(); }
            }
            while (opt != 10);
        }

        static int menu()
        {
            WriteLine("1. Make a Line");
            WriteLine("2. Update the Begin Point");
            WriteLine("3. Update the End Point");
            WriteLine("4. Show the Updated Point");
            WriteLine("5. Show the End Point");
            WriteLine("6. Get the Length of Line");
            WriteLine("7. Get the Gradient of line");
            WriteLine("8. Find the distance of begin point from zero coordinates");
            WriteLine("9. Find the distance of end point from zero coordinates");
            WriteLine("10. Exit");
            WriteLine();
            int opt;
            Write("Your Option ____________  ");
            opt = int.Parse(ReadLine());
            return opt;
        }

      
         static void clearScreen()
        {
            Write("Press any Key To continue_______");
            ReadKey();
            Clear();
        }

        static void LestStart()
        {
            Write("Lets's Start......");
            ReadKey();
            Clear();
        }

        static void getLength()
        {
            MyLine length = new MyLine();
            Write("The Length for Above Points is -------> {0}" , length.getLenght());
        }

        static void getGradient()
        {
            MyLine gredient = new MyLine();
            Write("The Gredient for Above Points is -------> {0}", gredient.getGradient()); 
        }
    }


}
