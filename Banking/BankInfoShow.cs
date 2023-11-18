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
    public partial class BankInfoShow : Form
    {
        public BankInfoShow()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=Banking;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
       
        }

        private void BankInfoShow_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from BankInfo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            DataSet d = new DataSet();
            da.Fill(d);
            res.DataSource = d.Tables[0];
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

