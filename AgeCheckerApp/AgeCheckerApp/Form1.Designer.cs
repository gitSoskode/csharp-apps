namespace AgeCheckerApp
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.screenTF = new System.Windows.Forms.TextBox();
            this.ageTf = new System.Windows.Forms.TextBox();
            this.nameTF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(325, 398);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(113, 35);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter age";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // screenTF
            // 
            this.screenTF.Location = new System.Drawing.Point(226, 307);
            this.screenTF.Margin = new System.Windows.Forms.Padding(5);
            this.screenTF.Name = "screenTF";
            this.screenTF.Size = new System.Drawing.Size(372, 26);
            this.screenTF.TabIndex = 3;
            this.screenTF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ageTf
            // 
            this.ageTf.Location = new System.Drawing.Point(425, 149);
            this.ageTf.Margin = new System.Windows.Forms.Padding(5);
            this.ageTf.Name = "ageTf";
            this.ageTf.Size = new System.Drawing.Size(148, 26);
            this.ageTf.TabIndex = 4;
            this.ageTf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nameTF
            // 
            this.nameTF.Location = new System.Drawing.Point(425, 60);
            this.nameTF.Margin = new System.Windows.Forms.Padding(5);
            this.nameTF.Name = "nameTF";
            this.nameTF.Size = new System.Drawing.Size(148, 26);
            this.nameTF.TabIndex = 5;
            this.nameTF.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 447);
            this.Controls.Add(this.nameTF);
            this.Controls.Add(this.ageTf);
            this.Controls.Add(this.screenTF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Age Checker App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox screenTF;
        private System.Windows.Forms.TextBox ageTf;
        private System.Windows.Forms.TextBox nameTF;
    }
}

