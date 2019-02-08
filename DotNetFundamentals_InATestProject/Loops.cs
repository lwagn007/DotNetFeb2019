using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        //Show loops in test runner and console program. 
        public void Loop()
        {
            string name = "Joshua";

            //1 Starting point
            //2 While true, keep looping
            //3 What to do after each loop
            //for  //1     //2     //3
            for (int i = 1; i <= name.Length; i++)
            {
                Console.Write(i);
            }

            //1 Collection being worked on
            //2 Name of current type being worked on
            //3 Current type in collection
            //4 in keyword used to seperate the individual and collection
            //foreach //3  //2   //4  //1
            foreach (char letter in name)
            {
                Console.WriteLine($"\n{letter}");
            }

            int total = 1;

            //1 Loop runs while this statement is true
            //while   //1
            while (total != 5)
            {
                Console.WriteLine(total);
                total++;
            }
        }

        public void Loop_Example()
        {
            //Do this example with the calculator
            string response = "n";
            while (response != "y")
            {
                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello {name}.");

                Console.WriteLine("Do you want to keep your name? (y/n)");
                response = "n";
            }
        }
    }
}
