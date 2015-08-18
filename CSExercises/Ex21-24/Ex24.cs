using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            double g;

            double sqrt_num = Math.Sqrt(N);

            Console.WriteLine("24(a)--> Square root of a number:\t"+sqrt_num);

            Random rnd = new Random();
            int G = rnd.Next(1,N);
            Console.WriteLine("24(b)--> Guess is Random of a number:\t" +G);
            if (G * G != N)
            {
                g = (G + (N / G)) / 2;
                
                Console.WriteLine("24(d)--> G* Approxiamately to N\t\t\t{0:###.#####}", g);
            }
            if (G * G == N)
            {
                Console.WriteLine("24(c)--> Guess is correct:\t" + G * G);
            }



        }
    }
}
