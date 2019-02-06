using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Operators_And_Methods
    {
        //Challenge: Create two numbers, than add, subtract, multiply, divide, and find the remainder. Make an assert statement verifying that you can still do math.
        [TestMethod]
        public void UsingOperators()
        {
            //Challenge: Create two numbers, than add, subtract, multiply, divide, and find the remainder. Make an assert statement verifying that you can still do math.
            int a = 100;
            int b = 200;
            int c = a + b;
            int d = b - a;
            int e = a * b;
            int f = b / a;
            int g = b % a;
            Assert.AreEqual(300, c);
            Assert.AreEqual(100, d);
            Assert.AreEqual(20000, e);
            Assert.AreEqual(2, f);
            Assert.AreEqual(0, g);
            //Why don't we create some methods so that we can reuse the code to make if we wanted to check the result of more then only two values?
        }

        [TestMethod]
        public void UsingAMethod()
        {
            int a = 12;
            int b = 300;

            int c = AddTwoNumbers(a, b);
            int d = SubtractTwoNumbers(b, a);
            int e = MultiplyTwoNumbers(a, b);
            int f = DivideTwoNumbers(b, a);
            int g = RemainderOfTwoNumbers(a, b);

            int one = 3;
            int two = 7;

            int three = RemainderOfTwoNumbers(one, two);

            float money = 249f;
            float newAmount = AddTax(money);

            Assert.AreEqual(312, c);
            Assert.AreEqual(288, d);
            Assert.AreEqual(3600, e);
            Assert.AreEqual(25, f);
            Assert.AreEqual(0, g);
            Assert.AreEqual(1, three);
            Assert.AreEqual(266.43, newAmount, 0.01);
        }

        private int AddTwoNumbers(int one, int two)
        {
            int sum = one + two;
            return sum;
        }
        //Challenge Write a method that will take a number apply a 7% tax to it and return the number.

        private int SubtractTwoNumbers(int one, int two)
        {
            int difference = one - two;
            return difference;
        }

        private int MultiplyTwoNumbers(int one, int two)
        {
            int product = one * two;
            return product;
        }

        private int DivideTwoNumbers(int one, int two)
        {
            int dividend = one / two;
            return dividend;
        }

        private int RemainderOfTwoNumbers(int one, int two)
        {
            int remainder = two % one;
            return remainder;
        }

        private float AddTax(float one)
        {
            float taxPercent = 0.07f;
            float taxedOwed = one * taxPercent;
            float finalAmount = taxedOwed + one;
            return finalAmount;
        }

        [TestMethod]
        public void SayHello()
        {
            string name = "John";
            string actual = SayHello(name);
            Assert.AreEqual("Hello, John", actual);
        }

        private string SayHello(string hello)
        {

            string greeting = "Hello, " + hello;
            Console.WriteLine($"Hello, {hello}");

            return greeting;
        }
    }
}
