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

namespace CreditManager
{
    public partial class AddNewSubject : UserControl
    {
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
                UserName = Student.UserName
            };

        }
    }
}
