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
using System.Data.SqlClient;
using System.Data.Linq;

namespace CreditManager
{
    public partial class MainForm : Form
    {
        static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");
        static DataContext dataContext = new DataContext(connection);
        Table<Students> studentsDb = dataContext.GetTable<Students>();

        public MainForm()
        {
            InitializeComponent();            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = Student.UserName + "!";
            SetUserId();
        }

        private void SetUserId()
        {
            Student.UserID = (from c in studentsDb where (c.Name == Student.UserName) select c.UserID).First();
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
