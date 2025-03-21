using System.Numerics;



namespace NumericTypesSuggester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void integralOnlyLabel_Click(object sender, EventArgs e)
        {

        }

        private void mBePreciseLabel_Click(object sender, EventArgs e)
        {

        }

        private void integralOnlyChckBox_Checked(object sender, EventArgs e)
        {
            if (integralOnlyChkBox.Checked == false)
            {
                mBePreciseLabel.Visible = true;
                mBePreciseChkBox.Visible = true;
                checkTxt();

            }
            else
            {
                mBePreciseLabel.Visible = false;
                mBePreciseChkBox.Visible = false;
                checkTxt();
            }


        }

        private void checkTxt()
        {
            bool isMinValueANum = BigInteger.TryParse(minValuetxtBox.Text, out BigInteger MinValue);
            bool isMaxValueANum = BigInteger.TryParse(maxValuetxtBox.Text, out BigInteger MaxValue);
            if (isMinValueANum == true && isMaxValueANum == true)
            {
                suggestedTypeValueLabel.Text = "Type";
                maxValuetxtBox.BackColor = default;
                if (MinValue > MaxValue)
                {
                    suggestedTypeValueLabel.Text = "Not enough data.";
                    maxValuetxtBox.BackColor = Color.Red;
                }

                suggestedTypeValueLabel.Text = NumericTypeSuggesters.GetName(MinValue, MaxValue, integralOnlyChkBox.Checked, mBePreciseChkBox.Checked);
            }
            else
            {
                suggestedTypeValueLabel.Text = "Not enough data.";
            }

        }

        private void minValueTxtBox_TxtChanged(object sender, EventArgs e)

        {
            bool isTextEnteredANumber = BigInteger.TryParse(minValuetxtBox.Text, out BigInteger minValue);


            if (minValuetxtBox.Text == "-")
            {
                minValuetxtBox.Text = "-";

            }
            else if (isTextEnteredANumber == false)
            {
                minValuetxtBox.Text = string.Empty;
            }
            else
            {
                minValuetxtBox.Text = minValue.ToString();
            }

            checkTxt();

        }

        private void maxValueTxtBox_TxtChanged(object sender, EventArgs e)
        {
            bool isTextEnteredANumber = BigInteger.TryParse(maxValuetxtBox.Text, out BigInteger maxValue);


            if (maxValuetxtBox.Text == "-")
            {
                maxValuetxtBox.Text = "-";
            }
            else if (isTextEnteredANumber == false)
            {
                maxValuetxtBox.Text = string.Empty;
            }
            else
            {
                maxValuetxtBox.Text = maxValue.ToString();
            }
            checkTxt();

        }

        private void mBePreciseChkBox_ChkChanged(object sender, EventArgs e)
        {
            checkTxt();
        }
    }
}
