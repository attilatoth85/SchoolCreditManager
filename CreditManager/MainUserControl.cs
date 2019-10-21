using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
using ClassLibrary;

namespace CreditManager
{
    public partial class MainUserControl : UserControl
    {
        static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");
        static DataContext dataContext = new DataContext(connection);
        Table<Students> studentsDb = dataContext.GetTable<Students>();
        Table<Subjects> subjectsDb = dataContext.GetTable<Subjects>();
        //MainUserControl mainUserControl1 = new MainUserControl();
        string name = Student.UserName;

        public MainUserControl()
        {
            InitializeComponent();
        }
        

        private void MainUserControl_Load(object sender, EventArgs e)
        {
            SetSchool();
            SetCredit();
            SetPassedNumber();
            SetRequiredPassed();
            SetSpecialistPassed();
            SetOptionalPassed();
        }

        private void SetOptionalPassed()
        {
            lblOptionalPassed.Text= (from c in subjectsDb where c.Pass == "1" && c.CurrentType == "optional" select c).Count().ToString();
        }

        private void SetSpecialistPassed()
        {
            lblSpecialistPassed.Text= (from c in subjectsDb where c.Pass == "1" && c.CurrentType == "specialist" select c).Count().ToString();
        }

        private void SetRequiredPassed()
        {
            lblRequiredPassed.Text= (from c in subjectsDb where c.Pass == "1" && c.CurrentType=="required" select c).Count().ToString();
        }

        private void SetPassedNumber()
        {
            lblPassedSubject.Text= (from c in subjectsDb where c.Pass == "1" select c).Count().ToString();
        }

        private void SetSchool()
        {
            lblSchoolName.Text = (from c in studentsDb where c.Name == Student.UserName select c.School).First();
        }
        private void SetCredit()
        {
            string temp = (from c in subjectsDb where c.Pass == "1" select c).Count().ToString();
            if (int.TryParse(temp, out int passedSubject))
            {
                int sumCredit = passedSubject * 5;
                lblSumCredit.Text = sumCredit.ToString();
            }
        }
    }
}
