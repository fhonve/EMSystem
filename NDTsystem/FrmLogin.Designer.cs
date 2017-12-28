namespace EMSystem
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            this.BtnLogin = new MetroFramework.Controls.MetroButton();
            this.ChkRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.TxtBoxUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(332, 174);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ChkRememberMe
            // 
            this.ChkRememberMe.AutoSize = true;
            this.ChkRememberMe.Location = new System.Drawing.Point(179, 155);
            this.ChkRememberMe.Name = "ChkRememberMe";
            this.ChkRememberMe.Size = new System.Drawing.Size(94, 17);
            this.ChkRememberMe.TabIndex = 2;
            this.ChkRememberMe.Text = "Remember me";
            this.ChkRememberMe.UseVisualStyleBackColor = true;
            this.ChkRememberMe.CheckedChanged += new System.EventHandler(this.ChkRememberMe_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EMSystem.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(23, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TxtBoxPassword
            // 
            // 
            // 
            // 
            this.TxtBoxPassword.CustomButton.Image = null;
            this.TxtBoxPassword.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.TxtBoxPassword.CustomButton.Name = "";
            this.TxtBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBoxPassword.CustomButton.TabIndex = 1;
            this.TxtBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBoxPassword.CustomButton.UseSelectable = true;
            this.TxtBoxPassword.CustomButton.Visible = false;
            this.TxtBoxPassword.DisplayIcon = true;
            this.TxtBoxPassword.Icon = global::EMSystem.Properties.Resources.password;
            this.TxtBoxPassword.Lines = new string[0];
            this.TxtBoxPassword.Location = new System.Drawing.Point(179, 126);
            this.TxtBoxPassword.MaxLength = 32767;
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.PasswordChar = '●';
            //this.TxtBoxPassword.WaterMark = "Password";
            this.TxtBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBoxPassword.SelectedText = "";
            this.TxtBoxPassword.SelectionLength = 0;
            this.TxtBoxPassword.SelectionStart = 0;
            this.TxtBoxPassword.ShortcutsEnabled = true;
            this.TxtBoxPassword.Size = new System.Drawing.Size(228, 23);
            this.TxtBoxPassword.TabIndex = 1;
            this.TxtBoxPassword.UseSelectable = true;
            this.TxtBoxPassword.UseSystemPasswordChar = true;
            this.TxtBoxPassword.WaterMark = "Password";
            this.TxtBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtBoxUserName
            // 
            // 
            // 
            // 
            this.TxtBoxUserName.CustomButton.Image = null;
            this.TxtBoxUserName.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.TxtBoxUserName.CustomButton.Name = "";
            this.TxtBoxUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBoxUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBoxUserName.CustomButton.TabIndex = 1;
            this.TxtBoxUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBoxUserName.CustomButton.UseSelectable = true;
            this.TxtBoxUserName.CustomButton.Visible = false;
            this.TxtBoxUserName.DisplayIcon = true;
            this.TxtBoxUserName.Icon = global::EMSystem.Properties.Resources.user;
            this.TxtBoxUserName.Lines = new string[0];
            this.TxtBoxUserName.Location = new System.Drawing.Point(179, 97);
            this.TxtBoxUserName.MaxLength = 32767;
            this.TxtBoxUserName.Name = "TxtBoxUserName";
            this.TxtBoxUserName.PasswordChar = '\0';
            //this.TxtBoxUserName.PromptText = "Username";
            this.TxtBoxUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBoxUserName.SelectedText = "";
            this.TxtBoxUserName.SelectionLength = 0;
            this.TxtBoxUserName.SelectionStart = 0;
            this.TxtBoxUserName.ShortcutsEnabled = true;
            this.TxtBoxUserName.Size = new System.Drawing.Size(228, 23);
            this.TxtBoxUserName.TabIndex = 0;
            this.TxtBoxUserName.UseSelectable = true;
            this.TxtBoxUserName.WaterMark = "Username";
            this.TxtBoxUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBoxUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 227);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ChkRememberMe);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtBoxPassword);
            this.Controls.Add(this.TxtBoxUserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Resizable = false;
            this.Text = " Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtBoxUserName;
        private MetroFramework.Controls.MetroTextBox TxtBoxPassword;
        private MetroFramework.Controls.MetroButton BtnLogin;
        private System.Windows.Forms.CheckBox ChkRememberMe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

