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
using System.Data.SqlClient;


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
        bool used;

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

                        if (UserNameTextBox.Text == tempArray[i] && tempArray[i+1]==EasyEncryption.MD5.ComputeMD5Hash(PasswordTextBox.Text))
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

            using (StreamReader reader = new StreamReader(LoginClass.FilePath))
            {
                string temp = reader.ReadLine();
                string[] tempArray = temp.Split(',');
                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (tempArray[i] == UserNameTextBox.Text)
                    {
                        used = true;
                        MessageBox.Show("This username is used", "Sign in to School Credit Manager");                        
                    }
                    i += 2;
                }
            }

            if ( used ||String.IsNullOrEmpty(UserNameTextBox.Text) || String.IsNullOrEmpty(PasswordTextBox.Text))
                { MessageBox.Show("Not filled right! Please try again.", "Sign in to School Credit Manager"); }

            else
            {
                FileStream stream = new FileStream(LoginClass.FilePath, FileMode.Append, FileAccess.Write, FileShare.None);

                string inputPswText = PasswordTextBox.Text;
                string calculateHash = EasyEncryption.MD5.ComputeMD5Hash(inputPswText);

                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write("," + UserNameTextBox.Text);
                    writer.Write("," + calculateHash);
                }

                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\totha\Source\Repos\SchoolCreditManager\CreditManager\Database1.mdf;Integrated Security=True");
                SqlCommand command2 = new SqlCommand("INSERT INTO Students( Name)" +
                " VALUES( @Name )", connection);
                connection.Open();
                command2.Parameters.AddWithValue("@Name", UserNameTextBox.Text);
                command2.ExecuteNonQuery();
                connection.Close();
            }
        }

        
    }
}
