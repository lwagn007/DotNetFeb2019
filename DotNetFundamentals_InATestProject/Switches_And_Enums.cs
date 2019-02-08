using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Switches_And_Enums
    {
        [TestMethod]
        public void Switches()
        {
            string intput = "Hello";

            switch (intput)
            {
                case "Hello":
                    Console.WriteLine("Idk what we are doing exactly.");
                    break;
                case "":
                    Console.WriteLine("Answer the question!");
                    break;
                case "90":
                    Console.WriteLine("Quick Question");
                    break;
                default:
                    Console.WriteLine("this is default like the else. a catch all");
                    break;
            }
        }

        [TestMethod]
        public void SwitchSpeedExample()
        {
            int x = 25;
            switch (x)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    Console.WriteLine("Got it!");
                    break;
                default:
                    break;
            }
        }

        [TestMethod]
        public void IfElseSpeedExample()
        {
            int x = 25;

            if (x == 1)
                Console.WriteLine("Nope");
            else if (x == 2)
                Console.WriteLine("Still nope");
            else if (x == 3)
                Console.WriteLine("Still nope");
            else if (x == 4)
                Console.WriteLine("Still nope");
            else if (x == 5)
                Console.WriteLine("Still nope");
            else if (x == 6)
                Console.WriteLine("Still nope");
            else if (x == 7)
                Console.WriteLine("Still nope");
            else if (x == 8)
                Console.WriteLine("Still nope");
            else if (x == 9)
                Console.WriteLine("Still nope");
            else if (x == 10)
                Console.WriteLine("Still nope");
            else if (x == 11)
                Console.WriteLine("Still nope");
            else if (x == 12)
                Console.WriteLine("Still nope");
            else if (x == 13)
                Console.WriteLine("Still nope");
            else if (x == 14)
                Console.WriteLine("Still nope");
            else if (x == 15)
                Console.WriteLine("Still nope");
            else if (x == 16)
                Console.WriteLine("Still nope");
            else if (x == 17)
                Console.WriteLine("Still nope");
            else if (x == 18)
                Console.WriteLine("Still nope");
            else if (x == 19)
                Console.WriteLine("Still nope");
            else if (x == 20)
                Console.WriteLine("Still nope");
            else if (x == 21)
                Console.WriteLine("Still nope");
            else if (x == 22)
                Console.WriteLine("Still nope");
            else if (x == 23)
                Console.WriteLine("Still nope");
            else if (x == 24)
                Console.WriteLine("Still nope");
            else if (x == 25)
                Console.WriteLine("Yup");
            else
                Console.WriteLine("End");
        }

        public enum Dogs
        {
            Yorkie = 100, GermanShepherd, Wolf, IrishWolfHound, FinnishSpitz
        }

        public enum DogSize
        {
            small, large, medium, xlarge
        }

        [TestMethod]
        public void Enum()
        {
            Dogs dog;

            int intput = 10200;

            switch (intput)
            {
                case 10200:
                    dog = Dogs.Yorkie;
                    break;
                case 1:
                    dog = Dogs.GermanShepherd;
                    break;
                case 4:
                    dog = Dogs.IrishWolfHound;
                    break;
                case 3:
                    dog = Dogs.FinnishSpitz;
                    break;
                case 2:
                    dog = Dogs.Wolf;
                    break;
                default:
                    break;
            }
        }


    }
}
