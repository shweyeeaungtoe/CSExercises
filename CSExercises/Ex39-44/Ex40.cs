using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("Square root of a number"+i+"\t"+Math.Round(SQT(i),3));
            }
        }

        public static double SQT(int y)
        {
            double num = Math.Sqrt(y);
            return num;
        }
        
    }
}
