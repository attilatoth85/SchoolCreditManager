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

        static DataContext dataContext = new DataContext(Database.ConnectionString);
        Table<Students> studentsDb = dataContext.GetTable<Students>();

        static SqlConnection sqlCon = new SqlConnection(Database.ConnectionString);
        SqlCommand sqlCmd = new SqlCommand(Database.SqlComm, sqlCon);



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
            Student.UserID = (from c in studentsDb where c.Name == Student.UserName select c.UserID).First();
            sqlCon.Close();
        }

        private void SetSchool()
        {
            lblSchoolName.Text = (from c in studentsDb where c.Name == Student.UserName select c.School).FirstOrDefault();
            sqlCon.Close();
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

        private void BtnAverages_Click(object sender, EventArgs e)
        {
            viewPointer.Location = new Point(160, 193);

        }

        private void BtnCalendar_Click(object sender, EventArgs e)
        {
            viewPointer.Location = new Point(160, 229);

        }

        private void BtnSetup_Click(object sender, EventArgs e)
        {
            viewPointer.Location = new Point(160, 265);

        }

        private void pbNeptun_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://nappw.dfad.duf.hu/hallgato/login.aspx");
        }

        private void pbMoodle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://moodle.uniduna.hu/login/index.php");

        }
        
        
    }
}
