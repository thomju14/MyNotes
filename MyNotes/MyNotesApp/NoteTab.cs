using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotesApp
{
    public partial class NoteTab : UserControl
    {
        public string title { get; set; }
        public NoteTab()
        {
            InitializeComponent();
            Title.MaximumSize = new Size(160, 80);
            Title.AutoSize = true;
        }

        private void Title_Click(object sender, EventArgs e)
        {
            
        }

        private void NoteTab_Load(object sender, EventArgs e)
        {
            Title.Text = title;
        }
    }
}
