using System;
using System.Collections.Generic;
using System.Linq;

namespace Versus_Verve
{
    public class mainclass
    {
        class player
        {
            public int HP;
            public int Verve;
        }

        public static List<string> BuyItem(string player, int verve)
        {
                Console.WriteLine("You have {0} verve, what would you like to buy?\n", verve);
                List<string> empty = new List<string>();

                var Shop = new Dictionary<string, int>()
                {
                    {"Basic Health Pot (Item)", 10},{"Guardian (Item)",10},{"Regenerative (Item)",15},{"Illusive Pot (Item)",15},
                    {"Windmill (Building)", 15},{"Enhanced Hexbow (Upgrade)",20},{"Taxation (Item)",20},{"Powerplant (Building)",25},
                    {"Reactor (Building)",35},{"Enhanced Hexlyene Caliver (Upgrade)",50}
                };

                for(int i=0; i < Shop.Count; i++)
                {
                    Console.WriteLine("{0}: {1} Cost : {2} V", i, Shop.ElementAt(i).Key, Shop.ElementAt(i).Value);
                }
                Console.WriteLine("10: End turn\n");
                int actionBuy = Int32.Parse(Console.ReadLine());
                if (actionBuy >= 10)
                {
                Console.WriteLine("Ending turn");
                System.Threading.Thread.Sleep(2000);
                return empty;
                }

                if (verve >= Shop.ElementAt(actionBuy).Value)
                {
                    verve -= Shop.ElementAt(actionBuy).Value;
                    Console.WriteLine("You have bought {0}, you have {1} V left" , Shop.ElementAt(actionBuy).Key,verve);
                    Console.WriteLine("Ending turn");
                    System.Threading.Thread.Sleep(2000);
                    if (player == "player1")
                    {
                    empty.Add(Shop.ElementAt(actionBuy).Key);
                    empty.Add(verve.ToString());
                    return empty;
                    }
                    else
                    {
                    return empty;
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient Funds, ending turn");
                    System.Threading.Thread.Sleep(2000);
                    return empty;
                }

        }
        static void useItem(string player, List<string> inventory)
        {
            Console.Clear();
            Console.WriteLine("{0}'s inventory", player);
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, inventory[i]);
            }
            if (player == "player1")
            {

            }
            else if (player == "player 2")
            {

            }
        }

        static void playerAction(string player, List<string> inventory)
        {
            string Action = Console.ReadLine();
            if (Action == "1")
            {
                if (player == "player1")
                {

                }
                else if (player == "player2")
                {

                }
            }
            else if (Action == "2")
            {
                if (player == "player1")
                {

                }
                else if (player == "player2")
                {

                }
            }
            else if (Action == "3")
            {
                if (player == "player1")
                {

                }
                else if (player == "player2")
                {

                }
            }
            else if (Action == "4")
            {
                if (player == "player1")
                {

                }
                else if (player == "player2")
                {

                }
            }
            else if (Action == "5")
            {
                if (inventory.Count > 0)
                {
                    useItem(player, inventory);
                }
                else
                {
                    Console.WriteLine("You have no items");
                    Console.WriteLine("\nChoose your action 1: use sword, 2: strong atk, 3: bow, 4: shield, 5: use item 6: rest");
                    playerAction(player, inventory);
                }
            }
            else if (Action == "6")
            {
                if (player == "player1")
                {

                }
                else if (player == "player2")
                {

                }
            }
            else
            {
                Console.WriteLine("Invalid input, Please try again");
                Console.WriteLine("\nChoose your action 1: use sword, 2: strong atk, 3: bow, 4: shield, 5: use item 6: rest");
                playerAction(player, inventory);
            }
        }
    

        static void Main(string[] args)
        {
            //declaring variables
            bool isGame = true;
            int turnCounter = 0;
            player Player1 = new player();
            Player1.HP = 100;
            Player1.Verve = 30;
            player Player2 = new player();
            Player2.HP = 100;
            Player2.Verve = 30;
            List<string> player1inv = new List<string>();
            List<string> player2inv = new List<string>();

            //main game loop
            while (isGame)
            {

                if (turnCounter % 2 == 0)
                {
                    Console.WriteLine("\nPlayer 1's turn, what would u like to do");
                    Console.WriteLine("You currently have {0} HP and {1} Verve", Player1.HP, Player1.Verve);
                    Console.WriteLine("\nChoose your action 1: use sword, 2: strong atk, 3: bow, 4: shield, 5: use item 6: rest");
                    playerAction("player1",player1inv);
                    Console.WriteLine("\nYou have {0} Verve remaining, would you like to buy something?", Player1.Verve);
                    Console.WriteLine("1: Go to Shop, 2: End turn");
                    string goShop = Console.ReadLine();
                    if (goShop == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome to the shop!");
                        List<string> tempinv = new List<string>();
                        tempinv.AddRange(BuyItem("player1", Player1.Verve));
                        Player1.Verve = Int32.Parse(tempinv[1]);
                        player1inv.Add(tempinv[0]);
                    }
                    //Console.WriteLine(empty);
                    Player1.Verve += 5;
                    turnCounter += 1;
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("\nPlayer 2's turn, what would u like to do");
                    Console.WriteLine("You currently have {0} HP and {1} Verve", Player2.HP, Player2.Verve);
                    Console.WriteLine("\nChoose your action 1: use sword, 2: strong atk, 3: bow, 4: shield, 5: use item 6: rest");
                    playerAction("player2", player2inv);
                    Console.WriteLine("\nYou have {0} Verve remaining, would you like to buy something?", Player2.Verve);
                    Console.WriteLine("1: Go to Shop, 2: End turn");
                    Player2.Verve += 5;
                    turnCounter += 1;
                    Console.Clear();
                }
                if (Player1.HP <= 0 || Player2.HP <= 0)
                {
                    isGame = false;
                }
            }
        }

    }
}
