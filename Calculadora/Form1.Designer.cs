namespace Calculadora
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
            this.txtBoxDisplay = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClearError = new System.Windows.Forms.Button();
            this.btnSquared = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxDisplay
            // 
            this.txtBoxDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDisplay.Location = new System.Drawing.Point(13, 15);
            this.txtBoxDisplay.MaxLength = 18;
            this.txtBoxDisplay.Multiline = true;
            this.txtBoxDisplay.Name = "txtBoxDisplay";
            this.txtBoxDisplay.ReadOnly = true;
            this.txtBoxDisplay.Size = new System.Drawing.Size(278, 43);
            this.txtBoxDisplay.TabIndex = 0;
            this.txtBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(81, 73);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 69);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(151, 73);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(140, 69);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "⌫";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentage.Location = new System.Drawing.Point(10, 143);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(70, 69);
            this.btnPercentage.TabIndex = 4;
            this.btnPercentage.Tag = "%";
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = false;
            this.btnPercentage.Click += new System.EventHandler(this.clickOperation);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(221, 143);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(70, 69);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Tag = "÷";
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.clickOperation);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(10, 213);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(70, 69);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.addNumber);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(81, 213);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(70, 69);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.addNumber);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(151, 213);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(70, 69);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.addNumber);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(221, 213);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(70, 69);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Tag = "×";
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.clickOperation);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(10, 283);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(70, 69);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.addNumber);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(81, 283);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(70, 69);
            this.btnFive.TabIndex = 13;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.addNumber);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(151, 283);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(70, 69);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.addNumber);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(221, 283);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(70, 69);
            this.btnSubtract.TabIndex = 15;
            this.btnSubtract.Tag = "-";
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.clickOperation);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(10, 353);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(70, 69);
            this.btnOne.TabIndex = 16;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.addNumber);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(81, 353);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(70, 69);
            this.btnTwo.TabIndex = 17;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.addNumber);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(151, 353);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(70, 69);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.addNumber);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(221, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 69);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Tag = "+";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.clickOperation);
            // 
            // btnNegative
            // 
            this.btnNegative.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegative.Location = new System.Drawing.Point(10, 423);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(70, 69);
            this.btnNegative.TabIndex = 20;
            this.btnNegative.Text = "+/-";
            this.btnNegative.UseVisualStyleBackColor = false;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(81, 423);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(70, 69);
            this.btnCero.TabIndex = 21;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.addNumber);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.Location = new System.Drawing.Point(151, 423);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(70, 69);
            this.btnPoint.TabIndex = 22;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(221, 423);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(70, 69);
            this.btnEqual.TabIndex = 23;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnClearError
            // 
            this.btnClearError.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearError.Location = new System.Drawing.Point(10, 73);
            this.btnClearError.Name = "btnClearError";
            this.btnClearError.Size = new System.Drawing.Size(70, 69);
            this.btnClearError.TabIndex = 1;
            this.btnClearError.Text = "CE";
            this.btnClearError.UseVisualStyleBackColor = false;
            this.btnClearError.Click += new System.EventHandler(this.btnClearError_Click);
            // 
            // btnSquared
            // 
            this.btnSquared.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSquared.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquared.Location = new System.Drawing.Point(151, 143);
            this.btnSquared.Name = "btnSquared";
            this.btnSquared.Size = new System.Drawing.Size(70, 69);
            this.btnSquared.TabIndex = 6;
            this.btnSquared.Tag = "²";
            this.btnSquared.Text = "x²";
            this.btnSquared.UseVisualStyleBackColor = false;
            this.btnSquared.Click += new System.EventHandler(this.clickOperation);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareRoot.Location = new System.Drawing.Point(81, 143);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(70, 69);
            this.btnSquareRoot.TabIndex = 5;
            this.btnSquareRoot.Tag = "√";
            this.btnSquareRoot.Text = "√";
            this.btnSquareRoot.UseVisualStyleBackColor = false;
            this.btnSquareRoot.Click += new System.EventHandler(this.clickOperation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(304, 505);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnSquared);
            this.Controls.Add(this.btnClearError);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxDisplay);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora CH-29 Plus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClearError;
        private System.Windows.Forms.Button btnSquared;
        private System.Windows.Forms.Button btnSquareRoot;
    }
}

