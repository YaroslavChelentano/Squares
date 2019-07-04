using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp5
{
    class TCircle
    {
        public double r=5;
        public TCircle()
        {

        }
        public void TSquere()
        {
            double square = 0;
            square = r * r * 3.14;
            Console.WriteLine(square);
        }
        public void TRing()
        {
            double length = 0;
            length = 2 * 3.14 * r;
        }
        public void TCircle3(double r)
        {
            double v = 0;
            v = 3.14 * 4 / 3 * r * r * r;
        }



        class Program
        {
            static void Main(string[] args)
            {
                TCircle a = new TCircle();
                a.TSquere();
            }
        }
    }
}
