using System.Data.SqlClient;

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


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Tarush Shankar\\source\\repos\\Library Management System\\Library Management System\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUsername()
        {
            con.Open();
            String syntax = "SELECT Value from systemTable where Property='Username'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }
        private String getPassword()
        {
            con.Open();
            String syntax = "SELECT Value from systemTable where Property='Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            con.Close();
            return temp;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            String uname = getUsername(), upass = getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if (name.Equals(uname) && pass.Equals(upass)) 
            {
                //Login
                Form2 obj = new Form2();
                this.Hide();
                obj.Show();
                
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