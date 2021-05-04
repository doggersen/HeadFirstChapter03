using System;

namespace PickACardUI
{
    //summary:
    //the methods u call in this class "PickSomeCards" returns an array of random cards, and the amount is based on "numberOfCards" that the user put in as an argument to the method.
    class CardPicker
    {

        //object "random" created. we can now use "random" to create random numbers
        
        /// <summary>
        /// this is an XML-comment. in this case its just a field called random, that is of type Random
        /// </summary>
        static Random random = new Random();

        //method with a return type "string[]", meaning it needs a string returned. Since its an array, it can have many returned.
        //numberOfCards is the number that the user inputs
        //the below xml-comments makes a much better and more "official" explanation of what the method does
       
        /// <summary>
        /// Picks a number of cards and returns them
        /// </summary>
        /// <param name="numberOfCards">The number of cards to pick</param>
        /// <returns>An array of strings that contains the card names</returns>
        public static string[] PickSomeCards(int numberOfCards)
        {
            //declaring af single-dimensional array. the numberOfCards defines the length of the array (how many array elements does it consist of)
            string[] pickedCards = new string[numberOfCards];
            //loop that gives string values to all the elements of the array
            for (int i = 0; i < numberOfCards; i++)
            {//"pickedCards[i]" gets 
                pickedCards[i] = RandomValue() + " of " + RandomSuit(); //the string consist mainly of the random results from other two methods
            }
            //returns the array "pickedCards" "filled up" with string elements.
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
