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
using System.Configuration;

namespace MyNotesApp
{
    public partial class LoginPage : Form
    {
        String dbConnectionString = "";
        DataTable login = new DataTable();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["MyNotesApp.Properties.Settings.NotesDBConnectionString"].ConnectionString;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TextBox_Username.Text;
            string password = textbox_Password.Text;
            string query = "SELECT * from Login";
            using (SqlConnection sqlConnection = new SqlConnection(dbConnectionString))
            {
                using (SqlDataAdapter Adapter = new SqlDataAdapter(query, sqlConnection))
                {

                    sqlConnection.Open();
                    Adapter.Fill(login);
                    sqlConnection.Close();

                    int count = 0;
                    for (int i = 0; i < login.Rows.Count; i++)
                    {
                        if (login.Rows[i]["Username"].ToString() == username)
                        {
                            count++;
                            if (login.Rows[i]["Password"].ToString() == password)
                            {
                                MyNotes notes = new MyNotes(username);
                                this.Hide();
                                notes.Show();
                                notes.Closed += (s, args) => Application.Exit();
                            }
                            else
                            {
                                //Message Password incorrect
                                MessageBox.Show("Password incorrect");
                            }
                        }
                    }
                    if (count == 0)
                    {
                        //Message username not found
                        MessageBox.Show("Username not found");
                    }
                }
            }

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = TextBox_Username.Text;
            string password = textbox_Password.Text;
            int count = 0;
            string query = "SELECT * from Login";
            using (SqlConnection sqlConnection = new SqlConnection(dbConnectionString))
            {
                using (SqlDataAdapter Adapter = new SqlDataAdapter(query, sqlConnection))
                {

                    sqlConnection.Open();
                    Adapter.Fill(login);
                    sqlConnection.Close();
                    for (int i = 0; i < login.Rows.Count; i++)
                    {
                        if (login.Rows[i]["Username"].ToString() == username)
                        {
                            count++;
                        }
                    }
                }
                if (count > 0)
                {
                    MessageBox.Show("Username Already Exists. Try a different one.");
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlConnection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Username", TextBox_Username.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", textbox_Password.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is sucessfull");
                    sqlConnection.Close();
                }
            }
        }
    }
}
