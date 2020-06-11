using PLPT.DatabaseAccess;
using PLPT.Models;
using System;
using System.Windows.Forms;

namespace PLPT
{
    public partial class Form1 : Form
    {
        // Testing Variables
        public string exampleUsername = "TestUser";
        public bool IsMale = false;
        // END Testing Variables

        readonly Lifts_Table_Gateway liftsGateway = new Lifts_Table_Gateway();
        readonly WilksCoefficient WilksCalculator = new WilksCoefficient();
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_SetNewEntry_Click(object sender, EventArgs e)
        {
            liftsGateway.InsertNewLifts(GetNewLiftsEntry(exampleUsername, IsMale));
        }

        private Lifts GetNewLiftsEntry(string username, bool isMale)
        {
            // Get values from form into variables
            int Squat = Int32.Parse(txtbox_SquatNewEntry.Text);
            int Bench = Int32.Parse(txtbox_BenchNewEntry.Text);
            int Deadlift = Int32.Parse(txtbox_DeadliftNewEntry.Text);
            int Bodyweight = Int32.Parse(txtbox_BodyweightEntry.Text);
            int Total = Squat + Bench + Deadlift;
            int Wilks = WilksCalculator.CalculateCoefficient(Total, Bodyweight, isMale);

            // Make new lifts object
            Lifts lifts = new Lifts(username, datepicker_NewEntry.Value.Date,
                Squat, Bench, Deadlift, Bodyweight, Total, Wilks);

            return lifts;
        }
    }
}
