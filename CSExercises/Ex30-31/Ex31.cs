using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int num=0;
            Console.WriteLine("--- Primes between 0 and 1000 ---");
            for (int i = 2; i < 1000; i++)
            {
                for (int j = 2; j <= i/2; j++)
                {
                    if (j % i != 0)
                        num = i;
                    else
                        num = 0;

                }
                if (num > 1)
                    Console.WriteLine("It is a perfect number:"+num);
            }



        }
    }
}
