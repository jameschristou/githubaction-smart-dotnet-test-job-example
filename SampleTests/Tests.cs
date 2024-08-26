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
    }
}