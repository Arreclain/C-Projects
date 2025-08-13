namespace TwentyOne;

public class Card
{
      //The name of a constructor (method) is always the same as the class.
      //This helps the IDE know what you're doing.
      public Card()
      {
            Suit = "Spades";
            Face = "Two";
      }
      public string Suit { get; set; }
      public string Face { get; set; }
}