namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = "admin", upass = "root", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if (name.Equals(uname) && pass.Equals(upass)) 
            {
                //Login
                MessageBox.Show("Login Successful");
                
            }
            else
            {
                //dont login
                MessageBox.Show("Incorrect Credentials");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}