using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class LearningObjectives
    {
        public LearningObjectives(DateOnly dateOnly, TimeOnly timeOnly, string teacherName)
        {   
            Date = dateOnly;
            Time = timeOnly;
            TeacherName = teacherName;
            
        }
        public DateOnly Date {  get; set; }
        public TimeOnly Time { get; set; }
        public string TeacherName { get; set; }
        public string GetAll()
        {
            return $"дата: {Date.ToString("dd.MM.yyyy")} время: {Time.ToString("HH:mm")}, преподаватель: \"{TeacherName}\"";
        }
    }
    
}
