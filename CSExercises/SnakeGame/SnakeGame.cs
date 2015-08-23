using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    class SnakeGame
    {
        static void Main(string[] args)
        {

            int[,] ladder = new Int32[,] {
            {1,38},{4,14},{9,31},{21,42},{28,84},{51,67},{71,91},{80,100}
            };

            int[,] snake = new Int32[,]{
            {17,7},{54,34},{62,19},{64,60},{87,24},{93,73},{95,75},{98,79}
            };
            int i = 0;
            int j = 0;
            int your_turn;

            Console.WriteLine("Ïnput -> How many players in games:\t");
            int user_no = Convert.ToInt16(Console.ReadLine());

            int[,] user_array = new int[user_no, 2]; //how many users will be involved in snake gme




            // store users into array
            for (i = 0; i < user_no; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    if (j == 0)
                        user_array[i, j] = i + 1;
                    else
                        user_array[i, j] = 0;
                    //Console.WriteLine(user_array[i,j]);
                }
            }


            int goal = 0;
            while (goal < 100) // winner stage
            {
                for (i = 0; i < user_no; i++) // need to make one by one
                {


                    if (user_array[i, 1] >= 100) // get user step from array to check goal or not
                    {
                        goal = 100;
                        break; // Reached point
                    }

                    else // if not reach goal, go on
                    {


                        int turn = 0; // we need to go one by on. Don't make two twice.

                        while (turn != i + 1) // we need to go one by on. Don't make two twice.
                        {
                            Console.Write("\nEnter Your turn:\t");
                            your_turn = Convert.ToInt16(Console.ReadLine());// now. who is turn? 

                            if (your_turn == i + 1)
                            {
                                Random rnd = new Random(); // declare random number
                                int rnd_no = rnd.Next(1, 6); // get one random number

                                Console.WriteLine("Your existing step is " + user_array[i, 1] + "\n");

                                user_array[i, 1] += rnd_no;


                                turn = i + 1; // 1; end while; let's go to for loop 

                                for (int a = 0; a < ladder.GetLength(0); a++)
                                {

                                    if (ladder[a, 0] == user_array[i, 1])
                                    {
                                        //    Console.WriteLine("Random number is " + rnd_no+"\nCongrat!!!!!  You get a ladder:   "+ladder[a,1]);
                                        Console.WriteLine("\nCongrat!!!!!  You get a ladder:   " + ladder[a, 1]);
                                        user_array[i, 1] = ladder[a, 1];

                                        //    Console.WriteLine("You reached here:   " + user_array[i,1]);
                                    }
                                    if (snake[a, 0] == user_array[i, 1])
                                    {
                                        //    Console.WriteLine("Random number is " + rnd_no + "\nYou get a snake:   " + snake[a, 1]);
                                        Console.WriteLine("\nYou get a snake:   " + snake[a, 1]);
                                        user_array[i, 1] = snake[a, 1];
                                        //    Console.WriteLine("You reached here:   " + user_array[i, 1]);
                                    }
                                }


                                if (user_array[i, 1] > 100)
                                {
                                    int value = user_array[i, 1] - 100;
                                    int value1 = 100 - value;
                                    user_array[i, 1] = value1;
                                    Console.WriteLine("Because of Random number is " + rnd_no + "\nPlayer: " + (i + 1) + " *******Now Your Step is " + user_array[i, 1] + "\n"); // show user your step

                                }
                                else if (user_array[i, 1] == 100) // for check to get goal
                                {
                                    goal = 100;
                                    // show user your step
                                    Console.WriteLine("Because of Random number is " + rnd_no + "\nPlayer: " + (i + 1) + " *** Now Your Step is  " + user_array[i, 1] + "\n");

                                    i = user_no + user_no;      // for break while and for
                                    turn = i + 1;               // for break while and for

                                    break;
                                }
                                else
                                    Console.WriteLine("Because of Random number is " + rnd_no + "\nPlayer: " + (i + 1) + " *** Now Your Step is  " + user_array[i, 1] + "\n"); // show user your step


                                break;
                            }

                            else
                            {
                                Console.WriteLine("\nSo Sorry!\nIt is not your turn:Now Player No:  " + (i + 1) + " turn!!!");
                                turn = your_turn; // let go while loop coz not your turn!!!! Try again!

                            }



                        }//end while

                    }//end else

                }//end for
                Console.WriteLine("________________________________________________________");
            }//end while

            if (goal == 10)
            {
                for (i = 0; i < user_no; i++)
                {
                    j = 1;

                    Console.WriteLine("\n\n" + user_array[i, j]);

                }

            }

        }
    }
}
