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

        public int Add(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
            {
                return 0;
            }
            throw new NotImplementedException();
        }
    }
}
