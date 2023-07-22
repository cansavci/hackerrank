using System.Collections.Generic;
using System.IO;
using System;
class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        var returnList = new List<int>();
        foreach (int grade in grades)
        {
            int nextGrade = returnNextNumOfMultipleOfFive(grade);
            if (grade < 38)
            {
                returnList.Add(grade);
            }
            else if (nextGrade - grade >= 3)
            {
                returnList.Add(grade);
            }
            else
            {
                returnList.Add(nextGrade);
            }
        }
        return returnList;
    }

    static int returnNextNumOfMultipleOfFive(int n)
    {
        return ((n + 4) / 5) * 5;
    }
}

public static class GradingStudents
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}