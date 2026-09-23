using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class LearningObjectivesParser
    {
        public bool TryParse(string str, out LearningObjectives? objective, out string? error)
        {
            objective = null;
            error = null;
            try
            {
                List<string> parts = str.Split('\"').ToList();

                if (parts.Count != 5)
                {
                    error = "Текстовые поля должны находиться в кавычках";
                    return false;
                }

                List<string> words = parts[0]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                words.Add(parts[1]);
                words.Add(parts[3]);
                words.Add(parts[4].Trim());

                if (words[0] == "Lec")
                {
                    DateOnly date = DateOnly.Parse(words[1]);
                    TimeOnly time = TimeOnly.Parse(words[2]);
                    int studentCount = int.Parse(words[5]);

                    if (studentCount < 0)
                    {
                        error = "Количество студентов не может быть отрицательным";
                        return false;
                    }

                    objective = new Lecture(
                        date,
                        time,
                        words[3],
                        words[4],
                        studentCount);

                    return true;
                }
                else if (words[0] == "Lab")
                {
                    DateOnly date = DateOnly.Parse(words[1]);
                    TimeOnly time = TimeOnly.Parse(words[2]);
                    int maxGrade = int.Parse(words[5]);

                    if (maxGrade <= 0)
                    {
                        error = "Максимальный балл должен быть больше нуля";
                        return false;
                    }

                    objective = new Laboratory(
                        date,
                        time,
                        words[3],
                        words[4],
                        maxGrade);

                    return true;
                }

                error = $"Неизвестный тип занятия: {words[0]}";
                return false;
            }
            catch (FormatException)
            {
                error = "Дата, время или число записаны в неверном формате";
                return false;
            }
            catch (OverflowException)
            {
                error = "Числовое значение слишком большое";
                return false;
            }
            catch (ArgumentOutOfRangeException)
            {
                error = "В строке недостаточно данных";
                return false;
            }
        }
    }
}
