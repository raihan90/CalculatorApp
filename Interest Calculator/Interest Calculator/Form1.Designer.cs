namespace Interest_Calculator
{
    partial class interestCalculatorForm
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
            this.bankNameLabel = new System.Windows.Forms.Label();
            this.timeYearLabel = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.interestLabel = new System.Windows.Forms.Label();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.bankNameListBox = new System.Windows.Forms.ListBox();
            this.interestCalculatorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bankNameLabel
            // 
            this.bankNameLabel.AutoSize = true;
            this.bankNameLabel.Location = new System.Drawing.Point(56, 42);
            this.bankNameLabel.Name = "bankNameLabel";
            this.bankNameLabel.Size = new System.Drawing.Size(63, 13);
            this.bankNameLabel.TabIndex = 0;
            this.bankNameLabel.Text = "Bank Name";
            this.bankNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeYearLabel
            // 
            this.timeYearLabel.AutoSize = true;
            this.timeYearLabel.Location = new System.Drawing.Point(47, 72);
            this.timeYearLabel.Name = "timeYearLabel";
            this.timeYearLabel.Size = new System.Drawing.Size(72, 13);
            this.timeYearLabel.TabIndex = 0;
            this.timeYearLabel.Text = "Time (in Year)";
            this.timeYearLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(163, 67);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(120, 20);
            this.timeTextBox.TabIndex = 1;
            this.timeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(73, 96);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(46, 13);
            this.balanceLabel.TabIndex = 0;
            this.balanceLabel.Text = "Balance";
            this.balanceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(163, 93);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(120, 20);
            this.balanceTextBox.TabIndex = 2;
            this.balanceTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(162, 132);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 22);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(77, 191);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(42, 13);
            this.interestLabel.TabIndex = 0;
            this.interestLabel.Text = "Interest";
            this.interestLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(163, 184);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.ReadOnly = true;
            this.interestTextBox.Size = new System.Drawing.Size(120, 20);
            this.interestTextBox.TabIndex = 4;
            this.interestTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bankNameListBox
            // 
            this.bankNameListBox.FormattingEnabled = true;
            this.bankNameListBox.Items.AddRange(new object[] {
            "------",
            "BRAC",
            "DBBL",
            "HSBC"});
            this.bankNameListBox.Location = new System.Drawing.Point(163, 42);
            this.bankNameListBox.Name = "bankNameListBox";
            this.bankNameListBox.Size = new System.Drawing.Size(120, 17);
            this.bankNameListBox.TabIndex = 0;
            // 
            // interestCalculatorLabel
            // 
            this.interestCalculatorLabel.AutoSize = true;
            this.interestCalculatorLabel.Location = new System.Drawing.Point(140, 1);
            this.interestCalculatorLabel.Name = "interestCalculatorLabel";
            this.interestCalculatorLabel.Size = new System.Drawing.Size(92, 13);
            this.interestCalculatorLabel.TabIndex = 5;
            this.interestCalculatorLabel.Text = "Interest Calculator";
            // 
            // interestCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 312);
            this.Controls.Add(this.interestCalculatorLabel);
            this.Controls.Add(this.bankNameListBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.timeYearLabel);
            this.Controls.Add(this.bankNameLabel);
            this.Name = "interestCalculatorForm";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bankNameLabel;
        private System.Windows.Forms.Label timeYearLabel;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.ListBox bankNameListBox;
        private System.Windows.Forms.Label interestCalculatorLabel;
    }
}

