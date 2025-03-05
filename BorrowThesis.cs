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
    public partial class BorrowThesis : Form
    {
        // Use the shared class to access the shared arrays
        private SharedData sharedData = new SharedData();

        public BorrowThesis()
        {
            InitializeComponent();
        }

        private void btnThesisBorrow_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;

            // Get the selected thesis and student ID
            if (lstThesisAvaliableList.SelectedIndex >= 0)
            {
            string selectedThesis = lstThesisAvaliableList.SelectedItem.ToString();
                
            // Add the borrowed thesis to the shared borrowed theses array
            SharedData.BorrowedTheses[SharedData.BorrowedTheses.Length - 1] = selectedThesis + "," + studentID + "," + DateTime.Now.ToString("MM/dd/yyyy");

            // Remove the borrowed thesis from the shared available theses list
            SharedData.AvailableTheses.Remove(selectedThesis);

            // Check if the student ID is empty
            if (string.IsNullOrEmpty(studentID))
            {
                MessageBox.Show("Please enter the student ID");
                return;
            }

            // Clear the student ID textbox
            txtStudentID.Text = "";

            // Update the borrowed thesis label
            lblBorrowedThesis.Text = selectedThesis;

            // Display a success message
            MessageBox.Show("Thesis borrowed successfully");
                return;
            }
            else
            {
                MessageBox.Show("Please select a thesis to borrow.");
            }
            

        }
        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already in this section. ");
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegStudent regStudent = new RegStudent();
            regStudent.ShowDialog();
        }

        private void thesisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegThesis regThesis = new RegThesis();
            regThesis.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnThesis returnThesis = new ReturnThesis();
            returnThesis.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the home form
            this.Close();
            Home home = new Home();
            home.ShowDialog();
        }

        // Populate the available theses listbox with the theses from the theses array
        private void BorrowThesis_Load(object sender, EventArgs e)
        {
            foreach (string thesis in SharedData.Theses)
            {
                if (!string.IsNullOrEmpty(thesis) && !SharedData.BorrowedTheses.Contains(thesis))
                {
                    lstThesisAvaliableList.Items.Add(thesis);
                }
            }
        }    
    }
}
