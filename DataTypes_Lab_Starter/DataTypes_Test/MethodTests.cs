using NUnit.Framework;
using DataTypes_Lib;

namespace DataTypes_Test
{
    public class MethodTests
    {
        [TestCase(1, 1)]
        public void Factorial_Returns_CorrectInteger(int n, long expResult)
        {
            var result = Methods.Factorial(n);
            Assert.That(result, Is.EqualTo(expResult));
        }
        [TestCase(10, 3_628_800)]
        public void FactorialTen_Returns_CorrectInteger(int n, long expResult)
        {
            var result = Methods.Factorial(n);
            Assert.That(result, Is.EqualTo(expResult));
        }
        [TestCase(12, 479_001_600)]
        public void FactorialTwelve_Returns_CorrectInteger(int n, long expResult)
        {
            var result = Methods.Factorial(n);
            Assert.That(result, Is.EqualTo(expResult));
        }
        [TestCase(13, 46_227_020_800)]
        public void FactorialThirteen_Returns_CorrectInteger(int n, long expResult)
        {
            var result = Methods.Factorial(n);
            Assert.That(result, Is.EqualTo(expResult));
        }
        [TestCase(20, 2_432_902_008_176_640_000)]
        public void FactorialTwenty_Returns_CorrectInteger(int n, long expResult)
        {
            var result = Methods.Factorial(n);
            Assert.That(result, Is.EqualTo(expResult));
        }

        [Test]
        public void Mult_ReturnsCorrectProductOfFloats()
        {
            var result = Methods.Mult(2.1f, 3.0f);
            Assert.That(result, Is.EqualTo(6.30000f));           
        }
    }
}