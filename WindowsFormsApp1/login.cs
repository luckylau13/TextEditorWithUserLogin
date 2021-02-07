using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginform (object sender, EventArgs e)
        {
           
        }

        //username label1
        private void username_label(object sender, EventArgs e)
        {

        }

        //password 
        private void password_label (object sender, EventArgs e)
        {

        }

        //logo for simple bank management system.
        private void Logo (object sender, EventArgs e)
        {

        }

        //button to login 
        private void login_button (object sender, EventArgs e)
        {
            TextEditor texteditor = new TextEditor();
            string username = textBox1.Text;
            string password = textBox2.Text;
            User user = new User();
            user.addToAccountsArray();
            if (user.CheckValidity(username, password))
            {
                if (user.CheckValidityandAccess(username, password))
                {
                    texteditor.changename(username);
                    texteditor.Show();
                }
                else
                {
                    TextEditor tex = new TextEditor();
                    tex.changename(username);
                    tex.disablertb();
                    tex.Show();
                }

                
            }
            else 
                MessageBox.Show("Invalid password or username!");
        }

        //button to exit
        private void exit_button (object sender, EventArgs e)
        {
            this.Close();
        }

        //button for new user 
        private void newuser_button (object sender, EventArgs e)
        {
            Newuser newuser = new Newuser();
            newuser.Show();
            this.Hide();
        }

        private void username_textbox (object sender, EventArgs e)
        {
            
        }

        private void password_textbox (object sender, EventArgs e)
        {

        }
    }
}
