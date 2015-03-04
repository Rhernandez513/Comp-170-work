using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
    class TestAgree
    {

        public static void Main() //testing routine
        {
            Console.WriteLine(Agree("Do you understand? "));
        }

        /// Prompt the user with a question; Return true of false.
        /// Allow certain starting characters for true (t, y) and
        /// others for false (f, n), and repeat until the response
        /// is in one of these groups.
        static Boolean Agree(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            while (!(answer.StartsWith("y") || answer.StartsWith("n") ||
                     answer.StartsWith("Y") || answer.StartsWith("N")))
            {
                Console.WriteLine("Bad Input! " + question);
                answer = Console.ReadLine();
            }
            return true;  // so stub compiles
        }
    }
}
