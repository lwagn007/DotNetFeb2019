using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_RepositoryPattern
{
    public class CalculatorRepository
    {
        public int AddTwoNumbers(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public int SubtractTwoNumbers(int hello, int world)
        {
            int goolash = world - hello;
            return goolash;
        }

        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberTwo * numberOne;
            return result;
        }

        public int DivideTwoNumbers(int biggerNumber, int smallerNumber)
        {
            int dividend = biggerNumber / smallerNumber;
            return dividend;
        }

        public int RemainderOperator(int biggerNumber, int smallerNumber)
        {
            int remainder = biggerNumber % smallerNumber;
            return remainder;
        }
    }
}
