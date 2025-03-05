using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP101_Assignment
{
    public partial class ReturnThesis : Form
    {
        // Use the shared class to access the shared arrays
        private SharedData sharedData = new SharedData();

        // Constants
        private const int FINE_PER_WEEK = 5;

        public ReturnThesis()
        {
            InitializeComponent();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already in this section.");

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

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowThesis borrowThesis = new BorrowThesis();
            borrowThesis.ShowDialog();
        }

        private void btnThesisReturn_Click(object sender, EventArgs e)
        {
            // Get the return date from the input field
            string returnDateString = returnDateInput.Text;

            // Check if any borrowed thesis is selected
            if (lstThesisBorrowedList.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a thesis to return.");
                return;
            }

            // Get the selected borrowed thesis
            string selectedBorrowedThesis = lstThesisBorrowedList.SelectedItem.ToString();

            // Split the selected borrowed thesis into its components
            string[] borrowedThesisInfo = selectedBorrowedThesis.Split(',');

            // Parse the return date
            DateTime returnDate;

            if(string.IsNullOrEmpty(returnDateInput.Text))
            {
                MessageBox.Show("Please enter return date.");
            }
            // Validate the return date format
            if (!DateTime.TryParseExact(returnDateString, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out returnDate))
            {
                MessageBox.Show($"Invalid return date format: {returnDateString}. Please ensure the date is in MM/DD/YYYY format.");
                return;
            }

            // Parse the borrow date
            DateTime borrowDate;
            if (!DateTime.TryParseExact(borrowedThesisInfo[2], "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out borrowDate))
            {
                MessageBox.Show($"Invalid borrow date format in the records: {borrowedThesisInfo[2]}. Please correct the borrow date for this thesis. Expected format: MM/DD/YYYY");
                return;
            }

            // Calculate the overdue fine
            int overdueDays = (returnDate - borrowDate).Days;
            int fine = Math.Max(0, overdueDays * FINE_PER_WEEK / 7);

            // Display the overdue fine
            lblFine.Text = $"Fine: RM{fine}";

            // Remove the returned thesis from the borrowedTheses array
            int indexToRemove = Array.IndexOf(SharedData.BorrowedTheses, selectedBorrowedThesis);
            if (indexToRemove >= 0)
            {
                SharedData.BorrowedTheses[indexToRemove] = "";
            }

            // Remove the returned thesis from the listbox
            lstThesisBorrowedList.Items.Remove(selectedBorrowedThesis);

            // Display a success message
            MessageBox.Show("Thesis returned successfully");
        }

        // Select a borrowed thesis and display the corresponding student ID
        private void lstThesisBorrowedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstThesisBorrowedList.SelectedIndex >= 0)
            {
                string selectedBorrowedThesis = lstThesisBorrowedList.SelectedItem.ToString();
                string[] borrowedThesisInfo = selectedBorrowedThesis.Split(',');

                if (borrowedThesisInfo.Length >= 2)
                {
                    // Display the thesis name and student ID
                    lblThesisName.Text = borrowedThesisInfo[0];
  
                    //Parse the return date
                    string returnDateString = returnDateInput.Text;

                    // Validate the return date
                    if (DateTime.TryParseExact(returnDateString, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime returnDate))
                    {
                        // Parse the borrow date
                        if (DateTime.TryParseExact(borrowedThesisInfo[2], "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime borrowDate))
                        {

                        }
                        else
                        {
                            MessageBox.Show($"Invalid borrow date format in the records: {borrowedThesisInfo[2]}. Please correct the borrow date for this thesis. Expected format: MM/dd/yyyy");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid return date format: {returnDateString}. Please ensure the date is in MM/dd/yyyy format.");
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid borrowed thesis information: {selectedBorrowedThesis}");
                }
            }
        }

        // Populate the borrowed theses listbox with the borrowed theses from the borrowedTheses array
        private void ReturnThesis_Load(object sender, EventArgs e)
        {
            foreach (string borrowedThesis in SharedData.BorrowedTheses)
            {
                if (!string.IsNullOrEmpty(borrowedThesis))
                {
                    // Correct the borrow date format
                    string correctedThesis = SharedData.CorrectBorrowDateFormat(borrowedThesis);
                    lstThesisBorrowedList.Items.Add(correctedThesis);
                }
            }
        }

        private void returnDateInput_TextChanged(object sender, EventArgs e)
        {
            // Validate the return date format when the user finishes typing
            if (returnDateInput.Text.Length == 10) // Check if the input is complete (MM/dd/yyyy)
            {
                // Validate the return date format only if the input is not empty
                if (!string.IsNullOrEmpty(returnDateInput.Text))
                {
                    // Validate the return date format
                    string returnDate = returnDateInput.Text;
                    if (!DateTime.TryParseExact(returnDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                    {
                        MessageBox.Show("Invalid return date format. Please enter the date in MM/dd/yyyy format.");
                        returnDateInput.Text = ""; // Clear the input field
                    }
                }
            }
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
