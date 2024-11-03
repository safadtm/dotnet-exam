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
    public partial class home : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["examdotnet"].ConnectionString;
        SqlCommand cmd;
        public home()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        public void disp_data()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    dataGridView1.Visible = true;
                    SqlDataAdapter sda = new SqlDataAdapter("select * from users", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // delete
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("delete from users where id=@id", conn);
                    cmd.Parameters.AddWithValue("id", int.Parse(textBox1.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // update
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("update users set username=@username,password=@password where id=@id", conn);
                    cmd.Parameters.AddWithValue("id", int.Parse(textBox1.Text));
                    cmd.Parameters.AddWithValue("username", textBox2.Text);
                    cmd.Parameters.AddWithValue("password", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated");
                    disp_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            adddept adddept = new adddept();
            adddept.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            viewdept viewdept = new ();
            viewdept.Show();
        }
    }
}
