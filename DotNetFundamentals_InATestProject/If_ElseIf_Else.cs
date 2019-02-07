using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFundamentals_InATestProject
{
    [TestClass]
    public class If_ElseIf_Else
    {
        [TestMethod]
        public void If_Else()
        {
            if (2 == 3)
            {
                Console.WriteLine("Of course");

                DateTime birthday = new DateTime(1978, 12, 14);
                DateTime date = DateTime.Now;

                if (birthday.Month == date.Month && birthday.Day == date.Day)
                {
                    Console.WriteLine("Happy Birthday!");
                }
                else
                {
                    Console.WriteLine("We are waiting for it");
                }
            }


            //Write a conditional statement that checks if someone is younger than 18,
            //write "still a kid"
            //if they are older than 18 but less than 25 write "you are a adult"
            // if they are older then 25 but younger then 50 write "you can rent a car for cheap
            // if they are older than 50 write you be wise
            int age = 25;
            if (age <= 18)
            {
                Console.WriteLine("Still A Kid");
            }
            else if (age > 18 && age < 25)
            {
                Console.WriteLine("You be adult");
            }
            else if (age >= 25 && age <= 50)
            {
                Console.WriteLine("Car cheap rent");
            }
            else
            {
                Console.WriteLine("You be wise?");
            }

        }
    }
}
