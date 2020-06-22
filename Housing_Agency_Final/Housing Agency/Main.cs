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
        Users myUsers;
        
        Houserules myhouserules;
        Complaints Complaint;

        


        int count;
        public Main()
        {
            InitializeComponent();
            tabControl1.SelectTab("tabPage3");
            cbxAnonymous.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
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
                
                this.listBox1.Items.Add(comboBox2.SelectedItem );
                this.listBox2.Items.Add(comboBox2.SelectedItem + "    " + student);
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

        private void AddComplaint()
        {
            
            String newComplaint = this.textBox2.Text;
            String studentName = this.tbNameC.Text;
            Complaint = new Complaints();
            Complaint.MakeComplaint(newComplaint);
            this.listBox7.Items.Add("This Complaint is from" + " " + studentName + "(" + DateTime.Now.ToString() + ")" + ":  " + newComplaint);
            
           
             listBox7.Items.Add(textBox2.Text);
    
            MessageBox.Show("New complaint added");
            tbNameC.Clear();
           textBox2.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            

            if (textBox2.TextLength <= 0)

            {
                MessageBox.Show("You need to fill in a complaint");
            }
            else if (cbxAnonymous.Checked == true)
            {
                
                String newComplaint = this.textBox2.Text;
                String studentName = this.tbNameC.Text;
                Complaint = new Complaints();
                Complaint.MakeComplaint(newComplaint);
                this.listBox7.Items.Add("This Complaint is from" + " Anonymous "  + "(" + DateTime.Now.ToString() + ")" + ":  " + newComplaint);


                MessageBox.Show("New complaint added");
                tbNameC.Clear();
                textBox2.Clear();
            }
            else
            {
                AddComplaint();
            }
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_Fire_DatabaseDataSet4.House_Rules' table. You can move, or remove it, as needed.
            this.house_RulesTableAdapter.Fill(this.project_Fire_DatabaseDataSet4.House_Rules);
            // TODO: This line of code loads data into the 'project_Fire_DatabaseDataSet3.Apartments' table. You can move, or remove it, as needed.
            this.apartmentsTableAdapter.Fill(this.project_Fire_DatabaseDataSet3.Apartments);
            // TODO: This line of code loads data into the 'project_Fire_DatabaseDataSet2.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.project_Fire_DatabaseDataSet2.Student);
            // TODO: This line of code loads data into the 'project_Fire_DatabaseDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.project_Fire_DatabaseDataSet1.Student);
            // TODO: This line of code loads data into the 'project_Fire_DatabaseDataSet.Chores' table. You can move, or remove it, as needed.
            this.choresTableAdapter.Fill(this.project_Fire_DatabaseDataSet.Chores);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string studentName = this.comboBox1.Text;
            String Task = this.comboBox3.SelectedItem.ToString();
            if (String.IsNullOrEmpty(studentName) && this.comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please fill in the Student name and choose item");
            }
            else
            {
              // this.listBox5.Items.Remove(comboBox3.SelectedItem + this.comboBox1.Text);
                this.listBox6.Items.Add(comboBox3.Text +"  - "+comboBox1.Text);
                MessageBox.Show("The Task has been Added from the Task list");
                

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");

        }
       
        //End of code for the grocery tab
    }
}
