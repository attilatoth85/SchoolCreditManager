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
        
        MainUserControl mainUserControl1 = new MainUserControl();

        public MainForm()
        {
            InitializeComponent();            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcomeName.Text = Student.UserName + "!";
            SetUserId();
            SetSchool();
        }

        private void SetUserId()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");
            DataContext dataContext = new DataContext(connection);
            Table<Students> studentsDb = dataContext.GetTable<Students>();
            Student.UserID = (from c in studentsDb where c.Name == Student.UserName select c.UserID).First();
            connection.Close();
        }

        private void SetSchool()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");
            DataContext dataContext = new DataContext(connection);
            Table<Students> studentsDb = dataContext.GetTable<Students>();
            lblSchoolName.Text = (from c in studentsDb where c.Name == Student.UserName select c.School).FirstOrDefault();
            connection.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        

        private void SignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }



        private void BtnAddSubject_Click(object sender, EventArgs e)
        {
            mainUserControl2.Visible = false;
            addNewSubject1.Visible = true;
            viewPointer.Location = new Point(160, 121); 
        }

        private void BtnDiagram_Click(object sender, EventArgs e)
        {
            viewPointer.Location = new Point(160, 157);

            addNewSubject1.Visible = false;
            mainUserControl2.Show();
        }
    }
}
