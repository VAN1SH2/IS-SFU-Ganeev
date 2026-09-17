using ConsoleApp1;

Console.WriteLine("напишите в формате дд.мм.гггг чч:мм \"фио\"");
LearningObjectivesStorage storage = new LearningObjectivesStorage();
storage.LoadFromFile("D:\\IS-SFU\\ConsoleApp1\\data.txt");
int f (List<int> list)
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
foreach (LearningObjectives obj in storage.Objectives)
{
    Console.WriteLine(obj.ToString());
}



