namespace simpleForm
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
            this.Fname = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.showNameBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.FnameTB = new System.Windows.Forms.TextBox();
            this.LnameTB = new System.Windows.Forms.TextBox();
            this.oldMan = new System.Windows.Forms.PictureBox();
            this.showImageBtn = new System.Windows.Forms.Button();
            this.hideImg = new System.Windows.Forms.Button();
            this.searchTF = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.oldMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(91, 220);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(69, 13);
            this.Fname.TabIndex = 0;
            this.Fname.Text = "FIRSTNAME";
            this.Fname.Click += new System.EventHandler(this.Fname_Click);
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(91, 287);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(65, 13);
            this.Lname.TabIndex = 1;
            this.Lname.Text = "LASTNAME";
            // 
            // showNameBtn
            // 
            this.showNameBtn.Location = new System.Drawing.Point(94, 359);
            this.showNameBtn.Name = "showNameBtn";
            this.showNameBtn.Size = new System.Drawing.Size(141, 23);
            this.showNameBtn.TabIndex = 2;
            this.showNameBtn.Text = "Show name";
            this.showNameBtn.UseVisualStyleBackColor = true;
            this.showNameBtn.Click += new System.EventHandler(this.showNameBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(551, 386);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // FnameTB
            // 
            this.FnameTB.Location = new System.Drawing.Point(94, 248);
            this.FnameTB.Name = "FnameTB";
            this.FnameTB.Size = new System.Drawing.Size(100, 20);
            this.FnameTB.TabIndex = 4;
            this.FnameTB.TextChanged += new System.EventHandler(this.FnameTB_TextChanged);
            // 
            // LnameTB
            // 
            this.LnameTB.Location = new System.Drawing.Point(94, 316);
            this.LnameTB.Name = "LnameTB";
            this.LnameTB.Size = new System.Drawing.Size(100, 20);
            this.LnameTB.TabIndex = 5;
            // 
            // oldMan
            // 
            this.oldMan.Image = ((System.Drawing.Image)(resources.GetObject("oldMan.Image")));
            this.oldMan.InitialImage = ((System.Drawing.Image)(resources.GetObject("oldMan.InitialImage")));
            this.oldMan.Location = new System.Drawing.Point(229, 12);
            this.oldMan.Name = "oldMan";
            this.oldMan.Size = new System.Drawing.Size(351, 205);
            this.oldMan.TabIndex = 6;
            this.oldMan.TabStop = false;
            this.oldMan.UseWaitCursor = true;
            this.oldMan.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // showImageBtn
            // 
            this.showImageBtn.Location = new System.Drawing.Point(335, 359);
            this.showImageBtn.Name = "showImageBtn";
            this.showImageBtn.Size = new System.Drawing.Size(75, 23);
            this.showImageBtn.TabIndex = 7;
            this.showImageBtn.Text = "Show image";
            this.showImageBtn.UseVisualStyleBackColor = true;
            this.showImageBtn.Click += new System.EventHandler(this.showImageBtn_Click);
            // 
            // hideImg
            // 
            this.hideImg.Location = new System.Drawing.Point(477, 358);
            this.hideImg.Name = "hideImg";
            this.hideImg.Size = new System.Drawing.Size(75, 23);
            this.hideImg.TabIndex = 8;
            this.hideImg.Text = "Hide image";
            this.hideImg.UseVisualStyleBackColor = true;
            this.hideImg.Click += new System.EventHandler(this.hideImg_Click);
            // 
            // searchTF
            // 
            this.searchTF.Location = new System.Drawing.Point(452, 298);
            this.searchTF.Name = "searchTF";
            this.searchTF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchTF.Size = new System.Drawing.Size(100, 20);
            this.searchTF.TabIndex = 9;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(558, 298);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "search person";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search person records by name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTF);
            this.Controls.Add(this.hideImg);
            this.Controls.Add(this.showImageBtn);
            this.Controls.Add(this.oldMan);
            this.Controls.Add(this.LnameTB);
            this.Controls.Add(this.FnameTB);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.showNameBtn);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.oldMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Button showNameBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox FnameTB;
        private System.Windows.Forms.TextBox LnameTB;
        private System.Windows.Forms.PictureBox oldMan;
        private System.Windows.Forms.Button showImageBtn;
        private System.Windows.Forms.Button hideImg;
        private System.Windows.Forms.TextBox searchTF;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

