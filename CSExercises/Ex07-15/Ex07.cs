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
            String temp;
            temp = Console.ReadLine();

            double salary;
            salary = Convert.ToDouble(temp);


            double home_allowance = salary * 0.1;
            double transport_allowance = salary * 0.03;

            double totalsalary = salary + home_allowance + transport_allowance;
            System.Console.WriteLine("Employee's total income\t" + totalsalary);
        }
    }
}
