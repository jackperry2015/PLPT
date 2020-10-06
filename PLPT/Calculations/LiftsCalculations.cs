using PLPT.Models;
using System;
using System.Linq;

namespace PLPT.Calculations
{
    public class LiftsCalculations
    {
        // Get all lifts entered by a user after a specified date
        public Lifts[] Get_Lifts_AfterDate(Lifts[] lifts, int Days)
        {
            var datePastDays = DateTime.Now.AddDays(-Days);

            return lifts.Where(lift => lift.Date > datePastDays).ToArray();
        }

        // Get all best lifts within an array of Lifts given dateRange
        public BestLifts Get_Lifts_BestLifts(Lifts[] lifts, string dateRange)
        {
            Lifts[] liftsInSelectedDateRange = null;

            switch (dateRange)
            {
                case "Past Week":
                    liftsInSelectedDateRange = Get_Lifts_AfterDate(lifts, 7);
                    break;
                case "Past Month":
                    liftsInSelectedDateRange = Get_Lifts_AfterDate(lifts, 30);
                    break;
                case "All Time":
                    liftsInSelectedDateRange = lifts;
                    break;
            }

            return new BestLifts(
                liftsInSelectedDateRange.Max(x => x.Squat),
                liftsInSelectedDateRange.Max(x => x.Bench),
                liftsInSelectedDateRange.Max(x => x.Deadlift),
                liftsInSelectedDateRange.Max(x => x.Total),
                liftsInSelectedDateRange.Max(x => x.Wilks)
            );
        }
    }
}
