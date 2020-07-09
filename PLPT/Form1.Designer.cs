using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace PLPT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_SquatNewEntry = new System.Windows.Forms.TextBox();
            this.txtbox_DeadliftNewEntry = new System.Windows.Forms.TextBox();
            this.txtbox_BenchNewEntry = new System.Windows.Forms.TextBox();
            this.txtbox_BodyweightEntry = new System.Windows.Forms.TextBox();
            this.btn_SetNewEntry = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_VisualiseTitle = new System.Windows.Forms.Label();
            this.btn_LoadGraph = new System.Windows.Forms.Button();
            this.lbl_CurrentTitle = new System.Windows.Forms.Label();
            this.ListBox_DateRangeForCurrent = new System.Windows.Forms.ListBox();
            this.lbl_SquatCurrent = new System.Windows.Forms.Label();
            this.lbl_TotalCurrent = new System.Windows.Forms.Label();
            this.lbl_DeadliftCurrent = new System.Windows.Forms.Label();
            this.lbl_BenchCurrent = new System.Windows.Forms.Label();
            this.datepicker_NewEntry = new System.Windows.Forms.DateTimePicker();
            this.lbl_WilksCurrent = new System.Windows.Forms.Label();
            this.btn_CurrentBestDate = new System.Windows.Forms.Button();
            this.checkBoxList_ValueToDisplay = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_NewEntryError = new System.Windows.Forms.Label();
            this.pic_NewEntryError = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_DateIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NewEntryError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_DateIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "__New Entry__";
            // 
            // txtbox_SquatNewEntry
            // 
            this.txtbox_SquatNewEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            this.txtbox_SquatNewEntry.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_SquatNewEntry.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_SquatNewEntry.Location = new System.Drawing.Point(53, 101);
            this.txtbox_SquatNewEntry.Name = "txtbox_SquatNewEntry";
            this.txtbox_SquatNewEntry.Size = new System.Drawing.Size(158, 28);
            this.txtbox_SquatNewEntry.TabIndex = 2;
            this.txtbox_SquatNewEntry.Text = "Squat (KG)";
            // 
            // txtbox_DeadliftNewEntry
            // 
            this.txtbox_DeadliftNewEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            this.txtbox_DeadliftNewEntry.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_DeadliftNewEntry.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_DeadliftNewEntry.Location = new System.Drawing.Point(53, 187);
            this.txtbox_DeadliftNewEntry.Name = "txtbox_DeadliftNewEntry";
            this.txtbox_DeadliftNewEntry.Size = new System.Drawing.Size(158, 28);
            this.txtbox_DeadliftNewEntry.TabIndex = 3;
            this.txtbox_DeadliftNewEntry.Text = "Deadlift (KG)";
            // 
            // txtbox_BenchNewEntry
            // 
            this.txtbox_BenchNewEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            this.txtbox_BenchNewEntry.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_BenchNewEntry.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_BenchNewEntry.Location = new System.Drawing.Point(53, 144);
            this.txtbox_BenchNewEntry.Name = "txtbox_BenchNewEntry";
            this.txtbox_BenchNewEntry.Size = new System.Drawing.Size(158, 28);
            this.txtbox_BenchNewEntry.TabIndex = 4;
            this.txtbox_BenchNewEntry.Text = "Bench (KG)";
            // 
            // txtbox_BodyweightEntry
            // 
            this.txtbox_BodyweightEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            this.txtbox_BodyweightEntry.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_BodyweightEntry.ForeColor = System.Drawing.Color.Gray;
            this.txtbox_BodyweightEntry.Location = new System.Drawing.Point(53, 231);
            this.txtbox_BodyweightEntry.Name = "txtbox_BodyweightEntry";
            this.txtbox_BodyweightEntry.Size = new System.Drawing.Size(158, 28);
            this.txtbox_BodyweightEntry.TabIndex = 5;
            this.txtbox_BodyweightEntry.Text = "Bodyweight (KG)";
            // 
            // btn_SetNewEntry
            // 
            this.btn_SetNewEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(23)))), ((int)(((byte)(246)))));
            this.btn_SetNewEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SetNewEntry.FlatAppearance.BorderSize = 0;
            this.btn_SetNewEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetNewEntry.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetNewEntry.ForeColor = System.Drawing.Color.White;
            this.btn_SetNewEntry.Location = new System.Drawing.Point(18, 307);
            this.btn_SetNewEntry.Name = "btn_SetNewEntry";
            this.btn_SetNewEntry.Size = new System.Drawing.Size(192, 30);
            this.btn_SetNewEntry.TabIndex = 6;
            this.btn_SetNewEntry.Text = ">      Submit";
            this.btn_SetNewEntry.UseVisualStyleBackColor = false;
            this.btn_SetNewEntry.Click += new System.EventHandler(this.btn_SetNewEntry_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 3;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisX2.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisY2.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            legend2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            legend2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(234, 27);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 2;
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(962, 571);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // lbl_VisualiseTitle
            // 
            this.lbl_VisualiseTitle.AutoSize = true;
            this.lbl_VisualiseTitle.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VisualiseTitle.Location = new System.Drawing.Point(1005, 376);
            this.lbl_VisualiseTitle.Name = "lbl_VisualiseTitle";
            this.lbl_VisualiseTitle.Size = new System.Drawing.Size(151, 21);
            this.lbl_VisualiseTitle.TabIndex = 10;
            this.lbl_VisualiseTitle.Text = "View on Graph";
            // 
            // btn_LoadGraph
            // 
            this.btn_LoadGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(23)))), ((int)(((byte)(246)))));
            this.btn_LoadGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadGraph.FlatAppearance.BorderSize = 0;
            this.btn_LoadGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadGraph.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadGraph.ForeColor = System.Drawing.Color.White;
            this.btn_LoadGraph.Location = new System.Drawing.Point(1009, 497);
            this.btn_LoadGraph.Name = "btn_LoadGraph";
            this.btn_LoadGraph.Size = new System.Drawing.Size(147, 33);
            this.btn_LoadGraph.TabIndex = 12;
            this.btn_LoadGraph.Text = ">    View";
            this.btn_LoadGraph.UseVisualStyleBackColor = false;
            this.btn_LoadGraph.Click += new System.EventHandler(this.btn_LoadGraph_Click);
            // 
            // lbl_CurrentTitle
            // 
            this.lbl_CurrentTitle.AutoSize = true;
            this.lbl_CurrentTitle.Font = new System.Drawing.Font("MS UI Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_CurrentTitle.Location = new System.Drawing.Point(12, 340);
            this.lbl_CurrentTitle.Name = "lbl_CurrentTitle";
            this.lbl_CurrentTitle.Size = new System.Drawing.Size(201, 33);
            this.lbl_CurrentTitle.TabIndex = 16;
            this.lbl_CurrentTitle.Text = "__Best Lifts__";
            this.lbl_CurrentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBox_DateRangeForCurrent
            // 
            this.ListBox_DateRangeForCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            this.ListBox_DateRangeForCurrent.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_DateRangeForCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            this.ListBox_DateRangeForCurrent.FormattingEnabled = true;
            this.ListBox_DateRangeForCurrent.ItemHeight = 15;
            this.ListBox_DateRangeForCurrent.Items.AddRange(new object[] {
            "Past Week",
            "Past Month",
            "All Time"});
            this.ListBox_DateRangeForCurrent.Location = new System.Drawing.Point(18, 376);
            this.ListBox_DateRangeForCurrent.Name = "ListBox_DateRangeForCurrent";
            this.ListBox_DateRangeForCurrent.Size = new System.Drawing.Size(110, 49);
            this.ListBox_DateRangeForCurrent.TabIndex = 17;
            // 
            // lbl_SquatCurrent
            // 
            this.lbl_SquatCurrent.AutoSize = true;
            this.lbl_SquatCurrent.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SquatCurrent.Location = new System.Drawing.Point(52, 434);
            this.lbl_SquatCurrent.Name = "lbl_SquatCurrent";
            this.lbl_SquatCurrent.Size = new System.Drawing.Size(22, 21);
            this.lbl_SquatCurrent.TabIndex = 18;
            this.lbl_SquatCurrent.Text = "0";
            // 
            // lbl_TotalCurrent
            // 
            this.lbl_TotalCurrent.AutoSize = true;
            this.lbl_TotalCurrent.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalCurrent.Location = new System.Drawing.Point(53, 536);
            this.lbl_TotalCurrent.Name = "lbl_TotalCurrent";
            this.lbl_TotalCurrent.Size = new System.Drawing.Size(22, 21);
            this.lbl_TotalCurrent.TabIndex = 20;
            this.lbl_TotalCurrent.Text = "0";
            // 
            // lbl_DeadliftCurrent
            // 
            this.lbl_DeadliftCurrent.AutoSize = true;
            this.lbl_DeadliftCurrent.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeadliftCurrent.Location = new System.Drawing.Point(53, 502);
            this.lbl_DeadliftCurrent.Name = "lbl_DeadliftCurrent";
            this.lbl_DeadliftCurrent.Size = new System.Drawing.Size(22, 21);
            this.lbl_DeadliftCurrent.TabIndex = 21;
            this.lbl_DeadliftCurrent.Text = "0";
            // 
            // lbl_BenchCurrent
            // 
            this.lbl_BenchCurrent.AutoSize = true;
            this.lbl_BenchCurrent.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BenchCurrent.Location = new System.Drawing.Point(52, 468);
            this.lbl_BenchCurrent.Name = "lbl_BenchCurrent";
            this.lbl_BenchCurrent.Size = new System.Drawing.Size(22, 21);
            this.lbl_BenchCurrent.TabIndex = 22;
            this.lbl_BenchCurrent.Text = "0";
            // 
            // datepicker_NewEntry
            // 
            this.datepicker_NewEntry.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            this.datepicker_NewEntry.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            this.datepicker_NewEntry.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            this.datepicker_NewEntry.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            this.datepicker_NewEntry.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            this.datepicker_NewEntry.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker_NewEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_NewEntry.Location = new System.Drawing.Point(53, 63);
            this.datepicker_NewEntry.MaxDate = new System.DateTime(2109, 12, 27, 0, 0, 0, 0);
            this.datepicker_NewEntry.MinDate = new System.DateTime(1919, 12, 25, 0, 0, 0, 0);
            this.datepicker_NewEntry.Name = "datepicker_NewEntry";
            this.datepicker_NewEntry.Size = new System.Drawing.Size(158, 28);
            this.datepicker_NewEntry.TabIndex = 0;
            this.datepicker_NewEntry.Value = new System.DateTime(2020, 6, 11, 20, 23, 58, 794);
            // 
            // lbl_WilksCurrent
            // 
            this.lbl_WilksCurrent.AutoSize = true;
            this.lbl_WilksCurrent.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WilksCurrent.Location = new System.Drawing.Point(54, 570);
            this.lbl_WilksCurrent.Name = "lbl_WilksCurrent";
            this.lbl_WilksCurrent.Size = new System.Drawing.Size(22, 21);
            this.lbl_WilksCurrent.TabIndex = 19;
            this.lbl_WilksCurrent.Text = "0";
            // 
            // btn_CurrentBestDate
            // 
            this.btn_CurrentBestDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(23)))), ((int)(((byte)(246)))));
            this.btn_CurrentBestDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CurrentBestDate.FlatAppearance.BorderSize = 0;
            this.btn_CurrentBestDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CurrentBestDate.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CurrentBestDate.ForeColor = System.Drawing.Color.White;
            this.btn_CurrentBestDate.Location = new System.Drawing.Point(135, 376);
            this.btn_CurrentBestDate.Name = "btn_CurrentBestDate";
            this.btn_CurrentBestDate.Size = new System.Drawing.Size(75, 49);
            this.btn_CurrentBestDate.TabIndex = 23;
            this.btn_CurrentBestDate.Text = "> Get";
            this.btn_CurrentBestDate.UseVisualStyleBackColor = false;
            this.btn_CurrentBestDate.Click += new System.EventHandler(this.btn_CurrentBestDate_Click);
            // 
            // checkBoxList_ValueToDisplay
            // 
            this.checkBoxList_ValueToDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            this.checkBoxList_ValueToDisplay.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxList_ValueToDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            this.checkBoxList_ValueToDisplay.FormattingEnabled = true;
            this.checkBoxList_ValueToDisplay.Items.AddRange(new object[] {
            "Squat",
            "Bench",
            "Deadlift",
            "Bodyweight",
            "Total",
            "Wilks"});
            this.checkBoxList_ValueToDisplay.Location = new System.Drawing.Point(1009, 410);
            this.checkBoxList_ValueToDisplay.Name = "checkBoxList_ValueToDisplay";
            this.checkBoxList_ValueToDisplay.Size = new System.Drawing.Size(147, 72);
            this.checkBoxList_ValueToDisplay.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "/Squat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "/Bench";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "/Deadlift";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "/Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "/Wilks";
            // 
            // lbl_NewEntryError
            // 
            this.lbl_NewEntryError.AutoSize = true;
            this.lbl_NewEntryError.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewEntryError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_NewEntryError.Location = new System.Drawing.Point(53, 266);
            this.lbl_NewEntryError.Name = "lbl_NewEntryError";
            this.lbl_NewEntryError.Size = new System.Drawing.Size(0, 13);
            this.lbl_NewEntryError.TabIndex = 43;
            // 
            // pic_NewEntryError
            // 
            this.pic_NewEntryError.BackgroundImage = global::PLPT.Properties.Resources.icons8_error_26;
            this.pic_NewEntryError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_NewEntryError.Location = new System.Drawing.Point(18, 266);
            this.pic_NewEntryError.Name = "pic_NewEntryError";
            this.pic_NewEntryError.Size = new System.Drawing.Size(28, 28);
            this.pic_NewEntryError.TabIndex = 42;
            this.pic_NewEntryError.TabStop = false;
            this.pic_NewEntryError.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PLPT.Properties.Resources.icons8_minimize_window_30;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1154, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 41;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PLPT.Properties.Resources.icons8_close_window_24;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1176, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::PLPT.Properties.Resources.icons8_formula_fx_50;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(18, 570);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(28, 28);
            this.pictureBox9.TabIndex = 34;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::PLPT.Properties.Resources.icons8_add_50;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(18, 536);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 28);
            this.pictureBox5.TabIndex = 33;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::PLPT.Properties.Resources.icons8_deadlift_30__1_;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(18, 502);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 28);
            this.pictureBox6.TabIndex = 32;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::PLPT.Properties.Resources.icons8_bench_press_26__1_;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(18, 468);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 28);
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::PLPT.Properties.Resources.icons8_squats_26__1_;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(18, 434);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 28);
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::PLPT.Properties.Resources.icons8_scale_50__1_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(19, 231);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PLPT.Properties.Resources.icons8_deadlift_30__1_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(19, 187);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PLPT.Properties.Resources.icons8_bench_press_26__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(19, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PLPT.Properties.Resources.icons8_squats_26__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(19, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_DateIcon
            // 
            this.picBox_DateIcon.BackgroundImage = global::PLPT.Properties.Resources.icons8_calendar_512__1_;
            this.picBox_DateIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_DateIcon.Location = new System.Drawing.Point(19, 63);
            this.picBox_DateIcon.Name = "picBox_DateIcon";
            this.picBox_DateIcon.Size = new System.Drawing.Size(28, 28);
            this.picBox_DateIcon.TabIndex = 25;
            this.picBox_DateIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(11)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1203, 620);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_NewEntryError);
            this.Controls.Add(this.pic_NewEntryError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBox_DateIcon);
            this.Controls.Add(this.checkBoxList_ValueToDisplay);
            this.Controls.Add(this.btn_CurrentBestDate);
            this.Controls.Add(this.lbl_BenchCurrent);
            this.Controls.Add(this.lbl_DeadliftCurrent);
            this.Controls.Add(this.lbl_TotalCurrent);
            this.Controls.Add(this.lbl_WilksCurrent);
            this.Controls.Add(this.lbl_SquatCurrent);
            this.Controls.Add(this.ListBox_DateRangeForCurrent);
            this.Controls.Add(this.lbl_CurrentTitle);
            this.Controls.Add(this.btn_LoadGraph);
            this.Controls.Add(this.lbl_VisualiseTitle);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_SetNewEntry);
            this.Controls.Add(this.txtbox_BodyweightEntry);
            this.Controls.Add(this.txtbox_BenchNewEntry);
            this.Controls.Add(this.txtbox_DeadliftNewEntry);
            this.Controls.Add(this.txtbox_SquatNewEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datepicker_NewEntry);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NewEntryError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_DateIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_SquatNewEntry;
        private System.Windows.Forms.TextBox txtbox_DeadliftNewEntry;
        private System.Windows.Forms.TextBox txtbox_BenchNewEntry;
        private System.Windows.Forms.TextBox txtbox_BodyweightEntry;
        private System.Windows.Forms.Button btn_SetNewEntry;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_VisualiseTitle;
        private System.Windows.Forms.Button btn_LoadGraph;
        private System.Windows.Forms.Label lbl_CurrentTitle;
        private System.Windows.Forms.ListBox ListBox_DateRangeForCurrent;
        private System.Windows.Forms.Label lbl_SquatCurrent;
        private System.Windows.Forms.Label lbl_TotalCurrent;
        private System.Windows.Forms.Label lbl_DeadliftCurrent;
        private System.Windows.Forms.Label lbl_BenchCurrent;
        private System.Windows.Forms.DateTimePicker datepicker_NewEntry;
        private System.Windows.Forms.Label lbl_WilksCurrent;
        private System.Windows.Forms.Button btn_CurrentBestDate;
        private System.Windows.Forms.CheckedListBox checkBoxList_ValueToDisplay;
        private System.Windows.Forms.PictureBox picBox_DateIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pic_NewEntryError;
        private System.Windows.Forms.Label lbl_NewEntryError;
    }
}

