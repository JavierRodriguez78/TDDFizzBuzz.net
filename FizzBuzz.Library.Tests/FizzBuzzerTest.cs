using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.Pass();
        }

        [Test]
        public void Buzzer_When1_Returns1()
        {
            //Arrange
            int input = 1;
            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("1", output);

        }

        [Test]
        public void Buzzer_When2_Returns2()
        {
            //Arrange
            int input = 2;
            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("2", output);

        }
        [Test]
        public void Buzzer_When3_ReturnsFizz()
        {
            //Arrange
            int input = 3;
            //Act
            string output = FizzBuzzer.GetValue(input);

            //Assert
            Assert.AreEqual("Fizz", output);

        }

        [Test]
        public void Buzzer_WhenDefault_ReturnsDefault([Values(1, 2, 4, 7, 8,11,13,14,16,17,19)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_When5_ReturnsBuzz()
        {
            int input = 5;
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_WhenDiv3_ReturnsFizz([Values(3, 6, 9,18)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_WhenDiv5_ReturnsBuzz([Values(5, 10,20)] int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_WhenDiv3AndDiv5_ReturnsFizzBuzz([Values(15)] int input)
            {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
            }
    }
}
