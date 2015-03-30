using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester
{
  class Class1
  {
    //public static void Main(){
    //   List<string> a = new List<string> ();
    //   a.Add ("pick up");
    //   Item rope = new Item("rope",a,"hall");
    //   Console.WriteLine (rope.getName ());
    //   Console.WriteLine (rope.getLocation ());
    //   foreach (string f in rope.getActions()) {
    //      Console.WriteLine (f);
    //   }
    //   rope.setName ("new name");
    //   Console.WriteLine (rope.getName ());

    //}
    public class Item
    {
      private string name;
      private List<string> actions;
      private string location;
      public Item(string Name, List<string> Actions, string Location)
      {
        name = Name;
        actions = Actions;
        location = Location;
      }
      public string getName()
      {
        return name;
      }
      public List<string> getActions()
      {
        return actions;
      }
      public string getLocation()
      {
        return location;
      }
      public void setName(string name)
      {
        this.name = name;
      }
      public void setActions(List<string> actions)
      {
        this.actions = actions;
      }
      public void setLocation(string location)
      {
        this.location = location;
      }
      public void Print()
      {
        Console.Write(this.ToString());
        ListToString(this.actions);
      }
      public override string ToString()
      {
        return string.Format("Item Name: {0}\nLocation: {1}\nProperties: ", 
                              name, location);
      }
      private void ListToString(List<string> list)
      {
        foreach (string a in list)
        {
          Console.Write(a + ". ");
        }
        Console.WriteLine();
      }
    }
  }
}