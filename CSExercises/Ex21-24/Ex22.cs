using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A = 0, B = 0;

            Console.Write("Enter a number:\t");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number:\t");
            B = Convert.ToInt32(Console.ReadLine());

            int A_B = A * B;

            do{

              if (A > B)
             {
                    A = A - B;
               
               }
               else
              {
                 B = B - A;
                
                }
            }while(A!=B);

            int HCF = A;
            int LCM = A_B / HCF;

            Console.WriteLine("HCF:\t"+HCF+""+"\nLCM:\t"+LCM);
            
        }
    }
}
