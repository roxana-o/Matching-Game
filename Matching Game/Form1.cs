using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_Game
{
    public partial class Form1 : Form
    {
        Random locatie = new Random();
        List <Point>puncte = new List <Point> ();   
        bool jocNou = false;

        PictureBox Imagine1;
        PictureBox Imagine2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelTimp.Text = "5";
            foreach (PictureBox pic in panel1.Controls)
            {
                pic.Enabled = false;
                puncte.Add(pic.Location);
            }

            foreach (PictureBox pic in panel1.Controls)
            {
                int next = locatie.Next(puncte.Count);
                Point p = puncte[next];
                pic.Location = p;
                puncte.Remove(p);
            }
            
            timer2.Start();
            timer1.Start();

            pictureBox1_1.Image = Properties.Resources.nr1;
            pictureBox1_2.Image = Properties.Resources.nr1;     
            pictureBox2_1.Image = Properties.Resources.nr2;
            pictureBox2_2.Image = Properties.Resources.nr2;      
            pictureBox3_1.Image = Properties.Resources.nr3;
            pictureBox3_2.Image = Properties.Resources.nr3;     
            pictureBox4_1.Image = Properties.Resources.nr4;
            pictureBox4_2.Image = Properties.Resources.nr4;    
            pictureBox5_1.Image = Properties.Resources.nr5;
            pictureBox5_2.Image = Properties.Resources.nr5;     
            pictureBox6_1.Image = Properties.Resources.nr6;
            pictureBox6_2.Image = Properties.Resources.nr6;      
            pictureBox7_1.Image = Properties.Resources.nr7;
            pictureBox7_2.Image = Properties.Resources.nr7;     
            pictureBox8_1.Image = Properties.Resources.nr8;
            pictureBox8_2.Image = Properties.Resources.nr8; 
            pictureBox9_1.Image = Properties.Resources.nr9;
            pictureBox9_2.Image = Properties.Resources.nr9;
            pictureBox10_1.Image = Properties.Resources.nr10;
            pictureBox10_2.Image = Properties.Resources.nr10;
            pictureBox11_1.Image = Properties.Resources.nr11;
            pictureBox11_2.Image = Properties.Resources.nr11;
            pictureBox12_1.Image = Properties.Resources.nr12;
            pictureBox12_2.Image = Properties.Resources.nr12;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            foreach(PictureBox pic in panel1.Controls)
            {
                pic.Enabled = true;
                pic.Image = Properties.Resources.Black;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(labelTimp.Text);
            timer = timer-1;
            labelTimp.Text = Convert.ToString(timer);

            if (timer == 0)
                timer2.Stop();
        }

        private void pictureBox1_1_Click(object sender, EventArgs e)
        {
            pictureBox1_1.Image = Properties.Resources.nr1;

            if (Imagine1 ==null)
            {
                Imagine1 = pictureBox1_1;
            }

            else if (Imagine1!=null && Imagine2==null)
            {
                Imagine2 = pictureBox1_1;
            }

            if (Imagine1 !=null && Imagine2 !=null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox1_1.Enabled = false;
                    pictureBox1_2.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox1_2_Click(object sender, EventArgs e)
        {
            pictureBox1_2.Image = Properties.Resources.nr1;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox1_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox1_2;
            }

             if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox1_2.Enabled = false;
                    pictureBox1_1.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox2_1_Click(object sender, EventArgs e)
        {
            pictureBox2_1.Image = Properties.Resources.nr2;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox2_1;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox2_1;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox2_1.Enabled = false;
                    pictureBox2_2.Enabled = false;

                }
                else timer3.Start();
            }
        }

        private void pictureBox2_2_Click(object sender, EventArgs e)
        {
            pictureBox2_2.Image = Properties.Resources.nr2;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox2_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox2_2;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox2_2.Enabled = false;
                    pictureBox2_1.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox3_1_Click(object sender, EventArgs e)
        {
            pictureBox3_1.Image = Properties.Resources.nr3;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox3_1;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox3_1;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox3_1.Enabled = false;
                    pictureBox3_2.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox3_2_Click(object sender, EventArgs e)
        {
            pictureBox3_2.Image = Properties.Resources.nr3;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox3_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox3_2;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox3_2.Enabled = false;
                    pictureBox3_1.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox4_1_Click(object sender, EventArgs e)
        {
            pictureBox4_1.Image = Properties.Resources.nr4;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox4_1;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox4_1;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox4_1.Enabled = false;
                    pictureBox4_2.Enabled = false;
                }
                else timer3.Start();
            }

        }

        private void pictureBox4_2_Click(object sender, EventArgs e)
        {
            pictureBox4_2.Image = Properties.Resources.nr4;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox4_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox4_2;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox4_2.Enabled = false;
                    pictureBox4_1.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox5_1_Click(object sender, EventArgs e)
        {
            pictureBox5_1.Image = Properties.Resources.nr5;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox5_1;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox5_1;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox5_1.Enabled = false;
                    pictureBox5_2.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox5_2_Click(object sender, EventArgs e)
        {
            pictureBox5_2.Image = Properties.Resources.nr5;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox5_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox5_2;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox5_2.Enabled = false;
                    pictureBox5_1.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox6_1_Click(object sender, EventArgs e)
        {
            pictureBox6_1.Image = Properties.Resources.nr6;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox6_1;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox6_1;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox6_1.Enabled = false;
                    pictureBox6_2.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox6_2_Click(object sender, EventArgs e)
        {
            pictureBox6_2.Image = Properties.Resources.nr6;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox6_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox6_2;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox6_1.Enabled = false;
                    pictureBox6_2.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox7_1_Click(object sender, EventArgs e)
        {
            pictureBox7_1.Image = Properties.Resources.nr7;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox7_1;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox7_1;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox7_1.Enabled = false;
                    pictureBox7_2.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox7_2_Click(object sender, EventArgs e)
        {
            pictureBox7_2.Image = Properties.Resources.nr7;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox7_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox7_2;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox7_2.Enabled = false;
                    pictureBox7_1.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox8_1_Click(object sender, EventArgs e)
        {
            pictureBox8_1.Image = Properties.Resources.nr8;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox8_1;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox8_1;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox8_1.Enabled = false;
                    pictureBox8_2.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox8_2_Click(object sender, EventArgs e)
        {
            pictureBox8_2.Image = Properties.Resources.nr8;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox8_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox8_2;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox8_2.Enabled = false;
                    pictureBox8_1.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox9_1_Click(object sender, EventArgs e)
        {
            pictureBox9_1.Image = Properties.Resources.nr9;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox9_1;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox9_1;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox9_1.Enabled = false;
                    pictureBox9_2.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox9_2_Click(object sender, EventArgs e)
        {
            pictureBox9_2.Image = Properties.Resources.nr9;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox9_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox9_2;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox9_2.Enabled = false;
                    pictureBox9_1.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox10_1_Click(object sender, EventArgs e)
        {
            pictureBox10_1.Image = Properties.Resources.nr10;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox10_1;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox10_1;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox10_1.Enabled = false;
                    pictureBox10_2.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox10_2_Click(object sender, EventArgs e)
        {
            pictureBox10_2.Image = Properties.Resources.nr10;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox10_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox10_2;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox10_2.Enabled = false;
                    pictureBox10_1.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox11_1_Click(object sender, EventArgs e)
        {
            pictureBox11_1.Image = Properties.Resources.nr11;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox11_1;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox11_1;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox11_1.Enabled = false;
                    pictureBox11_2.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox11_2_Click(object sender, EventArgs e)
        {
            pictureBox11_2.Image = Properties.Resources.nr11;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox11_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox11_2;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox11_2.Enabled = false;
                    pictureBox11_1.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox12_1_Click(object sender, EventArgs e)
        {
            pictureBox12_1.Image = Properties.Resources.nr12;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox12_1;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox12_1;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox12_1.Enabled = false;
                    pictureBox12_2.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void pictureBox12_2_Click(object sender, EventArgs e)
        {
            pictureBox12_2.Image = Properties.Resources.nr12;

            if (Imagine1 == null)
            {
                Imagine1 = pictureBox12_2;
            }

            else if (Imagine1 != null && Imagine2 == null)
            {
                Imagine2 = pictureBox12_2;
            }

            if (Imagine1 != null && Imagine2 != null)
            {
                if (Imagine1.Tag == Imagine2.Tag)
                {
                    Imagine1 = null;
                    Imagine2 = null;
                    pictureBox12_2.Enabled = false;
                    pictureBox12_1.Enabled = false;
                }
                else timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            Imagine1.Image = Properties.Resources.Black;
            Imagine2.Image = Properties.Resources.Black;
            Imagine1 = null;
            Imagine2 = null;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
