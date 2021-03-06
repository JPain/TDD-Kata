﻿using System;
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

            var stringSeparators = new List<String> { ",", "\n"};

            if (input.Length > 5)
            {
                if (input.Substring(0, 2) == "//")
                {
                    var delimiter = input.Substring(2, input.IndexOf('\n') - 2);

                    if (!string.IsNullOrEmpty(delimiter))
                    {
                        stringSeparators.Add(delimiter);
                    }

                    input = input.Substring(input.IndexOf('\n') + 1);
                }
            }
            var sNumbers = input.Split(stringSeparators.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            
            var result = 0;

            foreach (var sNumber in sNumbers)
            {
                int parsedNumber;
                decimal parsedDecimal;
                if (int.TryParse(sNumber, out parsedNumber))
                {
                    result += parsedNumber;
                }
                else if (decimal.TryParse(sNumber, out parsedDecimal))
                {
                    result += decimal.ToInt32(parsedDecimal);
                }
                else
                {
                    return 0;
                }
            }

            return result;
        }
    }
}
