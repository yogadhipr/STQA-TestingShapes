using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes
{
    public class shapes
    {
        public double kubus(double a)
        {
            return a *a  *a ;
        }


        public double balok(double a, double b, double c)
        {
            return a * b * c;
        }

        public double tabung(double a, double b)
        {
            return 22 / 7 * a * a * b;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            double a = Double.Parse(args[0]);
            double b = Double.Parse(args[1]);
            double c = Double.Parse(args[2]);
            

            shapes sh = new shapes();

            double kb = sh.kubus(a);
            double bl = sh.balok(a, b, c);
            double tb = sh.tabung(a, b);

            Console.WriteLine("volume kubus = {0}", kb);
            Console.WriteLine("volume balok = {0}", bl);
            Console.WriteLine("volume tabung = {0}", tb);
        }
    }
}