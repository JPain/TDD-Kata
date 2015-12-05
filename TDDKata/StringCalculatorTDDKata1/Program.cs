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
                int theThing;
                if (!int.TryParse(sNum, out theThing))
                    return 0;

                result += theThing;
            }

            return result;
        }
    }
}
