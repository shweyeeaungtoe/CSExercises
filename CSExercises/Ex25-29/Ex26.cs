using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("No\t\t" + "Inverse\t\t" + "Square Root\t\t" + "Square" + "\n-----------------------------------------------------------------");
            for (int i = 1; i < 11; i++)
            {
                
                double num_inverse = 1/i;
                double num_squareroot = Math.Round(Math.Sqrt(i),3);
                double num_square = Math.Pow(i,2);

                
                Console.Write(i+"\t\t"+num_inverse+"\t\t"+num_squareroot+"\t\t\t"+num_square+"\n");
            
            }

                
            }
        }
    }

