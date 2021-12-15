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

namespace MyNotesApp    
{
    public partial class MyNotes : Form
    {
        string dbConnectionString = "";
        DataTable noteData = new DataTable();
        string user;
        public MyNotes(string username)
        {
            try
            {
                InitializeComponent();
                this.Size = new Size(1200, 800);
                user = username;
                pnlNotes.AutoSize = true;
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
            using (SqlConnection sqlConnection= new SqlConnection(dbConnectionString))
            {
                using (SqlDataAdapter Adapter=new SqlDataAdapter(query,sqlConnection))
                {
                    sqlConnection.Open();
                    Adapter.Fill(noteData);
                    sqlConnection.Close();

                    for(int i=0;i<noteData.Rows.Count;i++)
                    {
                        if(noteData.Rows[i]["Username"].ToString()==user)
                        {
                           // AddNoteToGrid(noteData.Rows[i]["SerialNo"]);
                        }
                    }
                }
            }
        }
    }
}
