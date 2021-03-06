using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (rdIncome.Checked)
            {
                Income income = new Income();
                income.Show();
                this.Hide();
            }
            if (rdExpenses.Checked)
            {
                Expenses expenses = new Expenses();
                expenses.Show();
                this.Hide();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

    }
}
