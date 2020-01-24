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
    public partial class Form1 : Form
    {
        public static int len=0,counter=0;
        public static TextBox[,] tf = new TextBox[512, 2];
        public static Form2 f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool test= Int32.TryParse(textBox1.Text,out len);
            if (test == true)
            {
                this.Hide();
                Form2 f2 = new Form2();
                counter = 0;
                setUp(f2);
                f2.Show();
            }
            else
            {
                MessageBox.Show("Fill the text box correctly.");
            }
        }
        public void setUp(Form2 f2)
        {          
            for (int i = 0; i < len; i++)
            {
                if (counter == 0)
                {
                    tf[i, 0] = new TextBox();
                    tf[i, 1] = new TextBox();
                }
                tf[i, 0].Left = 10;
                tf[i, 0].Top = 50 + i * 40;
                tf[i, 0].Font = new Font("Calibri", 12, FontStyle.Regular);
                tf[i, 0].TextAlign = HorizontalAlignment.Center;
                f2.Controls.Add(tf[i, 0]);
                
                tf[i, 1].Left = 140;
                tf[i, 1].Top = 50 + i * 40;
                tf[i, 1].Font = new Font("Calibri", 12, FontStyle.Regular);
                tf[i, 1].TextAlign = HorizontalAlignment.Center;
                f2.Controls.Add(tf[i, 1]);
            }
            counter++;
        }

        public static void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                e.Cancel = false ;
                Environment.Exit(0);

            }
            else
            {
                e.Cancel=true;
            }
        }
    }
}
