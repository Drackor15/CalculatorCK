
namespace CalculatorCK
{
    partial class CalcForm
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
            this.components = new System.ComponentModel.Container();
            this.displayInOut = new System.Windows.Forms.TextBox();
            this.labelInOut = new System.Windows.Forms.Label();
            this.btnToPercent = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnXToY = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnNeg = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayInOut
            // 
            this.displayInOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayInOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.displayInOut.Location = new System.Drawing.Point(12, 35);
            this.displayInOut.Name = "displayInOut";
            this.displayInOut.ReadOnly = true;
            this.displayInOut.Size = new System.Drawing.Size(322, 26);
            this.displayInOut.TabIndex = 0;
            this.displayInOut.Text = "0";
            this.displayInOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelInOut
            // 
            this.labelInOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInOut.AutoSize = true;
            this.labelInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInOut.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelInOut.Location = new System.Drawing.Point(13, 9);
            this.labelInOut.Name = "labelInOut";
            this.labelInOut.Size = new System.Drawing.Size(111, 20);
            this.labelInOut.TabIndex = 1;
            this.labelInOut.Text = "Input/Output";
            // 
            // btnToPercent
            // 
            this.btnToPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToPercent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnToPercent.Location = new System.Drawing.Point(3, 3);
            this.btnToPercent.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnToPercent.Name = "btnToPercent";
            this.btnToPercent.Size = new System.Drawing.Size(74, 42);
            this.btnToPercent.TabIndex = 2;
            this.btnToPercent.Text = "%";
            this.btnToPercent.UseVisualStyleBackColor = true;
            this.btnToPercent.Click += new System.EventHandler(this.btnToPercent_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSqrt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSqrt.Location = new System.Drawing.Point(83, 3);
            this.btnSqrt.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(74, 42);
            this.btnSqrt.TabIndex = 3;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnXToY
            // 
            this.btnXToY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXToY.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXToY.Location = new System.Drawing.Point(163, 3);
            this.btnXToY.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnXToY.Name = "btnXToY";
            this.btnXToY.Size = new System.Drawing.Size(74, 42);
            this.btnXToY.TabIndex = 4;
            this.btnXToY.Text = "x^y";
            this.btnXToY.UseVisualStyleBackColor = true;
            this.btnXToY.Click += new System.EventHandler(this.btnXToY_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInverse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInverse.Location = new System.Drawing.Point(243, 3);
            this.btnInverse.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(74, 42);
            this.btnInverse.TabIndex = 5;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnCE
            // 
            this.btnCE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCE.Location = new System.Drawing.Point(3, 50);
            this.btnCE.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(74, 42);
            this.btnCE.TabIndex = 6;
            this.btnCE.Text = "CE";
            this.toolTip1.SetToolTip(this.btnCE, "Clear Entry     E");
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnC.Location = new System.Drawing.Point(83, 50);
            this.btnC.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(74, 42);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnC, "Clear     C");
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDel.Location = new System.Drawing.Point(163, 50);
            this.btnDel.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(74, 42);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Del.";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiv.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDiv.Location = new System.Drawing.Point(243, 50);
            this.btnDiv.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(74, 42);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btn7
            // 
            this.btn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn7.Location = new System.Drawing.Point(3, 97);
            this.btn7.MinimumSize = new System.Drawing.Size(74, 42);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 42);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn8.Location = new System.Drawing.Point(83, 97);
            this.btn8.MinimumSize = new System.Drawing.Size(74, 42);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(74, 42);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn9.Location = new System.Drawing.Point(163, 97);
            this.btn9.MinimumSize = new System.Drawing.Size(74, 42);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(74, 42);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnMul
            // 
            this.btnMul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMul.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMul.Location = new System.Drawing.Point(243, 97);
            this.btnMul.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(74, 42);
            this.btnMul.TabIndex = 13;
            this.btnMul.Text = "X";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btn4
            // 
            this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn4.Location = new System.Drawing.Point(3, 144);
            this.btn4.MinimumSize = new System.Drawing.Size(74, 42);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(74, 42);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.Location = new System.Drawing.Point(3, 191);
            this.btn1.MinimumSize = new System.Drawing.Size(74, 42);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 42);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnNeg
            // 
            this.btnNeg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNeg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNeg.Location = new System.Drawing.Point(3, 238);
            this.btnNeg.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnNeg.Name = "btnNeg";
            this.btnNeg.Size = new System.Drawing.Size(74, 47);
            this.btnNeg.TabIndex = 16;
            this.btnNeg.Text = "+/-";
            this.btnNeg.UseVisualStyleBackColor = true;
            this.btnNeg.Click += new System.EventHandler(this.btnNeg_Click);
            // 
            // btn5
            // 
            this.btn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn5.Location = new System.Drawing.Point(83, 144);
            this.btn5.MinimumSize = new System.Drawing.Size(74, 42);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(74, 42);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn6.Location = new System.Drawing.Point(163, 144);
            this.btn6.MinimumSize = new System.Drawing.Size(74, 42);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(74, 42);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMin.Location = new System.Drawing.Point(243, 144);
            this.btnMin.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(74, 42);
            this.btnMin.TabIndex = 19;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn2.Location = new System.Drawing.Point(83, 191);
            this.btn2.MinimumSize = new System.Drawing.Size(74, 42);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(74, 42);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn3.Location = new System.Drawing.Point(163, 191);
            this.btn3.MinimumSize = new System.Drawing.Size(74, 42);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(74, 42);
            this.btn3.TabIndex = 21;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Location = new System.Drawing.Point(243, 191);
            this.btnAdd.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 42);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn0
            // 
            this.btn0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn0.Location = new System.Drawing.Point(83, 238);
            this.btn0.MinimumSize = new System.Drawing.Size(74, 42);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(74, 47);
            this.btn0.TabIndex = 23;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDec
            // 
            this.btnDec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDec.Location = new System.Drawing.Point(163, 238);
            this.btnDec.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(74, 47);
            this.btnDec.TabIndex = 24;
            this.btnDec.Text = ".";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEquals.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEquals.Location = new System.Drawing.Point(243, 238);
            this.btnEquals.MinimumSize = new System.Drawing.Size(74, 42);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(74, 47);
            this.btnEquals.TabIndex = 25;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnToPercent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEquals, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSqrt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDec, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnXToY, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnInverse, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCE, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNeg, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnMin, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDiv, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMul, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 4);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 74);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(320, 282);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 288);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 374);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelInOut);
            this.Controls.Add(this.displayInOut);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(374, 430);
            this.Name = "CalcForm";
            this.Text = "C# Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayInOut;
        private System.Windows.Forms.Label labelInOut;
        private System.Windows.Forms.Button btnToPercent;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnXToY;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnNeg;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

