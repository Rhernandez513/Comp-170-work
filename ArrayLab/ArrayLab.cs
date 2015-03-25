using System;

namespace IntroCS
{
  public class ArrayLab
  {
    // Link to lab, http://introcs.cs.luc.edu/html/lab-array1d.html?highlight=printnums
    public static void Main()
    { /// Include test:. Display test input and output
      /// with liberal use of PrintInts,
      /// showing labeled inputs and outputs.
      int[] a = new int[] { 1, 2, 1, 3 };
      int[] b = new int[] { 5, 6, 7, 8 };
      int[] c = new int[] { 9, 10, 11, 12 };
      int[] d = new int[] { 2, 5, 8, 3, 9, 9, 8 };
      string prompt = "prompt";
      string label = "label";
      PrintInts(label, a);
      ReadInts(prompt, 3);
      Minimum(a);
      CountEven(a);
      PairwiseAdd(a, b, c);
      NewPairwiseAdd(a, b);
      IsAscending(a);
      Console.WriteLine("PrintRuns Test: ");
      PrintRuns(d);
    }
    //PrintInts chunk
    /// Print label and then each element preceeded by a space,
    ///  all across one line.  Example:
    ///  If a contains {3, -1, 5} and label is "Nums:",
    ///  print:   Nums: 3 -1 5
    static void PrintInts(string label, int[] a)
    {
      Console.Write(label);
      for (int i = 0; i < a.Length; i++)
      {
        Console.Write(" " + a[i]);
      }
      Console.WriteLine();
    }
    //ReadInts chunk
    ///  Prompt the user to enter n integers, and
    ///  return an array containing them.
    ///  Example:  ReadInts("Enter values", 3) could generate the
    ///  Console sequence:
    ///      Enter values (3)
    ///      1: 5
    ///      2: 7
    ///      3: -1
    ///  and the function would return an array containing {5, 7, -1}.
    ///  Note the format of the prompts for individual elements.
    static int[] ReadInts(string prompt, int n)
    {
      int[] a = new int[n];
      Console.WriteLine(prompt + " (" + n + ")");
      for (int i = 0; i < n; i++)
      {
        a[i] = UI.PromptInt("" + (i + 1) + ": ");
      }
      PrintInts("ReadInts test: ", a);
      return a;
    }
    //Minimum chunk
    ///  Return the minimum value in a.
    ///  Example: If a contains {5, 7, 4, 9}, return 4.
    ///  Assume a contains at least one value.
    static int Minimum(int[] a)
    {
      int min = a[0], i = 0;
      while (i < a.Length)
      {
        if (a[i] < min)
        {
          min = a[i];
        }
        i++;
      }
      Console.WriteLine("Minimum test: " + min);
      return min;
    }
    //CountEven chunk
    ///  Return the number of even values in a.
    ///  Example: If a contains {-4, 7, 6, 12, 9}, return 3.
    static int CountEven(int[] a)
    {
      int i = 0;
      foreach (int k in a)
      {
        if (k % 2 == 0)
        {
          i++;
        }
      }
      Console.WriteLine("CountEven test: " + i);
      return i;
    }
    //PairwiseAdd chunk
    ///  Add corresponding elements of a and b and place them in sum.
    ///  Assume all arrays have the same Length.
    ///  Example: If a contains {2, 4, 6} and b contains {7, -1, 8}
    ///  then at the end sum should contain {9, 3, 14}.
    static void PairwiseAdd(int[] a, int[] b, int[] sum)
    {
      for (int i = 0; i < a.Length && i < b.Length; i++)
      {
        sum[i] = a[i] + b[i];
      }
      PrintInts("PairwisAdd test", sum);
    }
    //NewPairwiseAdd chunk
    ///  Return a new array whose elements are the sums of the
    ///  corresponding elements of a and b.
    ///  Assume a and b have the same Length.
    ///  Example: If a contains {2, 4, 6} and b contains {3, -1, 5}
    ///  then return an array containing {5, 3, 11}.
    static int[] NewPairwiseAdd(int[] a, int[] b)
    {
      if (a.Length != b.Length)
      {
        Console.WriteLine("Arrays are not matching sizes.");
        return null;
      }
      else
      {
        int[] sum = new int[a.Length];
        for (int i = 0; i < a.Length && i < b.Length; i++)
        {
          sum[i] = a[i] + b[i];
        }
        PrintInts("NewPairwisAdd test", sum);
        return sum;
      }
    }
    //IsAscending chunk
    ///  Return true if the numbers are sorted in increasing order,
    ///  so that in each pair of consecutive entries,
    ///  the second is always at least as large as the first.
    ///  Return false otherwise.  Assume an array with fewer than
    ///  two elements is ascending.
    ///  Examples: If a contains {2, 5, 5, 8}, return true;
    ///  if a contains {2, 5, 3, 8}, return false.
    static bool IsAscending(int[] a)
    {
      if (a.Length > 1)
      { // Checks each pair, avoid out of range exception
        for (int i = 0; i < (a.Length - 1); i++)
        {
          if (a[i] < a[i + 1])
          {
            continue;
          }
          else
          {
            return false;
          }
        }
        // Check finishes, return true
        PrintInts("IsAscending test passed. Array tested: ", a);
        return true;
      }
      else
      {
        Console.WriteLine("Nothing to compare.");
        return false;
      }
    }
    //PrintAscendingValues chunk
    ///  Print an ascending sequence from the elements
    ///  of a, starting with the first element and printing
    ///  the next number after the previous number
    ///  that is at least as large as the previous one printed.
    ///  Example: If a contains {5, 2, 8, 4, 8, 11, 6, 7, 10},
    ///  print:  5 8 8 11
    static void PrintAscendingValues(int[] a)
    {
      int arrayVal = int.MinValue, count = 0;
      for (int i = 0; i < a.Length; i++)
      { // Counts each value greater than the last
        if (a[i] >= arrayVal)
        {
          arrayVal = a[i];
          count++;
        }
      }
      int[] ascendingArray = new int[count];
      int y = int.MinValue;
      for (int z = 0; z < count; z++)
      {
        if (y <= a[z])
        {
          y = a[z];
          ascendingArray[z] = a[z];
        }
      }
      PrintInts("PrintAscendingValues test: ", ascendingArray);
    }
    /// <summary>
    /// Prints each ascending run in a, one run per line.
    /// Example: If a contains {2, 5, 8, 3, 9, 9, 8}, print
    /// 2 5 8
    /// 3 9 9
    /// 8
    /// </summary>
    /// <param name="a">Array to check</param>
    static void PrintRuns(int[] a)
    {
      for (int k = 1, runStart = 0, runEnd = 0; runStart <= a.Length; k++)
      {
        int innerCount = 1;
        if (runStart == (a.Length))
        {
          Console.WriteLine("Run #" + k + " " + a[a.Length - 1]);
          return;
        }
        for (int i = runStart + 1; i < a.Length; i++)
        {
            if (a[i - 1] <= a[i])
            {
              innerCount++;
            }
            else
            {
              runEnd = innerCount + runStart;
              break;
            }
        }
        int currentRunStart = runStart;
        PrintInts("Run#" + k, (ReturnInts(a, currentRunStart, runEnd)));
        runStart = runEnd + 1;
      }
    }
    /// <summary>
    /// Returns an array of ints from specified indices
    /// </summary>
    /// <param name="a">Parent array to check</param>
    /// <param name="start">First index to check</param>
    /// <param name="end">Last index to check</param>
    /// <returns></returns>
    static int[] ReturnInts(int[] a, int start, int end)
    {
      int length;
      if (start == 0)
      {
        length = end - start;
      }
      // I know this looks weird, it works
      // length is used to assgin a length value
      // end and start are indicies
      // 
      else
      {
        length = (end - start) + 1;
        start--;
      }
      int[] newAscendingArray = new int[length];
      for (int i = start, x = 0; i < end; i++, x++)
      {
        newAscendingArray[x] = a[i];
      }
      return newAscendingArray;
    }
  }
}
