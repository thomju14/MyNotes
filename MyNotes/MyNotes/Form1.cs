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
        public int stringCounter { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();
            con = new SQLiteConnection(connectionString, true);
            pnlNotes.AutoSize = true;
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
                e.Handled=true;
            }
           

        }
    }
}
