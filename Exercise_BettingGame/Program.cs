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
            Console.WriteLine("How many players?");
            int amountOfPlayers = Convert.ToInt32(Console.ReadLine());
            var players = new Guy[amountOfPlayers];
            for (int i = 0; i < amountOfPlayers; i++)
            {
                players[i] = new Guy();

                Console.WriteLine($"what is the name of player {i} ?");
                string nameOfPlayer = Console.ReadLine();
                players[i].Name = nameOfPlayer;

            }

            Console.WriteLine("here is a list of the players:");
            for (int i = 0; i < amountOfPlayers; i++)
            {
                Console.WriteLine(players[i].Name);
            }




            while (true)
            {
                for (int i = 0; i < amountOfPlayers; i++)
                {

                    Console.WriteLine($"{players[i].Name} it is your turn! you have {players[i].Cash} bucks");
                    Console.WriteLine("How much money do you want to bet?");
                    string howMuch = Console.ReadLine();

                    if (int.TryParse(howMuch, out int amount))
                    {
                        int pot = amount * 2;

                        double randomNumber = random.NextDouble();
                        if (randomNumber > odds)
                        {
                            players[i].ReceiveCash(amount);
                        }
                        else
                        {
                            players[i].GiveCash(amount);
                        }

                    }
                }
            }

        }
    }
}
