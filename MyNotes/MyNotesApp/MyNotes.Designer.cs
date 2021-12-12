
namespace MyNotesApp
{
    partial class MyNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyNotes));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.dataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbHeading = new Bunifu.UI.WinForms.BunifuTextBox();
            this.richTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlNotes = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSideBar.Controls.Add(this.dataGridView1);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(159, 630);
            this.pnlSideBar.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowCustomTheming = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.Name = null;
            this.dataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(151, 623);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.rtbHeading);
            this.panel1.Controls.Add(this.pnlSideBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 630);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rtbHeading
            // 
            this.rtbHeading.AcceptsReturn = false;
            this.rtbHeading.AcceptsTab = false;
            this.rtbHeading.AnimationSpeed = 200;
            this.rtbHeading.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.rtbHeading.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.rtbHeading.AutoSizeHeight = true;
            this.rtbHeading.BackColor = System.Drawing.Color.Transparent;
            this.rtbHeading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtbHeading.BackgroundImage")));
            this.rtbHeading.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.rtbHeading.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rtbHeading.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.rtbHeading.BorderColorIdle = System.Drawing.Color.Silver;
            this.rtbHeading.BorderRadius = 1;
            this.rtbHeading.BorderThickness = 1;
            this.rtbHeading.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.rtbHeading.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbHeading.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.rtbHeading.DefaultText = "";
            this.rtbHeading.FillColor = System.Drawing.Color.White;
            this.rtbHeading.HideSelection = true;
            this.rtbHeading.IconLeft = null;
            this.rtbHeading.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbHeading.IconPadding = 10;
            this.rtbHeading.IconRight = null;
            this.rtbHeading.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbHeading.Lines = new string[0];
            this.rtbHeading.Location = new System.Drawing.Point(165, 12);
            this.rtbHeading.MaxLength = 32767;
            this.rtbHeading.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtbHeading.Modified = false;
            this.rtbHeading.Multiline = false;
            this.rtbHeading.Name = "rtbHeading";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.rtbHeading.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.rtbHeading.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.rtbHeading.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.rtbHeading.OnIdleState = stateProperties4;
            this.rtbHeading.Padding = new System.Windows.Forms.Padding(3);
            this.rtbHeading.PasswordChar = '\0';
            this.rtbHeading.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.rtbHeading.PlaceholderText = "Title";
            this.rtbHeading.ReadOnly = false;
            this.rtbHeading.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rtbHeading.SelectedText = "";
            this.rtbHeading.SelectionLength = 0;
            this.rtbHeading.SelectionStart = 0;
            this.rtbHeading.ShortcutsEnabled = true;
            this.rtbHeading.Size = new System.Drawing.Size(841, 39);
            this.rtbHeading.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.rtbHeading.TabIndex = 5;
            this.rtbHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rtbHeading.TextMarginBottom = 0;
            this.rtbHeading.TextMarginLeft = 3;
            this.rtbHeading.TextMarginTop = 1;
            this.rtbHeading.TextPlaceholder = "Title";
            this.rtbHeading.UseSystemPasswordChar = false;
            this.rtbHeading.WordWrap = true;
            this.rtbHeading.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbHeading_KeyDown);
            this.rtbHeading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbHeading_KeyPress);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsReturn = false;
            this.richTextBox1.AcceptsTab = false;
            this.richTextBox1.AnimationSpeed = 200;
            this.richTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.richTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.richTextBox1.AutoSizeHeight = true;
            this.richTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.richTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("richTextBox1.BackgroundImage")));
            this.richTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.richTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.richTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.richTextBox1.BorderColorIdle = System.Drawing.Color.Silver;
            this.richTextBox1.BorderRadius = 1;
            this.richTextBox1.BorderThickness = 1;
            this.richTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.richTextBox1.DefaultText = "";
            this.richTextBox1.FillColor = System.Drawing.Color.White;
            this.richTextBox1.HideSelection = true;
            this.richTextBox1.IconLeft = null;
            this.richTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.IconPadding = 10;
            this.richTextBox1.IconRight = null;
            this.richTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Lines = new string[0];
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.MaxLength = 32767;
            this.richTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.richTextBox1.Modified = false;
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.richTextBox1.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.richTextBox1.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.richTextBox1.OnIdleState = stateProperties8;
            this.richTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.richTextBox1.PasswordChar = '\0';
            this.richTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.richTextBox1.PlaceholderText = "Enter text";
            this.richTextBox1.ReadOnly = false;
            this.richTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.richTextBox1.SelectedText = "";
            this.richTextBox1.SelectionLength = 0;
            this.richTextBox1.SelectionStart = 0;
            this.richTextBox1.ShortcutsEnabled = true;
            this.richTextBox1.Size = new System.Drawing.Size(838, 523);
            this.richTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.richTextBox1.TextMarginBottom = 0;
            this.richTextBox1.TextMarginLeft = 3;
            this.richTextBox1.TextMarginTop = 1;
            this.richTextBox1.TextPlaceholder = "Enter text";
            this.richTextBox1.UseSystemPasswordChar = false;
            this.richTextBox1.WordWrap = true;
            // 
            // pnlNotes
            // 
            this.pnlNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNotes.Controls.Add(this.richTextBox1);
            this.pnlNotes.Location = new System.Drawing.Point(165, 60);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(841, 529);
            this.pnlNotes.TabIndex = 5;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Brown;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Navy;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Read";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(330, 585);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Green;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Brown;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Navy;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Save";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(653, 585);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton22.TabIndex = 7;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 630);
            this.Controls.Add(this.pnlNotes);
            this.Controls.Add(this.panel1);
            this.Name = "MyNotes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyNotes_Load);
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlNotes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridView1;
        private Bunifu.UI.WinForms.BunifuTextBox richTextBox1;
        private System.Windows.Forms.Panel pnlNotes;
        private Bunifu.UI.WinForms.BunifuTextBox rtbHeading;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}

