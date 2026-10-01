using ConsoleApp1;
using System.Security.Cryptography.X509Certificates;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CorrectObjective_CreateObjective()
        {
            string input = "Lec 07.10.2026 12:00 \"Иванов Иван Иванович\" \"5-10\" 30";
            var parser = new ConsoleApp1.LearningObjectivesParser();
            bool result = parser.TryParse(input, out LearningObjectives? objective, out string? error);
            Assert.True(result);
            Assert.NotNull(objective);
            Assert.Null(error);
        }
        [Theory]
        [InlineData("Sem 07.10.2026 12:00 \"Иванов\" \"5-10\" 30")]
        [InlineData("Lec неправильная-дата 12:00 \"Иванов\" \"5-10\" 30")]
        [InlineData("Lec 07.10.2026 неверное-время \"Иванов\" \"5-10\" 30")]
        [InlineData("Lec 07.10.2026 12:00 Иванов 5-10 30")]
        public void IncorrectObjective_CreateObjective(string input)
        {
            var parser = new ConsoleApp1.LearningObjectivesParser();
            bool result = parser.TryParse(input, out LearningObjectives? objective, out string? error);
            Assert.False(result);
            Assert.Null(objective);
            Assert.NotNull(error);
        }

    }
}
