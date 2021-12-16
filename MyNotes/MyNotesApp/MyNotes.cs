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
        string dbConnectionString = "";
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

                    height += 105;
                }
            }
        }

        private void Note_Click(object sender, EventArgs e)
        {
            readTitle = ((NoteTab)sender).title;
            ((NoteTab)sender).BackColor = Color.Blue;
            foreach(NoteTab note in Notes)
            {
                if(note.title!=readTitle)
                {
                    note.BackColor = Color.White;
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
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
                    }
                }
            }
            foreach (NoteTab note in Notes)
            {
                note.BackColor = Color.White;
            }
        }
    }
}
