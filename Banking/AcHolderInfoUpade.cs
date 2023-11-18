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
    public partial class AcHolderInfoUpade : Form
    {
        public AcHolderInfoUpade()
        {
            InitializeComponent();
        }
         SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=Banking;Integrated Security=True");
      
        private void AcHolderInfoUpade_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            long uano = long.Parse(ano.Text);
            string uemail = email.Text;
            string uphno = phno.Text;
            SqlCommand cmd = new SqlCommand("update Accountholdinfo set PhoneNumber=" + uphno + ",email='" + uemail + "' where AccountNo=" + uano + "", con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show((r != 0) ? " Data updated..." : "invalid name");
            con.Close();
        }

        private void AcHolderInfoUpade_Load_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AccountHolderInfo ah = new AccountHolderInfo();
            this.Hide();
            ah.Show();
        }
    }
}
