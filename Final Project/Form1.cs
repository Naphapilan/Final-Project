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
            Form2 form2 = new Form2();
                if (tbUsename.Text == "Naphapilan" && tbPassword.Text == "Nn.21042546")
                    form2.Show();
                else
                    MessageBox.Show("Usename หรือ Password ไม่ถูกต้อง");
          
        }
    }
}