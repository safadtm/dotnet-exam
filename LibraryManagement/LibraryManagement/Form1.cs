using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        string connString = "Data Source=LAPTOP-RPVNF73V;Initial Catalog=LibraryManagement;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // login page
            this.Hide();
            loginform logform = new loginform();
            logform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            // registration
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into users (name,email,password) values(@Name,@Email,@Password)",conn);
                cmd.Parameters.AddWithValue("Name",name);
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("Password", password);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Users created");
            }
        }
    }
}
