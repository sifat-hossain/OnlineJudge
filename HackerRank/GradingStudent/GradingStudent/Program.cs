class Result
{

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> finalGrades = [];
        foreach (int grade in grades)
        {
            int value = 5 - (grade % 5);

            if ((grade + value) >= 40)
            {

                if (value < 3)
                {
                    finalGrades.Add(grade + value);
                }
                else
                {
                    finalGrades.Add(grade);
                }
            }
            else
            {
                finalGrades.Add(grade);
            }
        }
        return finalGrades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}

