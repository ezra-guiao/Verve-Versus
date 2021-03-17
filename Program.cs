using System;

namespace Versus_Verve
{
    public class mainclass
    {
        class player
        {
            public int HP;
            public int Verve; 

        }

        class item
        {
            public string name;
            public int cost;
            public string description;

            public item(string itemname, int itemcost, string itemdesc)
            {
                name = itemname;
                cost = itemcost;
                description = itemdesc;
            }

            item Basic_Health_Pot = new item("Basic Health Pot", 10, "heals 30HP");
            item Guardian = new item("Guardian", 10, "you can only take a maximum of 10dmg per turn for 3 turns");
            item Regenerative_Health_Pot = new item("Regenerative Health Pot", 15, "heal 10 HP per turn for 5 turns");
            item Illusive_Pot = new item("Illusive Pot", 15,"33% dodge rate for 5 turns");
            item Windmill = new item("Windmill ", 15, "produces additional 3 verve per turn");
            item Enhanced_Hexbow = new item("Enhanced Hexbow ", 20, "gives the weapon 33% crit chance, reduce the drawback damage");
            item Taxation = new item("Taxation", 20, "steal half of the enemy’s verve");
            item Powerplant = new item("Powerplant  ", 25, "produces additional 5 verve per turn");
            item Reactor = new item("Reactor  ", 35, "produces additional 10 verve per turn, 20% chance per turn to destroy itself,dealing 25 dmg to both players");
            item Enhanced_Hexlyene_Caliver = new item("Enhanced Hexlyene Caliver ", 50, "gives the weapon a 20% chance of damaging the opponent for all his HP, can’t be dodged or shielded");

            public static void buyItem(string player, int verve)
            {
                if (player == "player1")
                {
                    Console.WriteLine("You have {0} verve, what would you like to buy?", verve);
                    string actionBuy = Console.ReadLine();

                    for (int i = 0; i < item.name; i++)
                    {
                        Console.WriteLine();
                    }
                    if (actionBuy == "1")
                    {

                    }
                    
                }
                else
                {

                }
            }
            static void checkInventory (string player)
            {

            }
            static void useItem (string player)
            {

            }

        }

        static void Main(string[] args)
        {

            //declaring variables
            bool isGame = true;
            int turnCounter = 0;
            player Player1 = new player();
            Player1.HP = 100;
            Player1.Verve = 0;
            player Player2 = new player();
            Player2.HP = 100;
            Player2.Verve = 0;

            static void playerAction(string player)
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
                    Console.WriteLine("\nChoose your action 1: use sword, 2: strong atk, 3: bow, 4: shield, 5: rest");
                    if (player == "player1")
                    {
                        playerAction("player1");
                    }
                    else
                    {
                        playerAction("player2");
                    }
                }
            }

            static  void verveShop(string player, int verve)
            {
                string goShop = Console.ReadLine();
                if (goShop == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the shop!");
                    item.buyItem(player, verve);
                }
                else
                {
                    return;
                }
            }

            //main game loop
            while (isGame)
            {

                if (turnCounter % 2 == 0)
                {
                    Console.WriteLine("\nPlayer 1's turn, what would u like to do");
                    Console.WriteLine("You currently have {0} HP and {1} Verve", Player1.HP, Player1.Verve);
                    Console.WriteLine("\nChoose your action 1: use sword, 2: strong atk, 3: bow, 4: shield, 5: rest");
                    playerAction("player1");
                    Console.WriteLine("\nYou have {0} Verve remaining, would you like to buy something?", Player1.Verve);
                    Console.WriteLine("1: Go to Shop, 2: End turn");
                    verveShop("player1", Player1.Verve);
                    Player1.Verve += 5;
                    turnCounter += 1;
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("\nPlayer 2's turn, what would u like to do");
                    Console.WriteLine("You currently have {0} HP and {1} Verve", Player2.HP, Player2.Verve);
                    Console.WriteLine("\nChoose your action 1: use sword, 2: strong atk, 3: bow, 4: shield, 5: rest");
                    playerAction("player2");
                    Console.WriteLine("\nYou have {0} Verve remaining, would you like to buy something?", Player2.Verve);
                    Console.WriteLine("1: Go to Shop, 2: End turn");
                    verveShop("player2", Player2.Verve);
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
