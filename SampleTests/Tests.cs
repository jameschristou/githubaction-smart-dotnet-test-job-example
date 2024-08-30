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
        [InlineData(1, 2, "This is the expected message")]
        [InlineData(2, 3, "This is the expected message")]
        public void TestThatRandomlyFails6(int start, int testNum, string expectedMessage)
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
                "This is an error that you would expect.",
                "This is a different error than you might expect."
            };

            Assert.Contains(errorMessages[rnd.Next(inputModel.InputA)], message);
        }

        [Trait("Category", "Group1")]
        [Theory(DisplayName = "TestThatRandomlyFails8_WithARidiculouslyLongTestingNameThatWillExceedTheCharacterLimitAtWhichXUnitTruncatesTestDisplayName")]
        [MemberData(nameof(InvalidInputReturnsErrorMessage))]
        public void TestThatRandomlyFails8_WithARidiculouslyLongTestingNameThatWillExceedTheCharacterLimitAtWhichXUnitTruncatesTestDisplayName(InputModel inputModel, string message)
        {
            Random rnd = new Random();

            var errorMessages = new List<string>()
            {
                "This is an error that you would expect.",
                "This is a different error than you might expect.",
                "This is a another error that you might expect"
            };

            Assert.Contains(errorMessages[rnd.Next(inputModel.InputA)], message);
        }


        public static IEnumerable<object[]> InvalidInputReturnsErrorMessage()
        {
            yield return new object[]
            {
                new InputModel
                {
                    InputA = 1, InputB = false, InputC = true
                },
                "This is an error that you would expect. We are intentionally making this message really really long because it becomes part of the display name for the test and we want the total length to exceed 450 chars"
            };

            yield return new object[]
            {
                new InputModel
                {
                    InputA = 2, InputB = false, InputC = true
                },
                "This is a different error than you might expect. We are intentionally making this message really really long because it becomes part of the display name for the test and we want the total length to exceed 450 chars"
            };

            yield return new object[]
            {
                new InputModel
                {
                    InputA = 3, InputB = false, InputC = true
                },
                "This is a another error that you might expect. We are intentionally making this message really really long because it becomes part of the display name for the test and we want the total length to exceed 450 chars"
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