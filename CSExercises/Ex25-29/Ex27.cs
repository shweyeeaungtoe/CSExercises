using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex27
    {

        public static void Main(string[] args)
        {
            //    No27 (a)
            Console.WriteLine("27(a)");
            for (int x = -5; x < 6; x++)
            {
                 
                double y = (2 * Math.Pow(x, 2)) - 4 * x + 3;
                System.Console.WriteLine("\tValue of y\t" + y);

            }

            /////////////////////////////////////////////////////////////
            //27(b)

            Console.WriteLine("\n--------------------------------------------------------------------------------\n\n27(b)");
            
            for (int x = -5; x < 6; x++)
            {
                
               double y1 = (2 * Math.Pow(x, 2)) - 4 * x + 3;
               System.Console.Write(y1 + "Times total");
                for (int i = 0; i < y1; i++)
                {
                    System.Console.Write('*');
                }
                System.Console.Write("\n\n");

            }

        }
    }
}

 