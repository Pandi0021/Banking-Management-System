using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Banking
{
    public partial class CForgot_password : Form
    {
        public CForgot_password()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=Banking;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            string uuname = uname.Text;
            string upass = pass.Text;
            string uphno = phno.Text;
            SqlCommand cmd = new SqlCommand("update Accountholdinfo set PasswordHash='" + upass + "' where PhoneNumber='" + uphno + "'and Userid='"+uuname+"'", con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show((r != 0) ? " Data updated..." : "invalid data");
            con.Close();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void phno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
