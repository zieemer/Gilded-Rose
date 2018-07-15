using Gilded.Rose.Services.Validators;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Gilded.Rose.Tests.Validators
{
    [TestFixture]
    public class ValidatorTests
    {

        [Test]
        public void ShouldValidatorNotAllowQualityGreaterThenFifty()
        {
            var sut = new QualityValidator();

            var result = sut.ValidateQuality(100);

            Assert.AreEqual(50, result);
        }

        [Test]
        public void ShouldValidatorNotAllowQualitySamllerThenZero()
        {
            var sut = new QualityValidator();

            var result = sut.ValidateQuality(-1);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void ShouldValidatorReturnSameValueifQulaityInRange()
        {
            var sut = new QualityValidator();

            var result = sut.ValidateQuality(22);

            Assert.AreEqual(22, result);
        }
    }
}
