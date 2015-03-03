using System;
// test no change1
namespace IntroCS
{
  class MainClass
  {
    public static void Main (string[] args)
    {
      Console.WriteLine("This Calculator will help you determine a grade in a "
       + "given class.\n");
      double finalGradeRaw = GiveFinalGrade(getWeights(), getAverages());
      FinalMessage(GradeAssignment(finalGradeRaw), finalGradeRaw);
    }

    //outputs final user prompt, grade as a letter and as a number
    public static void FinalMessage(string LetterGrade, double n)
    {
      Console.WriteLine("Your grade is {0:F2} " + LetterGrade, n);
    }

    //prompts user for weights, tests if adds to 100, loops back if test fails
    public static double[] getWeights()
    {
      Console.WriteLine("Begin by entering individual category weights, they " +
       "must add to 100%\n");
      double weightSum = 0;
      double[] weightValue = new double[5];
      do{
        weightValue[0] = FindWeight("exam");
        weightValue[1] = FindWeight("project");
        weightValue[2] = FindWeight("lab");
        weightValue[3] = FindWeight("homework");
        weightValue[4] = FindWeight("participation point");
        weightSum = (weightValue[0] + weightValue[1] + weightValue[2] +
         weightValue[3] + weightValue[4]);
        if (weightSum == 100) {
          Console.WriteLine ("Congratulations! Weights add to 100%\n");
        } else{
            Console.WriteLine("Sorry weights did not add to 100%, please try " +
             "again.\n");
          }
      }while(weightSum != 100);
      return weightValue;
    }

    //prompts user for weights of each category
    public static double FindWeight(string weightPrompt)
    {
      double weight = UI.PromptDouble("Please enter the weight of " +
       weightPrompt + "(s): ");
      return weight;
    }

    //gets and assigns average grades of each category
    public static double[] getAverages()
    {
      double[] averageValue = new double [5];
      averageValue[0] = FindAverage("exam");
      averageValue[1] = FindAverage("project");
      averageValue[2] = FindAverage("lab");
      averageValue[3] = FindAverage("homework assignment");
      averageValue[4] = FindAverage ("participation point");
      return averageValue;
    }

    //prompts for grade and averages the scores for passed in categories
    public static double FindAverage(string gradePrompt)
    {
      double numberOfGrades = UI.PromptDouble("Please enter the number of " +
       gradePrompt +  "(s) to grade: ");
      double i = 1;
      double totalScore = 0;
      while (i <= numberOfGrades){
        double score = UI.PromptDouble("Please enter the grade of the " +
         "assignment " + i + ": ");
        i++;
        totalScore += score;
      };
       return totalScore / numberOfGrades;
    }

    //computes final overall grade
      public static double GiveFinalGrade(double[] x, double[] y)
    {
      double[] multipliedVariables = new double[5];
      double finalGrade;
      for (int i = 0; i < 4; i++)
      {
            multipliedVariables[i] = x[i] * y[i];
      }
      finalGrade = (multipliedVariables[0] + multipliedVariables[1] +
       multipliedVariables[2] + multipliedVariables[3] + multipliedVariables[4])
       /100;
      return finalGrade;
    }

    //calcs and assigns grade
    public static string GradeAssignment(double grade)
    {
      if (grade == 100){
        return ", an A+ ";
      }
      else if (grade >= 93) {
        return ", an A ";
      }
      else if (grade >= 90) {
        return ", an A- ";
      }
      else if (grade >= 87) {
        return ", a B+ ";
      }
      else if (grade >= 83) {
        return ", a B ";
      }
      else if (grade >= 80) {
        return ", a B- ";
      }
      else if (grade >= 77) {
        return ", a C+ ";
      }
      else if (grade >= 73) {
        return ", a C ";
      }
      else if (grade >= 70) {
        return ", a C- ";
      }
      else if (grade >= 67) {
        return ", a D+ ";
      }
      else if (grade >= 63) {
        return ", a D ";
      }
      else if (grade >= 60) {
        return ", a D- ";
      }
      else {
        return ". It is so low that you are unlikely to pass ";
      }
    }
  }
}
