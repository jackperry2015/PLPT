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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_SquatNewEntry = new System.Windows.Forms.TextBox();
            this.txtbox_DeadliftNewEntry = new System.Windows.Forms.TextBox();
            this.txtbox_BenchNewEntry = new System.Windows.Forms.TextBox();
            this.txtbox_BodyweightEntry = new System.Windows.Forms.TextBox();
            this.btn_SetNewEntry = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_ViewBench = new System.Windows.Forms.Button();
            this.lbl_VisualiseTitle = new System.Windows.Forms.Label();
            this.btn_ViewDeadlift = new System.Windows.Forms.Button();
            this.btn_ViewSquat = new System.Windows.Forms.Button();
            this.btn_ViewBodyweight = new System.Windows.Forms.Button();
            this.btn_ViewTotal = new System.Windows.Forms.Button();
            this.btn_ViewWilks = new System.Windows.Forms.Button();
            this.lbl_CurrentTitle = new System.Windows.Forms.Label();
            this.ListBox_DateRangeForCurrent = new System.Windows.Forms.ListBox();
            this.lbl_SquatCurrent = new System.Windows.Forms.Label();
            this.lbl_WilksCurrent = new System.Windows.Forms.Label();
            this.lbl_TotalCurrent = new System.Windows.Forms.Label();
            this.lbl_DeadliftCurrent = new System.Windows.Forms.Label();
            this.lbl_BenchCurrent = new System.Windows.Forms.Label();
            this.datepicker_NewEntry = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Entry";
            // 
            // txtbox_SquatNewEntry
            // 
            this.txtbox_SquatNewEntry.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_SquatNewEntry.Location = new System.Drawing.Point(12, 111);
            this.txtbox_SquatNewEntry.Name = "txtbox_SquatNewEntry";
            this.txtbox_SquatNewEntry.Size = new System.Drawing.Size(200, 27);
            this.txtbox_SquatNewEntry.TabIndex = 2;
            // 
            // txtbox_DeadliftNewEntry
            // 
            this.txtbox_DeadliftNewEntry.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_DeadliftNewEntry.Location = new System.Drawing.Point(12, 196);
            this.txtbox_DeadliftNewEntry.Name = "txtbox_DeadliftNewEntry";
            this.txtbox_DeadliftNewEntry.Size = new System.Drawing.Size(200, 27);
            this.txtbox_DeadliftNewEntry.TabIndex = 3;
            // 
            // txtbox_BenchNewEntry
            // 
            this.txtbox_BenchNewEntry.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_BenchNewEntry.Location = new System.Drawing.Point(12, 153);
            this.txtbox_BenchNewEntry.Name = "txtbox_BenchNewEntry";
            this.txtbox_BenchNewEntry.Size = new System.Drawing.Size(200, 27);
            this.txtbox_BenchNewEntry.TabIndex = 4;
            // 
            // txtbox_BodyweightEntry
            // 
            this.txtbox_BodyweightEntry.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_BodyweightEntry.Location = new System.Drawing.Point(12, 241);
            this.txtbox_BodyweightEntry.Name = "txtbox_BodyweightEntry";
            this.txtbox_BodyweightEntry.Size = new System.Drawing.Size(200, 27);
            this.txtbox_BodyweightEntry.TabIndex = 5;
            // 
            // btn_SetNewEntry
            // 
            this.btn_SetNewEntry.Location = new System.Drawing.Point(33, 286);
            this.btn_SetNewEntry.Name = "btn_SetNewEntry";
            this.btn_SetNewEntry.Size = new System.Drawing.Size(152, 53);
            this.btn_SetNewEntry.TabIndex = 6;
            this.btn_SetNewEntry.Text = "Enter";
            this.btn_SetNewEntry.UseVisualStyleBackColor = true;
            this.btn_SetNewEntry.Click += new System.EventHandler(this.btn_SetNewEntry_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(316, 111);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(905, 537);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(817, 299);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 8;
            // 
            // btn_ViewBench
            // 
            this.btn_ViewBench.Location = new System.Drawing.Point(559, 67);
            this.btn_ViewBench.Name = "btn_ViewBench";
            this.btn_ViewBench.Size = new System.Drawing.Size(54, 41);
            this.btn_ViewBench.TabIndex = 9;
            this.btn_ViewBench.Text = "Bench";
            this.btn_ViewBench.UseVisualStyleBackColor = true;
            // 
            // lbl_VisualiseTitle
            // 
            this.lbl_VisualiseTitle.AutoSize = true;
            this.lbl_VisualiseTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VisualiseTitle.Location = new System.Drawing.Point(355, 79);
            this.lbl_VisualiseTitle.Name = "lbl_VisualiseTitle";
            this.lbl_VisualiseTitle.Size = new System.Drawing.Size(137, 29);
            this.lbl_VisualiseTitle.TabIndex = 10;
            this.lbl_VisualiseTitle.Text = "Visualise:";
            // 
            // btn_ViewDeadlift
            // 
            this.btn_ViewDeadlift.Location = new System.Drawing.Point(619, 67);
            this.btn_ViewDeadlift.Name = "btn_ViewDeadlift";
            this.btn_ViewDeadlift.Size = new System.Drawing.Size(54, 41);
            this.btn_ViewDeadlift.TabIndex = 11;
            this.btn_ViewDeadlift.Text = "Deadlift";
            this.btn_ViewDeadlift.UseVisualStyleBackColor = true;
            // 
            // btn_ViewSquat
            // 
            this.btn_ViewSquat.Location = new System.Drawing.Point(499, 68);
            this.btn_ViewSquat.Name = "btn_ViewSquat";
            this.btn_ViewSquat.Size = new System.Drawing.Size(54, 40);
            this.btn_ViewSquat.TabIndex = 12;
            this.btn_ViewSquat.Text = "Squat";
            this.btn_ViewSquat.UseVisualStyleBackColor = true;
            // 
            // btn_ViewBodyweight
            // 
            this.btn_ViewBodyweight.Location = new System.Drawing.Point(760, 67);
            this.btn_ViewBodyweight.Name = "btn_ViewBodyweight";
            this.btn_ViewBodyweight.Size = new System.Drawing.Size(75, 41);
            this.btn_ViewBodyweight.TabIndex = 13;
            this.btn_ViewBodyweight.Text = "Bodyweight";
            this.btn_ViewBodyweight.UseVisualStyleBackColor = true;
            // 
            // btn_ViewTotal
            // 
            this.btn_ViewTotal.Location = new System.Drawing.Point(679, 67);
            this.btn_ViewTotal.Name = "btn_ViewTotal";
            this.btn_ViewTotal.Size = new System.Drawing.Size(75, 41);
            this.btn_ViewTotal.TabIndex = 14;
            this.btn_ViewTotal.Text = "Total";
            this.btn_ViewTotal.UseVisualStyleBackColor = true;
            // 
            // btn_ViewWilks
            // 
            this.btn_ViewWilks.Location = new System.Drawing.Point(841, 68);
            this.btn_ViewWilks.Name = "btn_ViewWilks";
            this.btn_ViewWilks.Size = new System.Drawing.Size(75, 41);
            this.btn_ViewWilks.TabIndex = 15;
            this.btn_ViewWilks.Text = "Wilks";
            this.btn_ViewWilks.UseVisualStyleBackColor = true;
            // 
            // lbl_CurrentTitle
            // 
            this.lbl_CurrentTitle.AutoSize = true;
            this.lbl_CurrentTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentTitle.Location = new System.Drawing.Point(28, 377);
            this.lbl_CurrentTitle.Name = "lbl_CurrentTitle";
            this.lbl_CurrentTitle.Size = new System.Drawing.Size(255, 29);
            this.lbl_CurrentTitle.TabIndex = 16;
            this.lbl_CurrentTitle.Text = "Your Current Best:";
            // 
            // ListBox_DateRangeForCurrent
            // 
            this.ListBox_DateRangeForCurrent.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_DateRangeForCurrent.FormattingEnabled = true;
            this.ListBox_DateRangeForCurrent.ItemHeight = 16;
            this.ListBox_DateRangeForCurrent.Location = new System.Drawing.Point(45, 409);
            this.ListBox_DateRangeForCurrent.Name = "ListBox_DateRangeForCurrent";
            this.ListBox_DateRangeForCurrent.Size = new System.Drawing.Size(213, 20);
            this.ListBox_DateRangeForCurrent.TabIndex = 17;
            // 
            // lbl_SquatCurrent
            // 
            this.lbl_SquatCurrent.AutoSize = true;
            this.lbl_SquatCurrent.Location = new System.Drawing.Point(33, 449);
            this.lbl_SquatCurrent.Name = "lbl_SquatCurrent";
            this.lbl_SquatCurrent.Size = new System.Drawing.Size(35, 13);
            this.lbl_SquatCurrent.TabIndex = 18;
            this.lbl_SquatCurrent.Text = "Squat";
            // 
            // lbl_WilksCurrent
            // 
            this.lbl_WilksCurrent.AutoSize = true;
            this.lbl_WilksCurrent.Location = new System.Drawing.Point(33, 547);
            this.lbl_WilksCurrent.Name = "lbl_WilksCurrent";
            this.lbl_WilksCurrent.Size = new System.Drawing.Size(33, 13);
            this.lbl_WilksCurrent.TabIndex = 19;
            this.lbl_WilksCurrent.Text = "Wilks";
            // 
            // lbl_TotalCurrent
            // 
            this.lbl_TotalCurrent.AutoSize = true;
            this.lbl_TotalCurrent.Location = new System.Drawing.Point(33, 523);
            this.lbl_TotalCurrent.Name = "lbl_TotalCurrent";
            this.lbl_TotalCurrent.Size = new System.Drawing.Size(31, 13);
            this.lbl_TotalCurrent.TabIndex = 20;
            this.lbl_TotalCurrent.Text = "Total";
            // 
            // lbl_DeadliftCurrent
            // 
            this.lbl_DeadliftCurrent.AutoSize = true;
            this.lbl_DeadliftCurrent.Location = new System.Drawing.Point(33, 497);
            this.lbl_DeadliftCurrent.Name = "lbl_DeadliftCurrent";
            this.lbl_DeadliftCurrent.Size = new System.Drawing.Size(43, 13);
            this.lbl_DeadliftCurrent.TabIndex = 21;
            this.lbl_DeadliftCurrent.Text = "Deadlift";
            // 
            // lbl_BenchCurrent
            // 
            this.lbl_BenchCurrent.AutoSize = true;
            this.lbl_BenchCurrent.Location = new System.Drawing.Point(33, 473);
            this.lbl_BenchCurrent.Name = "lbl_BenchCurrent";
            this.lbl_BenchCurrent.Size = new System.Drawing.Size(38, 13);
            this.lbl_BenchCurrent.TabIndex = 22;
            this.lbl_BenchCurrent.Text = "Bench";
            // 
            // datepicker_NewEntry
            // 
            this.datepicker_NewEntry.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker_NewEntry.Location = new System.Drawing.Point(12, 68);
            this.datepicker_NewEntry.MaxDate = new System.DateTime(2109, 12, 27, 0, 0, 0, 0);
            this.datepicker_NewEntry.MinDate = new System.DateTime(1919, 12, 25, 0, 0, 0, 0);
            this.datepicker_NewEntry.Name = "datepicker_NewEntry";
            this.datepicker_NewEntry.Size = new System.Drawing.Size(200, 27);
            this.datepicker_NewEntry.TabIndex = 0;
            this.datepicker_NewEntry.Value = new System.DateTime(2020, 6, 11, 20, 23, 58, 794);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbl_BenchCurrent);
            this.Controls.Add(this.lbl_DeadliftCurrent);
            this.Controls.Add(this.lbl_TotalCurrent);
            this.Controls.Add(this.lbl_WilksCurrent);
            this.Controls.Add(this.lbl_SquatCurrent);
            this.Controls.Add(this.ListBox_DateRangeForCurrent);
            this.Controls.Add(this.lbl_CurrentTitle);
            this.Controls.Add(this.btn_ViewWilks);
            this.Controls.Add(this.btn_ViewTotal);
            this.Controls.Add(this.btn_ViewBodyweight);
            this.Controls.Add(this.btn_ViewSquat);
            this.Controls.Add(this.btn_ViewDeadlift);
            this.Controls.Add(this.lbl_VisualiseTitle);
            this.Controls.Add(this.btn_ViewBench);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_SetNewEntry);
            this.Controls.Add(this.txtbox_BodyweightEntry);
            this.Controls.Add(this.txtbox_BenchNewEntry);
            this.Controls.Add(this.txtbox_DeadliftNewEntry);
            this.Controls.Add(this.txtbox_SquatNewEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datepicker_NewEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_ViewBench;
        private System.Windows.Forms.Label lbl_VisualiseTitle;
        private System.Windows.Forms.Button btn_ViewDeadlift;
        private System.Windows.Forms.Button btn_ViewSquat;
        private System.Windows.Forms.Button btn_ViewBodyweight;
        private System.Windows.Forms.Button btn_ViewTotal;
        private System.Windows.Forms.Button btn_ViewWilks;
        private System.Windows.Forms.Label lbl_CurrentTitle;
        private System.Windows.Forms.ListBox ListBox_DateRangeForCurrent;
        private System.Windows.Forms.Label lbl_SquatCurrent;
        private System.Windows.Forms.Label lbl_WilksCurrent;
        private System.Windows.Forms.Label lbl_TotalCurrent;
        private System.Windows.Forms.Label lbl_DeadliftCurrent;
        private System.Windows.Forms.Label lbl_BenchCurrent;
        private System.Windows.Forms.DateTimePicker datepicker_NewEntry;
    }
}

