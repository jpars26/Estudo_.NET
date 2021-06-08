﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

    
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    
        /* 
           Show the Open File dialog. If the user clicks OK, load the
           picture that the user chose
        */
        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void setButton_Click(object sender, EventArgs e)
        {
            /* 
               Show the color dialog box. If the user clicks OK, change the
               PictureBox control's background to the color the user chose. 
            */
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /* 
               If the user selects the Stretch check box, 
               change the PictureBox's
               SizeMode property to "Stretch". If the user clears 
               the check box, change it to "Normal".
            */
            if (checkBox1.Checked)

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

        }
    }
}
