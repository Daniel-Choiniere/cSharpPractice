using System;


    public class Card {
        int val;
        int suit;


        public Card(int val, int suit)
        {
            this.val = val;
            this.suit = suit;
        }
    public static void Main()
        {
            Card firstCard = new Card(10, 4);
            Console.WriteLine(firstCard.val + firstCard.suit);
        }

    }
