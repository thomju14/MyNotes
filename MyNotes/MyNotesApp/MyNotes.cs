using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public int stringCounter { get; set; } = 0;
        static SqlCommand command;
        static string query = "";
        DataTable dt;
        
        public MyNotes()
        {
            try
            {
                InitializeComponent();
                pnlNotes.AutoSize = true;
                connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NotesDB.mdf;Integrated Security=True");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MyNotes_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataTable();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnRead_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbHeading.Text != null && rtbHeading.Text != string.Empty)
                {
                    query = @"INSERT INTO Note (UserName,Title,Content,LastAccessed) VALUES ('fshafiq','" + rtbHeading.Text + "','" + richTextBox1.Text + "','" + DateTime.Now + "')";
                    command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.Connection = connection;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    LoadDataTable();
                }
                else
                    MessageBox.Show("Please add some data");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void rtbHeading_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void rtbHeading_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
            
        }
        private void LoadDataTable()
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("Title", typeof(String));
                

                command = new SqlCommand();

                query = @"SELECT Title from NOTE WHERE username=@userName";
                command.Parameters.AddWithValue("@userName", "fshafiq");

                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = connection;
                connection.Open();

                // int result = command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(String.Format("{0}", reader["Title"]));
                    }

                }

                connection.Close();

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Title"].Width = 109;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }
    }
}
