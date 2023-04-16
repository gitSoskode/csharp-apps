using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial_pictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showImg_Click(object sender, EventArgs e)
        {
            mantaniPic.Visible = true;
        }

        private void hideImg_Click(object sender, EventArgs e)
        {
            mantaniPic.Visible = false;
        }

        int C=0;

        private void imageToggleB_Click(object sender, EventArgs e)
        {
            if (C % 2 == 0)
            {
                ayusPic.Visible = true;
                imageToggleB.Text = "Hide image";
                C++;
            }
            else
            {
                ayusPic.Visible = false;
                imageToggleB.Text = "Show image";
                C++;
            }
        }
    }
}
