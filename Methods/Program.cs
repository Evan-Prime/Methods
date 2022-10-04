using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int score;
        static void Main(string[] args)
        {

            //Initialization
            score = 0;
            int enemyValue;
            enemyValue = 5;
            int victoryValue;
            victoryValue = 1000;

            //Simulated gameplay
            while (true)
            {
                Console.WriteLine("Methods Game");
                Console.WriteLine("");

                Console.WriteLine("+-----------------+");
                Console.WriteLine("|Your Curent Score|");
                Console.WriteLine("+------------+----+");
                ShowHUD();

                if (score == 0)
                {
                    Console.WriteLine("Press any key to get more a Higher Score.");
                    Console.ReadKey(true);
                    Console.Clear();
                }

                score = score + enemyValue;
                Console.WriteLine("");
                
                Console.WriteLine("+--------------+");
                Console.WriteLine("|Your New Score|");
                Console.WriteLine("+------------+-+");
                ShowHUD();

                Console.WriteLine("");
                Console.WriteLine("Continue to press any key to get more a Higher Score.");
            
                Console.ReadKey(true);
                Console.Clear();

                if (score == victoryValue)
                {
                    Console.WriteLine("Methods Game");
                    Console.WriteLine("");
                    Console.WriteLine("+------------+");
                    ShowHUD();
                    Console.WriteLine("|You Won!|");
                    Console.WriteLine("+--------+");

                    Console.ReadKey(true);

                    Console.WriteLine("if you want to play again press [R] key.");
                    Console.WriteLine("");
                    Console.WriteLine("if you want to leave the game press any other key.");

                    System.ConsoleKey restChar = Console.ReadKey(true).Key;
                    if (restChar == ConsoleKey.R)
                    {
                        score = 0;
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        static void ShowHUD()
        {
            if (score >= 0 && score < 10)
            {
                Console.WriteLine("|Score: " + score + "    |");
                Console.WriteLine("+------------+");
            }

            if (score >= 10 && score < 100)
            {
                Console.WriteLine("|Score: " + score + "   |");
                Console.WriteLine("+------------+");
            }

            if (score >= 100 && score < 1000)
            {
                Console.WriteLine("|Score: " + score + "  |");
                Console.WriteLine("+------------+");
            }

            if (score == 1000)
            {
                Console.WriteLine("|Score: " + score + " |");
                Console.WriteLine("+--------+---+");
            }
        }
    }
}
