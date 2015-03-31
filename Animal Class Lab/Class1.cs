using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
  class Animal
  {
    private string name;
    private List<string> gut;
    public Animal(string Name)
    {
      this.name = Name;
      this.gut = null;
    }
  }
}
