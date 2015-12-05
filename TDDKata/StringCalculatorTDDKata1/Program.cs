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
            foreach (var sNum in sNumbers)
            {
                int parsedNumber;
                if (!int.TryParse(sNum, out parsedNumber))
                {
                    decimal parsedDecimal;
                    if (!decimal.TryParse(sNum, out parsedDecimal))
                    {
                        return 0;
                    }
                    parsedNumber = decimal.ToInt32(parsedDecimal);
                }

                result += parsedNumber;
            }

            return result;
        }
    }
}
