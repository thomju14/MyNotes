using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotesApp
{
    public partial class LoginPage : Form
    {
        static SqlConnection connection;
        string connectionString = "Data Source=NotesApp.db";
        public int stringCounter { get; set; } = 0;
        static SqlCommand command;
        static string query = "";
        //static SqlCommand command = new SqlCommand(query,connection);
        //command.ExecuteNonQuery();
        public LoginPage()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NotesDB.mdf;Integrated Security=True");
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
           
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TextBox_Username.Text;
            string password = textbox_Password.Text;

            query = @"SELECT * from Login WHERE username=@userName AND password=@password";

            command = new SqlCommand();
            command.Parameters.AddWithValue("@userName", username);
            command.Parameters.AddWithValue("@password", password);

            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = connection;

            connection.Open();
            int loginResult = command.ExecuteNonQuery();
            connection.Close();
            if (loginResult == 0)
            {
                lblMessage.Text = "Login Failed! Try Again.";
            }
            else
            {
                MyNotes notes = new MyNotes();
                this.Hide();
                notes.Show();
            }
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
                    }
    }
}
