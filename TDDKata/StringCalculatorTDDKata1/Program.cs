using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDDKata1
{
    public class StringCalculator
    {
        static void Main(string[] args)
        {
        }

        public int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            var sNumbers = input.Split(',');
            int result;
            try
            {
                result = sNumbers.Select(int.Parse).Sum();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                return 0;
            }

            return result;
        }
    }
}
