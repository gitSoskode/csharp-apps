using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showNameBtn_Click(object sender, EventArgs e)
        {
            String fullname = FnameTB.Text + " " + LnameTB.Text;
            showNameBtn.Text = fullname;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fname_Click(object sender, EventArgs e)
        {

        }

        private void FnameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int C=0;
        private void showImageBtn_Click(object sender, EventArgs e)
        {
            if (C % 2 == 0)
            {
                oldMan.Visible = true;
                showImageBtn.Text = "Hide image";
                C++;
            }
            else
            {
                oldMan.Visible = false;
                showImageBtn.Text = "Show image";
                C++;
            }
            
            
        }

        private void hideImg_Click(object sender, EventArgs e)
        {
            oldMan.Visible = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTF.Text == "ib")
            {

            }
        }
    }
}
