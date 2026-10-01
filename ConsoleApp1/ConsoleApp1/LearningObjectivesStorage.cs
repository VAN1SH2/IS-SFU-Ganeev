using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    public class LearningObjectivesStorage
    {
        
        public List<LearningObjectives> Objectives { get; set; } = new List<LearningObjectives>();
        private LearningObjectivesParser learningObjectivesParser = new LearningObjectivesParser();
        public string AddObjective(string str)
        {
            if (learningObjectivesParser.TryParse(str, out LearningObjectives? objective, out string? error))
            {
                Objectives.Add(objective);
                return "Объект успешно создан";
            }
            else
            {
                return $"Ошибка: {error}";
            }
        }
        public List<string> LoadFromFile(string filePath)
        {
            List<string> errors = new List<string>();
            Objectives.Clear();

            try
            {
                int lineNumber = 0;

                foreach (string line in File.ReadLines(filePath))
                {
                    lineNumber++;

                    if (learningObjectivesParser.TryParse(line, out LearningObjectives? objective, out string? error))
                    {
                        if (objective != null)
                        {
                            Objectives.Add(objective);
                        }
                    }
                    else
                    {
                        errors.Add($"Строка {lineNumber}: {error}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                errors.Add($"Файл не найден: {filePath}");
            }
            catch (UnauthorizedAccessException)
            {
                errors.Add("Нет доступа к файлу");
            }
            catch (IOException ex)
            {
                errors.Add($"Ошибка чтения файла: {ex.Message}");
            }

            return errors;
        }
    }
}
