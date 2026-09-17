

namespace ConsoleApp1
{
    internal class Lecture:LearningObjectives
    {
        public Lecture(DateOnly dateOnly, TimeOnly timeOnly, string teacherName, string classroom, int studentCount) : base(dateOnly, timeOnly, teacherName)
        {
            Classroom = classroom;
            StudentCount = studentCount;
        }
        public string Classroom { get; set; }
        public int StudentCount { get; set; }
        public override string ToString()
        {
            return $"дата: {Date.ToString("dd.MM.yyyy")} время: {Time.ToString("HH:mm")}, преподаватель: \"{TeacherName}\", аудитория: \"{Classroom}\", количество студентов: {StudentCount}";
        }
    }
}
