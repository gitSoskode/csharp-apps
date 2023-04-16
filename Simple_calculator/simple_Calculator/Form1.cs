using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_Calculator
{
    public partial class simpleCal_cs : Form
    {
        //Globals
        //to hold any current lower screen text(main screen)
        String S;       
        int num1 = 0, num2, count = 0;
        double numD1, numD2;
        int fd, fi; //to raise flag of 1 if double detected. f1 for first double number and f2 for the next
        //Boolean Override=false;
        public simpleCal_cs()
        {
            InitializeComponent();
            //Reading screen moment text
            LScreen.Text="0";
        }

        //Number discriminator -  if int or otherwise double
        private void checkNum()
        {
            String screentxt = LScreen.Text;
            if (screentxt.Contains("."))
            {
                numD1=double.Parse(LScreen.Text);
                fd = 1; fi = 0;
            }
            else
            {
                num1=int.Parse(LScreen.Text);
                fi = 1; fd = 0;
            }
        }

        
        private void button11_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;       //assigns the current screen text to S
            if (S != "0")
            {
                LScreen.AppendText("0");
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;       //assigns the current screen text to S
            if (S != "0"){
                LScreen.Text = S + "1";
            }
            
        }

        private void n2_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;       //assigns the current screen text to S
            if (S != "0")
            {
                LScreen.Text = S + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;       //assigns the current screen text to S
            if (S != "0")
            {
                LScreen.Text = S + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;       //assigns the current screen text to S
            if (S != "0")
            {
                LScreen.Text = S + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;       //assigns the current screen text to S
            if (S != "0")
            {
                LScreen.Text = S + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;       //assigns the current screen text to S
            if (S != "0")
            {
                LScreen.Text = S + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;       //assigns the current screen text to S
            if (S != "0")
            {
                LScreen.Text = S + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;       //assigns the current screen text to S
            if (S != "0")
            {
                LScreen.Text = S + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;       //assigns the current screen text to S
            if (S != "0")
            {
                LScreen.Text = S + "9";
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;
            if (!S.Contains(".")){
                LScreen.Text = S + ".";
            }
        }
        //Deleting characters from right(last char)
        private void del_Click(object sender, EventArgs e)
        {
            S = LScreen.Text;
            
            if (S.Length != 0)
            {
                LScreen.Text = S.Substring(0, S.Length - 1);
            }
            else
            {
                //LScreen.Text = "board clear";
                LScreen.ResetText();
            }
        }
        
        private void ac_Click(object sender, EventArgs e)
        {//AC clears all lower screen
            LScreen.Text="0";
            uScreen.Clear();
        }
        
        //Multiplication of numbers
        private void times_Click(object sender, EventArgs e)
        {
            checkNum();
            
            count = 3;
            LScreen.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            checkNum();
            count = 4;
            LScreen.Clear();
        }


        private void eq_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {//Reading current input
                if (LScreen.Text.Contains(".") && fi == 1)
                {//both first and current are integers
                    uScreen.Text = "" + num1 + " +" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                    LScreen.Text = "" + (num1 + int.Parse(LScreen.Text));
                }
                else if (LScreen.Text.Contains(".") && fd == 1)
                {
                    LScreen.Text = "" + (num1 + double.Parse(LScreen.Text));
                    uScreen.Text = "" + numD1 + " +" + double.Parse(LScreen.Text) + "=";//display to upperscreen
                }
                else if (!LScreen.Text.Contains(".") && fi == 1)
                {
                    LScreen.Text = "" + (num1 + int.Parse(LScreen.Text));
                    uScreen.Text = "" + num1 + " +" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                }
                else if (!LScreen.Text.Contains(".") && fd == 1)
                {
                    LScreen.Text = "" + (numD1 + int.Parse(LScreen.Text));
                    uScreen.Text = "" + numD1 + " +" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                }

            }
            else if (count == 2)
            {
                if (LScreen.Text.Contains(".") && fi == 1)
                {//both first and current are integers
                    uScreen.Text = "" + num1 + " -" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                    LScreen.Text = "" + (num1- int.Parse(LScreen.Text));
                }
                else if (LScreen.Text.Contains(".") && fd == 1)
                {
                    LScreen.Text = "" + (num1- double.Parse(LScreen.Text));
                    uScreen.Text = "" + numD1 + " -" + double.Parse(LScreen.Text) + "=";//display to upperscreen
                }
                else if (!LScreen.Text.Contains(".") && fi == 1)
                {
                    LScreen.Text = "" + (num1 -int.Parse(LScreen.Text));
                    uScreen.Text = "" + num1 + "-" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                }
                else if (!LScreen.Text.Contains(".") && fd == 1)
                {
                    LScreen.Text = "" + (numD1 - int.Parse(LScreen.Text));
                    uScreen.Text = "" + numD1 + "-" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                }
            }
            else if (count == 3)
            {
                if (LScreen.Text.Contains(".") && fi == 1)
                {//both first and current are integers
                    uScreen.Text = "" + num1 + " *" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                    LScreen.Text = "" + (num1 * int.Parse(LScreen.Text));
                }
                else if (LScreen.Text.Contains(".") && fd == 1)
                {
                    LScreen.Text = "" + (num1 *double.Parse(LScreen.Text));
                    uScreen.Text = "" + numD1 + "*" + double.Parse(LScreen.Text) + "=";//display to upperscreen
                }
                else if (!LScreen.Text.Contains(".") && fi == 1)
                {
                    LScreen.Text = "" + (num1 * int.Parse(LScreen.Text));
                    uScreen.Text = "" + num1 + "*" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                }
                else if (!LScreen.Text.Contains(".") && fd == 1)
                {
                    LScreen.Text = "" + (numD1 * int.Parse(LScreen.Text));
                    uScreen.Text = "" + numD1 + " *" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                }
            }
            else if (count == 4)
            {
                if (LScreen.Text.Contains(".") && fi==1)
                {//both first and current are integers
                    uScreen.Text = "" + num1 + " /" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                    LScreen.Text = "" + (num1 / int.Parse(LScreen.Text));
                }
                else if (LScreen.Text.Contains(".") && fd == 1)
                {
                    LScreen.Text = "" + (num1/ double.Parse(LScreen.Text));
                    uScreen.Text = "" + numD1 + " /" + double.Parse(LScreen.Text) + "=";//display to upperscreen
                }
                else if(!LScreen.Text.Contains(".") && fi == 1)
                {
                    LScreen.Text = "" + (num1 / int.Parse(LScreen.Text));
                    uScreen.Text = "" + num1 + " /" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                }else if(!LScreen.Text.Contains(".") && fd == 1)
                {
                    LScreen.Text = "" + (numD1 / int.Parse(LScreen.Text));
                    uScreen.Text = "" + numD1 + " /" + int.Parse(LScreen.Text) + "=";//display to upperscreen
                }
            }
            else if (count == 5)
            {
                if (LScreen.Text.Contains("."))
                {
                    LScreen.Text = "invalid value input";
                }
                else
                {
                    uScreen.Text = "" + num1 + " modulo " + int.Parse(LScreen.Text) + "=";//display to upperscreen
                    LScreen.Text = "" + num1 % int.Parse(LScreen.Text);
                }
                
            }
            //Override = true;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            checkNum();
            if (fd==1)
            {
                LScreen.Text = "not applicable";
            }
            else
            {
                num1 = int.Parse(LScreen.Text);
                uScreen.Text = num1 + " modulo";
                count = 5;
                LScreen.Clear();
            }
            
            
            
        }
            
        private void fac_Click(object sender, EventArgs e)
        {
            checkNum();
            if (fd==1)
            {
                LScreen.Text = "Use integer";
            }
            else
            {
                int k=num1 = int.Parse(LScreen.Text);
                for (int i=num1-1; i >= 1; i--)
                {
                    num1=num1*i;
                }LScreen.Text = "" + num1;
                uScreen.Text = "" + k + " factoria =" + int.Parse(LScreen.Text);//display to upperscreen
            }
            
            
        }

        private void cel_Click(object sender, EventArgs e)
        {
            checkNum();
            if (fd==1)
            {
                numD1 = double.Parse(LScreen.Text);
                LScreen.Text = "" + 5 * (numD1 - 32) / 9;
                uScreen.Text = numD1 + " F to Celcius = " + LScreen.Text;
            }
            else
            {
                num1 = int.Parse(LScreen.Text);
                LScreen.Text = "" + 5 * (num1 - 32) / 9;
                uScreen.Text = num1 + " F to Celcius = " + LScreen.Text;
            }
        }

        private void sroot_Click(object sender, EventArgs e)
        {
            checkNum();
            if (fd==1)
            {
                numD1 = double.Parse(LScreen.Text);
                LScreen.Text = "" + Math.Sqrt(numD1);
                uScreen.Text = "√" + numD1 + " = " + LScreen.Text;
            }
            else
            {
                num1 = int.Parse(LScreen.Text);
                LScreen.Text = "" + Math.Sqrt(num1);
                uScreen.Text = "√" + num1 + " = " + LScreen.Text;
            }
            
        }

        private void sq_Click(object sender, EventArgs e)
        {
            checkNum();
            if (fd==1)
            {
                numD1 = double.Parse(LScreen.Text);
                LScreen.Text=""+(numD1 * numD1);
                uScreen.Text = numD1 + " x " + numD1 + " = " + LScreen.Text;
            }
            else
            {
                num1 = int.Parse(LScreen.Text);
                uScreen.Text = num1 + " x "+num1+" = "+LScreen.Text;
            }
            
                       
        }

        private void far_Click(object sender, EventArgs e)
        {
            checkNum();
            if (fd==1)
            {
                numD1 = double.Parse(LScreen.Text);
                LScreen.Text = "" + (numD1 * 9 / 5 + 32);
                uScreen.Text = numD1 + " Celcius to F = " + LScreen.Text;
            }
            else
            {
                num1 = int.Parse(LScreen.Text);
                LScreen.Text = "" + (num1 * 9 / 5 + 32);
                uScreen.Text = num1 + " Celcius to F = " + LScreen.Text;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        
        int picHide=0;
        private void hidePicBtn_Click(object sender, EventArgs e)
        {//Numbing the background picture
            if (picHide %2== 0)
            {
                hidePicBtn.Text = "<";
                sos.Visible = false;
                //picHide++;
            }else
            {
                hidePicBtn.Text = ">";
                sos.Visible = true;
            }
            picHide++;
        }

        private void min_Click(object sender, EventArgs e)
        {
            checkNum();
            if (fd==1)
            {
                numD1 = double.Parse(LScreen.Text); 
                uScreen.Text = LScreen.Text + "-";
            }
            else
            {
                if (LScreen.Text == "0")
                {
                    LScreen.Text = "-";
                }
                else
                {
                    num1 = int.Parse(LScreen.Text); 
                    uScreen.Text = LScreen.Text + "-";
                }
                
            }
            
            count = 2;
            LScreen.Text="0";
        }

        private void plus_Click(object sender, EventArgs e)
        {//obtaining screen text as int parsed into variable num1, numD1
            checkNum();
            if (fd==1)
            {
                numD1 = double.Parse(LScreen.Text); 
            }
            else
            {
                num1 = int.Parse(LScreen.Text);
            }
            
            count = 1;
            LScreen.Clear();
            uScreen.Text = ""+LScreen.Text + " + ";
        }

    }
}
