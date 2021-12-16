
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            this.NoteList = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPasswordPro = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRead = new Bunifu.Framework.UI.BunifuThinButton2();
            this.rtbHeading = new Bunifu.UI.WinForms.BunifuTextBox();
            this.richTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlNotes = new System.Windows.Forms.Panel();
            this.btnDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnShare = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoteList)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSideBar.Controls.Add(this.NoteList);
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(159, 540);
            this.pnlSideBar.TabIndex = 3;
            // 
            // NoteList
            // 
            this.NoteList.AllowCustomTheming = false;
            this.NoteList.AllowUserToAddRows = false;
            this.NoteList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.NoteList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.NoteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NoteList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.NoteList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.NoteList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.NoteList.ColumnHeadersHeight = 40;
            this.NoteList.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.NoteList.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.NoteList.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.NoteList.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.NoteList.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.NoteList.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.NoteList.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.NoteList.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.NoteList.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.NoteList.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.NoteList.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.NoteList.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.NoteList.CurrentTheme.Name = null;
            this.NoteList.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.NoteList.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.NoteList.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.NoteList.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.NoteList.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NoteList.DefaultCellStyle = dataGridViewCellStyle3;
            this.NoteList.EnableHeadersVisualStyles = false;
            this.NoteList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.NoteList.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.NoteList.HeaderBgColor = System.Drawing.Color.Empty;
            this.NoteList.HeaderForeColor = System.Drawing.Color.White;
            this.NoteList.Location = new System.Drawing.Point(3, 2);
            this.NoteList.Name = "NoteList";
            this.NoteList.ReadOnly = true;
            this.NoteList.RowHeadersVisible = false;
            this.NoteList.RowHeadersWidth = 51;
            this.NoteList.RowTemplate.Height = 40;
            this.NoteList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NoteList.Size = new System.Drawing.Size(151, 535);
            this.NoteList.TabIndex = 6;
            this.NoteList.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnShare);
            this.panel1.Controls.Add(this.btnDropdown);
            this.panel1.Controls.Add(this.bunifuButton2);
            this.panel1.Controls.Add(this.bunifuButton1);
            this.panel1.Controls.Add(this.btnPasswordPro);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnRead);
            this.panel1.Controls.Add(this.rtbHeading);
            this.panel1.Controls.Add(this.pnlSideBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 537);
            this.panel1.TabIndex = 6;
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = true;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges1;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.IconLeft")));
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRight = null;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Cross;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton2.IdleBorderRadius = 0;
            this.bunifuButton2.IdleBorderThickness = 0;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton2.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.IdleIconLeftImage")));
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(1030, 478);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 48;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.BorderRadius = 48;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.OnIdleState.BorderRadius = 48;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.OnIdleState.IconLeftImage")));
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 48;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(50, 48);
            this.bunifuButton2.TabIndex = 9;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = true;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges2;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.IconLeft")));
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRight = null;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Cross;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleBorderRadius = 0;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.IdleIconLeftImage")));
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(956, 480);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 48;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 48;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 48;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.OnIdleState.IconLeftImage")));
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 48;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(50, 48);
            this.bunifuButton1.TabIndex = 6;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // btnPasswordPro
            // 
            this.btnPasswordPro.ActiveBorderThickness = 1;
            this.btnPasswordPro.ActiveCornerRadius = 20;
            this.btnPasswordPro.ActiveFillColor = System.Drawing.Color.Green;
            this.btnPasswordPro.ActiveForecolor = System.Drawing.Color.Brown;
            this.btnPasswordPro.ActiveLineColor = System.Drawing.Color.Navy;
            this.btnPasswordPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasswordPro.BackColor = System.Drawing.SystemColors.Control;
            this.btnPasswordPro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPasswordPro.BackgroundImage")));
            this.btnPasswordPro.ButtonText = "Password Protect";
            this.btnPasswordPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswordPro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordPro.ForeColor = System.Drawing.Color.Honeydew;
            this.btnPasswordPro.IdleBorderThickness = 1;
            this.btnPasswordPro.IdleCornerRadius = 20;
            this.btnPasswordPro.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnPasswordPro.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btnPasswordPro.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnPasswordPro.Location = new System.Drawing.Point(501, 480);
            this.btnPasswordPro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPasswordPro.Name = "btnPasswordPro";
            this.btnPasswordPro.Size = new System.Drawing.Size(150, 41);
            this.btnPasswordPro.TabIndex = 8;
            this.btnPasswordPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPasswordPro.Click += new System.EventHandler(this.btnPasswordPro_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.Green;
            this.btnSave.ActiveForecolor = System.Drawing.Color.Brown;
            this.btnSave.ActiveLineColor = System.Drawing.Color.Navy;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Honeydew;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(357, 480);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 41);
            this.btnSave.TabIndex = 7;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.ActiveBorderThickness = 1;
            this.btnRead.ActiveCornerRadius = 20;
            this.btnRead.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRead.ActiveForecolor = System.Drawing.Color.Brown;
            this.btnRead.ActiveLineColor = System.Drawing.Color.Navy;
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.BackColor = System.Drawing.SystemColors.Control;
            this.btnRead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRead.BackgroundImage")));
            this.btnRead.ButtonText = "Read";
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.Honeydew;
            this.btnRead.IdleBorderThickness = 1;
            this.btnRead.IdleCornerRadius = 20;
            this.btnRead.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnRead.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btnRead.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRead.Location = new System.Drawing.Point(195, 480);
            this.btnRead.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(135, 41);
            this.btnRead.TabIndex = 6;
            this.btnRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // rtbHeading
            // 
            this.rtbHeading.AcceptsReturn = false;
            this.rtbHeading.AcceptsTab = false;
            this.rtbHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.rtbHeading.Location = new System.Drawing.Point(164, 15);
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
            this.rtbHeading.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.rtbHeading.PasswordChar = '\0';
            this.rtbHeading.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.rtbHeading.PlaceholderText = "Title";
            this.rtbHeading.ReadOnly = false;
            this.rtbHeading.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rtbHeading.SelectedText = "";
            this.rtbHeading.SelectionLength = 0;
            this.rtbHeading.SelectionStart = 0;
            this.rtbHeading.ShortcutsEnabled = true;
            this.rtbHeading.Size = new System.Drawing.Size(916, 39);
            this.rtbHeading.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.rtbHeading.TabIndex = 5;
            this.rtbHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rtbHeading.TextMarginBottom = 0;
            this.rtbHeading.TextMarginLeft = 3;
            this.rtbHeading.TextMarginTop = 1;
            this.rtbHeading.TextPlaceholder = "Title";
            this.rtbHeading.UseSystemPasswordChar = false;
            this.rtbHeading.WordWrap = true;
            this.rtbHeading.Validating += new System.ComponentModel.CancelEventHandler(this.rtbHeading_Validating);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsReturn = false;
            this.richTextBox1.AcceptsTab = false;
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.richTextBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.richTextBox1.PasswordChar = '\0';
            this.richTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.richTextBox1.PlaceholderText = "Enter text";
            this.richTextBox1.ReadOnly = false;
            this.richTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.richTextBox1.SelectedText = "";
            this.richTextBox1.SelectionLength = 0;
            this.richTextBox1.SelectionStart = 0;
            this.richTextBox1.ShortcutsEnabled = true;
            this.richTextBox1.Size = new System.Drawing.Size(910, 396);
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
            this.pnlNotes.Size = new System.Drawing.Size(916, 403);
            this.pnlNotes.TabIndex = 5;
            // 
            // btnDropdown
            // 
            this.btnDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDropdown.BackColor = System.Drawing.Color.Transparent;
            this.btnDropdown.BackgroundColor = System.Drawing.Color.White;
            this.btnDropdown.BorderColor = System.Drawing.Color.Silver;
            this.btnDropdown.BorderRadius = 1;
            this.btnDropdown.Color = System.Drawing.Color.Silver;
            this.btnDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.btnDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.btnDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.btnDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.btnDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.btnDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.btnDropdown.FillDropDown = true;
            this.btnDropdown.FillIndicator = false;
            this.btnDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDropdown.ForeColor = System.Drawing.Color.Black;
            this.btnDropdown.FormattingEnabled = true;
            this.btnDropdown.Icon = null;
            this.btnDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.btnDropdown.IndicatorColor = System.Drawing.Color.DarkGray;
            this.btnDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.btnDropdown.IndicatorThickness = 2;
            this.btnDropdown.IsDropdownOpened = false;
            this.btnDropdown.ItemBackColor = System.Drawing.Color.White;
            this.btnDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.btnDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.btnDropdown.ItemHeight = 26;
            this.btnDropdown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.btnDropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.btnDropdown.ItemTopMargin = 3;
            this.btnDropdown.Location = new System.Drawing.Point(683, 480);
            this.btnDropdown.Name = "btnDropdown";
            this.btnDropdown.Size = new System.Drawing.Size(128, 32);
            this.btnDropdown.TabIndex = 10;
            this.btnDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.btnDropdown.TextLeftMargin = 5;
            this.btnDropdown.SelectedValueChanged += new System.EventHandler(this.btnDropdown_SelectedValueChanged);
            this.btnDropdown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDropdown_MouseClick);
            // 
            // btnShare
            // 
            this.btnShare.ActiveBorderThickness = 1;
            this.btnShare.ActiveCornerRadius = 20;
            this.btnShare.ActiveFillColor = System.Drawing.Color.Green;
            this.btnShare.ActiveForecolor = System.Drawing.Color.Brown;
            this.btnShare.ActiveLineColor = System.Drawing.Color.Navy;
            this.btnShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShare.BackColor = System.Drawing.SystemColors.Control;
            this.btnShare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShare.BackgroundImage")));
            this.btnShare.ButtonText = "Share";
            this.btnShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShare.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnShare.IdleBorderThickness = 1;
            this.btnShare.IdleCornerRadius = 20;
            this.btnShare.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnShare.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btnShare.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnShare.Location = new System.Drawing.Point(835, 478);
            this.btnShare.Margin = new System.Windows.Forms.Padding(5);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(99, 41);
            this.btnShare.TabIndex = 11;
            this.btnShare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // MyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 537);
            this.Controls.Add(this.pnlNotes);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1128, 573);
            this.Name = "MyNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyNotes_Load);
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NoteList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlNotes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView NoteList;
        private Bunifu.UI.WinForms.BunifuTextBox richTextBox1;
        private System.Windows.Forms.Panel pnlNotes;
        private Bunifu.UI.WinForms.BunifuTextBox rtbHeading;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRead;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPasswordPro;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuDropdown btnDropdown;
        private Bunifu.Framework.UI.BunifuThinButton2 btnShare;
    }
}

