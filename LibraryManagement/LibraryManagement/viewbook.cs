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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagement
{
    public partial class viewbook : Form
    {
        string connString = "Data Source=LAPTOP-RPVNF73V;Initial Catalog=LibraryManagement;Integrated Security=True";

        public viewbook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // back
            this.Hide();
            home vb = new home();
            vb.Show();
        }

        private void viewbook_Load(object sender, EventArgs e)
        {
            // datagridview display
            dispdata();
        }

        private void dispdata() {

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                dataGridView1.Visible=true;
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select * from books", conn);
                sda.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
