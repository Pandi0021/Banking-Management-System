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
    

    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }
       
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=Banking;Integrated Security=True");
        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_password fp = new Forgot_password();
            fp.Show();
        }

        private void btn_Admin_Login_Click(object sender, EventArgs e)
        {
           
              
            }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Admin_Home_Page ah = new Admin_Home_Page();
            string username = uname.Text;
            string password = pass.Text;
            string query = "SELECT COUNT(*) FROM AdminInfo WHERE AdminName = @Username AND PasswordHash = @Password";
            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);
            con.Open();
            int count = (int)command.ExecuteScalar();
            MessageBox.Show((count != 0) ? " Admin Admin_Login successful..." : "Admin Admin_Login failed");
            if (count != 0)
            {
                this.Hide();
                ah.Show();

            }
            con.Close();
        }
        }
    }
