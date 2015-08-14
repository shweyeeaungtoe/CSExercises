using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            int x1, x2, y1, y2;

            System.Console.Write("Please input the value of x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Please input the value of x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Please input the value of y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Please input the value of y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

           /* double Xmin = x2 - x1;
            double Ymin = y2 - y1;

            double Xsqrt = Math.Pow(Xmin,2);
            double Ysqrt = Math.Pow(Ymin, 2);

            double total = Xsqrt + Ysqrt;
            double distance = Math.Sqrt(total);*/

            double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));


            System.Console.WriteLine("Distance is \t" + distance);

        }
    }
}
