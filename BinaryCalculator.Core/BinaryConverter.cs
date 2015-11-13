using System;
using System.Text.RegularExpressions;

namespace BinaryCalculator.Core
{
    public class BinaryConverter : IBinaryConverter
    {
        private IBinaryValidator binaryValidator;

        public BinaryConverter(IBinaryValidator binaryValidator)
        {
            this.binaryValidator = binaryValidator;
        }

        /// <summary>
        /// Converts binary number to decimal number
        /// </summary>
        /// <param name="binaryNumber">Binary number</param>
        /// <exception cref="System.ArgumentException"> Thrown when provided number is not binary</exception>
        /// <returns>Decimal number</returns>
        public int ConvertToDecimalNumber(string binaryNumber)
        {
            bool valid = binaryValidator.IsValidBinaryNumber(binaryNumber);
            if (!valid)
            {
                throw new ArgumentException("Provided parameter is not a binary number");
            }
            return Convert.ToInt32(binaryNumber, 2);
        }
    }
}