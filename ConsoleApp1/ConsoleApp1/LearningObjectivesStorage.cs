using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class LearningObjectivesStorage
    {
        
        public List<LearningObjectives> Objectives { get; set; } = new List<LearningObjectives>();
        private LearningObjectives CreateObject(string str)
        {
            List<string> Words = new List<string>();
            foreach (string word in str.Split())
            {
                Words.Add(word);
            }
            if (Words[0] == "Lec")
            {
                DateOnly date = DateOnly.Parse(Words[1]);
                TimeOnly time = TimeOnly.Parse(Words[2]);
                string Name = Words[3][1..] + " " + Words[4] + " " + Words[5][0..^1]; 
                string classroom = Words[6][1..^1];
                int studentCount = int.Parse(Words[7]);
                Lecture lecture = new Lecture(date, time, Name, classroom, studentCount);
                return lecture;
            }
            else
            {
                DateOnly date = DateOnly.Parse(Words[1]);
                TimeOnly time = TimeOnly.Parse(Words[2]);
                string Name = Words[3][1..]+" "+ Words[4] + " "+ Words[5][0..^1];
                string LaboratoryName = Words[6][1..^1];
                int MaxGrade = int.Parse(Words[7]);
                Laboratory laboratory = new Laboratory(date, time, Name, LaboratoryName, MaxGrade);
                return laboratory;
            }
        }
        public void LoadFromFile(string FilePath)
        {
            string fileText = File.ReadAllText(FilePath);
            List<string> lines = new List<string>();
            foreach (string line in fileText.Split('\n'))
            {
                lines.Add(line);
            }
            foreach (string line in lines)
            {
                Objectives.Add(CreateObject(line));
            }
        }
    }
}
