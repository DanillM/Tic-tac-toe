using System.Diagnostics;
using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;

namespace Tic_tac_toe
{
    internal class Program
    {
        
        public static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void Board()
        {
            
            Console.WriteLine("    |   | ");
            Console.WriteLine($" {arr[1]}  | {arr[2]} | {arr[3]}");
            Console.WriteLine("____|___|_____ ");
            Console.WriteLine("    |   | ");
            Console.WriteLine($" {arr[4]}  | {arr[5]} | {arr[6]}");
            Console.WriteLine("____|___|_____ ");
            Console.WriteLine("    |   | ");
            Console.WriteLine($" {arr[7]}  | {arr[8]} | {arr[9]}");
            Console.WriteLine("    |   | ");
        }
        //public static int judjeFlag()
        //{return flag;
        
        
        static void Main(string[] args)
        {
            int stopgame = 1;
            do
            {
                int player = 1;
                int choice;
                int flag = 0;
                
            


                do
                {
                    Console.WriteLine("Player1:X and Player2:O");
                    Console.WriteLine("\n");
                    if (player % 2 == 0)
                    {
                        Console.WriteLine("Player 2 chance");
                    }
                    else if (player % 1 == 0)
                    {
                        Console.WriteLine("Player 1 chance");
                    }

                    //creating board

                    Board();

                    choice = int.Parse(Console.ReadLine());

                    if (player % 2 == 0)
                    {
                        if (arr[choice] != 'X' && arr[choice] != 'O')
                        {
                            arr[choice] = 'O';
                            player++;
                            Console.Clear();
                        }

                        else
                        {
                            Console.WriteLine("Allredy taken");
                        }


                    }
                    else
                    {
                        if (arr[choice] != 'X' && arr[choice] != 'O' && arr[choice] != '$')
                        {
                            arr[choice] = 'X';
                            player++;
                            Console.Clear();
                        }

                        else
                        {
                            Console.WriteLine("Allredy taken");
                        }

                    }



                    if (arr[1] == arr[2] && arr[2] == arr[3])
                    {
                        flag = 1;
                    }

                    else if (arr[4] == arr[5] && arr[5] == arr[6])
                    {
                        flag = 1;
                    }
                    else if (arr[6] == arr[7] && arr[7] == arr[8])
                    {
                        flag = 1;
                    }
                    else if (arr[1] == arr[4] && arr[4] == arr[7])
                    {
                        flag = 1;

                    }
                    else if (arr[2] == arr[5] && arr[5] == arr[8])
                    {
                        flag = 1;
                    }
                    else if (arr[3] == arr[6] && arr[6] == arr[9])
                    {
                        flag = 1;
                    }
                    else if (arr[1] == arr[5] && arr[5] == arr[9])
                    {
                        flag = 1;
                    }
                    else if (arr[3] == arr[5] && arr[5] == arr[7])
                    {
                        flag = 1;
                    }
                    else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5]
                    != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
                    {

                        flag = -1;

                    }
                    else
                    {

                        flag = 0;

                    }




                    /*
                    if (player % 2 == 0)
                    {
                        Console.WriteLine("Player 2");
                    }
                    else if (player % 1 == 0)
                    {
                        Console.WriteLine("Player 1");
                    }
                    */

                } while ((flag != -1) && (flag != 1));

                Console.WriteLine("\n");
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                Board();
                //while (flag != -1);

                //while (flag != 1);

                //while (!((flag==1)&&(flag==-1)));

                //!((flag==1)&&(flag==-1))   (flag!=1)||(flag!=-1)


                if (flag == 1)
                {
                    if (player % 2 == 0)
                    {
                        Console.WriteLine("Player 1 win");
                    }
                    else if (player % 1 == 0)
                    {
                        Console.WriteLine("Player 2 win");

                    }

                }
                else if (flag == -1)
                {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("Enter 1 to restart or 0 to exit");
                stopgame = int.Parse(Console.ReadLine());
                if (stopgame == 1)
                {
                    arr[1] = '1';
                    arr[2] = '2';
                    arr[3] = '3';
                    arr[4] = '4';
                    arr[5] = '5';
                    arr[6] = '6';
                    arr[7] = '7';
                    arr[8] = '8';
                    arr[9] = '9';
                    Console.Clear();
                }
                
            } while(stopgame !=0);


        } 
    }
}