using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotesApp
{
    public partial class MyNotes : Form
    {
        static SqlConnection connection;
        //static SqlCommand command;
        //static string query = "";
        //static SqlCommand command = new SqlCommand(query,connection);
        //command.ExecuteNonQuery();
        public MyNotes()
        {
            InitializeComponent();
        }

        private void MyNotes_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;" +
                @"AttachDbFilename=|DataDirectory|\NotesDB.mdf;
                Integrated Security=True;
                Connect Timeout=30;
                User Instance=True");
            connection.Open();
        }
    }
}
