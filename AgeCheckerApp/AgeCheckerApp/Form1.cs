using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCheckerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        { int age = 0;
            try
            {
                age = int.Parse(ageTf.Text);
            }catch
            {
                MessageBox.Show("Invalid age, make sure you enter only integer values");
                
            }
           
            String name = nameTF.Text;
            if (age < 21)
            {
                screenTF.Text = "Hey " + name + "! You are still a minor at "+age;
                screenTF.ForeColor = Color.Green;
            }else
            {
                screenTF.Text = "Hey " + name + "! You are now an adult at " + age;
                screenTF.ForeColor = Color.Red;
            }

        }

        
    }
}
