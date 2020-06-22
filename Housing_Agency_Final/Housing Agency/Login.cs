
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housing_Agency
{
    public partial class Login : Form
    {
        Login myLogIn;
        List<Users> User;
        //List<Employee> Employees;
        List<Houserules> Houserule;

        String username;
        String password;

        public Login()
        {
            InitializeComponent();
        }

        //public static void EnableTab(TabPage page, bool enable)
        //{
        //    EnableControls(page.Controls, enable);
        //}
        //private static void EnableControls(Control.ControlCollection ctls, bool enable)
        //{
        //    foreach (Control ctl in ctls)
        //    {
        //        ctl.Enabled = enable;
        //        EnableControls(ctl.Controls, enable);
        //    }
        //}

        public bool CheckUsernameStudent(String username, String password)
        {
            foreach (Users u in User)
            {
                if (username == u.GetUsername() && password == u.GetPassword())
                {
                    return true;
                }
            }
            return false;
        }
        

        public bool CheckUsernameManager(String username, String password)
        {
            foreach (Users u in User)
            {
                if (username == u.GetUsername() && password == u.GetPassword())
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox2.Text;
            string password = this.textBox1.Text;


            if (String.IsNullOrEmpty(username) && String.IsNullOrEmpty(password))
            {
                
                MessageBox.Show("Please fill in the given fields");
            }

            else if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please input your username");
            }

            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please input your password");
            }

            else
            {

                this.Hide();
                Main mm = new Main();
                mm.Show();

            }





        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
