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
    public partial class BankInfoUpade : Form
    {
        public BankInfoUpade()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=Banking;Integrated Security=True");
      
        private void button3_Click(object sender, EventArgs e)
        {
            string uifsc = ifsc.Text;
            string uadd =add1.Text;
            string uphno = phno.Text;
            SqlCommand cmd = new SqlCommand("update BankInfo set PhoneNumber='" + uphno + "',BankAddress='" +uadd+ "' where IFSCCode='" +uifsc+ "'", con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show((r != 0) ? " Data updated..." : "invalid name");
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BankInfo bk = new BankInfo();
            bk.Show();
            this.Hide();
        }
    }
}
