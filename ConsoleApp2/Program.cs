using System;
using System.Collections.Generic;

namespace CasinoVegas
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES_______________________________________
            int Money;
            string bet; // Red or black
            int Bet; // $ amount to bet

            Title();
            Console.Write("Good evening, I need to see some ID please. How old are you?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // if underage, terminate the program
            if (age < 18)
            {
                Console.WriteLine("Sorry, only entry for 18 and above. Come back next time");
                Console.ReadKey();
            }

            // If qualified, give the player chips
            else

            {
                Money = 100;
                Console.Write("Perfect, may enter the tournament! \nHow may I address you?: ");
                string name = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Alright, sucker.. I mean, honoured " + name + ".");
                Console.WriteLine();
                Console.WriteLine("--> You receive $100 worth in chips.");
                Console.WriteLine("--> Total chips owned: $100");
                Console.WriteLine();
                Console.ReadKey(true);

                Console.WriteLine("Let's begin! Double or nothing.\n");

                // Begin betting
                while (Money > 0)
                {
                    Console.Write("Black or Red?: ");
                    bet = Console.ReadLine();
                    Console.Write("Bet amount?: ");
                    Bet = Convert.ToInt32(Console.ReadLine());

                    // Check that player's bet is valid (i.e. Not $0, not more than his money)

                    while (Bet == 0 || Bet > Money)
                    {
                        if (Bet == 0)
                        {
                            Console.WriteLine("\nIf you aren't going to bet any money, why are you here... -_-");
                            Console.WriteLine("I'll ask again.");
                        }
                        else
                        {
                            Console.WriteLine("\nYou don't have enough money.");
                            Console.WriteLine("Please try again.");
                        }

                        Console.Write("Bet amount? : ");
                        Bet = Convert.ToInt32(Console.ReadLine());
                    }



                    // Results of bet
                    Console.WriteLine("\n3...2...1");
                    Console.ReadKey(true);

                    Random RNG = new Random();
                    int outcome = RNG.Next(1, 3);
                    if (outcome == 1)
                    {
                        Console.WriteLine("You win!");
                        Money += Bet;
                        Console.WriteLine("\n--> Total chips owned: $" + Money);
                    }
                    else
                    {
                        Console.WriteLine("You lost!");
                        Money -= Bet;
                        Console.WriteLine("\n--> Total chips owned: $" + Money);
                    }
                }

                // End game when player is bankrupt
                if (Money == 0)
                {
                    Console.WriteLine("BANKRUPT. Game over!");
                    Console.ReadKey();
                }
            }
            Console.ReadKey();



        }

        // Title
        static void Title()
        {

            string title = @"

         $$$$$$\                     $$\                     
        $$  __$$\                    \__|                    
        $$ /  \__|$$$$$$\   $$$$$$$\ $$\ $$$$$$$\   $$$$$$\  
        $$ |      \____$$\ $$  _____|$$ |$$  __$$\ $$  __$$\ 
        $$ |      $$$$$$$ |\$$$$$$\  $$ |$$ |  $$ |$$ /  $$ |
        $$ |  $$\$$  __$$ | \____$$\ $$ |$$ |  $$ |$$ |  $$ |
        \$$$$$$  \$$$$$$$ |$$$$$$$  |$$ |$$ |  $$ |\$$$$$$  |
         \______/ \_______|\_______/ \__|\__|  \__| \______/ 
                                                                           
          $$\    $$\                                         
          $$ |   $$ |                                        
          $$ |   $$ | $$$$$$\   $$$$$$\   $$$$$$\   $$$$$$$\ 
          \$$\  $$  |$$  __$$\ $$  __$$\  \____$$\ $$  _____|
           \$$\$$  / $$$$$$$$ |$$ /  $$ | $$$$$$$ |\$$$$$$\  
            \$$$  /  $$   ____|$$ |  $$ |$$  __$$ | \____$$\ 
             \$  /   \$$$$$$$\ \$$$$$$$ |\$$$$$$$ |$$$$$$$  |
              \_/     \_______| \____$$ | \_______|\_______/ 
                       $$\   $$ |                    
                       \$$$$$$  |                    
                        \______/                     

";
            Console.WriteLine(title);
        }
    }
}
