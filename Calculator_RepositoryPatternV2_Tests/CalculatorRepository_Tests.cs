using System;
using Calculator_RepositoryPatternV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_RepositoryPatternV2_Tests
{
    [TestClass]
    public class CalculatorRepository_Tests
    {
        CalculatorRepository _calcRepo;
        int a;
        int b;
        int x;
        int y;

        [TestInitialize]
        public void Arrange()
        {
            _calcRepo = new CalculatorRepository();
            a = 1;
            b = 5;
            x = 2;
            y = 6;

        }

        [TestMethod]
        public void CalculatorRepository_AddTwoNumbers_ShouldReturnCorrectSum()
        {
            var expected = 6;
            var actual = _calcRepo.AddTwoNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_SubtractTwoNumbers_ShouldReturnCorrectValue()
        {
            var expected = 4;
            var actual = _calcRepo.SubtractTwoNumbers(b, a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_MultiplyTwoNumbers_ShouldReturnCorrectValue()
        {
            var expected = 10;
            var actual = _calcRepo.MultiplyTwoNumbers(b, x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_DivideTwoNumbers_ShouldReturnCorrectValue()
        {
            var expected = 3;
            var actual = _calcRepo.DivideTwoNumbers(y, x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatorRepository_GetRemainder_ShouldReturnCorrectValue()
        {
            var expected = 1;
            var actual = _calcRepo.GetRemainder(b, x);

            Assert.AreEqual(expected, actual);
        }
    }
}
