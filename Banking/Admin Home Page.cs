using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class Admin_Home_Page : Form
    {
        public Admin_Home_Page()
        {
            InitializeComponent();
            
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            BankInfo bk = new BankInfo();
            bk.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountHolderInfo ah = new AccountHolderInfo();
            ah.Show();

           
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Login l = new Admin_Login();
            l.Show();
            
        }

        private void Admin_Home_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
