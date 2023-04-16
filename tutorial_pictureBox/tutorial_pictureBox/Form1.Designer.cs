namespace tutorial_pictureBox
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
            this.mantaniPic = new System.Windows.Forms.PictureBox();
            this.hideImg = new System.Windows.Forms.Button();
            this.showImg = new System.Windows.Forms.Button();
            this.ayusPic = new System.Windows.Forms.PictureBox();
            this.imageToggleB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mantaniPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayusPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mantaniPic
            // 
            this.mantaniPic.Image = ((System.Drawing.Image)(resources.GetObject("mantaniPic.Image")));
            this.mantaniPic.Location = new System.Drawing.Point(353, 62);
            this.mantaniPic.Name = "mantaniPic";
            this.mantaniPic.Size = new System.Drawing.Size(144, 149);
            this.mantaniPic.TabIndex = 0;
            this.mantaniPic.TabStop = false;
            this.mantaniPic.Visible = false;
            // 
            // hideImg
            // 
            this.hideImg.Location = new System.Drawing.Point(422, 243);
            this.hideImg.Name = "hideImg";
            this.hideImg.Size = new System.Drawing.Size(75, 23);
            this.hideImg.TabIndex = 1;
            this.hideImg.Text = "Hide pic";
            this.hideImg.UseVisualStyleBackColor = true;
            this.hideImg.Click += new System.EventHandler(this.hideImg_Click);
            // 
            // showImg
            // 
            this.showImg.Location = new System.Drawing.Point(338, 243);
            this.showImg.Name = "showImg";
            this.showImg.Size = new System.Drawing.Size(75, 23);
            this.showImg.TabIndex = 2;
            this.showImg.Text = "Show pic";
            this.showImg.UseVisualStyleBackColor = true;
            this.showImg.Click += new System.EventHandler(this.showImg_Click);
            // 
            // ayusPic
            // 
            this.ayusPic.Image = ((System.Drawing.Image)(resources.GetObject("ayusPic.Image")));
            this.ayusPic.Location = new System.Drawing.Point(12, 2);
            this.ayusPic.Name = "ayusPic";
            this.ayusPic.Size = new System.Drawing.Size(268, 327);
            this.ayusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ayusPic.TabIndex = 3;
            this.ayusPic.TabStop = false;
            // 
            // imageToggleB
            // 
            this.imageToggleB.Location = new System.Drawing.Point(98, 345);
            this.imageToggleB.Name = "imageToggleB";
            this.imageToggleB.Size = new System.Drawing.Size(75, 23);
            this.imageToggleB.TabIndex = 4;
            this.imageToggleB.Text = "Show image";
            this.imageToggleB.UseVisualStyleBackColor = true;
            this.imageToggleB.Click += new System.EventHandler(this.imageToggleB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 394);
            this.Controls.Add(this.imageToggleB);
            this.Controls.Add(this.ayusPic);
            this.Controls.Add(this.showImg);
            this.Controls.Add(this.hideImg);
            this.Controls.Add(this.mantaniPic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mantaniPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayusPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mantaniPic;
        private System.Windows.Forms.Button hideImg;
        private System.Windows.Forms.Button showImg;
        private System.Windows.Forms.PictureBox ayusPic;
        private System.Windows.Forms.Button imageToggleB;
    }
}

