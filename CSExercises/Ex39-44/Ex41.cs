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

            string s1 = null;
            string s2 = null;

            Console.Write("Enter first word(s1):\t");
            s1 = Console.ReadLine();
            Console.Write("Enter second word(s2):\t");
            s2 = Console.ReadLine();


            bool flag = InString(s1, s2);

            if (flag == false)
                Console.WriteLine("\n\nS2 not found in s1");
            else
                Console.WriteLine("\n\nS2 found in s1");

        }
        public static bool InString(string s1, string s2)
        {


            int equal1_count = 0;
            int not1_equalcount = 0;
            string s1_value = null;

            String[] S_arr = new String[s2.Length];

            if (s1.Length == s2.Length)
            {
                for (int k = 0; k < s2.Length; k++)
                {

                    String S2_value = s2.Substring(k, 1);
                    String S1_value = s1.Substring(k, 1);
                    if (S1_value.Equals(S2_value))
                    {
                        equal1_count++;

                    }
                    else
                        not1_equalcount++;
                }
            }

            else if (s1.Length > s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    equal1_count = 0;
                    not1_equalcount = 0;

                    if (s1.Length - i >= s2.Length)
                    {

                        s1_value = s1.Substring(i, s2.Length);

                        for (int k = 0; k < s2.Length; k++)
                        {
                            String S2_value = s2.Substring(k, 1);
                            String S1_value = s1_value.Substring(k, 1);
                            // Console.WriteLine("\n"+S2_value);
                            // Console.WriteLine(S1_value);
                            if (S1_value.Equals(S2_value))
                            {
                                equal1_count++;

                                if (equal1_count > 0)
                                    not1_equalcount = 0;
                            }//end if
                            else
                            {
                                not1_equalcount++;

                                if (not1_equalcount > 0)
                                    equal1_count = 0;

                            }//end else

                            //  Console.WriteLine(equal1_count);
                            //  Console.WriteLine(not1_equalcount);

                        }//end inner for

                        //  Console.WriteLine(equal1_count);
                        //   Console.WriteLine(not1_equalcount);

                        if (equal1_count == s2.Length)
                            break;


                    }//end if
                }//end for

            }//end else if
            else
            {
                not1_equalcount = 1;
            }

            if (not1_equalcount >= 0 && equal1_count != s2.Length)
                return false;
            else
                return true;
        }













       /* public static void Main(string[] args)
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
        }*/
    }
}
