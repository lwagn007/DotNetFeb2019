using System;
using Class_Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class_Example_Tests
{
    [TestClass]
    public class Thanksgiving_Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Thanksgiving dinner = new Thanksgiving();
            dinner.GuestCount = 45;
            dinner.Name = "Dinner";
            dinner.Type = FoodType.Entree;

            Thanksgiving dinnerTwo = new Thanksgiving("Dinner At Your Place", true, "Indiana", 50, 0.15d, FoodType.Appetizer);


            Thanksgiving dinnerThree = new Thanksgiving("another name");
        }
    }
}
