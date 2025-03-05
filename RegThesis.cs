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
    public partial class RegThesis : Form
    {
        // Use the shared class to access the shared arrays
        private SharedData sharedData = new SharedData();

        public RegThesis()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the thesis's ID, title, author, and year published
            string thesisID = txtThesisID.Text;
            string thesisTitle = txtThesisTitle.Text;
            string thesisAuthor = txtAuthor.Text;
            string thesisYearPublished = txtYearPublished.Text;

            // Check if the thesis's ID, title, author, and year published are empty
            if (string.IsNullOrEmpty(thesisID) || string.IsNullOrEmpty(thesisTitle) || string.IsNullOrEmpty(thesisAuthor) || string.IsNullOrEmpty(thesisYearPublished))
            {
                MessageBox.Show("Please fill in all the fields");
                return;
            }

            // Add the thesis to the shared theses array and available theses list
            SharedData.Theses[SharedData.Theses.Length - 1] = thesisID + "," + thesisTitle + "," + thesisAuthor + "," + thesisYearPublished;
            SharedData.AvailableTheses.Add(thesisID + "," + thesisTitle + "," + thesisAuthor + "," + thesisYearPublished);

            // Clear the textboxes
            txtThesisID.Text = "";
            txtThesisTitle.Text = "";
            txtAuthor.Text = "";
            txtYearPublished.Text = "";
            txtThesisID.Focus();

            // Display a success message
            MessageBox.Show("Thesis registered successfully");
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowThesis borrowThesis = new BorrowThesis();
            borrowThesis.ShowDialog();
        }

        private void studentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                RegStudent regstudent = new RegStudent();
                regstudent.ShowDialog();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
                RegStudent regstudent = new RegStudent();
                regstudent.ShowDialog();
        }

        private void thesisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already in this section. ");
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the home form
            this.Close();
            Home home = new Home();
            home.ShowDialog();

        }
    }
}
