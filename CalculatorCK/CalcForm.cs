using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCK
{
    public partial class CalcForm : Form
    {
        // Private Variables Important For Calculations
        private Double currVal = 0;
        //private Double sum = 0;




        public CalcForm()
        {
            InitializeComponent();
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            
        }

        #region Button Events

        #region Number Buttons
        private void btn0_Click_1(object sender, EventArgs e)
        {
            if (displayInOut.Text == "0")
            {
                displayInOut.Text = "0";
            }
            else {
                displayInOut.Text += "0";
            }

            Double.TryParse(displayInOut.Text, out currVal);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (displayInOut.Text == "0")
            {
                displayInOut.Text = "1";
            }
            else
            {
                displayInOut.Text += "1";
            }

            Double.TryParse(displayInOut.Text, out currVal);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (displayInOut.Text == "0")
            {
                displayInOut.Text = "2";
            }
            else
            {
                displayInOut.Text += "2";
            }

            Double.TryParse(displayInOut.Text, out currVal);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (displayInOut.Text == "0")
            {
                displayInOut.Text = "3";
            }
            else
            {
                displayInOut.Text += "3";
            }

            Double.TryParse(displayInOut.Text, out currVal);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (displayInOut.Text == "0")
            {
                displayInOut.Text = "4";
            }
            else
            {
                displayInOut.Text += "4";
            }

            Double.TryParse(displayInOut.Text, out currVal);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (displayInOut.Text == "0")
            {
                displayInOut.Text = "5";
            }
            else
            {
                displayInOut.Text += "5";
            }

            Double.TryParse(displayInOut.Text, out currVal);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (displayInOut.Text == "0")
            {
                displayInOut.Text = "6";
            }
            else
            {
                displayInOut.Text += "6";
            }

            Double.TryParse(displayInOut.Text, out currVal);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (displayInOut.Text == "0")
            {
                displayInOut.Text = "7";
            }
            else
            {
                displayInOut.Text += "7";
            }

            Double.TryParse(displayInOut.Text, out currVal);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (displayInOut.Text == "0")
            {
                displayInOut.Text = "8";
            }
            else
            {
                displayInOut.Text += "8";
            }

            Double.TryParse(displayInOut.Text, out currVal);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (displayInOut.Text == "0")
            {
                displayInOut.Text = "9";
            }
            else
            {
                displayInOut.Text += "9";
            }

            Double.TryParse(displayInOut.Text, out currVal);
        }
        #endregion

        #region Field Buttons
        private void btnCE_Click(object sender, EventArgs e)
        {
            // most likely will not touch the sum variable & will only touch currval and display
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            // most likely will touch all variables
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((currVal < 0 && displayInOut.Text.Length == 2) || displayInOut.Text.Length == 1)
            {
                displayInOut.Text = "0";
                Double.TryParse(displayInOut.Text, out currVal);
            }
            else {
                displayInOut.Text = displayInOut.Text.Remove(displayInOut.Text.Length - 1, 1);
                Double.TryParse(displayInOut.Text, out currVal);
            }
        }
        #endregion

        #region Operation Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }

        private void btnMul_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // equals and operation buttons will operate on the sum variable
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {

        }

        private void btnXToY_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Special Buttons
        private void btnNeg_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(displayInOut.Text) != 0) {
                currVal *= -1;
                displayInOut.Text = currVal.ToString();
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (!displayInOut.Text.Contains('.')) {
                if (displayInOut.Text == "0")
                {
                    displayInOut.Text = "0.";
                }
                else
                {
                    displayInOut.Text += ".";
                }
            }
            
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {

        }

        private void btnToPercent_Click(object sender, EventArgs e)
        {
            currVal /= 100;
            displayInOut.Text = currVal.ToString();
        }
        #endregion

        #endregion
    }
}
