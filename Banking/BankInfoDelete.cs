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
    public partial class BankInfoDelete : Form
    {
        public BankInfoDelete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=Banking;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            string difsc=ifsc.Text;
            SqlCommand cmd = new SqlCommand("delete from BankInfo where IFSCCode='" + difsc + "'", con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show((r != 0) ? " Data deleted..." : "invalid name");
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BankInfo bk = new BankInfo();
            bk.Show();
            this.Hide();
            
        }

        private void BankInfoDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
