using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interest_Calculator
{
    public partial class interestCalculatorForm : Form
    {
        public interestCalculatorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public double basic;
        public double interest;
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int Indexnum = bankNameListBox.TopIndex;
            basic = Convert.ToDouble(balanceTextBox.Text);
            int time = Convert.ToInt32(timeTextBox.Text);
            if (Indexnum==1)
            {
                interest = time*((basic*6)/100);
                interestTextBox.Text = interest.ToString();
            }
            else if (Indexnum == 2)
            {
                interest = time * ((basic * 7) / 100);
                interestTextBox.Text = interest.ToString();
            }
            else if (Indexnum == 3)
            {
                interest = time * ((basic * 8) / 100);
                interestTextBox.Text = interest.ToString();
            }
            else
            {
                {
                    interestTextBox.Text = ("No bank is selected.");
                }
            }
        }
    }
}
