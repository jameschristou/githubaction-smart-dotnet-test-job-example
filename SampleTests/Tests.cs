namespace SampleTests
{
    public class Tests
    {
        [Trait("Category", "Group1")]
        [Fact]
        public void TestThatRandomlyFails()
        {
            Random rnd = new Random();

            Assert.Equal(1, rnd.Next(2));
        }

        [Trait("Category", "Group1")]
        [Fact]
        public void TestThatRandomlyFails2()
        {
            Random rnd = new Random();

            Assert.Equal(1, rnd.Next(2));
        }

        [Trait("Category", "Group1")]
        [Fact]
        public void TestThatRandomlyFails3()
        {
            Random rnd = new Random();

            Assert.Equal(1, rnd.Next(2));
        }

        [Trait("Category", "Group1")]
        [Fact]
        public void TestThatRandomlyFails4()
        {
            Random rnd = new Random();

            Assert.Equal(1, rnd.Next(2));
        }

        [Trait("Category", "Group1")]
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        public void TestThatRandomlyFails5(int start, int testNum)
        {
            Random rnd = new Random();

            Assert.Equal(start, rnd.Next(testNum));
        }

        [Trait("Category", "Group1")]
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        public void TestThatRandomlyFails6(int start, int testNum)
        {
            Random rnd = new Random();

            Assert.Equal(start, rnd.Next(testNum));
        }

        [Trait("Category", "Group1")]
        [Theory]
        [MemberData(nameof(InvalidInputReturnsErrorMessage))]
        public void TestThatRandomlyFails7_WithARidiculouslyLongTestingNameThatWillExceedTheCharacterLimitAtWhichXUnitTruncatesTestDisplayName(InputModel inputModel, string message)
        {
            Random rnd = new Random();

            var errorMessages = new List<string>()
            {
                "This is an error that you would expect",
                "This is a different error that you might expect"
            };

            Assert.Equal(message, errorMessages[rnd.Next(inputModel.InputA)]);
        }

        
        public static IEnumerable<object[]> InvalidInputReturnsErrorMessage()
        {
            yield return new object[]
            {
                new InputModel
                {
                    InputA = 1, InputB = false, InputC = true
                },
                "This is an error that you would expect"
            };

            yield return new object[]
            {
                new InputModel
                {
                    InputA = 2, InputB = false, InputC = true
                },
                "This is a different error that you might expect"
            };
        }

        public class InputModel
        {
            public int InputA { get; set; }
            public bool InputB { get; set; }
            public bool InputC { get; set; }
        }
    }
}