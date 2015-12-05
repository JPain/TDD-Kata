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

            var result = 0;

            foreach (var sNumber in sNumbers)
            {
                int parsedNumber;
                if (int.TryParse(sNumber, out parsedNumber))
                {
                    result += parsedNumber;
                    continue;
                }

                decimal parsedDecimal;
                if (decimal.TryParse(sNumber, out parsedDecimal))
                {
                    result += decimal.ToInt32(parsedDecimal);
                    continue;
                }
            }

            return result;
        }
    }
}
