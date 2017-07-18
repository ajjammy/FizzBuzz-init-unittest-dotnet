using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzz fizzBuzz;

        public FizzBuzzTests() 
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void Number_1_DisplayText_1()
        {
            Assert.AreEqual(fizzBuzz.GetTextDisplay(1), "1");
        }

        [Test]
        public void Number_2_DisplayText_2()
        {
            string textDisplay =  fizzBuzz.GetTextDisplay(2);
            Assert.AreEqual(textDisplay, "2");
        }

        [Test]
        public void Number_3_DisplayText_Fizz()
        {
            string textDisplay =  fizzBuzz.GetTextDisplay(3);
            Assert.AreEqual(textDisplay, "Fizz");
        }

        [Test]
        public void Number_4_DisplayText_4()
        {
            string textDisplay =  fizzBuzz.GetTextDisplay(4);
            Assert.AreEqual(textDisplay, "4");
        }

        [Test]
        public void Number_5_DisplayText_Buzz()
        {
            string textDisplay =  fizzBuzz.GetTextDisplay(5);
            Assert.AreEqual(textDisplay, "Buzz");
        }

        [Test]
        public void Number_15_DisplayText_FizzBuzz()
        {
            string textDisplay =  fizzBuzz.GetTextDisplay(15);
            Assert.AreEqual(textDisplay, "FizzBuzz");
        }
    }
}