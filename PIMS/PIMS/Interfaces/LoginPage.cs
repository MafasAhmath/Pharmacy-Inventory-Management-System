using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }

        private void imgHidden_MouseHover(object sender, EventArgs e)
        {
            //The password visible
            txtPassword.UseSystemPasswordChar = false;
            //imgHidden.Visible = false;
        }

        
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminHomeForm admin = new AdminHomeForm();
            admin.Show();
            this.Hide();

            /*if (txtUserName.Text=="Admin" && txtPassword.Text == "123")
            {
                
            }
            else
            {
                MessageBox.Show("Please enter correct User name & Password");
            }*/

            
        }

        private void pcrClose_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Do you want to exit?", "Application Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pcrShow_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            imgHidden.Visible = true;
        }
    }
}
