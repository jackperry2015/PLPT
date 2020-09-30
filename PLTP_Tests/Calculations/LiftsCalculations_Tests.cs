using NUnit.Framework;
using PLPT.Calculations;
using PLPT.Models;
using PLTP_Tests.TestData;

namespace PLTP_Tests.Calculations
{
    [TestFixture]
    public class LiftsCalculations_Tests
    {
        // SUT
        private LiftsCalculations _liftsCalculations;

        // Test Data Generation Class
        Lifts_Tests_Data _lifts_Tests_Data;

        [OneTimeSetUp]
        public void SetUp()
        {
            _liftsCalculations = new LiftsCalculations();
            _lifts_Tests_Data = new Lifts_Tests_Data();
        }

        [TestCase(0, 0)]
        [TestCase(7, 1)]
        [TestCase(30, 2)]
        [TestCase(365, 3)]
        public void GetLiftsAfterDate_Returns_LiftsAfterSpecifiedDate(int pastNofDays, int expectedResult)
        {
            Lifts[] testLifts = _lifts_Tests_Data.GenerateLiftsArray();

            Assert.That(_liftsCalculations.
                Get_Lifts_AfterDate(testLifts, pastNofDays).Length, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetLiftsBestLifts_Returns_BestLifts()
        {
            Lifts[] testLifts = _lifts_Tests_Data.GenerateLiftsArray();
            BestLifts[] expectedResults = _lifts_Tests_Data.GenerateBestLiftsArray();

            // Just testing the resulting totals
            Assert.That(_liftsCalculations.Get_Lifts_BestLifts(testLifts, "Past Week").Total == expectedResults[0].Total);
            Assert.That(_liftsCalculations.Get_Lifts_BestLifts(testLifts, "Past Month").Total ==  expectedResults[1].Total);
            Assert.That(_liftsCalculations.Get_Lifts_BestLifts(testLifts, "All Time").Total == expectedResults[2].Total);
        }
    }
}
