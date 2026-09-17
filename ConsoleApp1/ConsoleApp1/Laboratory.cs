using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Laboratory:LearningObjectives
    {
        public Laboratory(DateOnly dateOnly, TimeOnly timeOnly, string teacherName, string laboratoryName, int studentCount) : base(dateOnly, timeOnly, teacherName)
        {
            LaboratoryName = laboratoryName;
            MaxGrade = studentCount;
        }
        public string LaboratoryName { get; set; }
        public int MaxGrade { get; set; }

    }
}
