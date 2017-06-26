using System;
using HomeHeatingCalc;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class CalculateCostShould
    {
        [Test]
        public void Given1500AndMild_Return52Point74()
        {
            var result = Program.CalculateCost(1500, 'M');
            Assert.AreEqual(52.74m, result);
        }

        [Test]
        public void Given2500AndMild_Return87Point9()
        {
            var result = Program.CalculateCost(2500, 'M');
            Assert.AreEqual(87.9m, result);
        }
    }
}
