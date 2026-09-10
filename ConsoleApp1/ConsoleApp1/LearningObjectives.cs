using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

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
        

        public override string ToString()
        {
            return $"дата: {Date.ToString("dd.MM.yyyy")} время: {Time.ToString("HH:mm")}, преподаватель: \"{TeacherName}\"";
        }
    }
}
