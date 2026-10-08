using ConsoleApp1;

namespace GraphTest
{
    public class UnitTest1
    {
        ConsoleApp1.GraphParser Parser = new ConsoleApp1.GraphParser();
        [Fact]
        public void CorrectAdjacencyList()
        {
            Dictionary<string, List<string[]>> answer = new Dictionary<string, List<string[]>>
        {
            { "A", new List<string[]> { new string[2] {"inherit", "B" }, new string[2] { "aggregation", "F" } } },
            { "B", new List<string[]> {} },
            { "C", new List<string[]> { new string[2] { "inherit", "B" } } },
            { "D", new List<string[]> { new string[2] { "inherit", "C" } } },
            { "E", new List<string[]> { new string[2] { "inherit", "A" } } },
            { "F", new List<string[]> { new string[2] { "inherit", "C" } } }
        };
            string input = "A-->B\n" +
                "C --> B\n" +
                "E --> A\n" +
                "D --> C\n" +
                "F --> C\n" +
                "A 0-> F";
            bool result = Parser.Parse(input).Count == answer.Count && Parser.Parse(input).OrderBy(kvp => kvp.Key).SequenceEqual(answer.OrderBy(kvp => kvp.Key));
            Assert.True(result);
        }

        [Theory]
        [InlineData("A-->B \nC --> B \nE --> A \nD --> C\n")]
        [InlineData("A-->B \nC-> B \nE --> A \nD --> C\nF -->C")]
        [InlineData("A-->B \nC --> B \nE --> A \nD --> C \nF --> C \nG --> H")]
        [InlineData(null)]
        public void IncorrectAdjacencyList(string input)
        {
            Assert.Throws<ArgumentException>(() => Parser.Parse(input));
        }
    }
}

