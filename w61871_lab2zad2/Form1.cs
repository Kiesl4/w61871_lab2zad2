using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w61871_lab2zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int wielkosc;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    wielkosc = 10;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, wielkosc);
                }
                if (radioButton2.Checked == true)
                {
                    wielkosc = 12;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, wielkosc);
                }
                if (radioButton3.Checked == true)
                {
                    wielkosc = 14;
                    textBox1.Font = new Font(textBox1.Font.FontFamily, wielkosc);
                }
            }
            else
            {
                MessageBox.Show("Wybierz rozmiar tekstu");
            }
            if (radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
            {
                if (radioButton4.Checked == true)
                {
                    textBox1.ForeColor = Color.Red;
                }
                if (radioButton5.Checked == true)
                {
                    textBox1.ForeColor = Color.Blue;
                }
                if (radioButton6.Checked == true)
                {
                    textBox1.ForeColor = Color.Orange;
                }
            }
            if ((checkBox1.Checked == true) || (checkBox2.Checked == true) || (checkBox3.Checked == true))
            {
                if ((radioButton4.Checked == false) && (radioButton5.Checked == false) && (radioButton6.Checked == false))
                {
                    MessageBox.Show("Wybierz kolor 1");
                }
                else if ((checkBox1.Checked == true) && (checkBox2.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, wielkosc, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, wielkosc, FontStyle.Bold | FontStyle.Italic);
                }
                else if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, wielkosc, FontStyle.Bold | FontStyle.Underline);
                }
                else if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, wielkosc, FontStyle.Italic | FontStyle.Underline);
                }
                else if (checkBox1.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, wielkosc, FontStyle.Bold);
                }
                else if (checkBox2.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, wielkosc, FontStyle.Italic);
                }
                else if (checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, wielkosc, FontStyle.Underline);
                }
            }
            
        }
    }
}
