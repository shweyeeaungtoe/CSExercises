using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex42
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
            s2 = Console.ReadLine();


            int flag = FindWord(s1, s2);

            if (flag == 0)
                Console.WriteLine("\n\nS2 not found in s1");
            else
                Console.WriteLine("\n\nS2 found in s1"+"\n"+"starting position of a word:\t"+flag);
            
        }
        public static int FindWord(string s1, string s2)
        {
            
            int occur_str=0;
            string s1_value = null;

            int start_position = -1;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Length == s2.Length)
                {
                    //    s1_value = s1.Substring(i, s2.Length);
                    if (s1.Equals(s2))
                    {
                        occur_str = i + 1;
                        break;
                    }

                }

                else if (s1.Length-i >= s2.Length)
                {                      
                    s1_value = s1.Substring(i, s2.Length);

                    if (s1_value.Equals(s2))
                    {
                        start_position = i + 1;
                        break;
                    }
                   
                }
            }
            if (start_position == -1)
                return 0;
            else
                return start_position; 
        }
    }
}
