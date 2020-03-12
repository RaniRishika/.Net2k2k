using NUnit.Framework;

namespace TestProject1
{
   [TestFixture]
    public class TestCalculate
    {
        Cacluate obj = null;
        [SetUp]
        public void Setup()
        {
            obj = new Cacluate();
        }

        [Test]
        public void TestAdd()
        {
            int actual = obj.Add(3, 5);
            int expected = 8;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        [Description("Test Greet Method")]
        public void GreetTest()
        {
            string result = obj.Greet("Sachin");
            Assert.NotNull(result);
            Assert.AreEqual("Hi Sachin", result);
        }
    }
}