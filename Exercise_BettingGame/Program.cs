using System;

namespace Exercise_BettingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Name = "The Player", Cash = 100 };

            Console.WriteLine("welcome player, to the betting game! the odds are 0.75");

            while (true)
            {
                Console.WriteLine("The Player has: " + player.Cash + " bucks");
                Console.WriteLine("How much money do you want to bet?");
                string howMuch = Console.ReadLine();

                if(int.TryParse(howMuch, out int amount))
                {                    
                    int pot = amount *2 ;

                    double randomNumber = random.NextDouble();
                    if (randomNumber > odds)
                    {
                        player.ReceiveCash(amount);
                    }
                    else
                    {
                        player.GiveCash(amount);
                    }

                }

            }

        }
    }
}
