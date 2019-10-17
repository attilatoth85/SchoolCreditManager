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

        
    }
}
