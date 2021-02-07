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
    public partial class Newuser : Form
    {
        
        public Newuser()
        {
            InitializeComponent();
        }

        private void Newuser_Load(object sender, EventArgs e)
        {

        }

        private void password_laebel(object sender, EventArgs e)
        {

        }

        private void DOB_label(object sender, EventArgs e)
        {

        }

        // to ca
        private void usertype_dropdown (object sender, EventArgs e)
        {

        }

        private void username_label(object sender, EventArgs e)
        {

        }

        private void username_textbox(object sender, EventArgs e)
        {
              
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void re_enter_password_label(object sender, EventArgs e)
        {

        }

        private void re_enter_password_textbox(object sender, EventArgs e)
        {

        }

        private void firstname_label(object sender, EventArgs e)
        {

        }

        private void firstname_textbox(object sender, EventArgs e)
        {

        }

        private void lastname_label(object sender, EventArgs e)
        {

        }

        private void lastname_textbox(object sender, EventArgs e)
        {

        }

        private void DOB(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
         
        private void submit(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string re_enter_password = textBox3.Text;
            string firstname = textBox4.Text;
            string lastname = textBox5.Text;
            string date = dateTimePicker1.Text;
            string type = comboBox1.Text;
            if (password == re_enter_password)
            {
                
                User account = new User(username, password, type, firstname, lastname, date);
                
                String acc = account.Username + "," + account.Password + "," + account.UserType +","+ account.FirstName + "," + account.LastName + "," + account.Dateofbirth;
                account.accounts.Add(acc);
                account.addToLogin();
                MessageBox.Show("Your account has been created.");
                this.Hide();
                login login = new login();
                login.Show();

            }
            else
                MessageBox.Show("Password does not match.");


        }

        private void cancel(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }
    }
}
