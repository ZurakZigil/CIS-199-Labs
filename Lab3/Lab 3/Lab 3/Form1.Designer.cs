namespace Lab_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttCalc = new System.Windows.Forms.Button();
            this.textBoxRad = new System.Windows.Forms.TextBox();
            this.labRad = new System.Windows.Forms.Label();
            this.displaySurfaceA = new System.Windows.Forms.Label();
            this.displayDiam = new System.Windows.Forms.Label();
            this.labSurf = new System.Windows.Forms.Label();
            this.labDiam = new System.Windows.Forms.Label();
            this.pBoxRad1 = new System.Windows.Forms.PictureBox();
            this.pBoxRad2 = new System.Windows.Forms.PictureBox();
            this.displayVol = new System.Windows.Forms.Label();
            this.labVol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRad2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttCalc
            // 
            this.buttCalc.Location = new System.Drawing.Point(269, 117);
            this.buttCalc.Name = "buttCalc";
            this.buttCalc.Size = new System.Drawing.Size(103, 23);
            this.buttCalc.TabIndex = 5;
            this.buttCalc.Text = "Calculate";
            this.buttCalc.UseVisualStyleBackColor = true;
            this.buttCalc.Click += new System.EventHandler(this.buttCalc_Click);
            // 
            // textBoxRad
            // 
            this.textBoxRad.Location = new System.Drawing.Point(269, 79);
            this.textBoxRad.Name = "textBoxRad";
            this.textBoxRad.Size = new System.Drawing.Size(103, 20);
            this.textBoxRad.TabIndex = 4;
            // 
            // labRad
            // 
            this.labRad.AutoSize = true;
            this.labRad.Location = new System.Drawing.Point(173, 86);
            this.labRad.Name = "labRad";
            this.labRad.Size = new System.Drawing.Size(90, 13);
            this.labRad.TabIndex = 3;
            this.labRad.Text = "Radius of sphere:";
            // 
            // displaySurfaceA
            // 
            this.displaySurfaceA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displaySurfaceA.Location = new System.Drawing.Point(89, 238);
            this.displaySurfaceA.Name = "displaySurfaceA";
            this.displaySurfaceA.Size = new System.Drawing.Size(106, 22);
            this.displaySurfaceA.TabIndex = 10;
            this.displaySurfaceA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // displayDiam
            // 
            this.displayDiam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayDiam.Location = new System.Drawing.Point(89, 193);
            this.displayDiam.Name = "displayDiam";
            this.displayDiam.Size = new System.Drawing.Size(106, 22);
            this.displayDiam.TabIndex = 9;
            this.displayDiam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labSurf
            // 
            this.labSurf.AutoSize = true;
            this.labSurf.Location = new System.Drawing.Point(11, 243);
            this.labSurf.Name = "labSurf";
            this.labSurf.Size = new System.Drawing.Size(72, 13);
            this.labSurf.TabIndex = 8;
            this.labSurf.Text = "Surface Area:";
            // 
            // labDiam
            // 
            this.labDiam.AutoSize = true;
            this.labDiam.Location = new System.Drawing.Point(31, 198);
            this.labDiam.Name = "labDiam";
            this.labDiam.Size = new System.Drawing.Size(52, 13);
            this.labDiam.TabIndex = 7;
            this.labDiam.Text = "Diameter:";
            // 
            // pBoxRad1
            // 
            this.pBoxRad1.Image = ((System.Drawing.Image)(resources.GetObject("pBoxRad1.Image")));
            this.pBoxRad1.Location = new System.Drawing.Point(14, 12);
            this.pBoxRad1.Name = "pBoxRad1";
            this.pBoxRad1.Size = new System.Drawing.Size(150, 150);
            this.pBoxRad1.TabIndex = 11;
            this.pBoxRad1.TabStop = false;
            // 
            // pBoxRad2
            // 
            this.pBoxRad2.Image = ((System.Drawing.Image)(resources.GetObject("pBoxRad2.Image")));
            this.pBoxRad2.Location = new System.Drawing.Point(222, 199);
            this.pBoxRad2.Name = "pBoxRad2";
            this.pBoxRad2.Size = new System.Drawing.Size(150, 150);
            this.pBoxRad2.TabIndex = 12;
            this.pBoxRad2.TabStop = false;
            // 
            // displayVol
            // 
            this.displayVol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayVol.Location = new System.Drawing.Point(89, 283);
            this.displayVol.Name = "displayVol";
            this.displayVol.Size = new System.Drawing.Size(106, 22);
            this.displayVol.TabIndex = 14;
            this.displayVol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labVol
            // 
            this.labVol.AutoSize = true;
            this.labVol.Location = new System.Drawing.Point(38, 288);
            this.labVol.Name = "labVol";
            this.labVol.Size = new System.Drawing.Size(45, 13);
            this.labVol.TabIndex = 13;
            this.labVol.Text = "Volume:";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.displayVol);
            this.Controls.Add(this.labVol);
            this.Controls.Add(this.pBoxRad2);
            this.Controls.Add(this.pBoxRad1);
            this.Controls.Add(this.displaySurfaceA);
            this.Controls.Add(this.displayDiam);
            this.Controls.Add(this.labSurf);
            this.Controls.Add(this.labDiam);
            this.Controls.Add(this.buttCalc);
            this.Controls.Add(this.textBoxRad);
            this.Controls.Add(this.labRad);
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRad2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttCalc;
        private System.Windows.Forms.TextBox textBoxRad;
        private System.Windows.Forms.Label labRad;
        private System.Windows.Forms.Label displaySurfaceA;
        private System.Windows.Forms.Label displayDiam;
        private System.Windows.Forms.Label labSurf;
        private System.Windows.Forms.Label labDiam;
        private System.Windows.Forms.PictureBox pBoxRad1;
        private System.Windows.Forms.PictureBox pBoxRad2;
        private System.Windows.Forms.Label displayVol;
        private System.Windows.Forms.Label labVol;
    }
}

