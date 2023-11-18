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
    public partial class BankInfo : Form
    {
        public BankInfo()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=Banking;Integrated Security=True");
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

            string ibname = Bname.Text;
            string iifsc = ifsc.Text;
            string imicr = micr.Text;
            string iadd1 = add1.Text;
            string icity = city.Text;
            string istate = state.Text;
            string ipin = pin.Text;
            string iphno = phno.Text;
            string iweb = web.Text;
            SqlCommand cmd = new SqlCommand("insert into BankInfo(BankName,IFSCCode,MICRCode,BankAddress,City,BankState,PinCode,PhoneNumber,Website)values('" + ibname + "','" + iifsc + "','" + imicr+ "','" +iadd1 + "','" + icity + "','" + istate + "','" + ipin + "','" + iphno + "','" + iweb + "')", con);
            con.Open();
            int r = cmd.ExecuteNonQuery();
            MessageBox.Show((r != 0) ? " Data Saved..." : "data not saved");
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankInfoUpade bupdate = new BankInfoUpade();
            bupdate.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BankInfoDelete delete = new BankInfoDelete();
            delete.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            BankInfoShow Show = new BankInfoShow();
            Show.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_Home_Page ah = new Admin_Home_Page();
            this.Hide();
            ah.Show();
        }
    }
}
