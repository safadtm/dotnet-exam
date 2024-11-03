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
    public partial class viewdept : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["examdotnet"].ConnectionString;
        SqlCommand cmd;
        public viewdept()
        {
            InitializeComponent();
        }

        private void viewdept_Load(object sender, EventArgs e)
        {
            loaddept();
        }

        private void loaddept()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select name from department", conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    comboBox1.Items.Clear();

                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr["name"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
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
