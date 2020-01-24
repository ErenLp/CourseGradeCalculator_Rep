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
    public partial class Form3 : Form
    {
        Form2 f2 = new Form2();
        Form1 f1 = new Form1();
        public Form3()
        {
            InitializeComponent();
            label2.Text = Convert.ToString(Form2.x);
            if (Form2.x >= 0 && Form2.x < 35)
                label1.Text = "FF";
            else if (Form2.x >= 35 && Form2.x < 45)
                label1.Text = "FD";
            else if (Form2.x >= 45 && Form2.x < 50)
                label1.Text = "DD";
            else if (Form2.x >= 50 && Form2.x < 60)
                label1.Text = "DC";
            else if (Form2.x >= 60 && Form2.x < 70)
                label1.Text = "CC";
            else if (Form2.x >= 70 && Form2.x < 80)
                label1.Text = "CB";
            else if (Form2.x >= 80 && Form2.x < 85)
                label1.Text = "BB";
            else if (Form2.x >= 85 && Form2.x < 90)
                label1.Text = "BA";
            else if (Form2.x >= 90 && Form2.x < 101)
                label1.Text = "A";
            else
                label1.Text=("NA");

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.setUp(f2);
            f2.Show();
        }
    }
}
