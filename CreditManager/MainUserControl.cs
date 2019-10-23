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
using System.Windows.Forms.DataVisualization.Charting;

namespace CreditManager
{
    public partial class MainUserControl : UserControl
    {
        
        string name = Student.UserName;

        string s1r, s2r, s3r, s4r, s5r, s6r, s7r;
        string s1s, s2s, s3s, s4s, s5s, s6s, s7s;
        string s1o, s2o, s3o, s4o, s5o, s6o, s7o;

        public MainUserControl()
        {
            InitializeComponent();          

        }

        private void MainUserControl_Load(object sender, EventArgs e)
        {
            SetCredit();
            SetPassedNumber();
            SetRequiredPassed();
            SetSpecialistPassed();
            SetOptionalPassed();

            SetSemestersValues();
            chart1.Titles.Add("Subjects in Semesters");

            chart1.Series["Optional"].Points.AddXY("1", s1r);
            chart1.Series["Specialist"].Points.AddXY("1", s1s);
            chart1.Series["Required"].Points.AddXY("1", s1o);

            chart1.Series["Optional"].Points.AddXY("2", s2r);
            chart1.Series["Specialist"].Points.AddXY("2", s2s);
            chart1.Series["Required"].Points.AddXY("2", s2o);

            chart1.Series["Optional"].Points.AddXY("3", s3r);
            chart1.Series["Specialist"].Points.AddXY("3", s3s);
            chart1.Series["Required"].Points.AddXY("3", s3o);

            chart1.Series["Optional"].Points.AddXY("4", s4r);
            chart1.Series["Specialist"].Points.AddXY("4", s4s);
            chart1.Series["Required"].Points.AddXY("4", s4o);

            chart1.Series["Optional"].Points.AddXY("5", s5r);
            chart1.Series["Specialist"].Points.AddXY("5", s5s);
            chart1.Series["Required"].Points.AddXY("5", s5o);

            chart1.Series["Optional"].Points.AddXY("6", s6r);
            chart1.Series["Specialist"].Points.AddXY("6", s6s);
            chart1.Series["Required"].Points.AddXY("6", s6o);

            chart1.Series["Optional"].Points.AddXY("7", s7r);
            chart1.Series["Specialist"].Points.AddXY("7", s7s);
            chart1.Series["Required"].Points.AddXY("7", s7o);
        }

        private void SetSemestersValues()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");
            connection.Open();
            DataContext dataContext = new DataContext(connection);
            Table<Students> studentsDb = dataContext.GetTable<Students>();
            Table<Subjects> subjectsDb = dataContext.GetTable<Subjects>();

            s1r = (from c in subjectsDb where c.Semester == 1 && c.CurrentType == "required" && c.Pass == "1" select c).Count().ToString();
            s1s= (from c in subjectsDb where c.Semester == 1 && c.CurrentType == "specialist" && c.Pass == "1" select c).Count().ToString();
            s1o = (from c in subjectsDb where c.Semester == 1 && c.CurrentType == "optional" && c.Pass == "1" select c).Count().ToString();

            s2r = (from c in subjectsDb where c.Semester == 2 && c.CurrentType == "required" && c.Pass == "1" select c).Count().ToString();
            s2s = (from c in subjectsDb where c.Semester == 2 && c.CurrentType == "specialist" && c.Pass == "1" select c).Count().ToString();
            s2o = (from c in subjectsDb where c.Semester == 2 && c.CurrentType == "optional" && c.Pass == "1" select c).Count().ToString();

            s3r = (from c in subjectsDb where c.Semester == 3 && c.CurrentType == "required" && c.Pass == "1" select c).Count().ToString();
            s3s = (from c in subjectsDb where c.Semester == 3 && c.CurrentType == "specialist" && c.Pass == "1" select c).Count().ToString();
            s3o = (from c in subjectsDb where c.Semester == 3 && c.CurrentType == "optional" && c.Pass == "1" select c).Count().ToString();

            s4r = (from c in subjectsDb where c.Semester == 4 && c.CurrentType == "required" && c.Pass == "1" select c).Count().ToString();
            s4s = (from c in subjectsDb where c.Semester == 4 && c.CurrentType == "specialist" && c.Pass == "1" select c).Count().ToString();
            s4o = (from c in subjectsDb where c.Semester == 4 && c.CurrentType == "optional" && c.Pass == "1" select c).Count().ToString();

            s5r = (from c in subjectsDb where c.Semester == 5 && c.CurrentType == "required" && c.Pass == "1" select c).Count().ToString();
            s5s = (from c in subjectsDb where c.Semester == 5 && c.CurrentType == "specialist" && c.Pass == "1" select c).Count().ToString();
            s5o = (from c in subjectsDb where c.Semester == 5 && c.CurrentType == "optional" && c.Pass == "1" select c).Count().ToString();

            s6r = (from c in subjectsDb where c.Semester == 6 && c.CurrentType == "required" && c.Pass == "1" select c).Count().ToString();
            s6s = (from c in subjectsDb where c.Semester == 6 && c.CurrentType == "specialist" && c.Pass == "1" select c).Count().ToString();
            s6o = (from c in subjectsDb where c.Semester == 6 && c.CurrentType == "optional" && c.Pass == "1" select c).Count().ToString();

            s7r = (from c in subjectsDb where c.Semester == 7 && c.CurrentType == "required" && c.Pass == "1" select c).Count().ToString();
            s7s = (from c in subjectsDb where c.Semester == 7 && c.CurrentType == "specialist" && c.Pass == "1" select c).Count().ToString();
            s7o = (from c in subjectsDb where c.Semester == 7 && c.CurrentType == "optional" && c.Pass == "1" select c).Count().ToString();

            

        }


        

        private void SetOptionalPassed()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");
            connection.Open();
            DataContext dataContext = new DataContext(connection);
            Table<Students> studentsDb = dataContext.GetTable<Students>();
            Table<Subjects> subjectsDb = dataContext.GetTable<Subjects>();
            lblOptionalPassed.Text= (from c in subjectsDb where c.Pass == "1" && c.CurrentType == "optional" select c).Count().ToString();
            connection.Close();
        }

        private void SetSpecialistPassed()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");
            connection.Open();
            DataContext dataContext = new DataContext(connection);
            Table<Students> studentsDb = dataContext.GetTable<Students>();
            Table<Subjects> subjectsDb = dataContext.GetTable<Subjects>();
            lblSpecialistPassed.Text= (from c in subjectsDb where c.Pass == "1" && c.CurrentType == "specialist" select c).Count().ToString();
            connection.Close();

        }

        private void SetRequiredPassed()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");
            connection.Open();

            DataContext dataContext = new DataContext(connection);
            Table<Students> studentsDb = dataContext.GetTable<Students>();
            Table<Subjects> subjectsDb = dataContext.GetTable<Subjects>();
            lblRequiredPassed.Text= (from c in subjectsDb where c.Pass == "1" && c.CurrentType=="required" select c).Count().ToString();
            connection.Close();

        }

        private void SetPassedNumber()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");
            connection.Open();

            DataContext dataContext = new DataContext(connection);
            Table<Students> studentsDb = dataContext.GetTable<Students>();
            Table<Subjects> subjectsDb = dataContext.GetTable<Subjects>();
            lblPassedSubject.Text= (from c in subjectsDb where c.Pass == "1" select c).Count().ToString();
            connection.Close();

        }


        private void SetCredit()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");
            connection.Open();

            DataContext dataContext = new DataContext(connection);
            Table<Students> studentsDb = dataContext.GetTable<Students>();
            Table<Subjects> subjectsDb = dataContext.GetTable<Subjects>();
            string temp = (from c in subjectsDb where c.Pass == "1" select c).Count().ToString();
            if (int.TryParse(temp, out int passedSubject))
            {
                int sumCredit = passedSubject * 5;
                lblSumCredit.Text = sumCredit.ToString();
            }
            connection.Close();

        }

        
    }
}
