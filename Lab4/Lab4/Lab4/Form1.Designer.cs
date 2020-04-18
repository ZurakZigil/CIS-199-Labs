namespace Lab4
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
            this.labTestScore = new System.Windows.Forms.Label();
            this.labGPA = new System.Windows.Forms.Label();
            this.buttTest = new System.Windows.Forms.Button();
            this.labReject = new System.Windows.Forms.Label();
            this.labAccept = new System.Windows.Forms.Label();
            this.displayResults = new System.Windows.Forms.Label();
            this.displayCounterRejects = new System.Windows.Forms.Label();
            this.displayCounterAccepts = new System.Windows.Forms.Label();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.textBoxTScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labTestScore
            // 
            this.labTestScore.AutoSize = true;
            this.labTestScore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestScore.Location = new System.Drawing.Point(3, 67);
            this.labTestScore.Name = "labTestScore";
            this.labTestScore.Size = new System.Drawing.Size(74, 16);
            this.labTestScore.TabIndex = 17;
            this.labTestScore.Text = "Test Score:";
            // 
            // labGPA
            // 
            this.labGPA.AutoSize = true;
            this.labGPA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGPA.Location = new System.Drawing.Point(33, 30);
            this.labGPA.Name = "labGPA";
            this.labGPA.Size = new System.Drawing.Size(39, 16);
            this.labGPA.TabIndex = 15;
            this.labGPA.Text = "GPA:";
            // 
            // buttTest
            // 
            this.buttTest.Location = new System.Drawing.Point(116, 102);
            this.buttTest.Name = "buttTest";
            this.buttTest.Size = new System.Drawing.Size(73, 23);
            this.buttTest.TabIndex = 19;
            this.buttTest.Text = "Test";
            this.buttTest.UseVisualStyleBackColor = true;
            this.buttTest.Click += new System.EventHandler(this.buttTest_Click);
            // 
            // labReject
            // 
            this.labReject.Location = new System.Drawing.Point(361, 112);
            this.labReject.Name = "labReject";
            this.labReject.Size = new System.Drawing.Size(72, 13);
            this.labReject.TabIndex = 21;
            this.labReject.Text = "# of Rejects:";
            // 
            // labAccept
            // 
            this.labAccept.Location = new System.Drawing.Point(358, 99);
            this.labAccept.Name = "labAccept";
            this.labAccept.Size = new System.Drawing.Size(72, 13);
            this.labAccept.TabIndex = 20;
            this.labAccept.Text = "# of Accepts:";
            // 
            // displayResults
            // 
            this.displayResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayResults.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayResults.Location = new System.Drawing.Point(239, 29);
            this.displayResults.Name = "displayResults";
            this.displayResults.Size = new System.Drawing.Size(239, 57);
            this.displayResults.TabIndex = 22;
            this.displayResults.Text = "hi";
            this.displayResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayCounterRejects
            // 
            this.displayCounterRejects.Location = new System.Drawing.Point(436, 112);
            this.displayCounterRejects.Name = "displayCounterRejects";
            this.displayCounterRejects.Size = new System.Drawing.Size(42, 13);
            this.displayCounterRejects.TabIndex = 24;
            this.displayCounterRejects.Text = "-";
            // 
            // displayCounterAccepts
            // 
            this.displayCounterAccepts.Location = new System.Drawing.Point(436, 99);
            this.displayCounterAccepts.Name = "displayCounterAccepts";
            this.displayCounterAccepts.Size = new System.Drawing.Size(42, 13);
            this.displayCounterAccepts.TabIndex = 23;
            this.displayCounterAccepts.Text = "-";
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Location = new System.Drawing.Point(83, 29);
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(106, 20);
            this.textBoxGPA.TabIndex = 25;
            // 
            // textBoxTScore
            // 
            this.textBoxTScore.Location = new System.Drawing.Point(83, 66);
            this.textBoxTScore.Name = "textBoxTScore";
            this.textBoxTScore.Size = new System.Drawing.Size(106, 20);
            this.textBoxTScore.TabIndex = 26;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttTest;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 144);
            this.Controls.Add(this.textBoxTScore);
            this.Controls.Add(this.textBoxGPA);
            this.Controls.Add(this.displayCounterRejects);
            this.Controls.Add(this.displayCounterAccepts);
            this.Controls.Add(this.displayResults);
            this.Controls.Add(this.labReject);
            this.Controls.Add(this.labAccept);
            this.Controls.Add(this.buttTest);
            this.Controls.Add(this.labTestScore);
            this.Controls.Add(this.labGPA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labTestScore;
        private System.Windows.Forms.Label labGPA;
        private System.Windows.Forms.Button buttTest;
        private System.Windows.Forms.Label labReject;
        private System.Windows.Forms.Label labAccept;
        private System.Windows.Forms.Label displayResults;
        private System.Windows.Forms.Label displayCounterRejects;
        private System.Windows.Forms.Label displayCounterAccepts;
        private System.Windows.Forms.TextBox textBoxGPA;
        private System.Windows.Forms.TextBox textBoxTScore;
    }
}

