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
    public partial class Income : Form
    {
        SumIncome sumIncome = new SumIncome();
        int selectedRow;
        public Income()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string amountIn = this.textBoxAmountIn.Text;
            string list = this.textBoxList.Text;
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = dateTimePicker1.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBoxList.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBoxAmountIn.Text;

            double dIn = Convert.ToDouble(amountIn);
            sumIncome.addSumIn(dIn,list);

            double sumIn = sumIncome.getSumIn();
            lbTotal.Text = sumIn.ToString();

            double min = sumIncome.getMin();
            lbInMin.Text = min.ToString();          
            lbListMin.Text = sumIncome.getListMin().ToString();

            double max = sumIncome.getMax();
            lbInMax.Text = max.ToString();
            lbListMax.Text = sumIncome.getListMax().ToString();
                      
            textBoxList.Text = "";
            textBoxAmountIn.Text = "0";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            dateTimePicker1.Text = row.Cells[0].Value.ToString();
            textBoxList.Text = row.Cells[1].Value.ToString();
            textBoxAmountIn.Text = row.Cells[2].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);

            string amountIn = this.textBoxAmountIn.Text;
            string list = this.textBoxList.Text;

            double dDeleteSumIn = Convert.ToDouble(amountIn);
            sumIncome.deleteSumIn(dDeleteSumIn,list);

            double deleteSumIn = sumIncome.getDeleteSumIn();
            lbTotal.Text = deleteSumIn.ToString();

            textBoxList.Text = "";
            textBoxAmountIn.Text = "0";
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            for(int i = 0; i < numRows; i++)
            {
                try
                {
                    int max = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[max]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
            }
            
            lbTotal.Text = sumIncome.reSum().ToString();
            lbListMin.Text = sumIncome.reListMin().ToString();
            lbInMin.Text = sumIncome.reMin().ToString();
            lbListMax.Text = sumIncome.reListMax().ToString();
            lbInMax.Text = sumIncome.reMax().ToString();
        }

        private void Income_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
        }
    }    
}

