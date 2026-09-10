using ConsoleApp1;


string fileText = File.ReadAllText("D:\\IS-SFU\\ConsoleApp1\\data.txt");
List<string> lines = new List<string>();
List<LearningObjectives> learningObjectives = new List<LearningObjectives>();

Console.WriteLine("напишите в формате дд.мм.гггг чч:мм \"фио\"");
foreach (string line in fileText.Split('\n'))
{
    lines.Add(line);
}
Console.WriteLine(fileText);
string str = Console.ReadLine();
foreach (string line in lines)
{
    LearningObjectives learningObjective = CreateObject(line);
    learningObjectives.Add(learningObjective);
    Console.WriteLine(learningObjective.ToString());
}

int f(List<int> list)
{
    int max = 0;
    for (int i = 2; i < list.Count; i++)
    {
        int three = list[i - 2] + list[i - 1] + list[i];
        if (three > max)
        {
            max = three;
        }
    }
    return max;   
}


LearningObjectives CreateObject(string str)
{
    DateOnly date = DateOnly.Parse(str[0..10]);
    TimeOnly time = TimeOnly.Parse(str[11..16]);
    int Index1 = str.IndexOf("\"") + 1;
    string Name = str[Index1..^1];
    LearningObjectives learningObjective = new LearningObjectives(date, time, Name);
    return learningObjective;
}