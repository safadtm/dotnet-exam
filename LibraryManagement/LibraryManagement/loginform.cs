using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class loginform : Form
    {
        string connString = "Data Source=LAPTOP-RPVNF73V;Initial Catalog=LibraryManagement;Integrated Security=True";

        public loginform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text;
            string password = textBox3.Text;
            // login

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from users where (email=@Email and password=@Password)",conn);
                sda.SelectCommand.Parameters.AddWithValue("Email",email);
                sda.SelectCommand.Parameters.AddWithValue("Password", password);
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString()=="1")
                {
                    // home page
                    this.Hide();
                    home hm = new home();
                    hm.Show();
                }
                else
                {
                    MessageBox.Show("Email and Password incorrect");
                }
            }
        }
    }
}
