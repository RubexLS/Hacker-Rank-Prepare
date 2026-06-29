Console.WriteLine("How many grades will be entered?");
int gradesCount = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> grades = new List<int>();

Console.WriteLine("Enter grades:");
for (int i = 0; i < gradesCount; i++)
{
    int gradesItem = Convert.ToInt32(Console.ReadLine()!.Trim());
    grades.Add(gradesItem);
}

List<int> result = gradingStudents(grades);

Console.WriteLine("The grades are following:");
foreach (int x in result)
{
    Console.WriteLine(x);
}



static List<int> gradingStudents(List<int> grades)
{
    List<int> modifiedGrades = new List<int>();
    foreach(int x in grades)
    {
        if(x > 37)
        {
            if(x % 5 > 2)
            {
                modifiedGrades.Add(x + 5 - x % 5);
            }
            else
                modifiedGrades.Add(x);
        }
        else
            modifiedGrades.Add(x);
    }

    return modifiedGrades;
}