using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int [] sale=new Int32[12];
            double total_sales = 0;
            double avg_sales = 0;
            int temp_max = 0;
            int temp_min = -1;
            int max_month = 0;
            int min_month = 0;
            for (int i = 0; i < sale.Length; i++)
            {
                Console.Write("Enter sales for month\t" + i + "\t:");
                sale[i] = Convert.ToInt32(Console.ReadLine());
            }

          /* for (int i = 0; i < sale.Length; i++)
            {
                for (int j = sale.Length-1; j >= i; j--)
                {

                    if (sale[j] > sale[i])
                    {
                        temp = sale[j];
                        sale[j] = sale[i];
                        sale[i] = temp;
                    }
                }
            }

           
            Console.WriteLine("\n\n32(b)-------> Maximum sales:\t"+ sale[0]);
            Console.WriteLine("32(c)-------> Maximum sales:\t"+ sale[sale.Length-1]);
            */

            /*for (int i = 0; i < sale.Length; i++)
            {
                Console.WriteLine(sale[i]);
               
            }
            */
            for (int i = 0; i < sale.Length; i++)
            {
                for (int j = sale.Length-1; j >=0 ; j--)
                {

                    if (sale[i] > sale[j])
                    {
                        if (temp_max == 0)
                        {
                            temp_max = sale[i];
                            max_month = i;
                        }
                        else if (temp_max < sale[i])
                        {
                            temp_max = sale[i];
                             max_month = i;
                        }
                      
                    }
                }
            }

            Console.WriteLine("\n32(b)------->Print the month for Maximum sales:\t" +max_month);

            for (int i = 0; i < sale.Length; i++)
            {
                for (int j = sale.Length - 1; j >= 0; j--)
                {

                    if (sale[i] < sale[j])
                    {
                        if (temp_min == -1)
                        {
                            temp_min = sale[i];
                            min_month = i;
                        }
                        else if (temp_min > sale[i])
                        {
                            temp_min = sale[i];
                            min_month = i;
                        }
                        

                    }
                }
            }
            Console.WriteLine("2(c)-------> Print the month for Minimum sales:\t:\t"+min_month);

             for (int j = 0; j < sale.Length; j++)
             {
                    total_sales += sale[j];
                    avg_sales =Math.Round (total_sales / sale.Length);
              }
            Console.WriteLine("32(d)-------> Average Sales For the year: \t"+avg_sales+"\n");
        }
    }
}
