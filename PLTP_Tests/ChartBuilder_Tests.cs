using NUnit.Framework;
using PLPT;

namespace PLTP_Tests
{
    [TestFixture]
    public class ChartBuilder_Tests
    {
        ChartBuilder chartBuilder;
        [SetUp]
        public void Setup()
        {
            chartBuilder = new ChartBuilder();
        }



        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}