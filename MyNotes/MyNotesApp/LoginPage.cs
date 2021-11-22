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
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;" +
                @"AttachDbFilename=|DataDirectory|\NotesDB.mdf;
                Integrated Security=True;
                Connect Timeout=30;
                User Instance=True");
            connection.Open();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TextBox_Username.Text;
            string password = textbox_Password.Text;
            query = $"fn_checklogin({username},{password})";
            command = new SqlCommand(query, connection);
            int loginResult= command.ExecuteNonQuery();

            if(loginResult==0)
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
    }
}
