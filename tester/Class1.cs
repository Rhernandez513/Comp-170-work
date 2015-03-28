using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester
{
   class GuessGameTest
   {
      public static void Main(){
         List<string> a = new List<string> ();
         a.Add ("pick up");
         Item rope = new Item("rope",a,"hall");
         Console.WriteLine (rope.getName ());
         Console.WriteLine (rope.getLocation ());
         foreach (string f in rope.getActions()) {
            Console.WriteLine (f);
         }
         rope.setName ("new name");
         Console.WriteLine (rope.getName ());
        
      }
      public class Item{
         private string name;
         private List<string> actions;
         private string location;
         public Item(string Name, List<string> Actions,string Location){
            name=Name;
            actions=Actions;
            location=Location;
         }
         public string getName (){
            return name;
         }
         public List<string> getActions(){
            return actions;
         }
         public string getLocation(){
            return location;
         }
         public void setName (string name){
            this.name = name;
         }

      }

   }
}