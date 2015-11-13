using BinaryCalculator.Core.UnitTests.Stubs;
using NUnit.Framework;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator.Core.UnitTests
{
    [TestFixture]
    public class BinaryConverterTests
    {
        [Test]
        public void ConvertOne()
        {
            BinaryValidator binaryValidator = new BinaryValidator();
            BinaryConverter binaryConverter = new BinaryConverter(binaryValidator);
            int convertedValue = binaryConverter.ConvertToDecimalNumber("1");
            Assert.That(convertedValue == 1);
        }

        [Test]
        public void ThrowsArgumentExceptionWhenParameterIsNotBinaryNumber()
        {
            IBinaryValidator binaryValidator = new BinaryValidatorAlwaysInvalid();
            BinaryConverter binaryConverter = new BinaryConverter(binaryValidator);
            Assert.Throws<ArgumentException>(
                () => binaryConverter.ConvertToDecimalNumber("a")
                );
        }

        [Test]
        public void ThrowsArgumentExceptionWhenParameterIsNotBinaryNumberVersionWithRhinoMocks()
        {
            IBinaryValidator binaryValidator = MockRepository.GenerateStub<IBinaryValidator>();
            binaryValidator.Stub(x => x.IsValidBinaryNumber(Arg<string>.Is.Anything))
                .Return(false);

            BinaryConverter binaryConverter = new BinaryConverter(binaryValidator);
            Assert.Throws<ArgumentException>(
                () => binaryConverter.ConvertToDecimalNumber("a")
                );
        }

        
        [TestCase("0", 0)]
        [TestCase("10", 2)]
        public void ConvertNumberShouldSucceed(string binaryNumber, int result)
        {
            BinaryValidator binaryValidator = new BinaryValidator();
            BinaryConverter binaryConverter = new BinaryConverter(binaryValidator);
            int convertedValue = binaryConverter.ConvertToDecimalNumber(binaryNumber);
            Assert.That(convertedValue == result);
        }
    }
}
