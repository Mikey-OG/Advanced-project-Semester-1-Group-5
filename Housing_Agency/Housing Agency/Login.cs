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
        public Login()
        {
            InitializeComponent();
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
