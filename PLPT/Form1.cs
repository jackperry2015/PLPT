using PLPT.Calculations;
using PLPT.DatabaseAccess;
using PLPT.Models;
using PLPT.Validation;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PLPT
{
    public partial class Form1 : Form
    {
        //TODO: Login Functionality (Temp variables for user model until then)
        public string exampleUsername = "TestUser";
        public bool IsMale = false;

        // Functionality class objects
        private readonly Lifts_Table_Gateway _liftsGateway = new Lifts_Table_Gateway();
        private readonly WilksCoefficient _wilksCalculator = new WilksCoefficient();
        private readonly LiftsCalculations _liftsCalculator = new LiftsCalculations();
        private readonly ChartBuilder _charting = new ChartBuilder();
        private readonly NewEntryValidation _newEntryValidation = new NewEntryValidation();

        // Holds all of the users lifts
        public Lifts[] allLifts;

        // Form initialize
        public Form1()
        {
            InitializeComponent();
            InitializeTxtBoxWaterMarks();
            datepicker_NewEntry.Value = DateTime.Today;
            allLifts = _liftsGateway.GetAllLiftsForAUser(exampleUsername);
        }

        #region Form1:: New entry functionality
        // Checks if entry is valid -> inserts new lifts to database

        private void btn_SetNewEntry_Click(object sender, EventArgs e)
        {
            if (CheckNewEntryIsValid())
            {
                _liftsGateway.InsertNewLifts(GetNewLiftsEntry(exampleUsername, IsMale));
                allLifts = _liftsGateway.GetAllLiftsForAUser(exampleUsername);
                ClearEntryForm();
            }
            else pic_NewEntryError.Visible = true;
        }

        private Lifts GetNewLiftsEntry(string username, bool isMale)
        {
            // Get values from form into variables
            var Squat = Int32.Parse(txtbox_SquatNewEntry.Text);
            var Bench = Int32.Parse(txtbox_BenchNewEntry.Text);
            var Deadlift = Int32.Parse(txtbox_DeadliftNewEntry.Text);
            var Bodyweight = Int32.Parse(txtbox_BodyweightEntry.Text);
            var Total = Squat + Bench + Deadlift;
            var Wilks = _wilksCalculator.CalculateCoefficient(Total, Bodyweight, isMale);

            // Make new lifts object
            var lifts = new Lifts(username, datepicker_NewEntry.Value.Date,
                Squat, Bench, Deadlift, Bodyweight, Total, Wilks);

            return lifts;
        }

        #endregion Form1:: New entry functionality

        #region Form1:: Best lifts functionality
        // Displays users current best lifts - within their requested data range

        private void btn_CurrentBestDate_Click(object sender, EventArgs e)
        {
            // Gets requested date range from list box
            string dateRange = ListBox_DateRangeForCurrent.GetItemText
                (ListBox_DateRangeForCurrent.SelectedItem);

            BestLifts bestLifts = _liftsCalculator.Get_Lifts_BestLifts(allLifts, dateRange);

            lbl_SquatCurrent.Text = bestLifts.Squat.ToString();
            lbl_BenchCurrent.Text = bestLifts.Bench.ToString();
            lbl_DeadliftCurrent.Text = bestLifts.Deadlift.ToString();
            lbl_TotalCurrent.Text = bestLifts.Total.ToString();
            lbl_WilksCurrent.Text = bestLifts.Wilks.ToString();
        }

        #endregion Form1:: Current best lifts functionality

        #region Form1:: Chart Series Building
        // Build all series' requested by user to display on the chart
        private void btn_LoadGraph_Click(object sender, EventArgs e)
        {
            Series[] allSeries =
                _charting.Get_SeriesData_ForChart(checkBoxList_ValueToDisplay, allLifts);

            chart1.Series.Clear();

            foreach (Series series in allSeries)
            {
                series.BorderWidth = 3;
                series.MarkerStyle = MarkerStyle.Circle;
                series.MarkerBorderWidth = 3;
                series.MarkerColor = Color.Red;

                chart1.Series.Add(series);
            }
        }

        #endregion Form1:: Handles button to load data into chart

        #region Form1:: TextBox Watermark Handler
        // Textbox watermark functionality handler
        private void txtbox_SquatNewEntry_Leave(object sender, EventArgs e)
        {
            if (txtbox_SquatNewEntry.Text.Length == 0)
            {
                txtbox_SquatNewEntry.Text = "Squat (KG)";
                txtbox_SquatNewEntry.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtbox_BenchNewEntry_Leave(object sender, EventArgs e)
        {
            if (txtbox_BenchNewEntry.Text.Length == 0)
            {
                txtbox_BenchNewEntry.Text = "Bench (KG)";
                txtbox_BenchNewEntry.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtbox_DeadliftNewEntry_Leave(object sender, EventArgs e)
        {
            if (txtbox_DeadliftNewEntry.Text.Length == 0)
            {
                txtbox_DeadliftNewEntry.Text = "Deadlift (KG)";
                txtbox_DeadliftNewEntry.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtbox_BodyweightEntry_Leave(object sender, EventArgs e)
        {
            if (txtbox_BodyweightEntry.Text.Length == 0)
            {
                txtbox_BodyweightEntry.Text = "Bodyweight (KG)";
                txtbox_BodyweightEntry.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtbox_SquatNewEntry_Enter(object sender, EventArgs e)
        {
            if (txtbox_SquatNewEntry.Text == "Squat (KG)")
            {
                txtbox_SquatNewEntry.Text = "";
                txtbox_SquatNewEntry.ForeColor = Color.White;
            }
        }

        private void txtbox_BenchNewEntry_Enter(object sender, EventArgs e)
        {
            if (txtbox_BenchNewEntry.Text == "Bench (KG)")
            {
                txtbox_BenchNewEntry.Text = "";
                txtbox_BenchNewEntry.ForeColor = Color.White;
            }
        }

        private void txtbox_DeadliftNewEntry_Enter(object sender, EventArgs e)
        {
            if (txtbox_DeadliftNewEntry.Text == "Deadlift (KG)")
            {
                txtbox_DeadliftNewEntry.Text = "";
                txtbox_DeadliftNewEntry.ForeColor = Color.White;
            }
        }

        private void txtbox_BodyweightEntry_Enter(object sender, EventArgs e)
        {
            if (txtbox_BodyweightEntry.Text == "Bodyweight (KG)")
            {
                txtbox_BodyweightEntry.Text = "";
                txtbox_BodyweightEntry.ForeColor = Color.White;
            }
        }

        #endregion Form1:: TextBox Watermark Handling

        #region Form1:: Form Maximise and Minimise functionality

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion Form1:: Maximise and Minimise the form

        #region Form1:: Validate new entry
        // Checks values in new entry inputs are valid
        private bool CheckNewEntryIsValid()
        {
            if (!_newEntryValidation.NewEntryDateChecker(datepicker_NewEntry.Value))
            {
                lbl_NewEntryError.Text = "Enter Valid Date!";
                return false;
            }
            if (!_newEntryValidation.NewEntryIntChecker(txtbox_SquatNewEntry.Text))
            {
                lbl_NewEntryError.Text = "Enter Squat Correctly!";
                return false;
            }
            if (!_newEntryValidation.NewEntryIntChecker(txtbox_BenchNewEntry.Text))
            {
                lbl_NewEntryError.Text = "Enter Bench Correctly!";
                return false;
            }
            if (!_newEntryValidation.NewEntryIntChecker(txtbox_DeadliftNewEntry.Text))
            {
                lbl_NewEntryError.Text = "Enter Deadlift Correctly!";
                return false;
            }
            if (!_newEntryValidation.NewEntryIntChecker(txtbox_BodyweightEntry.Text))
            {
                lbl_NewEntryError.Text = "Enter Bodyweight Correctly!";
                return false;
            }
            pic_NewEntryError.Visible = false;
            lbl_NewEntryError.Text = "Success!";
            return true;
        }

        #endregion Form1:: Validate new entry

        #region Form1:: Clear entry form for new entry
        // Clears entry form preparing it for a new entry
        private void ClearEntryForm()
        {
            datepicker_NewEntry.Value = DateTime.Today;
            txtbox_SquatNewEntry.Text = "";
            txtbox_BenchNewEntry.Text = "";
            txtbox_DeadliftNewEntry.Text = "";
            txtbox_BodyweightEntry.Text = "";
        }

        #endregion Form1:: Clear entry form for new entry

        #region Form1:: Initialize txtbox for watermarks
        // Loads in watermarks for textboxes upon form initialization
        private void InitializeTxtBoxWaterMarks()
        {
            txtbox_SquatNewEntry.ForeColor = SystemColors.GrayText;
            txtbox_BenchNewEntry.ForeColor = SystemColors.GrayText;
            txtbox_DeadliftNewEntry.ForeColor = SystemColors.GrayText;
            txtbox_BodyweightEntry.ForeColor = SystemColors.GrayText;

            txtbox_SquatNewEntry.Enter += new System.EventHandler(txtbox_SquatNewEntry_Enter);
            txtbox_BenchNewEntry.Enter += new System.EventHandler(txtbox_BenchNewEntry_Enter);
            txtbox_DeadliftNewEntry.Enter += new System.EventHandler(txtbox_DeadliftNewEntry_Enter);
            txtbox_BodyweightEntry.Enter += new System.EventHandler(txtbox_BodyweightEntry_Enter);

            txtbox_SquatNewEntry.Leave += new System.EventHandler(txtbox_SquatNewEntry_Leave);
            txtbox_BenchNewEntry.Leave += new System.EventHandler(txtbox_BenchNewEntry_Leave);
            txtbox_DeadliftNewEntry.Leave += new System.EventHandler(txtbox_DeadliftNewEntry_Leave);
            txtbox_BodyweightEntry.Leave += new System.EventHandler(txtbox_BodyweightEntry_Leave);
        }

        #endregion Form1:: Initialize txtbox for watermarks
    }
}