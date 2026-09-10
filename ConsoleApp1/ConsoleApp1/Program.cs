using ConsoleApp1;

Console.WriteLine("напишите в формате дд.мм.гггг чч:мм \"фио\"");
string fileText = File.ReadAllText("D:\\IS-SFU\\ConsoleApp1\\data.txt");
Console.WriteLine(fileText);
//string str = Console.ReadLine();
//DateOnly date = DateOnly.Parse(str[0..10]);
//TimeOnly time = TimeOnly.Parse(str[11..16]);
//int Index1 = str.IndexOf("\"")+1;
//string Name = str[Index1..^1];
//LearningObjectives learningObjectives = new LearningObjectives(date, time, Name);
//Console.WriteLine(learningObjectives.ToString());
