using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = Student.UserName + "!";
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            addNewSubject1.Visible = true;
        }

        private void ToHome_Click(object sender, EventArgs e)
        {
            addNewSubject1.Visible = false;
        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        
    }
}
