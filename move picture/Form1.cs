using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 10);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 10);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Location.X > 0)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X - 10, pictureBox2.Location.Y);

            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            
                pictureBox2.Location = new Point(pictureBox2.Location.X - 5, pictureBox2.Location.Y);
            
        }

            private void btnRight_Click(object sender, EventArgs e)
            {
                if (pictureBox2.Location.X + 5 < ClientRectangle.Width)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X + 5, pictureBox2.Location.Y);
                }
            }
     }
 }



