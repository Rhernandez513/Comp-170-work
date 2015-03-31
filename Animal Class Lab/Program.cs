using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class TestAnimal
  {
    /// Thoroughly test all Animal methods, with all the actions 
    /// Clearly labeled for a person *not* reading the code.
    /// Start by creating a new Animal...

    static void Main(string[] args)
    {
      Animal Froggy = new Animal("Froggy");
      Animal DonkeyKong = new Animal("Donkey Kong");

      Froggy.Greet();
      Froggy.Eat("fly");
      Froggy.Eat("worm");
      Console.WriteLine(Froggy);
      Froggy.Excrete();
      Froggy.Excrete();
      Froggy.Excrete();
      Console.WriteLine(Froggy);
      Console.WriteLine(DonkeyKong);
    }
  }
}
