using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            //string s1 = "abcde";
            //string s2 = "cfg";
            string s1 = null;
            string s2 = null;

            Console.Write("Enter first word(s1):\t");
            s1 = Console.ReadLine();
            Console.Write("Enter second word(s2):\t");
            s2= Console.ReadLine();


            Boolean flag = InString(s1,s2);

            if (flag == true)
                Console.WriteLine("\n\nString s2 found in s1");
            else if (flag == false)
                Console.WriteLine("\n\nString s2 not found in s1");
        }

        public static bool InString(string s1, string s2)
        {

            if(!s1.Contains(s2))
            return false;
            else 
            return true;
        }
    }
}
