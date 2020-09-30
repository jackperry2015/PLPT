using NUnit.Framework;
using PLPT;

namespace PLTP_Tests.Calculations
{
    [TestFixture]
    public class WilksCoefficient_Tests
    {
        // SUT
        private WilksCoefficient _wilksCoefficient;

        [OneTimeSetUp]
        public void SetUp()
        {
            _wilksCoefficient = new WilksCoefficient();
        }

        [TestCase(700, 100, 427)]
        [TestCase(150, 70, 113)]
        [TestCase(1200, 99, 734)]
        public void CalculateCoefficient_PersonIsMale_ReturnsWilksForMale(int total, int bodyweight, int expectedResult)
        {
            int result = _wilksCoefficient.CalculateCoefficient(total, bodyweight, true);
            Assert.That(result == expectedResult);
        }
    }
}
