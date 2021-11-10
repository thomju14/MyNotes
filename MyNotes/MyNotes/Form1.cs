using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace MyNotes
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=NotesApp.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        public Form1()
        {
            InitializeComponent();
            con = new SQLiteConnection(connectionString, true);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM USER";
                cmd = new SQLiteCommand(query, con);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string command = @"INSERT INTO USER (FirstName,LastName,Email,Password) VALUES ('Palak','Sharma','palak@gmail.com','123')";
            cmd = new SQLiteCommand(command, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
