using System;
namespace gradecalc
{
  class MainClass
  {
    static void Main()
      {
        Console.WriteLine ("This Calculator will help you determine a grade in a given class. Remember to have the weights add to 100%");


        string ErrorMsg = ("Oops, looks like something went wrong. Program will now end.");

        int ExamsWeight, LabsWeight, HomeworkWeight, ProjectWeight, ParticipationWeight;
        string ExamsWeightString, LabsWeightString, HomeworkWeightString, ProjectWeightString, ParticipationWeightString;

        Console.WriteLine ("Enter Exams Weight: ");
        ExamsWeightString = Console.ReadLine();
        ExamsWeight = int.Parse(ExamsWeightString);
        Console.WriteLine ("Enter Labs Weight: ");
        LabsWeightString = Console.ReadLine();
        LabsWeight = int.Parse(LabsWeightString);
        Console.WriteLine ("Enter Homework Weight: ");
        HomeworkWeightString = Console.ReadLine();
        HomeworkWeight = int.Parse(HomeworkWeightString);
        Console.WriteLine ("Enter Projects Weight: ");
        ProjectWeightString = Console.ReadLine();
        ProjectWeight = int.Parse(ProjectWeightString);
        Console.WriteLine ("Enter Participation Weight: ");
        ParticipationWeightString = Console.ReadLine();
        ParticipationWeight = int.Parse(ParticipationWeightString);

        double sum = ParticipationWeight + ProjectWeight + HomeworkWeight + LabsWeight + ExamsWeight;

        if (ParticipationWeight + ProjectWeight + HomeworkWeight + LabsWeight + ExamsWeight == 100) {
          Console.WriteLine ("Congratulations! Weights add to 100% ");
        }

        else  {
          Console.WriteLine ("Grades add to " + sum + " not 100% \n");
          Console.WriteLine (ErrorMsg);
          return;
        }
        double ExamsGrade, LabsGrade, HomeworkGrade, ProjectGrade, ParticipationGrade;
        string ExamsGradeString, LabsGradeString, HomeworkGradeString, ProjectGradeString, ParticipationGradeString;

        Console.WriteLine ( "Enter Exams Grade: ");
        ExamsGradeString = Console.ReadLine();
        ExamsGrade = double.Parse(ExamsGradeString);
        Console.WriteLine ( "Enter Labs Grade: ");
        LabsGradeString = Console.ReadLine();
        LabsGrade = double.Parse(LabsGradeString);
        Console.WriteLine ( "Enter Homework Grade: ");
        HomeworkGradeString = Console.ReadLine();
        HomeworkGrade = double.Parse(HomeworkGradeString);
        Console.WriteLine ( "Enter Projects Grade: ");
        ProjectGradeString = Console.ReadLine();
        ProjectGrade = double.Parse(ProjectGradeString);
        Console.WriteLine ( "Enter Participation Grade: ");
        ParticipationGradeString = Console.ReadLine();
        ParticipationGrade = double.Parse(ParticipationGradeString);
          //whats going on here?
          + ParticipationWeight * ParticipationGrade) / 100.00);

        string GradeLetter = "Undefined";

        if (grade == 100) {
          GradeLetter = "an A+ ";
        }
        else if (grade >= 93) {
          GradeLetter = "an A ";
        }
        else if (grade >= 90) {
          GradeLetter = "an A- ";
        }
        else if (grade >= 87) {
          GradeLetter = ("a B+ ");
        }
        else if (grade >= 83) {
          GradeLetter = ("a B ");
        }
        else if (grade >= 80) {
          GradeLetter = ("a B- ");
        }
        else if (grade >= 77) {
          GradeLetter = ("a C+ ");
        }
        else if (grade >= 73) {
          GradeLetter = ("a C ");
        }
        else if (grade >= 70) {
          GradeLetter = ("a C- ");
        }
        else if (grade >= 67) {
          GradeLetter = ("a D+ ");
        }
        else if (grade >= 63) {
          GradeLetter = ("a D ");
        }
        else if (grade >= 60) {
          GradeLetter = ("a D- ");
        }
        else if (grade < 60 && grade >= 0) {
          GradeLetter = ("so low that you are unlikely to pass ");
        }
        else{
          Console.WriteLine("Looks Like your final grade is not within 0 to 100% \n");
          Console.WriteLine(ErrorMsg);
        }
        Console.WriteLine ("Your grade is " + GradeLetter);
      }
  }
}
