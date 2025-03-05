using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP101_Assignment
{
    public partial class RegStudent : Form
    {
        // Use the shared class to access the shared arrays
        private SharedData sharedData = new SharedData();

        public RegStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the student's name, ID, and email
            string studentName = txtStudentName.Text;
            string studentID = (txtStudentID.Text);
            string studentEmail = txtStudentEmail.Text;

            // Check if the student's name, ID, and email are empty
            if (string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(studentEmail))
            {
                // Display an error message
                MessageBox.Show("Please fill in all the fields");
                return;
            }

            // Add the student to the shared students array
            SharedData.Students[SharedData.Students.Length - 1] = studentName + "," + studentID + "," + studentEmail;

            // Clear the textboxes
            txtStudentName.Text = "";
            txtStudentID.Text = "";
            txtStudentEmail.Text = "";
            btnExit.Focus();

            // Display a success message
            MessageBox.Show("Student added successfully");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the current form and show the home form
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already in this section. ");
        }

        private void thesisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegThesis regThesis = new RegThesis();
            regThesis.ShowDialog();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowThesis borrowThesis = new BorrowThesis();
            borrowThesis.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnThesis returnThesis = new ReturnThesis();
            returnThesis.ShowDialog();
        }
        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
