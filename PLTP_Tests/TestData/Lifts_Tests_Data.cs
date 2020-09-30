using PLPT.Models;
using System;
using System.Collections.Generic;

namespace PLTP_Tests.TestData
{
    public class Lifts_Tests_Data
    {
        public Lifts[] GenerateLiftsArray()
        {
            List<Lifts> lifts = new List<Lifts>
            {
                // Past Week Test
                new Lifts("testUsername",
                    DateTime.Now.AddDays(-6),
                    100, 100, 100, 100, 300, 300),
                // Past Month Test
                new Lifts("testUsername",
                    DateTime.Now.AddDays(-29),
                    200, 200, 200, 200, 600, 600),
                // All Time Test
                new Lifts("testUsername",
                    DateTime.Now.AddDays(-60),
                    400, 400, 400, 400, 1200, 1200)
            };
            return lifts.ToArray();
        }

        public BestLifts[] GenerateBestLiftsArray()
        {
            List<BestLifts> bestLifts = new List<BestLifts>
            {
                // Past Week Test
                new BestLifts(
                    100, 100, 100, 300, 300),
                // Past Month Test
                new BestLifts(
                    200, 200, 200, 600, 600),
                // All Time Test
                new BestLifts(
                    400, 400, 400, 1200, 1200)
            };
            return bestLifts.ToArray();
        }
    }
}
