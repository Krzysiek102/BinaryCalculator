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
    public class BinaryCalculatorTests
    {
        BinaryValidator binaryValidator;
        BinaryConverter binaryConverter;

        [SetUp]
        public void Init()
        {
            binaryValidator = new BinaryValidator();
            binaryConverter = new BinaryConverter(binaryValidator);
        }

        [Test]
        public void AddOneAndTwoShouldReturnThree()
        {
            ILogger logger = new Logger();
            BinaryCalculator binaryCalculator = new BinaryCalculator(binaryConverter, logger);

            int result = binaryCalculator.Add("1", "10");
            Assert.That(result == 3);
        }

        [Test]
        public void LoggingWasCalledForAddOperation()
        {
            ILogger logger = MockRepository.GenerateMock<ILogger>();

            BinaryCalculator binaryCalculator = new BinaryCalculator(binaryConverter, logger);
            int result = binaryCalculator.Add("1", "10");

            logger.AssertWasCalled(x => x.Log(Arg<string>.Is.Anything));
        }

    }
}
