using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Race_Rajpal
{
    public partial class Form1 : Form
    {
        int dg = 0;
        int rajpal = 100, jordan = 100, sandhu = 100;
        int winner = 0;
        RajpalRunningClass houndClass = new RajpalRunningClass();
        RajpalGuyClass guys = new RajpalGuyClass();//object of client class
        public Form1()
        {
            InitializeComponent();
            //dynamic loading of amount
            for (int i = 1; i <= 50; i++)
            {
                comboBox3.Items.Add(i.ToString());

            }
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0 && dg > 0 && Convert.ToInt32(comboBox3.SelectedItem.ToString()) <= rajpal)
            {
                //we have selected the rajpal here
                label5.Text = "Rajpal choosed " + dg + " dog and " + comboBox3.SelectedItem.ToString() + " Dollar";
                button2.Enabled = true;
            }
            else if (comboBox2.SelectedIndex == 1 && dg > 0 && Convert.ToInt32(comboBox3.SelectedItem.ToString()) <= jordan)
            {
                label6.Text = "Jordan choosed " + dg + " dog and " + comboBox3.SelectedItem.ToString() + " Dollar";
                button2.Enabled = true;
            }
            else if (comboBox2.SelectedIndex == 2 && dg > 0 && Convert.ToInt32(comboBox3.SelectedItem.ToString()) <= sandhu)
            {
                label7.Text = "Sandhu choosed " + dg + " dog and " + comboBox3.SelectedItem.ToString() + " Dollar";
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("You must folow the Details of the game to Play ");
            }
            dg = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Left += houndClass.moving();
            pictureBox4.Left += houndClass.moving();
            pictureBox5.Left += houndClass.moving();
            pictureBox6.Left += houndClass.moving();
            //when ethe dog reach at the finishing point stop the game announce the result
            if (pictureBox3.Left > 800)
            {
                winner = 1;

                timer1.Enabled = false;
                resultset();
            }
            if (pictureBox4.Left > 800)
            {
                winner = 2;

                timer1.Enabled = false;
                resultset();
            }
            if (pictureBox5.Left > 800)
            {
                winner = 3;

                timer1.Enabled = false;
                resultset();
            }
            if (pictureBox6.Left > 800)
            {
                winner = 4;

                timer1.Enabled = false;
                resultset();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dg = 1;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dg = 2;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                dg = 3;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                dg = 4;
            }
            else
            {
                dg = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        public void resultset()
        {
            MessageBox.Show(winner + " dog Won the race");
            if (label5.Text.Contains("dog"))
            {
                rajpal = guys.budgetSet(label5.Text, rajpal, winner);
                label5.Text = "Rajpal has Total $" + rajpal;
            }
            if (label6.Text.Contains("dog"))
            {
                jordan = guys.budgetSet(label6.Text, jordan, winner);
                label6.Text = "Jordan has Total $" + jordan;
            }
            if (label7.Text.Contains("dog"))
            {
                sandhu = guys.budgetSet(label7.Text, sandhu, winner);
                label7.Text = "Sandhu has Total $" + sandhu;
            }



            pictureBox3.Left = 340;
            pictureBox4.Left = 340;
            pictureBox5.Left = 340;
            pictureBox6.Left = 340;
            dg = 0;
            winner = 0;
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox1.Text = "";
            button2.Enabled = false;
        }
    }
}
