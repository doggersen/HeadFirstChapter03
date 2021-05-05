using System;

namespace Exercise_BobJoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Name = "Joe", Cash = 50 };
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();

                if (howMuch == "") return;

                if (int.TryParse(howMuch, out int howMuchInt))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        int savedResult = joe.GiveCash(howMuchInt);
                        bob.ReceiveCash(savedResult);

                    }
                    else if (whichGuy == "Bob")
                    {
                        int savedResult = bob.GiveCash(howMuchInt);
                        joe.ReceiveCash(savedResult);

                    }
                    else
                    {
                        Console.WriteLine("please enter Joe or Bob");
                    }


                }
                else
                {
                    Console.WriteLine("please enter an amount (or a blank line to exit)");
                }

            }
        }
    }
}
