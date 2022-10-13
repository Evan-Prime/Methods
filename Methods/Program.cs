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
        static int health;

        static void Main(string[] args)
        {

            //Initialization
            score = 0;
            health = 100;
            int takeDamage;
            takeDamage = -5;
            int healDamage;
            healDamage = 5;
            int enemyValue;
            enemyValue = 5;

            //Simulated gameplay
            while (true)
            {
                GameTitle();
                Console.WriteLine(" +-----------------+");
                Console.WriteLine(" |Your Curent Score|");
                Console.WriteLine(" +------------+----+");
                ShowScoreHUD();
                Console.WriteLine("");
                Console.WriteLine(" +------------------+");
                Console.WriteLine(" |Your Curent Health|");
                Console.WriteLine(" +------------+-----+");
                ShowHeatlhHUD();
                Console.WriteLine("");
                Console.WriteLine(" Press any key to Continue");
                Console.ReadKey(true);
                Console.Clear();

                GameTitle();
                Console.WriteLine("");
                Console.WriteLine(" !!!See a Enemy in front of You!!!");
                Console.WriteLine("");
                Console.WriteLine(" Press [E] to Fight them or Press [Q] to Heal yourself");
                while (true)
                {
                    System.ConsoleKey combatChar = Console.ReadKey(true).Key;
                    if (combatChar == ConsoleKey.E)
                    {
                        score = score + enemyValue;
                        health = health + takeDamage;
                        break;
                    }
                    else if (combatChar == ConsoleKey.Q)
                    {
                        if (health <= 95)
                        {
                           health = health + healDamage;
                           Console.WriteLine(" you gained +5 health");
                        }
                        else
                        {
                            Console.WriteLine("You're health is at Max");
                        }
                    }
                }

                Console.Clear();

                GameTitle();
                Console.WriteLine("");
                Console.WriteLine(" You took 5 damage but...");
                Console.WriteLine("");
                Console.WriteLine(" ...You won the fight!");
                Console.WriteLine("");

                Console.WriteLine(" +--------------+");
                Console.WriteLine(" |Your New Score|");
                Console.WriteLine(" +------------+-+");
                ShowScoreHUD();
                Console.WriteLine("");
                Console.WriteLine(" +---------------+");
                Console.WriteLine(" |Your New Heatlh|");
                Console.WriteLine(" +------------+--+");
                ShowHeatlhHUD();

                Console.WriteLine("");
                Console.WriteLine(" Press any key to Continue");
            
                Console.ReadKey(true);
                Console.Clear();

                if (score == 200 && health >= 1)
                {
                    GameTitle();
                    Console.WriteLine(" +------------+");
                    ShowScoreHUD();
                    Console.WriteLine(" |You Won!|");
                    Console.WriteLine(" +--------+");

                    Console.ReadKey(true);

                    Console.WriteLine(" if you want to play again press [R] key.");
                    Console.WriteLine("");
                    Console.WriteLine(" if you want to leave the game press any other key.");

                    System.ConsoleKey restChar = Console.ReadKey(true).Key;
                    if (restChar == ConsoleKey.R)
                    {
                        score = 0;
                        health = 100;
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }
                }
                else if (health == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" You Died!");
                    Console.WriteLine("");

                    Console.ReadKey(true);

                    Console.WriteLine(" if you want to play again press [R] key.");
                    Console.WriteLine("");
                    Console.WriteLine(" if you want to leave the game press any other key.");

                    System.ConsoleKey restChar = Console.ReadKey(true).Key;
                    if (restChar == ConsoleKey.R)
                    {
                        score = 0;
                        health = 100;
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        static void ShowScoreHUD()
        {
            if (score >= 0 && score < 10)
            {
                Console.WriteLine(" |Score: " + score + "    |");
                Console.WriteLine(" +------------+");
            }
            else if (score >= 10 && score < 100)
            {
                Console.WriteLine(" |Score: " + score + "   |");
                Console.WriteLine(" +------------+");
            }
            else if (score >= 100 && score <= 200)
            {
                Console.WriteLine(" |Score: " + score + "  |");
                Console.WriteLine(" +------------+");
            }
        }

        static void ShowHeatlhHUD()
        {
            if (health == 100)
            {
                Console.WriteLine(" |Heatlh: " + health + " |");
                Console.WriteLine(" +------------+");
            }
            else if (health >= 10 && health < 100)
            {
                Console.WriteLine(" |Heatlh: " + health + "  |");
                Console.WriteLine(" +------------+");
            }
            else if (health >= 0 && health < 10)
            {
                Console.WriteLine(" |Heatlh: " + health + "   |");
                Console.WriteLine(" +------------+");
            }
        }

        static void GameTitle()
        {
            Console.WriteLine("");
            Console.WriteLine("  The Methods Game");
            Console.WriteLine("");
        }
    }
}
