using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class CardPicker
    {

        //object "random" created. we can now use "random" to create random numbers
        static Random random = new Random();

        //method with a return type "string[]", meaning it needs a string returned. Since its an array, it can have many returned.
        //numberOfCards is the number that the user inputs
        public static string[] PickSomeCards(int numberOfCards)
        {
            //making an array. the nu
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            //if we haven't returned yet, return the string Diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            //gets a random number between 1 and 13
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            //if we haven't returned yet(none of the above numbers matched), it will return the random number value.
            //it's converted to string, because the return type of the method is string. so it expects to have a string returned.
            return value.ToString();
        }
    }
}
