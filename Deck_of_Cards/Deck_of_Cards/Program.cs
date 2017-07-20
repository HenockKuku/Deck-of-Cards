using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
  public class MainProgram
  {
    public static void Main(string[] args)
    {
      Deck deck1 = new Deck();
      deck1.Shuffle();
      for (int i=0; i<52;i++)
      {
        Console.Write("{0,-19}", deck1.dealOneCard());
        if ((i + 1) % 4 == 0)
          Console.WriteLine();
      }
      Console.ReadLine();
    }
  }
}
