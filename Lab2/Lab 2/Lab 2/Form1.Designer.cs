namespace Lab_2
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
            this.priceInput = new System.Windows.Forms.TextBox();
            this.labelSubT = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelTip1 = new System.Windows.Forms.Label();
            this.displayTip2 = new System.Windows.Forms.Label();
            this.displayTip3 = new System.Windows.Forms.Label();
            this.displayTip4 = new System.Windows.Forms.Label();
            this.displayTip1 = new System.Windows.Forms.Label();
            this.displayTip5 = new System.Windows.Forms.Label();
            this.labelTip5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTip2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTip3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTip4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(86, 18);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(112, 20);
            this.priceInput.TabIndex = 0;
            this.priceInput.Text = "Price";
            this.priceInput.TextChanged += new System.EventHandler(this.priceInput_TextChanged);
            // 
            // labelSubT
            // 
            this.labelSubT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubT.Location = new System.Drawing.Point(8, 9);
            this.labelSubT.Name = "labelSubT";
            this.labelSubT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSubT.Size = new System.Drawing.Size(74, 43);
            this.labelSubT.TabIndex = 1;
            this.labelSubT.Text = "Enter Price of Meal";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(13, 201);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(186, 35);
            this.buttonCalc.TabIndex = 2;
            this.buttonCalc.Text = "Calculate Tip";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelTip1
            // 
            this.labelTip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip1.Location = new System.Drawing.Point(13, 62);
            this.labelTip1.Name = "labelTip1";
            this.labelTip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTip1.Size = new System.Drawing.Size(41, 20);
            this.labelTip1.TabIndex = 4;
            this.labelTip1.Text = ".88";
            // 
            // displayTip2
            // 
            this.displayTip2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTip2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTip2.Location = new System.Drawing.Point(86, 87);
            this.displayTip2.Name = "displayTip2";
            this.displayTip2.Size = new System.Drawing.Size(113, 19);
            this.displayTip2.TabIndex = 11;
            // 
            // displayTip3
            // 
            this.displayTip3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTip3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTip3.Location = new System.Drawing.Point(86, 113);
            this.displayTip3.Name = "displayTip3";
            this.displayTip3.Size = new System.Drawing.Size(113, 19);
            this.displayTip3.TabIndex = 12;
            // 
            // displayTip4
            // 
            this.displayTip4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTip4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTip4.Location = new System.Drawing.Point(86, 139);
            this.displayTip4.Name = "displayTip4";
            this.displayTip4.Size = new System.Drawing.Size(113, 19);
            this.displayTip4.TabIndex = 13;
            // 
            // displayTip1
            // 
            this.displayTip1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTip1.Location = new System.Drawing.Point(86, 61);
            this.displayTip1.Name = "displayTip1";
            this.displayTip1.Size = new System.Drawing.Size(113, 19);
            this.displayTip1.TabIndex = 14;
            // 
            // displayTip5
            // 
            this.displayTip5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTip5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTip5.Location = new System.Drawing.Point(85, 163);
            this.displayTip5.Name = "displayTip5";
            this.displayTip5.Size = new System.Drawing.Size(113, 19);
            this.displayTip5.TabIndex = 15;
            this.displayTip5.Text = "Custom Tip Whole Number";
            // 
            // labelTip5
            // 
            this.labelTip5.Location = new System.Drawing.Point(13, 163);
            this.labelTip5.MaxLength = 2;
            this.labelTip5.Name = "labelTip5";
            this.labelTip5.Size = new System.Drawing.Size(64, 20);
            this.labelTip5.TabIndex = 16;
            this.labelTip5.Text = "25";
            this.labelTip5.TextChanged += new System.EventHandler(this.labelTip5_TextChanged);
            this.labelTip5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelTip5_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 61);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 87);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "%";
            // 
            // labelTip2
            // 
            this.labelTip2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip2.Location = new System.Drawing.Point(13, 88);
            this.labelTip2.Name = "labelTip2";
            this.labelTip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTip2.Size = new System.Drawing.Size(41, 20);
            this.labelTip2.TabIndex = 18;
            this.labelTip2.Text = ".18";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 113);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "%";
            // 
            // labelTip3
            // 
            this.labelTip3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip3.Location = new System.Drawing.Point(13, 114);
            this.labelTip3.Name = "labelTip3";
            this.labelTip3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTip3.Size = new System.Drawing.Size(41, 20);
            this.labelTip3.TabIndex = 20;
            this.labelTip3.Text = ".20";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 139);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "%";
            // 
            // labelTip4
            // 
            this.labelTip4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip4.Location = new System.Drawing.Point(13, 140);
            this.labelTip4.Name = "labelTip4";
            this.labelTip4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTip4.Size = new System.Drawing.Size(41, 20);
            this.labelTip4.TabIndex = 22;
            this.labelTip4.Text = ".22";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(211, 248);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTip4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTip3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTip2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTip5);
            this.Controls.Add(this.displayTip5);
            this.Controls.Add(this.displayTip1);
            this.Controls.Add(this.displayTip4);
            this.Controls.Add(this.displayTip3);
            this.Controls.Add(this.displayTip2);
            this.Controls.Add(this.labelTip1);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelSubT);
            this.Controls.Add(this.priceInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.Label labelSubT;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelTip1;
        private System.Windows.Forms.Label displayTip2;
        private System.Windows.Forms.Label displayTip3;
        private System.Windows.Forms.Label displayTip4;
        private System.Windows.Forms.Label displayTip1;
        private System.Windows.Forms.Label displayTip5;
        private System.Windows.Forms.TextBox labelTip5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTip2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTip3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTip4;
    }
}

