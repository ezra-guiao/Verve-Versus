using System;

namespace Versus_Verve
{
    public class mainclass
    {
        static void playerAction(string player)
        {
            string Action = Console.ReadLine();
            if (Action == "1")
            {
                //code
            }
            else if (Action == "2")
            {
                //code
            }
            else if (Action == "3")
            {
                //code
            }
            else if (Action == "4")
            {
                //code
            }
            else if (Action == "5")
            {
                //code
            }
            else
            {
                Console.WriteLine("Invalid input, Please try again");
                Console.WriteLine("\nChoose your action 1: use sword, 2: strong atk, 3: bow, 4: shield, 5: rest");
                playerAction("player1");
            }
        }

        static void verveShop(string player)
        {
            string goShop = Console.ReadLine();
            if (goShop == "1")
            {
                //code
            }
            else if (goShop == "2")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid input, Please try again");
                Console.WriteLine("1: Go to Shop, 2: End turn");
                verveShop("player1");
            }
        }
        static void Main(string[] args)
        {
            //declaring variables
            bool isGame = true;
            int turnCounter = 0;
            int p1Hp = 100;
            int p2Hp = 100;
            int p1Verve = 0;
            int p2Verve = 0;

            //main game loop
            while (isGame)
            {
                if (p1Hp <= 0 || p2Hp <= 0)
                {
                    isGame = false;
                }

                if (turnCounter % 2 == 0)
                {
                    Console.WriteLine("\nPlayer 1's turn, what would u like to do");
                    Console.WriteLine("You currently have {0} HP and {1} Verve", p1Hp, p1Verve);
                    Console.WriteLine("\nChoose your action 1: use sword, 2: strong atk, 3: bow, 4: shield, 5: rest");
                    playerAction("player1");
                    Console.WriteLine("\nYou have {0} Verve remaining, would you like to buy something?", p1Verve);
                    Console.WriteLine("1: Go to Shop, 2: End turn");
                    verveShop("player1");
                    p1Verve += 5;
                    turnCounter += 1;

                }
                else
                {
                    Console.WriteLine("\nPlayer 2's turn, what would u like to do");
                    Console.WriteLine("You currently have {0} HP and {1} Verve", p2Hp, p2Verve);
                    Console.WriteLine("\nChoose your action 1: use sword, 2: strong atk, 3: bow, 4: shield, 5: rest");
                    playerAction("player2");
                    Console.WriteLine("\nYou have {0} Verve remaining, would you like to buy something?", p2Verve);
                    Console.WriteLine("1: Go to Shop, 2: End turn");
                    verveShop("player2");
                    p2Verve += 5;
                    turnCounter += 1;
                }
            }
        }
    }
}


