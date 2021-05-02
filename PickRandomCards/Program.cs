using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            //assigns the user input to a string variable
            string line = Console.ReadLine();
            //if user input can be converted int then do the following..
            if (int.TryParse(line, out int numberOfCards))
            {
                                                                                    //My own solution (the solution from the book was simpler):
                                                                                    //string[] results = CardPicker.PickSomeCards(numberOfCards);
                                                                                    //int count = 0;
                //calling the PickSomeCards method, and inputting the user input
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);

                                                                                    //Console.WriteLine(results[count]);
                                                                                    //count++;
                }
            }
            else
            {
                Console.WriteLine("You must type a number!");
            }
        }
    }
}
