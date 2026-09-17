
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
        public override string ToString()
        {
            return $"дата: {Date.ToString("dd.MM.yyyy")} время: {Time.ToString("HH:mm")}, преподаватель: \"{TeacherName}\", название лабораторной: \"{LaboratoryName}\", максимальный балл: {MaxGrade}";
        }
    }
}
