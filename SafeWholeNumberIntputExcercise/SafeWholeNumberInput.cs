﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCS
{
    class TestInputWhole  // stub for InputWhole
    {
        public static void Main() //testing routine
        {
            int n = PromptWhole("Enter a whole niumber: ");
            Console.WriteLine("The number is {0}.", n);
        }

        /// Return true if s contains one or more digits
        /// and nothing else. Otherwise return false.
        static Boolean IsDigits(string s)
        {
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] < '0' || s[i] > '9')
                {
                    return false;
                }
                i++;
            }
            return (s.Length > 0);
        }

        /// Return a whole number.  Catch input
        /// errors, and keep prompting the user until
        /// a legal entry is made, and return
        /// the corresponding int.  Trim extra whitespace.
        static int PromptWhole(string prompt)
        {
            string userInput = UIF.PromptLine(prompt);
            while (!(IsDigits(userInput)))
            {
                Console.WriteLine("Bad Input! Try again.");
                userInput = UIF.PromptLine(prompt);
            }
            return (int.Parse(userInput)); // so stub compiles:  FIX!
        }
    }
}