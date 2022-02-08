
namespace Project3Group16
{
    partial class mainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWin));
            this.projTitle = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.readButton = new System.Windows.Forms.Button();
            this.tickerLabel = new System.Windows.Forms.Label();
            this.ticketCB = new System.Windows.Forms.ComboBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.periodCB = new System.Windows.Forms.ComboBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // projTitle
            // 
            this.projTitle.AutoSize = true;
            this.projTitle.BackColor = System.Drawing.Color.Transparent;
            this.projTitle.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projTitle.ForeColor = System.Drawing.Color.Cornsilk;
            this.projTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.projTitle.Location = new System.Drawing.Point(103, 6);
            this.projTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projTitle.Name = "projTitle";
            this.projTitle.Size = new System.Drawing.Size(405, 35);
            this.projTitle.TabIndex = 0;
            this.projTitle.Text = "Software Sys Development - Project 3";
            this.projTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamLabel.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.teamLabel.Location = new System.Drawing.Point(168, 42);
            this.teamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(299, 24);
            this.teamLabel.TabIndex = 1;
            this.teamLabel.Text = "Group 16 - Akash Singh and Justina Le";
            // 
            // readButton
            // 
            this.readButton.BackColor = System.Drawing.Color.Blue;
            this.readButton.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readButton.ForeColor = System.Drawing.Color.White;
            this.readButton.Location = new System.Drawing.Point(271, 319);
            this.readButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(144, 43);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "Read Data";
            this.readButton.UseVisualStyleBackColor = false;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // tickerLabel
            // 
            this.tickerLabel.AutoSize = true;
            this.tickerLabel.BackColor = System.Drawing.Color.Transparent;
            this.tickerLabel.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickerLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.tickerLabel.Location = new System.Drawing.Point(38, 99);
            this.tickerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tickerLabel.Name = "tickerLabel";
            this.tickerLabel.Size = new System.Drawing.Size(56, 24);
            this.tickerLabel.TabIndex = 3;
            this.tickerLabel.Text = "Ticker:";
            // 
            // ticketCB
            // 
            this.ticketCB.FormattingEnabled = true;
            this.ticketCB.Items.AddRange(new object[] {
            "AAPL",
            "AMZN",
            "FB",
            "GOOGL",
            "HPQ",
            "IBM",
            "INTC",
            "MSFT",
            "NFLX",
            "TSLA"});
            this.ticketCB.Location = new System.Drawing.Point(110, 99);
            this.ticketCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ticketCB.Name = "ticketCB";
            this.ticketCB.Size = new System.Drawing.Size(82, 24);
            this.ticketCB.TabIndex = 4;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.startDateLabel.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.startDateLabel.Location = new System.Drawing.Point(339, 100);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(91, 24);
            this.startDateLabel.TabIndex = 5;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.endDateLabel.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.endDateLabel.Location = new System.Drawing.Point(349, 139);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(81, 24);
            this.endDateLabel.TabIndex = 6;
            this.endDateLabel.Text = "End Date:";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.BackColor = System.Drawing.Color.Transparent;
            this.periodLabel.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.periodLabel.Location = new System.Drawing.Point(38, 145);
            this.periodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(59, 24);
            this.periodLabel.TabIndex = 7;
            this.periodLabel.Text = "Period:";
            // 
            // periodCB
            // 
            this.periodCB.FormattingEnabled = true;
            this.periodCB.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.periodCB.Location = new System.Drawing.Point(110, 145);
            this.periodCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.periodCB.Name = "periodCB";
            this.periodCB.Size = new System.Drawing.Size(82, 24);
            this.periodCB.TabIndex = 10;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(442, 102);
            this.startDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(244, 22);
            this.startDate.TabIndex = 11;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(442, 143);
            this.endDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(244, 22);
            this.endDate.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 386);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.periodCB);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.ticketCB);
            this.Controls.Add(this.tickerLabel);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.projTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Welcome Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projTitle;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label tickerLabel;
        private System.Windows.Forms.ComboBox ticketCB;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.ComboBox periodCB;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
    }
}

