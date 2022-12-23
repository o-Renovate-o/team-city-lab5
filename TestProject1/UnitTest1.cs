using NUnit.Framework;
using ConsoleApp1;

namespace TestProject
{
    public class Tests
    {
        [Test]
        // [Ignore("This test is disabled")]
        public static void TestOne()
        {
            Assert.AreEqual(Program.Factorial(7), 5040);
        }

        [Test]
        // [Ignore("This test is disabled")]
        public static void TestTwo()
        {
            Assert.AreEqual(Program.Factorial(0), 1);
        }

        [Test]
        // [Ignore("This test is disabled")]
        public static void TestThree()
        {
            Assert.AreEqual(Program.Factorial(2), 2);
        }
    }
}