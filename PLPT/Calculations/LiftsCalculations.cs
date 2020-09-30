using PLPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PLPT.Calculations
{
    public class LiftsCalculations
    {
        // Get all lifts entered by a user after a specified date
        public Lifts[] Get_Lifts_AfterDate(Lifts[] lifts, int Days)
        {
            List<Lifts> liftsPastDays = new List<Lifts>();
            DateTime datePastDays = DateTime.Now.AddDays(-Days);

            foreach(Lifts lift in lifts)
            {
                if(lift.Date > datePastDays) liftsPastDays.Add(lift);
            }
            return liftsPastDays.ToArray();
        }

        // Get all best lifts within an array of Lifts given dateRange
        public BestLifts Get_Lifts_BestLifts(Lifts[] lifts, string dateRange)
        {
            Lifts[] liftsInSelectedDateRange = null;

            if (dateRange == "Past Week") liftsInSelectedDateRange = Get_Lifts_AfterDate(lifts, 7);
            if (dateRange == "Past Month") liftsInSelectedDateRange = Get_Lifts_AfterDate(lifts, 30);
            if (dateRange == "All Time") liftsInSelectedDateRange = lifts;

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
