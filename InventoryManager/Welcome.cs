using System;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            //check if user didn't enter username and password
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("You must to enter Username and Password!");
            }
            else
            {
                //check if user name or password is wrong
                if (username.Text != "admin" || password.Text != "admin")
                {
                    MessageBox.Show("Invalid Username or Password !");
                }
                else
                {
                    //close this login form and show main menu of the program
                    this.Hide();
                    Main logon = new Main();
                    if (logon.ShowDialog() != DialogResult.OK)
                    {
                        //Handle authentication failures as necessary, for example :
                        Application.Exit();
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }       
        }
        private void btnreg_Click(object sender, EventArgs e)
        {
            // Not available yet (future plan)
        }
    }
}
