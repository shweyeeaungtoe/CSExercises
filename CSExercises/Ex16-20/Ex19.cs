using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {

            Console.Write("Please Enter The distance travelled in km:\t");
            double travelled_km = Convert.ToDouble(Console.ReadLine());

            double travelled_m = travelled_km * 10;
            double travelled_roundup = Math.Ceiling(travelled_m);

            System.Console.Write(travelled_roundup);

            if (travelled_roundup > 90)
            {
                double total_travelledcost = 2.40 + 85 * 0.04 + (travelled_roundup - 90) * 0.05;
                System.Console.WriteLine("\nTravelled Cost: \t{0:C}" , total_travelledcost);
            }
            else if (travelled_roundup > 5)
            {
                double total_travelledcost = 2.40 + (travelled_roundup-5) * 0.04;
                System.Console.WriteLine("\nTravelled Cost:\t{0:C}" , total_travelledcost);
            }
            else
            {
                double total_travelledcost = 2.40;
                System.Console.WriteLine("\nTravelled Cost:\t{0:C}" , total_travelledcost);
            }
        }
    }
}