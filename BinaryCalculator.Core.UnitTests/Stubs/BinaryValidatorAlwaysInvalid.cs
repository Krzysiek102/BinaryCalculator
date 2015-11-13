using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator.Core.UnitTests.Stubs
{
    class BinaryValidatorAlwaysInvalid : IBinaryValidator
    {
        public bool IsValidBinaryNumber(string binaryNumber)
        {
            return false;
        }
    }
}
