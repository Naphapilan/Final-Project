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
    public partial class Expenses : Form
    {
        SumExpenses sumExpenses = new SumExpenses();
        int selectedRow;
        public Expenses()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string amountEx = this.textBoxAmountEx.Text;
            string list = this.textBoxList.Text;
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = dateTimePicker1.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBoxList.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBoxAmountEx.Text;

            double dEx = Convert.ToDouble(amountEx);
            sumExpenses.addSumEx(dEx, list);

            double sumEx = sumExpenses.getSumEx();
            lbTotal.Text = sumEx.ToString();

            double min = sumExpenses.getMin();
            lbExMin.Text = min.ToString();
            lbListMin.Text = sumExpenses.getListMin().ToString();

            double max = sumExpenses.getMax();
            lbExMax.Text = max.ToString();
            lbListMax.Text = sumExpenses.getListMax().ToString();

            textBoxList.Text = "";
            textBoxAmountEx.Text = "0";
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
            textBoxAmountEx.Text = row.Cells[2].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);

            string amountEx = this.textBoxAmountEx.Text;
            string list = this.textBoxList.Text;

            double dDeleteSumEx = Convert.ToDouble(amountEx);
            sumExpenses.deleteSumEx(dDeleteSumEx,list);

            double deleteSumEx = sumExpenses.getDeleteSumEx();
            lbTotal.Text = deleteSumEx.ToString();

            textBoxList.Text = "";
            textBoxAmountEx.Text = "0";
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
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV(.csv)|*.csv";
            openFile.Title = "Please select file";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = null;

                DataTable dt = new DataTable();
                string[] colName = { "", "", "" };

                foreach (string col in colName)
                {
                    dt.Columns.Add(col);
                }

                foreach (string file in openFile.FileNames)
                {
                    try
                    {
                        if (File.Exists(file) == true)
                        {
                            //import file data
                            StreamReader csv = new StreamReader(file);
                            string textLine; //string line data
                            string[] splitLine; // use array to save split data

                            do
                            {
                                textLine = csv.ReadLine();
                                splitLine = textLine.Split(",");
                                dt.Rows.Add(splitLine);
                            }
                            while (csv.Peek() != -1);
                            csv.Close();
                            csv.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                dataGridView1.DataSource = dt;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            for (int i = 0; i < numRows; i++)
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

            lbTotal.Text = "";
            lbListMin.Text = "";
            lbExMin.Text = "";
            lbListMax.Text = "";
            lbExMax.Text = "";
        }  
        
        private void Expenses_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
