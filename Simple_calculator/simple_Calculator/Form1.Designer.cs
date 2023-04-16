namespace simple_Calculator
{
    partial class simpleCal_cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(simpleCal_cs));
            this.label1 = new System.Windows.Forms.Label();
            this.uScreen = new System.Windows.Forms.RichTextBox();
            this.LScreen = new System.Windows.Forms.TextBox();
            this.fac = new System.Windows.Forms.Button();
            this.cel = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.far = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.eq = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.sroot = new System.Windows.Forms.Button();
            this.sq = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.hidePicBtn = new System.Windows.Forms.Button();
            this.keyPad = new System.Windows.Forms.Panel();
            this.sos = new System.Windows.Forms.PictureBox();
            this.keyPad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "soskode@tek.eid";
            // 
            // uScreen
            // 
            this.uScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uScreen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uScreen.Location = new System.Drawing.Point(30, 10);
            this.uScreen.Multiline = false;
            this.uScreen.Name = "uScreen";
            this.uScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uScreen.Size = new System.Drawing.Size(229, 75);
            this.uScreen.TabIndex = 3;
            this.uScreen.Text = "";
            // 
            // LScreen
            // 
            this.LScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LScreen.Location = new System.Drawing.Point(34, 48);
            this.LScreen.Name = "LScreen";
            this.LScreen.Size = new System.Drawing.Size(220, 28);
            this.LScreen.TabIndex = 4;
            this.LScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fac
            // 
            this.fac.Location = new System.Drawing.Point(11, 76);
            this.fac.Name = "fac";
            this.fac.Size = new System.Drawing.Size(40, 23);
            this.fac.TabIndex = 1;
            this.fac.Text = "n!";
            this.fac.UseVisualStyleBackColor = true;
            this.fac.Click += new System.EventHandler(this.fac_Click);
            // 
            // cel
            // 
            this.cel.Location = new System.Drawing.Point(53, 30);
            this.cel.Name = "cel";
            this.cel.Size = new System.Drawing.Size(40, 23);
            this.cel.TabIndex = 2;
            this.cel.Text = "℃";
            this.cel.UseVisualStyleBackColor = true;
            this.cel.Click += new System.EventHandler(this.cel_Click);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(11, 172);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(50, 30);
            this.n1.TabIndex = 3;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // far
            // 
            this.far.Location = new System.Drawing.Point(155, 31);
            this.far.Name = "far";
            this.far.Size = new System.Drawing.Size(40, 24);
            this.far.TabIndex = 4;
            this.far.Text = "℉";
            this.far.UseVisualStyleBackColor = true;
            this.far.Click += new System.EventHandler(this.far_Click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(69, 171);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(50, 30);
            this.n2.TabIndex = 5;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(130, 172);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(50, 30);
            this.n3.TabIndex = 6;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(10, 137);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(50, 30);
            this.n4.TabIndex = 7;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(69, 136);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(50, 30);
            this.n5.TabIndex = 8;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(10, 102);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(50, 30);
            this.n7.TabIndex = 9;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(130, 136);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(50, 30);
            this.n6.TabIndex = 10;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(69, 218);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(50, 23);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button11_Click);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(130, 102);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(50, 30);
            this.n9.TabIndex = 12;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(69, 102);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(50, 30);
            this.n8.TabIndex = 13;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // eq
            // 
            this.eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eq.Location = new System.Drawing.Point(101, 32);
            this.eq.Name = "eq";
            this.eq.Size = new System.Drawing.Size(48, 41);
            this.eq.TabIndex = 14;
            this.eq.Text = "=";
            this.eq.UseVisualStyleBackColor = true;
            this.eq.Click += new System.EventHandler(this.eq_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(130, 208);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(48, 33);
            this.dot.TabIndex = 15;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(10, 30);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(40, 23);
            this.mod.TabIndex = 16;
            this.mod.Text = "mod";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(189, 199);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 40);
            this.plus.TabIndex = 17;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(189, 157);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(50, 40);
            this.min.TabIndex = 18;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(189, 111);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(50, 40);
            this.times.TabIndex = 19;
            this.times.Text = "x";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(189, 72);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(50, 33);
            this.div.TabIndex = 20;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // sroot
            // 
            this.sroot.Location = new System.Drawing.Point(69, 76);
            this.sroot.Name = "sroot";
            this.sroot.Size = new System.Drawing.Size(50, 23);
            this.sroot.TabIndex = 21;
            this.sroot.Text = "√";
            this.sroot.UseVisualStyleBackColor = true;
            this.sroot.Click += new System.EventHandler(this.sroot_Click);
            // 
            // sq
            // 
            this.sq.Location = new System.Drawing.Point(130, 76);
            this.sq.Name = "sq";
            this.sq.Size = new System.Drawing.Size(50, 23);
            this.sq.TabIndex = 22;
            this.sq.Text = "x^2";
            this.sq.UseVisualStyleBackColor = true;
            this.sq.Click += new System.EventHandler(this.sq_Click);
            // 
            // ac
            // 
            this.ac.Location = new System.Drawing.Point(11, 216);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(35, 23);
            this.ac.TabIndex = 23;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(201, 31);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(35, 23);
            this.del.TabIndex = 24;
            this.del.Text = "Del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // hidePicBtn
            // 
            this.hidePicBtn.Location = new System.Drawing.Point(106, 3);
            this.hidePicBtn.Name = "hidePicBtn";
            this.hidePicBtn.Size = new System.Drawing.Size(26, 23);
            this.hidePicBtn.TabIndex = 5;
            this.hidePicBtn.Text = ">";
            this.hidePicBtn.UseVisualStyleBackColor = true;
            this.hidePicBtn.Click += new System.EventHandler(this.hidePicBtn_Click);
            // 
            // keyPad
            // 
            this.keyPad.Controls.Add(this.hidePicBtn);
            this.keyPad.Controls.Add(this.del);
            this.keyPad.Controls.Add(this.eq);
            this.keyPad.Controls.Add(this.ac);
            this.keyPad.Controls.Add(this.sq);
            this.keyPad.Controls.Add(this.sroot);
            this.keyPad.Controls.Add(this.div);
            this.keyPad.Controls.Add(this.times);
            this.keyPad.Controls.Add(this.min);
            this.keyPad.Controls.Add(this.plus);
            this.keyPad.Controls.Add(this.mod);
            this.keyPad.Controls.Add(this.dot);
            this.keyPad.Controls.Add(this.n8);
            this.keyPad.Controls.Add(this.n9);
            this.keyPad.Controls.Add(this.zero);
            this.keyPad.Controls.Add(this.n6);
            this.keyPad.Controls.Add(this.n7);
            this.keyPad.Controls.Add(this.n5);
            this.keyPad.Controls.Add(this.n4);
            this.keyPad.Controls.Add(this.n3);
            this.keyPad.Controls.Add(this.n2);
            this.keyPad.Controls.Add(this.far);
            this.keyPad.Controls.Add(this.n1);
            this.keyPad.Controls.Add(this.cel);
            this.keyPad.Controls.Add(this.fac);
            this.keyPad.Controls.Add(this.sos);
            this.keyPad.Location = new System.Drawing.Point(23, 91);
            this.keyPad.Name = "keyPad";
            this.keyPad.Size = new System.Drawing.Size(247, 255);
            this.keyPad.TabIndex = 2;
            // 
            // sos
            // 
            this.sos.Image = ((System.Drawing.Image)(resources.GetObject("sos.Image")));
            this.sos.Location = new System.Drawing.Point(18, 28);
            this.sos.Name = "sos";
            this.sos.Size = new System.Drawing.Size(227, 214);
            this.sos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sos.TabIndex = 26;
            this.sos.TabStop = false;
            // 
            // simpleCal_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 368);
            this.Controls.Add(this.keyPad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LScreen);
            this.Controls.Add(this.uScreen);
            this.Name = "simpleCal_cs";
            this.Text = "SosOpera";
            this.keyPad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox uScreen;
        private System.Windows.Forms.TextBox LScreen;
        private System.Windows.Forms.Button fac;
        private System.Windows.Forms.Button cel;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button far;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button eq;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button sroot;
        private System.Windows.Forms.Button sq;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button hidePicBtn;
        private System.Windows.Forms.Panel keyPad;
        private System.Windows.Forms.PictureBox sos;
    }
}

