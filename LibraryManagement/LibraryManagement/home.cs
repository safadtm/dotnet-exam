using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add book
            this.Hide();
            addbook ab = new addbook();
            ab.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // view book
            this.Hide();
            viewbook vb = new viewbook();
            vb.Show();
        }
    }
}
