namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.ndot = new System.Windows.Forms.Button();
            this.bc = new System.Windows.Forms.Button();
            this.nequal = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.bad = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(112, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(295, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(13, 73);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(74, 39);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(104, 73);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(83, 39);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(210, 73);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(83, 39);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(12, 138);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(75, 35);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(104, 138);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(83, 35);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(210, 138);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(83, 35);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(12, 193);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(75, 33);
            this.n7.TabIndex = 7;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(104, 193);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(83, 33);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(210, 193);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(83, 33);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(104, 245);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(83, 31);
            this.n0.TabIndex = 10;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // ndot
            // 
            this.ndot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ndot.Location = new System.Drawing.Point(12, 245);
            this.ndot.Name = "ndot";
            this.ndot.Size = new System.Drawing.Size(75, 31);
            this.ndot.TabIndex = 11;
            this.ndot.Text = ".";
            this.ndot.UseVisualStyleBackColor = true;
            this.ndot.Click += new System.EventHandler(this.ndot_Click);
            // 
            // bc
            // 
            this.bc.Location = new System.Drawing.Point(218, 245);
            this.bc.Name = "bc";
            this.bc.Size = new System.Drawing.Size(75, 31);
            this.bc.TabIndex = 12;
            this.bc.Text = "C";
            this.bc.UseVisualStyleBackColor = true;
            this.bc.Click += new System.EventHandler(this.bc_Click);
            // 
            // nequal
            // 
            this.nequal.Location = new System.Drawing.Point(112, 307);
            this.nequal.Name = "nequal";
            this.nequal.Size = new System.Drawing.Size(75, 42);
            this.nequal.TabIndex = 13;
            this.nequal.Text = "=";
            this.nequal.UseVisualStyleBackColor = true;
            this.nequal.Click += new System.EventHandler(this.nequal_Click);
            // 
            // bmul
            // 
            this.bmul.Location = new System.Drawing.Point(332, 193);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(75, 33);
            this.bmul.TabIndex = 14;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = true;
            this.bmul.Click += new System.EventHandler(this.bmul_Click);
            // 
            // bad
            // 
            this.bad.Location = new System.Drawing.Point(332, 73);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(75, 39);
            this.bad.TabIndex = 15;
            this.bad.Text = "+";
            this.bad.UseVisualStyleBackColor = true;
            this.bad.Click += new System.EventHandler(this.bad_Click);
            // 
            // bsub
            // 
            this.bsub.Location = new System.Drawing.Point(332, 138);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(75, 35);
            this.bsub.TabIndex = 16;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // bdiv
            // 
            this.bdiv.Location = new System.Drawing.Point(332, 245);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(75, 31);
            this.bdiv.TabIndex = 17;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.nequal);
            this.Controls.Add(this.bc);
            this.Controls.Add(this.ndot);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button ndot;
        private System.Windows.Forms.Button bc;
        private System.Windows.Forms.Button nequal;
        private System.Windows.Forms.Button bmul;
        private System.Windows.Forms.Button bad;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Label label1;
    }
}

