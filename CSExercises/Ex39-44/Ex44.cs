using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string [] args)
        {
            string s= null;
            char c1;
            char c2;

            Console.Write("Enter one string:\t");
            s = Console.ReadLine();
            Console.Write("\nEnter one character:\t");
            c1 = Convert.ToChar(Console.ReadLine());
            Console.Write("\nEnter one character:\t");
            c2 = Convert.ToChar(Console.ReadLine());
            string new_word=Substitute(s, c1, c2);
        }
        public static string Substitute(string s, char c1, char c2)
        {
            s.Contains(c1);
            c1 = c2;

            return null;
        }
    }
}
