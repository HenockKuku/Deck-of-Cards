using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
  public class Card
  {
    private String face;
    private String suit;
    public Card (string cardFace, string cardSuit)
    {
      face = cardFace;
      suit = cardSuit;
    }
    public override string ToString()
    {
      return face + " of " + suit ;
    }
  }
}
