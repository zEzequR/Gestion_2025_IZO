namespace Gestión_2025
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwrdInp = new System.Windows.Forms.TextBox();
            this.userInp = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.Label();
            this.passwrdTxt = new System.Windows.Forms.Label();
            this.tableUsers = new System.Windows.Forms.DataGridView();
            this.divLogin = new System.Windows.Forms.TableLayoutPanel();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.passwordImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).BeginInit();
            this.divLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImg)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divLogin.SetColumnSpan(this.loginBtn, 2);
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(366, 402);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(117, 32);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Iniciar sesión";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwrdInp
            // 
            this.passwrdInp.AcceptsTab = true;
            this.passwrdInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwrdInp.Location = new System.Drawing.Point(425, 324);
            this.passwrdInp.Name = "passwrdInp";
            this.passwrdInp.PasswordChar = '*';
            this.passwrdInp.Size = new System.Drawing.Size(138, 20);
            this.passwrdInp.TabIndex = 1;
            // 
            // userInp
            // 
            this.userInp.AcceptsTab = true;
            this.userInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userInp.Location = new System.Drawing.Point(425, 238);
            this.userInp.Name = "userInp";
            this.userInp.Size = new System.Drawing.Size(138, 20);
            this.userInp.TabIndex = 2;
            // 
            // userTxt
            // 
            this.userTxt.AutoSize = true;
            this.userTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTxt.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(286, 208);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(133, 81);
            this.userTxt.TabIndex = 3;
            this.userTxt.Text = "Usuario:";
            this.userTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwrdTxt
            // 
            this.passwrdTxt.AutoSize = true;
            this.passwrdTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwrdTxt.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdTxt.Location = new System.Drawing.Point(286, 289);
            this.passwrdTxt.Name = "passwrdTxt";
            this.passwrdTxt.Size = new System.Drawing.Size(133, 91);
            this.passwrdTxt.TabIndex = 4;
            this.passwrdTxt.Text = "Contraseña:";
            this.passwrdTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableUsers
            // 
            this.tableUsers.AllowUserToAddRows = false;
            this.tableUsers.AllowUserToDeleteRows = false;
            this.tableUsers.AllowUserToResizeColumns = false;
            this.tableUsers.AllowUserToResizeRows = false;
            this.tableUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divLogin.SetColumnSpan(this.tableUsers, 4);
            this.tableUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableUsers.Location = new System.Drawing.Point(200, 2);
            this.tableUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableUsers.MultiSelect = false;
            this.tableUsers.Name = "tableUsers";
            this.tableUsers.ReadOnly = true;
            this.tableUsers.RowHeadersWidth = 62;
            this.tableUsers.RowTemplate.Height = 28;
            this.tableUsers.Size = new System.Drawing.Size(452, 204);
            this.tableUsers.TabIndex = 5;
            this.tableUsers.TabStop = false;
            // 
            // divLogin
            // 
            this.divLogin.ColumnCount = 6;
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.14878F));
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.953161F));
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.27635F));
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.93989F));
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30445F));
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.15164F));
            this.divLogin.Controls.Add(this.userInp, 3, 1);
            this.divLogin.Controls.Add(this.userTxt, 2, 1);
            this.divLogin.Controls.Add(this.passwrdInp, 3, 2);
            this.divLogin.Controls.Add(this.passwrdTxt, 2, 2);
            this.divLogin.Controls.Add(this.loginBtn, 2, 3);
            this.divLogin.Controls.Add(this.tableUsers, 1, 0);
            this.divLogin.Controls.Add(this.userImg, 1, 1);
            this.divLogin.Controls.Add(this.passwordImg, 1, 2);
            this.divLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divLogin.Location = new System.Drawing.Point(0, 0);
            this.divLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.divLogin.Name = "divLogin";
            this.divLogin.RowCount = 4;
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.76503F));
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.75956F));
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.08197F));
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25683F));
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.divLogin.Size = new System.Drawing.Size(854, 456);
            this.divLogin.TabIndex = 6;
            // 
            // userImg
            // 
            this.userImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userImg.Image = ((System.Drawing.Image)(resources.GetObject("userImg.Image")));
            this.userImg.Location = new System.Drawing.Point(200, 210);
            this.userImg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(81, 77);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImg.TabIndex = 6;
            this.userImg.TabStop = false;
            // 
            // passwordImg
            // 
            this.passwordImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordImg.Image = ((System.Drawing.Image)(resources.GetObject("passwordImg.Image")));
            this.passwordImg.Location = new System.Drawing.Point(200, 291);
            this.passwordImg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordImg.Name = "passwordImg";
            this.passwordImg.Size = new System.Drawing.Size(81, 87);
            this.passwordImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordImg.TabIndex = 7;
            this.passwordImg.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 456);
            this.Controls.Add(this.divLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión 2025 - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).EndInit();
            this.divLogin.ResumeLayout(false);
            this.divLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwrdInp;
        private System.Windows.Forms.TextBox userInp;
        private System.Windows.Forms.Label userTxt;
        private System.Windows.Forms.Label passwrdTxt;
        private System.Windows.Forms.DataGridView tableUsers;
        private System.Windows.Forms.TableLayoutPanel divLogin;
        private System.Windows.Forms.PictureBox userImg;
        private System.Windows.Forms.PictureBox passwordImg;
    }
}