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
    public List<string> gut { get; private set; }
    public int gutContents { get; private set; }
    public Animal(string Name)
    {
      this.name = Name;
      this.gut = new List<string>();
      this.gutContents = gutContents;
    }
    public void Greet()
    {
      Console.WriteLine("Hello, my name is {0}", name);
    }
    public void Eat(string food)
    {
      gut.Add(food);
      this.gutContents++;
    }
    public void Excrete()
    {
      if (gut.Count == 0)
      {
        Console.WriteLine("");
      }
      else
      {
        Console.WriteLine(gut.First());
        gut.Remove(gut.First());
        this.gutContents--;
      }
    }
    public override string ToString()
    {
      if (gut.Count == 0)
      {
        return ("Animal: " + name + " ate nothing");
      }

      StringBuilder gutStr = new StringBuilder("Animal: ");
      foreach (string s in gut)
      {
        if (s == gut.Last())
        {
          gutStr = gutStr.AppendFormat("and {0}", s);
        }
        else
        {
          gutStr = gutStr.AppendFormat("{0}, ", s);
        }
      }
      return gutStr.ToString();
    }
  }
}
