using ConsoleApp1;
LearningObjectivesStorage storage = new LearningObjectivesStorage();

string filePath = Path.Combine(AppContext.BaseDirectory, "data.txt");
LearningObjectivesParser parser = new LearningObjectivesParser();

List<string> errors = storage.LoadFromFile(filePath);

while (true)
{
    Console.WriteLine("1. Загрузить данные из файла");
    Console.WriteLine("2. добавить объект"); 
    Console.WriteLine("3. Вывести все объекты");
    Console.WriteLine("4. Выход");
    Console.Write("Выберите пункт меню: ");
    string choice = Console.ReadLine();
    if (choice == "4")
    {
        break;
    }
    else
    {
        switch (choice)
        {
            case "1":
                Console.Clear();
                LoadData();
                Console.ReadKey();
                Console.Clear();
                break;
            case "2":
                Console.Clear();
                CreateObjective();
                Console.ReadKey();
                Console.Clear();
                break;
            case "3":
                Console.Clear();
                foreach (LearningObjectives objective in storage.Objectives)
                {
                    Console.WriteLine(objective);
                }
                Console.ReadKey();
                Console.Clear();
                break;
            default:
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
                Console.ReadKey();
                Console.Clear();
                break;
        }
    }


}
string LoadData()
{
    List<string> errors = storage.LoadFromFile(filePath);
    foreach (LearningObjectives objective in storage.Objectives)
    {
        Console.WriteLine(objective);
    }
    foreach (string error in errors)
    {
        Console.WriteLine($"Ошибка: {error}");
    }
    return filePath;
}
string CreateObjective()
{
    Console.WriteLine("Введите данные для создания объекта (формат: Lec дд.мм.гггг ЧЧ:ММ \"имя преподавателя\" \"аудитория\" количество студентов):");
    string input = Console.ReadLine();
    string result = storage.AddObjective(input);
    Console.WriteLine(result);
    return result;
}




