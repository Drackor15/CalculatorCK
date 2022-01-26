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
        private Double dispVal = 0;
        private Double val1 = 0;
        /**
         * Table of Operands
         * 0    =   null
         * 1    =   addition
         * 2    =   subtraction
         * 3    =   multiplication
         * 4    =   division
         * 5    =   x^y
         */
        private int operand = 0;
        private bool isOperationSet = false;


        public CalcForm()
        {
            InitializeComponent();
            KeyDown += CalcForm_KeyDown;
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            
        }

        #region Key Events
        private void CalcForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                // Number Buttons (not NumPad)
                case Keys.D0:
                    e.Handled = true;
                    btn0.PerformClick();
                    break;
                case Keys.D1:
                    e.Handled = true;
                    btn1.PerformClick();
                    break;
                case Keys.D2:
                    e.Handled = true;
                    btn2.PerformClick();
                    break;
                case Keys.D3:
                    e.Handled = true;
                    btn3.PerformClick();
                    break;
                case Keys.D4:
                    e.Handled = true;
                    btn4.PerformClick();
                    break;
                case Keys.D5:
                    e.Handled = true;
                    btn5.PerformClick();
                    break;
                case Keys.D6:
                    e.Handled = true;
                    btn6.PerformClick();
                    break;
                case Keys.D7:
                    e.Handled = true;
                    btn7.PerformClick();
                    break;
                case Keys.D8:
                    e.Handled = true;
                    btn8.PerformClick();
                    break;
                case Keys.D9:
                    e.Handled = true;
                    btn9.PerformClick();
                    break;
                // Number Keys (NumPad)
                case Keys.NumPad0:
                    e.Handled = true;
                    btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    e.Handled = true;
                    btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    e.Handled = true;
                    btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    e.Handled = true;
                    btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    e.Handled = true;
                    btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    e.Handled = true;
                    btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    e.Handled = true;
                    btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    e.Handled = true;
                    btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    e.Handled = true;
                    btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    e.Handled = true;
                    btn9.PerformClick();
                    break;
                // Field Buttons
                case Keys.Back:
                    e.Handled = true;
                    btnDel.PerformClick();
                    break;
                case Keys.Delete:
                    e.Handled = true;
                    btnDel.PerformClick();
                    break;
                case Keys.E:
                    e.Handled = true;
                    btnCE.PerformClick();
                    break;
                case Keys.C:
                    e.Handled = true;
                    btnC.PerformClick();
                    break;
                // Operation Buttons (not NumPad)
                case Keys.Oemplus:
                    e.Handled = true;
                    btnAdd.PerformClick();
                    break;
                case Keys.OemMinus:
                    e.Handled = true;
                    btnMin.PerformClick();
                    break;
                // Operation Buttons (NumPad)
                case Keys.Add:
                    e.Handled = true;
                    btnAdd.PerformClick();
                    break;
                case Keys.Subtract:
                    e.Handled = true;
                    btnMin.PerformClick();
                    break;
                case Keys.Multiply:
                    e.Handled = true;
                    btnAdd.PerformClick();
                    break;
                case Keys.Divide:
                    e.Handled = true;
                    btnMin.PerformClick();
                    break;
                // Special Buttons
                case Keys.OemPeriod:
                    e.Handled = true;
                    btnDec.PerformClick();
                    break;
                case Keys.Decimal:
                    e.Handled = true;
                    btnDec.PerformClick();
                    break;
            }        
        }
        #endregion

        #region Button Events

        #region Number Buttons
        private void btn0_Click(object sender, EventArgs e)
        {
            if (!isOperationSet)
            {
                if (displayInOut.Text == "0")
                {
                    displayInOut.Text = "0";
                }
                else
                {
                    displayInOut.Text += "0";
                }
            }
            else {
                displayInOut.Text = "0";
                isOperationSet = false;
            }

            Double.TryParse(displayInOut.Text, out dispVal);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (!isOperationSet)
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
            else
            {
                displayInOut.Text = "1";
                isOperationSet = false;
            }

            Double.TryParse(displayInOut.Text, out dispVal);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!isOperationSet)
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
            else
            {
                displayInOut.Text = "2";
                isOperationSet = false;
            }

            Double.TryParse(displayInOut.Text, out dispVal);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!isOperationSet)
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
            else {
                displayInOut.Text = "3";
                isOperationSet = false;
            }

            Double.TryParse(displayInOut.Text, out dispVal);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (!isOperationSet)
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
            else
            {
                displayInOut.Text = "4";
                isOperationSet = false;
            }

            Double.TryParse(displayInOut.Text, out dispVal);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!isOperationSet)
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
            else
            {
                displayInOut.Text = "5";
                isOperationSet = false;
            }

            Double.TryParse(displayInOut.Text, out dispVal);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (!isOperationSet)
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
            else
            {
                displayInOut.Text = "6";
                isOperationSet = false;
            }

            Double.TryParse(displayInOut.Text, out dispVal);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (!isOperationSet)
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
            else
            {
                displayInOut.Text = "7";
                isOperationSet = false;
            }

            Double.TryParse(displayInOut.Text, out dispVal);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (!isOperationSet)
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
            else
            {
                displayInOut.Text = "8";
                isOperationSet = false;
            }

            Double.TryParse(displayInOut.Text, out dispVal);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (!isOperationSet)
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
            else
            {
                displayInOut.Text = "9";
                isOperationSet = false;
            }

            Double.TryParse(displayInOut.Text, out dispVal);
        }
        #endregion

        #region Field Buttons
        private void btnCE_Click(object sender, EventArgs e)
        {
            dispVal = 0;
            displayInOut.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            dispVal = 0;
            val1 = 0;
            operand = 0;
            isOperationSet = false;
            displayInOut.Text = "0";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((dispVal < 0 && displayInOut.Text.Length == 2) || displayInOut.Text.Length == 1)
            {
                displayInOut.Text = "0";
                Double.TryParse(displayInOut.Text, out dispVal);
            }
            else {
                displayInOut.Text = displayInOut.Text.Remove(displayInOut.Text.Length - 1, 1);
                Double.TryParse(displayInOut.Text, out dispVal);
            }
        }
        #endregion

        #region Operation Buttons
        /**
         * Helper Function used by operations
         */
        private void operate() {
            if (operand == 1)
            {
                dispVal += val1;
                displayInOut.Text = dispVal.ToString();
            }
            if (operand == 2)
            {
                dispVal *= -1;
                dispVal += val1;
                displayInOut.Text = dispVal.ToString();
            }
            if (operand == 3) {
                dispVal *= val1;
                displayInOut.Text = dispVal.ToString();
            }
            if (operand == 4) {
                if (dispVal != 0 && val1 != 0)
                {
                    dispVal = 1 / dispVal;
                    dispVal *= val1;
                    displayInOut.Text = dispVal.ToString();
                }
                else {
                    displayInOut.Text = "Undef";
                }
            }
            if (operand == 5) {
                dispVal = Math.Pow(val1, dispVal);
                displayInOut.Text = dispVal.ToString();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            operate();
            val1 = dispVal;
            operand = 1;
            isOperationSet = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            operate();
            val1 = dispVal;
            operand = 2;
            isOperationSet = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operate();
            val1 = dispVal;
            operand = 3;
            isOperationSet = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operate();
            val1 = dispVal;
            operand = 4;
            isOperationSet = true;
        }

        private void btnXToY_Click(object sender, EventArgs e)
        {
            operate();
            val1 = dispVal;
            operand = 5;
            isOperationSet = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            operate();
        }
        #endregion

        #region Special Buttons
        private void btnNeg_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(displayInOut.Text) != 0) {
                dispVal *= -1;
                displayInOut.Text = dispVal.ToString();
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (!isOperationSet)
            {
                if (!displayInOut.Text.Contains('.'))
                {
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
            else {
                displayInOut.Text = "0.";
                isOperationSet = false;
            }
            
            
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            dispVal = 1 / dispVal;
            displayInOut.Text = dispVal.ToString();
        }

        private void btnToPercent_Click(object sender, EventArgs e)
        {
            dispVal /= 100;
            displayInOut.Text = dispVal.ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (dispVal > 0)
            {
                dispVal = Math.Sqrt(dispVal);
                displayInOut.Text = dispVal.ToString();
            }
            else
            {
                displayInOut.Text = "Undef";
            }
        }
        #endregion

        #endregion
    }
}
