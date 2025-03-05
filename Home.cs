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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
           
        }

        private void btnRegStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegStudent regStudent = new RegStudent();
            regStudent.ShowDialog();
        }

        private void btnRegThesis_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegThesis regThesis = new RegThesis();
            regThesis.ShowDialog();
           
        }

        private void btnBorrowThesis_Click(object sender, EventArgs e)
        {
            BorrowThesis borrowThesisForm = new BorrowThesis();
            this.Hide();
            borrowThesisForm.ShowDialog();
            
        }

        private void btnReturnThesis_Click(object sender, EventArgs e)
        {
            ReturnThesis returnThesis = new ReturnThesis();
            this.Hide();
            returnThesis.ShowDialog();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
