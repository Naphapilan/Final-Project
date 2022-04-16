namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           
                if (tbUsename.Text == "Naphapilan" && tbPassword.Text == "Nn.21042546")
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }                    
                else
                    MessageBox.Show("Usename หรือ Password ไม่ถูกต้อง");
          
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ขอบคูณที่ใช้บริการ");
            this.Close();
        }
    }
}