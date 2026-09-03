using ConsoleApp1;

List<LearningObjectives> list = new List<LearningObjectives>
{
    new LearningObjectives(new DateOnly(2026, 6, 6), new TimeOnly(10, 15), "Иванов Иван Иванович"),
    new LearningObjectives(new DateOnly(2026, 6, 6), new TimeOnly(12, 0), "Иванов Иван Иванович"),
    new LearningObjectives(new DateOnly(2026, 6, 6), new TimeOnly(14, 10), "Иванов Иван Иванович"),
    new LearningObjectives(new DateOnly(2026, 6, 6), new TimeOnly(16, 55), "Иванов Иван Иванович"),
};
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i].GetAll());
}
