using PLPT.Models;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PLPT
{
    // Responsible for preparing the chart series'
    public class ChartBuilder
    {
        // Holds all of the users lifts
        public Series[] allSeries;

        #region Chart builder based on users choses options to display
        // Returns array of series given series' chosen by user and array of users lifts
        public Series[] Get_SeriesData_ForChart(CheckedListBox optionsChosen, Lifts[] allLifts)
        {
            allSeries = new Series[optionsChosen.CheckedItems.Count];
            Generate_EmptySeries(optionsChosen);
            Fill_EmptySeries_WithLifts(allLifts, optionsChosen);
            return allSeries;
        }

        // Method to pre-generate series with no data depending on options chosen
        private void Generate_EmptySeries(CheckedListBox optionsChosen)
        {
            int i = 0;
            foreach(string item in optionsChosen.CheckedItems)
            {
                Series newSeries = new Series();
                newSeries.ChartType = SeriesChartType.Line;

                newSeries.Name = item;
                allSeries[i] = newSeries;
                i++;
            }
        }

        // Given users lifts and users chosen options, populates series' for those options
        private void Fill_EmptySeries_WithLifts(Lifts[] allLifts, CheckedListBox optionsChosen)
        {
            foreach(Lifts lift in allLifts)
            {
                foreach (Series series in allSeries)
                {
                    if (series.Name == "Squat") series.Points.AddXY(lift.Date, lift.Squat);
                    if (series.Name == "Bench") series.Points.AddXY(lift.Date, lift.Bench);
                    if (series.Name == "Deadlift") series.Points.AddXY(lift.Date, lift.Deadlift);
                    if (series.Name == "Bodyweight") series.Points.AddXY(lift.Date, lift.Bodyweight);
                    if (series.Name == "Total") series.Points.AddXY(lift.Date, lift.Total);
                    if (series.Name == "Wilks") series.Points.AddXY(lift.Date, lift.Wilks);
                }
            }
        }
        #endregion
    }
}
