using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradeCalculator
{
    public partial class Form2 : Form
    {
        public static int x = 0;
        Form1 f1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool check=Calculate();
            Form3 f3 = new Form3();
            if (check)
            {
                this.Hide();
                f3.Show();
            }
        }
        public bool Calculate()
        {
           
            int perc = 0, num1 = 0, num2 = 0;
            bool chr1, chr2;
            x = 0;
            for (int i = 0; i < Form1.len; i++)
            {
                chr1 = int.TryParse(Form1.tf[i, 0].Text, out num1);
                chr2 = int.TryParse(Form1.tf[i, 1].Text, out num2);
                if (chr1 == false || chr2 == false)
                {
                    MessageBox.Show("Wrong entry!");
                    return false;
                }
                else
                {
                    if (num2 > 100 || num2 < 0)
                    {
                        MessageBox.Show("Out of range!");
                        return false;
                    }
                    x += (num1 * num2) / 100;
                    perc += num1;
                }
            }
            if (perc != 100)
            {
                MessageBox.Show("Has to add up to 100");
                return false;
            }
            else
                return true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }
    }
}
