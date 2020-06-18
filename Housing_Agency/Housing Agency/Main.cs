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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSendAnnouncement_Click(object sender, EventArgs e)
        {

            //Start of code for the announcement tab

            string studentName = this.tbStudentName.Text;
            string announcement = this.tbAnnouncement.Text;

            //Validation to avoid the user from not providing necessary information

            //if user does not provide name and announcement
            if (String.IsNullOrEmpty(this.tbStudentName.Text) && String.IsNullOrEmpty(this.tbAnnouncement.Text))
            {
                MessageBox.Show("Please fill in the empty text fields");
            }

            //if user does not input name
           else if (String.IsNullOrEmpty(this.tbStudentName.Text)) 
            {
                MessageBox.Show("Please fill in student name");
            }

            //if user does not input announcement
            else if (String.IsNullOrEmpty(this.tbAnnouncement.Text))
            {
                MessageBox.Show("Please fill in your announcement");
            }

            //if user provides necessary information 
            else
            {
                this.lbAnnouncement.Items.Add("This announcement is from" +" " +  studentName +"(" + DateTime.Now.ToString() + ")" + ":  "+ announcement);
                MessageBox.Show("Your announcement has been sent");

                this.tbStudentName.Clear();
                this.tbAnnouncement.Clear();
                
            }
            //End of code for the announcement tab

           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            //Start of code for the grocery tab

            string student = this.textBox1.Text;
           

            
            //if both the student textbox and the item combobox are empty
            if (String.IsNullOrEmpty(student) && this.comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please insert your name and choose item");
            }

            //if the student textbox is empty
            else if (String.IsNullOrEmpty(student)) 
            {
                MessageBox.Show("Please insert your name");
            }

            //if the user does not select an item from the combobox
            else if (this.comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please choose item");
            }

            else if (listBox2.Items.Cast<String>().Any(item => item == comboBox2.SelectedItem.ToString()))
            {
                MessageBox.Show("This item has already been added to the grocery list");
            }

            //if user provides the necessary information
            else
            {
                this.listBox1.Items.Add(comboBox2.SelectedItem);
                this.listBox2.Items.Add(comboBox2.SelectedItem);
                MessageBox.Show("The item has been added to the grocery list");
                this.listBox1.Items.Clear();
                this.textBox1.Clear();
            }

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string student = this.textBox1.Text;


            //if both the student textbox and the item combobox are empty
            if (String.IsNullOrEmpty(student) && this.comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please insert your name and choose item");
            }

            //if the student textbox is empty
            else if (String.IsNullOrEmpty(student))
            {
                MessageBox.Show("Please insert your name");
            }

            //if the user does not select an item from the combobox
            else if (this.comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please choose item");
            }

            //if user provides the necessary information
            else
            {
                this.listBox2.Items.Remove(comboBox2.SelectedItem);
                MessageBox.Show("The item has been removed from the grocery list");
                this.textBox1.Clear();
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
             if (listBox3.Items.Cast<String>().Any(item => item == listBox2.SelectedItem.ToString()))
            {
                MessageBox.Show("This item has already been added to the storage");
            }

            else
            {
                //To add the selected item from the grocery list to the storage after the item has been bought
                this.listBox3.Items.Add(this.listBox2.SelectedItem);
            }
           
        }

        //End of code for the grocery tab
    }
}
