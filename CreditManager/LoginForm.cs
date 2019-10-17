using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        MainForm mainForm = new MainForm();
        Student student = new Student();


        private void SignInButton_Click(object sender, EventArgs e)
        {
            bool fail = true;

            if(String.IsNullOrEmpty(UserNameTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Not filled right! Please try again.","Sign in to School Credit Manager");
            }  
            else
            {
                FileStream stream = new FileStream(LoginClass.FilePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                using (StreamReader reader = new StreamReader(stream))
                {
                    string temp = reader.ReadLine();
                    string[] tempArray = temp.Split(',');

                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        if (UserNameTextBox.Text == tempArray[i] && PasswordTextBox.Text == tempArray[i+1])
                        {
                            fail = false;
                            Student.UserName = UserNameTextBox.Text;
                            this.Hide();
                            mainForm.Show();
                        }
                    }                   
                }
                if (fail)
                {
                    MessageBox.Show("Not filled right! Please try again.", "Sign in to School Credit Manager");
                }
            }
        }


        private void RegisterButton_Click(object sender, EventArgs e)
        { 

            if (String.IsNullOrEmpty(UserNameTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text)) { MessageBox.Show("Not filled right! Please try again.", "Sign in to School Credit Manager"); }
            else
            {
                FileStream stream = new FileStream(LoginClass.FilePath, FileMode.Append, FileAccess.Write, FileShare.None);
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write("," + UserNameTextBox.Text);
                    writer.Write("," + PasswordTextBox.Text);
                }
            }
        }
    }
}
