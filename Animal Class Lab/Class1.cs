using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  /// <summary>
  /// An Animal can eat and excrete food
  /// </summary>
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
    /// <summary>
    /// Animal says hi
    /// </summary>
    public void Greet()
    {
      Console.WriteLine("Hello, my name is {0}", name);
    }
    /// <summary>
    /// Adds food to gut
    /// </summary>
    /// <param name="food">food Animal eats as string</param>
    public void Eat(string food)
    {
      Console.WriteLine("{0} is eating {1}", name, food);
      gut.Add(food);
      this.gutContents++;
    }
    /// <summary>
    /// Removes contents of gut in order they were put in
    /// </summary>
    public void Excrete()
    {
      if (gut.Count == 0)
      {
        Console.WriteLine("");
      }
      else
      {
        Console.WriteLine(name + " excreted " + gut.First());
        gut.Remove(gut.First());
        this.gutContents--;
      }
    }
    /// <summary>
    /// Checks what the Animal has in its gut
    /// </summary>
    /// <returns>String saying what is currently in the Animal's gut</returns>
    public override string ToString()
    {
      if (gut.Count == 0)
      {
        return ("Animal: " + name + " has nothing in his gut.");
      }
      else if (gut.Count == 1)
      {
        return ("Animal: " + name + " ate " + gut.First());
      }
      StringBuilder gutStr = new StringBuilder();
      gutStr = gutStr.AppendFormat("Animal: {0} ate ", name);
      for (int i = 0; i < gutContents; i++ )
      {
        if (gut[i] == gut.Last())
        {
          gutStr = gutStr.AppendFormat("and {0}", gut[i]);
        }
        else
        {
          gutStr = gutStr.AppendFormat("{0}, ", gut[i]);
        }
      }
      return gutStr.ToString();
    }
  }
}
