using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_RepositoryPatternV2
{
    public class CalculatorRepository
    {
        public decimal AddTwoNumbers(decimal a, decimal b) => a + b;

        public int AddTwoNumbersByInt(int a, int b) => a + b;

        public decimal AddMultipleNumbers(decimal[] inputs)
        {
            decimal result = 0;
            foreach (decimal i in inputs)
                result += i;
            return result;
        }

        public decimal SubtractTwoNumbers(decimal a, decimal b) => a - b;

        public decimal MultiplyTwoNumbers(decimal a, decimal b) => a * b;

        public decimal DivideTwoNumbers(decimal a, decimal b) => a / b;

        public decimal GetRemainder(decimal a, decimal b) => a % b;

        public decimal Square(decimal a) => a * a;
    }
}
