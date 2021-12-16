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
using System.Configuration;
using Microsoft.VisualBasic;

namespace MyNotesApp
{
    public partial class MyNotes : Form
    {
        ErrorProvider err = new ErrorProvider();
        string dbConnectionString = "";
        string query = "";
        List<SqlParameter> param = new List<SqlParameter>();
        string newpass = "";
        string readTitle = "";
        DataTable noteData = new DataTable();
        string user;
        List<NoteTab> Notes = new List<NoteTab>();
        public MyNotes(string username)
        {
            try
            {
                InitializeComponent();
                this.Size = new Size(1200, 800);
                user = username;
                this.Text = user;
                pnlNotes.AutoSize = true;
                Notes.Clear();

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
                dbConnectionString = ConfigurationManager.ConnectionStrings["MyNotesApp.Properties.Settings.NotesDBConnectionString"].ConnectionString;
                LoadDataTable();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadDataTable()
        {
            string query = "SELECT * FROM Note";
            using (SqlConnection sqlConnection = new SqlConnection(dbConnectionString))
            {
                using (SqlDataAdapter Adapter = new SqlDataAdapter(query, sqlConnection))
                {
                    sqlConnection.Open();
                    Adapter.Fill(noteData);
                    sqlConnection.Close();

                    for (int i = 0; i < noteData.Rows.Count; i++)
                    {
                        if (noteData.Rows[i]["Username"].ToString() == user)
                        {
                            AddNoteToGrid(Convert.ToInt32(noteData.Rows[i]["SerialNo"]));
                        }
                    }
                }
            }
        }
        int height = 0;
        private void AddNoteToGrid(int num)
        {
            for (int i = 0; i < noteData.Rows.Count; i++)
            {
                if (Convert.ToInt32(noteData.Rows[i]["SerialNo"]) == num)
                {
                    NoteTab Note = new NoteTab();
                    Note.title = noteData.Rows[i]["Title"].ToString();
                    Note.BackColor = Color.White;
                    Note.Size = new Size(180, 50);
                    Note.Location = new Point(0, height - NoteList.VerticalScrollingOffset);
                    NoteList.Controls.Add(Note);
                    Note.Click += Note_Click;
                    Notes.Add(Note);

                    height += 60;
                }
            }
        }

        private void Note_Click(object sender, EventArgs e)
        {
            readTitle = ((NoteTab)sender).title;
            ((NoteTab)sender).BackColor = Color.Blue;
            foreach (NoteTab note in Notes)
            {
                if (note.title != readTitle)
                {
                    note.BackColor = Color.White;
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < noteData.Rows.Count; i++)
            {
                if (noteData.Rows[i]["Title"].ToString() == readTitle)
                {
                    string password = noteData.Rows[i]["Password"].ToString().Trim();
                    if (password != "")
                    {
                        string pass = Interaction.InputBox("Enter Password:", "Password Protected Note", "");
                        if (pass == password)
                        {
                            rtbHeading.Text = readTitle;
                            richTextBox1.Text = noteData.Rows[i]["Content"].ToString();
                            LoadDropDownBtn(rtbHeading.Text, richTextBox1.Text);
                        }
                        else
                        {
                            MessageBox.Show("The password was incorrect. Try Again later", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        rtbHeading.Text = readTitle;
                        richTextBox1.Text = noteData.Rows[i]["Content"].ToString();
                        LoadDropDownBtn(rtbHeading.Text, richTextBox1.Text);
                    }
                }
                rtbHeading.ReadOnly = true;
            }
            foreach (NoteTab note in Notes)
            {
                note.BackColor = Color.White;
            }
        }

        private void btnPasswordPro_Click(object sender, EventArgs e)
        {
            newpass = Interaction.InputBox("Enter Password:", "Create Password", "");
            if (newpass == "")
            {
                MessageBox.Show("The password was not created", "No password creation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("The password created. Use this password later when you attempt to access this not.", "No password created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //old note saved/edited
                if (readTitle != "")
                {
                    //not password protected
                    if (newpass == "")
                    {
                        UpdateWithoutPassword();
                    }
                    //password protected
                    else
                    {
                        UpdateWithPassword();
                    }
                }
                //new note
                else
                {
                    //not password protected
                    if (newpass == "")
                    {
                        AddWithoutPassword();
                    }
                    //password protected
                    else
                    {
                        AddWithPassword();
                    }
                }
                try
                {
                    using (SqlConnection connection = new SqlConnection(dbConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            if (param != null)
                                command.Parameters.AddRange(param.ToArray());
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        query = "";
                        param.Clear();
                        newpass = "";
                        readTitle = "";
                        richTextBox1.Text = "";
                        rtbHeading.Text = "";
                        MessageBox.Show("Note Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MyNotes form = new MyNotes(user);
                        form.Show();
                        this.Hide();
                        form.Closed += (s, args) => Application.Exit();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void UpdateWithoutPassword()
        {
            query = @"UPDATE Note SET Content=@content,LastAccessed=@date WHERE Title=@title";
            param.Clear();
            param.Add(new SqlParameter
            {
                ParameterName = "@content",
                SqlDbType = SqlDbType.NText,
                SqlValue = richTextBox1.Text
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@date",
                SqlDbType = SqlDbType.DateTime,
                SqlValue = DateTime.Now
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@title",
                SqlDbType = SqlDbType.NVarChar,
                SqlValue = rtbHeading.Text
            });

        }
        private void UpdateWithPassword()
        {
            query = @"UPDATE Note SET Content=@content,LastAccessed=@date,Password=@pass WHERE Title=@title";
            param.Clear();
            param.Add(new SqlParameter
            {
                ParameterName = "@content",
                SqlDbType = SqlDbType.NText,
                SqlValue = richTextBox1.Text
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@date",
                SqlDbType = SqlDbType.DateTime,
                SqlValue = DateTime.Now
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@pass",
                SqlDbType = SqlDbType.NVarChar,
                SqlValue = newpass
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@title",
                SqlDbType = SqlDbType.NVarChar,
                SqlValue = rtbHeading.Text
            });
        }
        private void AddWithoutPassword()
        {
            query = @"INSERT INTO Note(Username,Title,Content) VALUES(@user,@title,@content)";
            param.Clear();
            param.Add(new SqlParameter
            {
                ParameterName = "@content",
                SqlDbType = SqlDbType.NText,
                SqlValue = richTextBox1.Text
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@user",
                SqlDbType = SqlDbType.NVarChar,
                SqlValue = user
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@title",
                SqlDbType = SqlDbType.NVarChar,
                SqlValue = rtbHeading.Text
            });
        }
        private void AddWithPassword()
        {
            query = @"INSERT INTO Note(Username,Title,Content,Password) VALUES(@user,@title,@content,@pass)";
            param.Clear();
            param.Add(new SqlParameter
            {
                ParameterName = "@content",
                SqlDbType = SqlDbType.NText,
                SqlValue = richTextBox1.Text
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@user",
                SqlDbType = SqlDbType.NVarChar,
                SqlValue = user
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@pass",
                SqlDbType = SqlDbType.NVarChar,
                SqlValue = newpass
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@title",
                SqlDbType = SqlDbType.NVarChar,
                SqlValue = rtbHeading.Text
            });
        }
        private void rtbHeading_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtbHeading.Text))
            {
                e.Cancel = true;
                err.SetError(rtbHeading, "Title cannot be empty");
            }
            else if (rtbHeading.Text.Length > 35)
            {
                e.Cancel = true;
                err.SetError(rtbHeading, "Title cannot be longer than 35 characters");
            }
            else
            {
                e.Cancel = false;
                err.SetError(rtbHeading, null);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string title = rtbHeading.Text;
            if (title == "")
            {
                MessageBox.Show("You need to have a note on reading mode to delete");
            }
            else
            {
                string query = "SELECT * from Note";
                using (SqlConnection sqlConnection = new SqlConnection(dbConnectionString))
                {
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(query, sqlConnection))
                    {
                        DataTable note = new DataTable();
                        sqlConnection.Open();
                        Adapter.Fill(note);
                        sqlConnection.Close();


                        for (int i = 0; i < note.Rows.Count; i++)
                        {
                            if (note.Rows[i]["Title"].ToString() == title)
                            {
                                sqlConnection.Open();
                                query = "DELETE FROM Note WHERE Title='" + title + "'";
                                SqlCommand sqlCmd = new SqlCommand(query, sqlConnection);
                                sqlCmd.CommandType = CommandType.Text;
                                sqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Note deleted successfully");
                                sqlConnection.Close();

                                MyNotes form = new MyNotes(user);
                                form.Show();
                                this.Hide();
                                form.Closed += (s, args) => Application.Exit();
                            }
                        }
                    }
                }
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            MyNotes form = new MyNotes(user);
            form.Show();
            this.Hide();
            form.Closed += (s, args) => Application.Exit();
        }
        private void LoadDropDownBtn(string heading, string body)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlConnection con = new SqlConnection(dbConnectionString);
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [Login] WHERE Username!=@userName";
                cmd.Parameters.AddWithValue("@userName", user);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> lst = new List<string>();
                while (reader.Read())
                {
                    lst.Add(reader.GetString(0));
                }
                btnDropdown.DataSource = lst;
            }
           
           
        }

        private void btnDropdown_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDropdown_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            string title = rtbHeading.Text;
            if (title == "")
            {
                MessageBox.Show("You need to have a note on reading mode to share");
            }
            else
            {
                query = @"INSERT INTO Note(Username,Title,Content) VALUES(@user,@title,@content)";
                param.Clear();
                param.Add(new SqlParameter
                {
                    ParameterName = "@content",
                    SqlDbType = SqlDbType.NText,
                    SqlValue = richTextBox1.Text
                });
                param.Add(new SqlParameter
                {
                    ParameterName = "@user",
                    SqlDbType = SqlDbType.NVarChar,
                    SqlValue = btnDropdown.SelectedValue.ToString()
                });
                param.Add(new SqlParameter
                {
                    ParameterName = "@title",
                    SqlDbType = SqlDbType.NVarChar,
                    SqlValue = rtbHeading.Text
                });

                try
                {
                    using (SqlConnection connection = new SqlConnection(dbConnectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            if (param != null)
                                command.Parameters.AddRange(param.ToArray());
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show($"Note has been shared with {btnDropdown.SelectedValue.ToString()}");
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //rtbHeading.Text, richTextBox1.Text
           
        }
    }
}
