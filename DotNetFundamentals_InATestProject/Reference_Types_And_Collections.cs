using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Reference_Types_And_Collections
    {
        [TestMethod]
        public void ReferenceTypes()
        {
            //Classes
            //Interfaces
            //Objects

            //String is a reference type that acts like a value type
            string hello = "Whatever I want.";
        }

        [TestMethod]
        public void Collections()
        {
            string[] arrayOfStrings = { "This", "can", "be", "a", "collection of any string" };
            int[] arrayOfInts = { 1, 2, 3, 4, 5, 6, 10008, 34, 234, 5634, 321 };
            List<string> listOfStrings = new List<string>();
            Queue<string> firstInFirstOut = new Queue<string>();
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }

        //Challenge write a method that will take a parameter of a string and then add that string to a sentence. Output it to the test runner.
        private string SayHello(string hello)
        {

            string greeting = "Hello, " + hello;
            Console.WriteLine($"Hello, {hello}");

            return greeting;
        }

        [TestMethod]
        public void SayHello_Test()
        {
            string name = "John";
            string actual = SayHello(name);
            Assert.AreEqual("Hello, John", actual);
        }
    }
}
