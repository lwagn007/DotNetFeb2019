using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class Value_Types
    {
        public void ValueTypes()
        {
            char c = 'i';  // a string is just a linked list of chars, note the single quotes, a.k.a. Char

            bool on = true;
            bool off = false;

            //Integers

            byte by = 255;    // 2^8, or 256, or +/- 0-255, a.k.a. Byte
            byte byteMin = 0;
            byte byteMax = 255;

            short sh = 32767; // 2^16, or 32768, or +/- 0-32767, a.k.a. Int16
            short shortMin = -32768;
            short shortMax = 32767;


            int intMin = -2147483648;
            int intMax = 2147483647;

            long youtubeMinutesWatched = 9223372036854775807; // a very long number, 64-bit, a.k.a. Int64
            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;

            float PI = 334.5340958091415927f; // floating point integer, must put f *explicit* conversion afterwards
                                              //if using a constant, or you could cast as (float)
                                              // Think of the decimal point as being movable....
            float floatExample = 1.04523f;

            double d = 780d; // 64-bit decimal, a.k.a. Double
            double doubleExample = 1.789053278907036333333333333333333d;

            decimal p = 7.80m; // 128-bit precision decimal, very expensive, a.k.a. Decimal
            decimal decimalExample = 1.2578907289045789789789789787897m;

            int i = 0;        // 2,147,483,647 +/-
            int a = -2147483648;
            int b = 2147483647;
            int? ni = null; // nullable variables, use .HasValue to determine if they are populated, 
                            ////useful with web services, database results

            DateTime today = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);

        }

        public void Declaration()
        {
            int number;
            string name;
            bool isValid;
            //Challenge declare an addtional 6 different value types.
        }

        [TestMethod]
        public void Declaration_Than_Initialization()
        {
            int number;
            string name;
            bool isValid;

            number = 7;
            name = "Max";
            isValid = true;
            //Challenge declare and then initialize all values that you created in the last test method Declaration.
            //Challenge: Initialize a value and make an assert statement 
            Assert.AreEqual(7, number);
        }

        [TestMethod]
        public void Declaration_And_Initialization()
        {
            int year = 2019;
            string country = "USA";
            //Declare and initialize the 9 values you have from the previous method in one line.
            Assert.AreEqual(2019, year);
        }
    }
}
