using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            int temp = 0;
            string name = null;
            string i_name = null;
            string j_name = null;


            string[] name_array = new string[] {"John","Venkat","Mary","Victor","Betty"};
            int[] marks_array = new int[] {63,29,75,82,55};

            for (int i = 0; i < marks_array.Length; i++)
            {
                for (int j = marks_array.Length - 1; j >= i; j--)
                {

                    if (marks_array[j] > marks_array[i])
                    {
                        temp = marks_array[j];
                        marks_array[j] = marks_array[i];
                        marks_array[i] = temp;
                    }
                }
            }
            Console.WriteLine("38(a)\nFirst Report is:Decending order of the Marks\t");
            for (int i = 0; i < marks_array.Length; i++)
            {
                Console.WriteLine(marks_array[i]);
            }

            Console.WriteLine("\n\n38(b)\nSecond Report is:Sort student name alphabetically\t");

            for (int i = 0; i < name_array.Length; i++)
            {
                for (int j = name_array.Length - 1; j >= i; j--)
                {
                    j_name = name_array[j];
                    i_name = name_array[i];

                    int return_value=j_name.CompareTo(i_name);

                    if (return_value==-1)
                    {
                        name = name_array[j];
                        name_array[j] = name_array[i];
                        name_array[i] = name;
                    }
                }
            } 
            for (int i = 0; i < name_array.Length; i++)
            {
                Console.WriteLine(name_array[i]);
            }

        }
    }
}
