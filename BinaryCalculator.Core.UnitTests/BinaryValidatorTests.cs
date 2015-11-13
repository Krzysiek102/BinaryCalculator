using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator.Core.UnitTests
{
    [TestFixture]
    public class BinaryValidatorTests
    {
        [Test]
        public void EmptyParameterIsNotValid()
        {
            BinaryValidator binaryValidator = new BinaryValidator();
            bool valid =  binaryValidator.IsValidBinaryNumber(String.Empty);
            Assert.IsFalse(valid);
        }
    }
}
