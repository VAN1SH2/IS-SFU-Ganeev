using ConsoleApp1;

LearningObjectivesStorage storage = new LearningObjectivesStorage();

string filePath = Path.Combine(AppContext.BaseDirectory, "data.txt");

List<string> errors = storage.LoadFromFile(filePath);

foreach (LearningObjectives objective in storage.Objectives)
{
    Console.WriteLine(objective);
}

foreach (string error in errors)
{
    Console.WriteLine($"Ошибка: {error}");
}




