using System;
using CarDealership;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarDealership_Tests
{
    [TestClass]
    public class CarRepository_Tests
    {

        private CarRepository _carRepoTest;

        [TestInitialize]
        public void Arrange()
        {
            _carRepoTest = new CarRepository();
        }

        [TestMethod]
        public void CarRepository_GetCarList_ShouldReturnCorrectCount()
        {
            //Arrange
            var carList = _carRepoTest.GetCarList();

            //Act
            var actual = carList.Count;
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CarRepository_AddCarToList_ShouldReturnCorrectCount()
        {
            //Arrange
            var carList = _carRepoTest.GetCarList();
            var car = new Car();
            _carRepoTest.AddCarToList(car);

            //Act
            var actual = carList.Count;
            var expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CarRepository_RemoveCarFromList_ShouldReturnCorrectCount()
        {
            //Arrange
            var carList = _carRepoTest.GetCarList();
            var car = new Car();
            _carRepoTest.AddCarToList(car);
            _carRepoTest.RemoveCarFromList(car);

            //Act
            var actual = carList.Count;
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("yes", true)]
        [DataRow("Yes", true)]
        [DataRow("no", false)]
        [DataRow("No", false)]
        [DataRow("AENIONFpijwev216879031qckwona", false)]
        public void CarRepository_GetBooleanFromString_ShouldReturnCorrectBoolean(string input, bool expectedBool)
        {
            //Act
            var actual = _carRepoTest.GetBooleanFromString(input);
            var expected = expectedBool;
            Console.WriteLine($"Actual: {actual}, Expected: {expected}, Input: {input}");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1, Brand.Toyota)]
        [DataRow(2, Brand.Ford)]
        [DataRow(3, Brand.Chevrolet)]
        [DataRow(4, Brand.Honda)]
        [DataRow(5, Brand.Tesla)]
        [DataRow(6, Brand.Lambourgini)]
        [DataRow(7, Brand.BMW)]
        [DataRow(93, Brand.Other)]
        public void CarRepository_GetBrandByInt_ShouldSetCorrectBrand(int input, Brand expectedBrand)
        {
            //Act
            var actual = _carRepoTest.GetBrandByInt(input);
            var expected = expectedBrand;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1, CarType.Truck)]
        [DataRow(2, CarType.Van)]
        [DataRow(3, CarType.Sedan)]
        [DataRow(4, CarType.Hybrid)]
        [DataRow(15, CarType.Other)]
        public void CarRepository_GetCarTypeByInt_ShouldSetCorrectCarType(int input, CarType expected)
        {
            //Act
            var actual = _carRepoTest.GetCarTypeByInt(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
