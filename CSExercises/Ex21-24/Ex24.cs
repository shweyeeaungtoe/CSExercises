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
            

            double sqrt_num = Math.Sqrt(N);

            Console.WriteLine("24(a)--> Square root of a number:\t"+sqrt_num);

            Random rnd = new Random();
            double G = Convert.ToDouble(rnd.Next(1,N));

            double n = Convert.ToDouble(N); 


            Console.WriteLine("24(b)--> Guess is Random of a number:\t" +G);


            while (Math.Round(G * G,5) != n)
            {
                G = (G + (n / G)) / 2;
                
                Console.WriteLine("24(d)--> G* Approxiamately to N\t\t\t{0:0.00000}", G);
            }

            Console.WriteLine("24(c)--> Guess is correct:\t{0:0.00000}", G);
            



        }
    }
}
