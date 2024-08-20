namespace SampleTests
{
    public class Tests
    {
        [Fact]
        public void TestThatRandomlyFails()
        {
            Random rnd = new Random();

            Assert.Equal(1, rnd.Next(2));
        }

        [Fact]
        public void TestThatRandomlyFails2()
        {
            Random rnd = new Random();

            Assert.Equal(1, rnd.Next(2));
        }

        [Fact]
        public void TestThatRandomlyFails3()
        {
            Random rnd = new Random();

            Assert.Equal(1, rnd.Next(2));
        }
    }
}