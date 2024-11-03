using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class login : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["examdotnet"].ConnectionString;
        SqlCommand cmd;

        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from users where(username='" + username+ "' and password='" + password+"')", conn);
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString()=="1")
                    {
                        this.Hide();
                        home hm = new ();
                        hm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username and password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }
    }
}
