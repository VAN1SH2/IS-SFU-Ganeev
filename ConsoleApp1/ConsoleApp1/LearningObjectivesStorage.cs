using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class LearningObjectivesStorage
    {
        
        public List<LearningObjectives> Objectives { get; set; } = new List<LearningObjectives>();
        private LearningObjectivesParser learningObjectivesParser = new LearningObjectivesParser();
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
