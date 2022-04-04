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
        SumIncome sumIncomeTotal = new SumIncome();
        SumExpenses sumExpensesTotal = new SumExpenses();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxAmountIn.Text = "0";
            textBoxAmountEx.Text = "0";
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string amountIn = this.textBoxAmountIn.Text;
            string amountEx = this.textBoxAmountEx.Text;
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = dateTimePicker1.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBoxList.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBoxAmountIn.Text;
            dataGridView1.Rows[n].Cells[4].Value = textBoxAmountEx.Text;

            if (rdIn.Checked)
                dataGridView1.Rows[n].Cells[2].Value = rdIn.Text;
            else if (rdEx.Checked)
                dataGridView1.Rows[n].Cells[2].Value = rdEx.Text;


            double dIn = Convert.ToDouble(amountIn);
            sumIncomeTotal.addSumIn(dIn);

            double sumIn = sumIncomeTotal.getSumIn();
            tbTotalINcome.Text = sumIn.ToString();

            double dEx = Convert.ToDouble(amountEx);
            sumExpensesTotal.addSumEx(dEx);

            double sumEx = sumExpensesTotal.getSumEx();
            tbTotalExpenses.Text = sumEx.ToString();

            textBoxList.Text = "";
            textBoxAmountIn.Text = "0";
            textBoxAmountEx.Text = "0";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {   
            tbSearch.Text = tbSumDaily.Text;
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("วัน/เดือน/ปี like '%" + tbSearch.Text + "%");
            
        }
    }
}
