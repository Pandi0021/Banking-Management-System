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
    public partial class Customer_Home_Page : Form
    {
        long Ano;
        double balance;
        public Customer_Home_Page(long value,double value1)
        {
            InitializeComponent();
            Ano = value;
            balance=value1;
        }

        private void Customer_Home_Page_Load(object sender, EventArgs e)
        {
            a.Text = Ano.ToString();
            b.Text = balance.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send_Money s = new Send_Money(Ano);
            s.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Passbook p = new Passbook(Ano);
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
           My__Profile m = new My__Profile(Ano);
            m.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Login c = new Customer_Login();
            c.Show();
        }
    }
}
