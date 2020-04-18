namespace Lab7
{
    partial class FormmMain
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
            this.labelFutureValue = new System.Windows.Forms.Label();
            this.tBoxFutureValue = new System.Windows.Forms.TextBox();
            this.tBoxAnnualRate = new System.Windows.Forms.TextBox();
            this.labelAIR = new System.Windows.Forms.Label();
            this.tBoxNoYears = new System.Windows.Forms.TextBox();
            this.labelNoYears = new System.Windows.Forms.Label();
            this.displayPresentValue = new System.Windows.Forms.Label();
            this.labelPresentValue = new System.Windows.Forms.Label();
            this.buttCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFutureValue
            // 
            this.labelFutureValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFutureValue.Location = new System.Drawing.Point(32, 34);
            this.labelFutureValue.Name = "labelFutureValue";
            this.labelFutureValue.Size = new System.Drawing.Size(239, 33);
            this.labelFutureValue.TabIndex = 0;
            this.labelFutureValue.Text = "Future Value:";
            this.labelFutureValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxFutureValue
            // 
            this.tBoxFutureValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxFutureValue.Location = new System.Drawing.Point(296, 34);
            this.tBoxFutureValue.Name = "tBoxFutureValue";
            this.tBoxFutureValue.Size = new System.Drawing.Size(217, 35);
            this.tBoxFutureValue.TabIndex = 1;
            // 
            // tBoxAnnualRate
            // 
            this.tBoxAnnualRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAnnualRate.Location = new System.Drawing.Point(296, 84);
            this.tBoxAnnualRate.Name = "tBoxAnnualRate";
            this.tBoxAnnualRate.Size = new System.Drawing.Size(217, 35);
            this.tBoxAnnualRate.TabIndex = 3;
            // 
            // labelAIR
            // 
            this.labelAIR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAIR.Location = new System.Drawing.Point(32, 84);
            this.labelAIR.Name = "labelAIR";
            this.labelAIR.Size = new System.Drawing.Size(239, 33);
            this.labelAIR.TabIndex = 2;
            this.labelAIR.Text = "Annual Interest Rate:";
            this.labelAIR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxNoYears
            // 
            this.tBoxNoYears.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNoYears.Location = new System.Drawing.Point(296, 136);
            this.tBoxNoYears.Name = "tBoxNoYears";
            this.tBoxNoYears.Size = new System.Drawing.Size(217, 35);
            this.tBoxNoYears.TabIndex = 5;
            // 
            // labelNoYears
            // 
            this.labelNoYears.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoYears.Location = new System.Drawing.Point(32, 136);
            this.labelNoYears.Name = "labelNoYears";
            this.labelNoYears.Size = new System.Drawing.Size(239, 33);
            this.labelNoYears.TabIndex = 4;
            this.labelNoYears.Text = "No. of Year(s):";
            this.labelNoYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // displayPresentValue
            // 
            this.displayPresentValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPresentValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPresentValue.Location = new System.Drawing.Point(296, 213);
            this.displayPresentValue.Name = "displayPresentValue";
            this.displayPresentValue.Size = new System.Drawing.Size(217, 33);
            this.displayPresentValue.TabIndex = 8;
            this.displayPresentValue.Text = "$";
            this.displayPresentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPresentValue
            // 
            this.labelPresentValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentValue.Location = new System.Drawing.Point(32, 213);
            this.labelPresentValue.Name = "labelPresentValue";
            this.labelPresentValue.Size = new System.Drawing.Size(239, 33);
            this.labelPresentValue.TabIndex = 9;
            this.labelPresentValue.Text = "Present Value:";
            this.labelPresentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttCalc
            // 
            this.buttCalc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCalc.Location = new System.Drawing.Point(37, 269);
            this.buttCalc.Name = "buttCalc";
            this.buttCalc.Size = new System.Drawing.Size(476, 43);
            this.buttCalc.TabIndex = 10;
            this.buttCalc.Text = "Calculate";
            this.buttCalc.UseVisualStyleBackColor = true;
            this.buttCalc.Click += new System.EventHandler(this.buttCalc_Click);
            // 
            // FormmMain
            // 
            this.AcceptButton = this.buttCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 328);
            this.Controls.Add(this.buttCalc);
            this.Controls.Add(this.labelPresentValue);
            this.Controls.Add(this.displayPresentValue);
            this.Controls.Add(this.tBoxNoYears);
            this.Controls.Add(this.labelNoYears);
            this.Controls.Add(this.tBoxAnnualRate);
            this.Controls.Add(this.labelAIR);
            this.Controls.Add(this.tBoxFutureValue);
            this.Controls.Add(this.labelFutureValue);
            this.Name = "FormmMain";
            this.Text = "Lab 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFutureValue;
        private System.Windows.Forms.TextBox tBoxFutureValue;
        private System.Windows.Forms.TextBox tBoxAnnualRate;
        private System.Windows.Forms.Label labelAIR;
        private System.Windows.Forms.TextBox tBoxNoYears;
        private System.Windows.Forms.Label labelNoYears;
        private System.Windows.Forms.Label displayPresentValue;
        private System.Windows.Forms.Label labelPresentValue;
        private System.Windows.Forms.Button buttCalc;
    }
}

