using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Employee salary");
            //String temp;
            //temp = Console.ReadLine();

            double salary;
            salary = Convert.ToDouble(Console.ReadLine());


            double home_allowance = (salary / 100) * 10;
            double transport_allowance = (salary / 100) * 3;

            double totalsalary = salary + home_allowance + transport_allowance;
            System.Console.WriteLine("Employee's total income {0:C}\t" , totalsalary);
        }
    }
}
