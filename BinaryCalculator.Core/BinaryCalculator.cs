using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator.Core
{
    public class BinaryCalculator
    {
        private IBinaryConverter binaryConverter;
        private ILogger logger;

        public BinaryCalculator(IBinaryConverter binaryConverter, ILogger logger)
        {
            this.binaryConverter = binaryConverter;
            this.logger = logger;
        }

        public int Add(string binaryNumber1, string binaryNumber2)
        {
            int decimalNumber1 = binaryConverter.ConvertToDecimalNumber(binaryNumber1);
            int decimalNumber2 = binaryConverter.ConvertToDecimalNumber(binaryNumber2);
            int result = decimalNumber1 + decimalNumber2;
            logger.Log(String.Format("{0} + {1} = {2}", binaryNumber1, binaryNumber2, result));
            return result;
        }
    }
}
