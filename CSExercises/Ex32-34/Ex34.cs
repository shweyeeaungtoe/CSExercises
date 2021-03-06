using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int [,] Arrstu_marks=new int[,]{
            {56,84,68,29},{94,73,31,89},
            {41,63,36,90},{99,9,18,17},
            {62,3,65,75},{40,96,53,23},
            {81,15,27,30},{21,70,100,22},
            {88,50,13,12},{48,54,52,78},
            {64,71,67,25},{16,93,46,72}
            };

            int total_mark = 0;
            String[] stu_name = new string[] { "Student1", "Student2", "Student3", "Student4", "Student5", "Student6", "Student7", "Student8", "Student9", "Student10", "Student11", "Student12"};

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    total_mark += Arrstu_marks[i, j];
                }

                Console.WriteLine("34(a)-----> Total Marks for "+stu_name[i]+":\t"+total_mark);
            }

            Console.WriteLine("\n\n");


          ///////////////////////////////////////////////////////////////////////////////////////////////////////
          //*************************************** 34(b)***************************
             
            int arr_column=0;
            double onesubject_totalmarks = 0;
            double marks_allSubject = 0;

            while (arr_column <= Arrstu_marks.GetUpperBound(1))
            {
                onesubject_totalmarks = 0;
                for (int j = 0; j <= Arrstu_marks.GetUpperBound(0); j++)
                {

                    onesubject_totalmarks += Arrstu_marks[j, arr_column];
                }
                arr_column++;
                marks_allSubject += onesubject_totalmarks; // add all subject marks
                Console.WriteLine("34(b)-----> Average Marks for Subject" + arr_column + ":\t" + Math.Round(onesubject_totalmarks / Arrstu_marks.GetLength(0)));
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            //*************************************** 34(c)***************************

            double avgmarks_all = marks_allSubject / Arrstu_marks.Length;
              Console.WriteLine("\n\n34(c)-----> Overall Average Marks for all Subjects:\t" + Math.Round(avgmarks_all));
        }
    }
}
