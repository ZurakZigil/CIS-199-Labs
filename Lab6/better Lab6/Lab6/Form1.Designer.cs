namespace Lab6
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
            this.tBoxWordsPerMinute = new System.Windows.Forms.TextBox();
            this.labelWPM = new System.Windows.Forms.Label();
            this.displayGrade = new System.Windows.Forms.Label();
            this.buttCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxWordsPerMinute
            // 
            this.tBoxWordsPerMinute.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxWordsPerMinute.Location = new System.Drawing.Point(42, 48);
            this.tBoxWordsPerMinute.Name = "tBoxWordsPerMinute";
            this.tBoxWordsPerMinute.Size = new System.Drawing.Size(121, 32);
            this.tBoxWordsPerMinute.TabIndex = 0;
            // 
            // labelWPM
            // 
            this.labelWPM.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWPM.Location = new System.Drawing.Point(39, 9);
            this.labelWPM.Name = "labelWPM";
            this.labelWPM.Size = new System.Drawing.Size(124, 36);
            this.labelWPM.TabIndex = 1;
            this.labelWPM.Text = "Words Per Minute";
            this.labelWPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayGrade
            // 
            this.displayGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayGrade.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayGrade.Location = new System.Drawing.Point(42, 135);
            this.displayGrade.Name = "displayGrade";
            this.displayGrade.Size = new System.Drawing.Size(121, 70);
            this.displayGrade.TabIndex = 2;
            this.displayGrade.Text = "Grade";
            this.displayGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttCalc
            // 
            this.buttCalc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttCalc.Location = new System.Drawing.Point(42, 86);
            this.buttCalc.Name = "buttCalc";
            this.buttCalc.Size = new System.Drawing.Size(121, 32);
            this.buttCalc.TabIndex = 3;
            this.buttCalc.Text = "Calculate";
            this.buttCalc.UseVisualStyleBackColor = true;
            this.buttCalc.Click += new System.EventHandler(this.buttCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 224);
            this.Controls.Add(this.buttCalc);
            this.Controls.Add(this.displayGrade);
            this.Controls.Add(this.labelWPM);
            this.Controls.Add(this.tBoxWordsPerMinute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxWordsPerMinute;
        private System.Windows.Forms.Label labelWPM;
        private System.Windows.Forms.Label displayGrade;
        private System.Windows.Forms.Button buttCalc;
    }
}

