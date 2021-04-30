using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] results;

            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();

            if(int.TryParse(line, out int numberOfCards))
            {
                CardPicker.PickSomeCards(numberOfCards);

                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {

                }

            }
            else
            {
                Console.WriteLine("You must type a number!");
            }
        }
    }
}
