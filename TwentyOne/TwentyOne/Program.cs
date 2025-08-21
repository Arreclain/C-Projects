using System;

namespace TwentyOne
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int timesShuffled = 0;
            Deck deck = new Deck();
            deck = Shuffle(deck, out timesShuffled, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled,int times = 1)
        { //When you give a parameter a default value, you make it an optional parameter.
            //out int timesShuffled spits out this variable
            //assignment via a separate channel than the return.
            //out parameters need to be added before any optional ones.
            //The method fills these out, not the programmer.
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);

                }
                timesShuffled++;
                deck.Cards = TempList; 
            }
            Console.WriteLine("TimesShuffled: {0}", timesShuffled);
            return deck;
        }

        // public static Deck Shuffle(Deck deck, int times)
        // {
        //     for (int i = 0; i < times; i++)
        //     {
        //         deck = Shuffle(deck);
        //     }
        //     return deck;
        // }
    }
}

