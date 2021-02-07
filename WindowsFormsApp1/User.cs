using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public class User
    {
            private string username;
            private string password;
            private string userType;
            private string firstName;
            private string lastName;
            private string dateOfBirth;
            public ArrayList accounts = new ArrayList();

        public User() { }

        //overloaded constractor
        public User (string Username, string Password, string Usertype, string Firstname, string Lastname, string DateOfBirth)
        {
            this.username = Username;
            this.password = Password;
            this.userType = Usertype;
            this.firstName = Firstname;
            this.lastName = Lastname;
            this.dateOfBirth = DateOfBirth;

        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password 
        {
            get { return password; }
            set { password = value; }
        }

        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Dateofbirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public void addToAccountsArray() {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("login.txt");
                foreach (string line in lines)
                {
                    accounts.Add(line);
                }
            }
            catch (Exception ioe)
            {
                Console.WriteLine("Something went wrong!");
            }
            
        }

        public void addToLogin()
        {
            try
            {
                string path = @"..\Debug\login.txt";
                using (StreamWriter sw = new StreamWriter(path, true))
                    for (int i = 0; i < accounts.ToArray().Length; i++)
                    {
                        sw.WriteLine(accounts[i]);
                    }
            }
            catch (Exception ioe)
            {
               Console.WriteLine("Something went wrong!");
            }
        }

        public bool CheckValidityandAccess(string username, string password)
        {
       
            foreach (string account in accounts)
            {
                string[] splits = account.Split(',');
                if (username == splits[0] && password == splits[1] && splits[2] == "Edit")
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckValidity(string username, string password)
        {

            foreach (string account in accounts)
            {
                string[] splits = account.Split(',');
                if (username == splits[0] && password == splits[1])
                {
                    return true;
                }
            }
            return false;
        }






    }
}
