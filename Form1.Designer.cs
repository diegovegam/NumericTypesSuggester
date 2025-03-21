namespace NumericTypesSuggester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            minValueLabel = new Label();
            panel1 = new Panel();
            suggestedTypeValueLabel = new Label();
            suggestedTypeLabel = new Label();
            mBePreciseChkBox = new CheckBox();
            mBePreciseLabel = new Label();
            integralOnlyLabel = new Label();
            integralOnlyChkBox = new CheckBox();
            maxValuetxtBox = new TextBox();
            minValuetxtBox = new TextBox();
            maxValueLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // minValueLabel
            // 
            minValueLabel.AutoSize = true;
            minValueLabel.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minValueLabel.Location = new Point(126, 107);
            minValueLabel.Name = "minValueLabel";
            minValueLabel.Size = new Size(165, 45);
            minValueLabel.TabIndex = 0;
            minValueLabel.Text = "Min value:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(suggestedTypeValueLabel);
            panel1.Controls.Add(suggestedTypeLabel);
            panel1.Controls.Add(mBePreciseChkBox);
            panel1.Controls.Add(mBePreciseLabel);
            panel1.Controls.Add(integralOnlyLabel);
            panel1.Controls.Add(integralOnlyChkBox);
            panel1.Controls.Add(maxValuetxtBox);
            panel1.Controls.Add(minValuetxtBox);
            panel1.Controls.Add(maxValueLabel);
            panel1.Controls.Add(minValueLabel);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 600);
            panel1.TabIndex = 1;
            // 
            // suggestedTypeValueLabel
            // 
            suggestedTypeValueLabel.AutoSize = true;
            suggestedTypeValueLabel.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suggestedTypeValueLabel.Location = new Point(325, 420);
            suggestedTypeValueLabel.Name = "suggestedTypeValueLabel";
            suggestedTypeValueLabel.Size = new Size(312, 48);
            suggestedTypeValueLabel.TabIndex = 9;
            suggestedTypeValueLabel.Text = "Not enough data.";
            // 
            // suggestedTypeLabel
            // 
            suggestedTypeLabel.AutoSize = true;
            suggestedTypeLabel.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suggestedTypeLabel.Location = new Point(24, 420);
            suggestedTypeLabel.Name = "suggestedTypeLabel";
            suggestedTypeLabel.Size = new Size(295, 48);
            suggestedTypeLabel.TabIndex = 8;
            suggestedTypeLabel.Text = "Suggested type:";
            // 
            // mBePreciseChkBox
            // 
            mBePreciseChkBox.AutoSize = true;
            mBePreciseChkBox.Location = new Point(297, 368);
            mBePreciseChkBox.Name = "mBePreciseChkBox";
            mBePreciseChkBox.Size = new Size(22, 21);
            mBePreciseChkBox.TabIndex = 7;
            mBePreciseChkBox.TextAlign = ContentAlignment.MiddleCenter;
            mBePreciseChkBox.UseVisualStyleBackColor = true;
            mBePreciseChkBox.Visible = false;
            mBePreciseChkBox.CheckedChanged += mBePreciseChkBox_ChkChanged;
            // 
            // mBePreciseLabel
            // 
            mBePreciseLabel.AutoSize = true;
            mBePreciseLabel.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mBePreciseLabel.Location = new Point(30, 349);
            mBePreciseLabel.Name = "mBePreciseLabel";
            mBePreciseLabel.Size = new Size(261, 45);
            mBePreciseLabel.TabIndex = 6;
            mBePreciseLabel.Text = "Must be precise?";
            mBePreciseLabel.Visible = false;
            mBePreciseLabel.Click += mBePreciseLabel_Click;
            // 
            // integralOnlyLabel
            // 
            integralOnlyLabel.AutoSize = true;
            integralOnlyLabel.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            integralOnlyLabel.Location = new Point(79, 285);
            integralOnlyLabel.Name = "integralOnlyLabel";
            integralOnlyLabel.Size = new Size(212, 45);
            integralOnlyLabel.TabIndex = 5;
            integralOnlyLabel.Text = "Integral only?";
            integralOnlyLabel.Click += integralOnlyLabel_Click;
            // 
            // integralOnlyChkBox
            // 
            integralOnlyChkBox.AutoSize = true;
            integralOnlyChkBox.Checked = true;
            integralOnlyChkBox.CheckState = CheckState.Checked;
            integralOnlyChkBox.Location = new Point(297, 304);
            integralOnlyChkBox.Name = "integralOnlyChkBox";
            integralOnlyChkBox.Size = new Size(22, 21);
            integralOnlyChkBox.TabIndex = 4;
            integralOnlyChkBox.TextAlign = ContentAlignment.MiddleCenter;
            integralOnlyChkBox.UseVisualStyleBackColor = true;
            integralOnlyChkBox.CheckedChanged += integralOnlyChckBox_Checked;
            // 
            // maxValuetxtBox
            // 
            maxValuetxtBox.Location = new Point(297, 205);
            maxValuetxtBox.Name = "maxValuetxtBox";
            maxValuetxtBox.Size = new Size(445, 31);
            maxValuetxtBox.TabIndex = 3;
            maxValuetxtBox.TextChanged += maxValueTxtBox_TxtChanged;
            // 
            // minValuetxtBox
            // 
            minValuetxtBox.Location = new Point(297, 120);
            minValuetxtBox.Name = "minValuetxtBox";
            minValuetxtBox.Size = new Size(445, 31);
            minValuetxtBox.TabIndex = 2;
            minValuetxtBox.TextChanged += minValueTxtBox_TxtChanged;
            // 
            // maxValueLabel
            // 
            maxValueLabel.AutoSize = true;
            maxValueLabel.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxValueLabel.Location = new Point(126, 192);
            maxValueLabel.Name = "maxValueLabel";
            maxValueLabel.Size = new Size(170, 45);
            maxValueLabel.TabIndex = 1;
            maxValueLabel.Text = "Max value:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 593);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label minValueLabel;
        private Panel panel1;
        private Label integralOnlyLabel;
        private CheckBox integralOnlyChkBox;
        private TextBox maxValuetxtBox;
        private TextBox minValuetxtBox;
        private Label maxValueLabel;
        private Label mBePreciseLabel;
        private CheckBox mBePreciseChkBox;
        private Label suggestedTypeValueLabel;
        private Label suggestedTypeLabel;
    }
}
