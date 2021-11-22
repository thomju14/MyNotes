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
        string connectionString = "Data Source=NotesApp.db";
        public int stringCounter { get; set; } = 0;
        //static SqlCommand command;
        //static string query = "";
        //static SqlCommand command = new SqlCommand(query,connection);
        //command.ExecuteNonQuery();
        public MyNotes()
        {
            InitializeComponent();
            pnlNotes.AutoSize = true;
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM USER";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string command = @"INSERT INTO USER (FirstName,LastName,Email,Password) VALUES ('Palak','Sharma','palak@gmail.com','123')";
        }

        private void rtbHeading_KeyDown(object sender, KeyEventArgs e)
        {
            //stringCounter++;
            //if (stringCounter > 34)
            //{
            //    MessageBox.Show("Sorry Only 34 characters are allowed");
            //    if (e.KeyCode=>Keys.A || e.)
            //    return;
            //}
        }

        private void rtbHeading_KeyPress(object sender, KeyPressEventArgs e)
        {

            char key = e.KeyChar;
            if (key == '\b')
                stringCounter--;
            else
                stringCounter++;



            if (rtbHeading.Text.Length >= 34)
            {
                MessageBox.Show("Sorry Only 33 characters are allowed");
                e.Handled = true;
            }


        }
    }
}
