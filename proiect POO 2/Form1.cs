using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_POO_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            anul111.Visible = true;
            anul121.Visible = false;
            anul211.Visible = false;
            anul221.Visible = false;

            an1sem1TI1.Visible = false;
            an1sem2TI1.Visible = false;
            an2sem1TI1.Visible = false;
            an2sem2TI1.Visible = false;

            an1sem1CALC1.Visible = false;
            an1sem2CALC1.Visible = false;
            an2sem1CALC1.Visible = false;
            an2sem2CALC1.Visible = false;

            an1sem1ROBO1.Visible = false;
            an1sem2ROBO1.Visible = false;
            an2sem1ROBO1.Visible = false;
            an2sem2ROBO1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //////// AIA
            
            if (comboBox1.Text == "Semestrul 1" && checkBox1.Checked == true)
            {
                anul111.Visible = true;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }
            if (comboBox1.Text == "Semestrul 2" && checkBox1.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = true;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }

            //////// TI

            if (comboBox1.Text == "Semestrul 1" && checkBox2.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = true;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }
            if (comboBox1.Text == "Semestrul 2" && checkBox2.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = true;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }

            //////// CALC

            if (comboBox1.Text == "Semestrul 1" && checkBox3.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = true;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }
            if (comboBox1.Text == "Semestrul 2" && checkBox3.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = true;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }

            //////// ROBO

            if (comboBox1.Text == "Semestrul 1" && checkBox4.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = true;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }
            if (comboBox1.Text == "Semestrul 2" && checkBox4.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = true;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //////// AIA

            if (comboBox1.Text == "Semestrul 1" && checkBox1.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = true;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }
            if (comboBox1.Text == "Semestrul 2" && checkBox1.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = true;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }

            //////// TI

            if (comboBox1.Text == "Semestrul 1" && checkBox2.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = true;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }
            if (comboBox1.Text == "Semestrul 2" && checkBox2.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = true;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }

            //////// CALC

            if (comboBox1.Text == "Semestrul 1" && checkBox3.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = true;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }
            if (comboBox1.Text == "Semestrul 2" && checkBox3.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = true;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = false;


            }

            //////// ROBO

            if (comboBox1.Text == "Semestrul 1" && checkBox4.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = true;
                an2sem2ROBO1.Visible = false;


            }
            if (comboBox1.Text == "Semestrul 2" && checkBox4.Checked == true)
            {
                anul111.Visible = false;
                anul121.Visible = false;
                anul211.Visible = false;
                anul221.Visible = false;

                an1sem1TI1.Visible = false;
                an1sem2TI1.Visible = false;
                an2sem1TI1.Visible = false;
                an2sem2TI1.Visible = false;

                an1sem1CALC1.Visible = false;
                an1sem2CALC1.Visible = false;
                an2sem1CALC1.Visible = false;
                an2sem2CALC1.Visible = false;

                an1sem1ROBO1.Visible = false;
                an1sem2ROBO1.Visible = false;
                an2sem1ROBO1.Visible = false;
                an2sem2ROBO1.Visible = true;


            }


        } 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }
    }
}
