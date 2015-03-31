using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class Animal
  {
    public string name { get; set; }
    public List<string> gut { get; set; }
    public Animal(string Name)
    {
      this.name = Name;
      this.gut = new List<string>(new[]{"empty"});
    }
    public void Greet()
    {
      Console.WriteLine("Hello, my name is {0}", name);
    }
    public void Eat(string food)
    {
      gut.Add(food);
    }
    public void Excrete()
    {
      if (gut == null)
      {
        Console.WriteLine("");
      }
      else
      {
        Console.WriteLine(gut.First());
        gut.Remove(gut.First());
      }
    }
    public override string ToString()
    {
      return string.Format("Animal: {0}", name);
    }
  }
}
