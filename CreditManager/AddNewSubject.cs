using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.Data.SqlClient;
using System.Data.Linq;

namespace CreditManager
{
    public partial class AddNewSubject : UserControl
    {

        static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
            C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");               

        public AddNewSubject()
        {
            InitializeComponent();
            
        }

        

        public void CreateSubjectButton_Click(object sender, EventArgs e)
        {

            Subject subject = new Subject
            {
                SubjectName = SubjectNameTextBox.Text,
                Semester = int.Parse(SubjectSemesterTextBox.Text),
                CurrentType = SubjectTypeTextBox.Text,
                Credit = int.Parse(SubjectCreditTextBox.Text),
                Pass = bool.Parse(SubjectPassTextBox.Text),
            };

            SqlCommand command = new SqlCommand("INSERT INTO Subjects(SubjectName, Semester, CurrentType, Credit, Pass, UserID)" + 
                " VALUES( @SubjectName, @Semester, @CurrentType, @Credit, @Pass, @UserID)", connection);
            command.Parameters.AddWithValue("@SubjectName",subject.SubjectName);
            command.Parameters.AddWithValue("@Semester", subject.Semester);
            command.Parameters.AddWithValue("@CurrentType", subject.CurrentType);
            command.Parameters.AddWithValue("@Credit", subject.Credit);
            command.Parameters.AddWithValue("@Pass", subject.Pass);
            command.Parameters.AddWithValue("@UserID", Student.UserID);

            connection.Open();
            command.ExecuteNonQuery();
            

            connection.Close();

                                 
        }
    }
}
