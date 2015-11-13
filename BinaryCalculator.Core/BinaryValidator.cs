using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BinaryCalculator.Core
{
    public class BinaryValidator : IBinaryValidator
    {
        public bool IsValidBinaryNumber(string binaryNumber)
        {
            return Regex.IsMatch(binaryNumber, "[01]+");
        }
    }
}
