
namespace MyNotesApp
{
    partial class LoginPage
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
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.textbox_Password = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.Navy;
            this.LblUsername.Location = new System.Drawing.Point(257, 237);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(136, 33);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Username";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.Navy;
            this.LblPassword.Location = new System.Drawing.Point(257, 306);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(131, 33);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(352, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "MyNotes";
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TextBox_Username.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Username.Location = new System.Drawing.Point(461, 236);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(268, 33);
            this.TextBox_Username.TabIndex = 4;
            // 
            // textbox_Password
            // 
            this.textbox_Password.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textbox_Password.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Password.Location = new System.Drawing.Point(461, 305);
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.Size = new System.Drawing.Size(268, 33);
            this.textbox_Password.TabIndex = 5;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Gold;
            this.BtnLogin.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Navy;
            this.BtnLogin.Location = new System.Drawing.Point(368, 409);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(273, 51);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(362, 509);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 33);
            this.lblMessage.TabIndex = 7;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1040, 658);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.textbox_Password);
            this.Controls.Add(this.TextBox_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.TextBox textbox_Password;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label lblMessage;
    }
}