using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Druid_Horoscope
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int d = dateTimePicker1.Value.Day;
            int m = dateTimePicker1.Value.Month;
            if (d >= 23 && m == 12 && d <= 31 || d == 1 && m == 1 || d >= 25 && m == 6 && d <= 30 || d >= 1 && d <= 4 && m == 7)
            {
                pictureBox1.Image = Image.FromFile("Apple_Tree.png");
                richTextBox1.LoadFile("Apple_Tree.rtf");
            }
            if (d >= 2 && m == 1 && d <= 11 || d >= 5 && m == 7 && d <= 14)
            {
                pictureBox1.Image = Image.FromFile("Fir.png");
                richTextBox1.LoadFile("Fir.rtf");
            }
            if (d >= 12 && d <= 24 && m == 1 || d >= 15 && d <= 25 && m == 7)
            {
                pictureBox1.Image = Image.FromFile("Elm.png");
                richTextBox1.LoadFile("Elm.rtf");
            }
            if (d >= 25 && m == 1 && d <= 31 || d >= 1 && m == 2 && d <= 3 || d >= 26 && m == 7 && d <= 31 || d >= 1 && m == 8 && d <= 4)
            {
                pictureBox1.Image = Image.FromFile("Cypress.png");
                richTextBox1.LoadFile("Cypress.rtf");
            }
            if (d >= 4 && d <= 8 && m == 2 || d >= 5 && d <= 13 && m == 8)
            {
                pictureBox1.Image = Image.FromFile("Poplar.png");
                richTextBox1.LoadFile("Poplar.rtf");
            }
            if (d >= 9 && d <= 18 && m == 2 || d >= 14 && d <= 23 && m == 8)
            {
                pictureBox1.Image = Image.FromFile("Frame.png");
                richTextBox1.LoadFile("Frame.rtf");
            }
            if (d >= 19 && d <= 29 && m == 2 || d >= 24 && d <= 31 && m == 8 || d >= 1 && d <= 2 && m == 9)
            {
                pictureBox1.Image = Image.FromFile("Pine.png");
                richTextBox1.LoadFile("Pine.rtf");
            }
            if (d >= 1 && d <= 10 && m == 3 || d >= 3 && d <= 12 && m == 9)
            {
                pictureBox1.Image = Image.FromFile("Willow.png");
                richTextBox1.LoadFile("Willow.rtf");
            }
            if (d >= 11 && d <= 20 && m == 3 || d >= 13 && d <= 22 && m == 9)
            {
                pictureBox1.Image = Image.FromFile("Linden.png");
                richTextBox1.LoadFile("Linden.rtf");
            }
            if (d >= 22 && d <= 31 && m == 3 || d >= 24 && d <= 30 && m == 9 || d >= 1 && d <= 3 && m == 10)
            {
                pictureBox1.Image = Image.FromFile("Hazel.png");
                richTextBox1.LoadFile("Hazel.rtf");
            }
            if (d >= 1 && d <= 10 && m == 4 || d >= 4 && d <= 13 && m == 10)
            {
                pictureBox1.Image = Image.FromFile("Rowan.png");
                richTextBox1.LoadFile("Rowan.rtf");
            }
            if (d >= 11 && d <= 20 && m == 4 || d >= 14 && d <= 23 && m == 10)
            {
                pictureBox1.Image = Image.FromFile("Maple.png");
                richTextBox1.LoadFile("Maple.rtf");
            }
            if (d >= 21 && d <= 30 && m == 4 || d >= 24 && d <= 31 && m == 10 || d >= 1 && d <= 2 && m == 11)
            {
                pictureBox1.Image = Image.FromFile("Nut.png");
                richTextBox1.LoadFile("Nut.rtf");
            }
            if (d >= 1 && d <= 14 && m == 5 || d >= 3 && d <= 11 && m == 11)
            {
                pictureBox1.Image = Image.FromFile("Jasmine.png");
                richTextBox1.LoadFile("Jasmine.rtf");
            }
            if (d >= 15 && d <= 24 && m == 5 || d >= 12 && d <= 21 && m == 11)
            {
                pictureBox1.Image = Image.FromFile("Chestnut.png");
                richTextBox1.LoadFile("Chestnut.rtf");
            }
            if (d >= 25 && d <= 31 && m == 5 || d >= 1 && d <= 3 && m == 6 || d >= 22 && d <= 30 && m == 11 || d == 1 && m == 12)
            {
                pictureBox1.Image = Image.FromFile("Ash.png");
                richTextBox1.LoadFile("Ash.rtf");
            }
            if (d >= 4 && d <= 13 && m == 6 || d >= 2 && d <= 11 && m == 12)
            {
                pictureBox1.Image = Image.FromFile("Hornbeam.png");
                richTextBox1.LoadFile("Hornbeam.rtf");
            }
            if (d >= 14 && d <= 23 && m == 6 || d >= 12 && d <= 21 && m == 12)
            {
                pictureBox1.Image = Image.FromFile("Figs.png");
                richTextBox1.LoadFile("Figs.rtf");
            }
            if (d == 21 && m == 3)
            {
                pictureBox1.Image = Image.FromFile("Oak.png");
                richTextBox1.LoadFile("Oak.rtf");
            }
            if (d == 24 && m == 6)
            {
                pictureBox1.Image = Image.FromFile("Birch.png");
                richTextBox1.LoadFile("Birch.rtf");
            }
            if (d == 23 && m == 9)
            {
                pictureBox1.Image = Image.FromFile("Olive.png");
                richTextBox1.LoadFile("Olive.rtf");
            }
            if (d >= 21 && d <= 22 && m == 12)
            {
                pictureBox1.Image = Image.FromFile("Beech.png");
                richTextBox1.LoadFile("Beech.rtf");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog(this);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
