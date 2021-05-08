using System;

namespace Exercise_BettingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0;
            double difficultyMultiplier = 0;
            Player player = new Player() { Name = "The Player", Cash = 100 };

            Console.WriteLine("chose difficulty, 1-3");
            ChooseDifficulty(Convert.ToInt32(Console.ReadLine()));
            void ChooseDifficulty(int difficulty)
            {
                switch (difficulty)
                {
                    case 1:
                    odds = 0.25;
                    difficultyMultiplier = 1.25;
                        break;
                    case 2:
                        odds = 0.50;
                        difficultyMultiplier = 2;
                        break;
                    case 3:
                        odds = 0.80;
                        difficultyMultiplier = 10;
                        break;
                    default:
                        Console.WriteLine("u need to type a number betweeen 1 and 3");
                        break;

                }
                Console.WriteLine($"you chose difficulty {difficulty}, so the odds are: {odds} and you get your money back {difficultyMultiplier} times when you win");
            }

            Console.WriteLine("welcome player, to the betting game! the odds are 0.75");
            Console.WriteLine("How many players?");
            int amountOfPlayers = Convert.ToInt32(Console.ReadLine());
            var players = new Player[amountOfPlayers];
            for (int i = 0; i < amountOfPlayers; i++)
            {
                players[i] = new Player();

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
                        int pot = Convert.ToInt32(amount * difficultyMultiplier);

                        double randomNumber = random.NextDouble();
                        if (randomNumber > odds)
                        {
                            players[i].ReceiveCash(pot);
                        }
                        else
                        {
                            players[i].GiveCash(amount);
                        }

                        if (players[i].Cash <= 0)
                        {
                            Console.WriteLine($"{players[i].Name} you are out of money! and you have lost the game!");
                            Console.WriteLine("final status over the remaining players");
                            for (i = 0; i < amountOfPlayers; i++)
                            {
                                if (players[i].Cash is not 0)
                                {
                                    Console.WriteLine($"{players[i].Name} ended up with {players[i].Cash } bucks");
                                }
                            }
                            Console.WriteLine("press a button to exit the program!");
                            Environment.Exit(0);

                        }

                    }
                }
            }

        }
    }
}
