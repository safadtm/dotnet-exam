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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exam
{
    public partial class adddept : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["examdotnet"].ConnectionString;
        SqlCommand cmd;
        public adddept()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deptname = textBox1.Text;


            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("insert into department (name) values (@deptname)", conn);

                    cmd.Parameters.AddWithValue("deptname", deptname);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("department inserted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            home hm = new();
            hm.Show();
        }
    }
}
