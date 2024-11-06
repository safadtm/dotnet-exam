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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class addbook : Form
    {
        string connString = "Data Source=LAPTOP-RPVNF73V;Initial Catalog=LibraryManagement;Integrated Security=True";

        public addbook()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // back
            this.Hide();
            home vb = new home();
            vb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // book adding
            string name = textBox1.Text;
            string category = textBox2.Text;
          
            // registration
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into books (name,category) values(@Name,@Category)", conn);
                cmd.Parameters.AddWithValue("Name", name);
                cmd.Parameters.AddWithValue("Category", category);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Books Added");
            }
        }
    }
}
