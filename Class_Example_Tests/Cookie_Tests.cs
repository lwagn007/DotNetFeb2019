using System;
using Class_Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Class_Example_Tests
{
    [TestClass]
    public class Cookie_Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Sugar Cookie";
            cookie.IsGlutenFree = false;
            cookie.Ingredient = "Flour and sugar";
            cookie.BatchSize = 45;

            Console.WriteLine(cookie.IsGlutenFree);

            cookie = new Cookie();

            Console.WriteLine(cookie.IsGlutenFree);

            Cookie cookieTwo = new Cookie();
            cookieTwo.Name = "Snickerdoodle";
            cookieTwo.IsGlutenFree = true;
            cookieTwo.Ingredient = "Gluten free flour and sugar";
            cookieTwo.BatchSize = 2000;
        }
    }
}
