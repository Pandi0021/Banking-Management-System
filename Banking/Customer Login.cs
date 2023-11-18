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
    public partial class Customer_Login : Form
    {
        long Ano;
        double balance;
        public Customer_Login()
        {
            InitializeComponent();
        }
     
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=Banking;Integrated Security=True");
        private void btn_login_Click(object sender, EventArgs e)
        {
           
            string username = uname.Text;
            string password = pass.Text;
            string query = "SELECT COUNT(*) FROM Accountholdinfo WHERE Userid= @Username AND PasswordHash = @Password";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            con.Open();
            int count = (int)command.ExecuteScalar();
            con.Close();
            string selectQuery = "SELECT AccountNo,AccountBalance FROM Accountholdinfo WHERE Userid= @Username";
            command = new SqlCommand(selectQuery, con);
            command.Parameters.AddWithValue("@Username", username);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Ano = reader.GetInt64(reader.GetOrdinal("AccountNo"));
                decimal iabalDouble = reader.GetDecimal(1);
                balance = Convert.ToDouble(iabalDouble);
            }
            reader.Close();
            con.Close();
            Customer_Home_Page ch = new Customer_Home_Page(Ano,balance);
            MessageBox.Show((count != 0) ? " Customer login successful..." + Ano : "Customer login failed");
            if (count != 0)
            {
                this.Hide();
                ch.Show();
            }

            
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CForgot_password Cfp = new CForgot_password();
            Cfp.Show();
        }

        private void Customer_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
