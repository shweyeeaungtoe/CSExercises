using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {

       
             
            double distance;
            System.Console.Write("Input the distance travelled :\t");
            distance = Convert.ToDouble(System.Console.ReadLine());

            double cal_price = 2.40 + distance * 0.4;
            System.Console.WriteLine("The Total Fare :\t"+ cal_price);
        }
    }
}
