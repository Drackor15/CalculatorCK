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
        }

        #endregion

        #region Field Buttons
        private void btnCE_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

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

        private void btnSqrt_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Special Buttons

        private void btnNeg_Click(object sender, EventArgs e)
        {

        }

        private void btnDec_Click(object sender, EventArgs e)
        {

        }
        private void btnXToY_Click(object sender, EventArgs e)
        {

        }

        private void btnInverse_Click(object sender, EventArgs e)
        {

        }
        private void btnToPercent_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion
    }
}
