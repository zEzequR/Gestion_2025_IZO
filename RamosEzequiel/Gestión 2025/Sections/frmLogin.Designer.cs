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
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(324, 404);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(122, 37);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Iniciar sesión";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwrdInp
            // 
            this.passwrdInp.AcceptsTab = true;
            this.passwrdInp.Location = new System.Drawing.Point(324, 358);
            this.passwrdInp.Name = "passwrdInp";
            this.passwrdInp.PasswordChar = '*';
            this.passwrdInp.Size = new System.Drawing.Size(154, 20);
            this.passwrdInp.TabIndex = 1;
            // 
            // userInp
            // 
            this.userInp.AcceptsTab = true;
            this.userInp.Location = new System.Drawing.Point(324, 289);
            this.userInp.Name = "userInp";
            this.userInp.Size = new System.Drawing.Size(154, 20);
            this.userInp.TabIndex = 2;
            // 
            // userTxt
            // 
            this.userTxt.AutoSize = true;
            this.userTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(259, 293);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(75, 21);
            this.userTxt.TabIndex = 3;
            this.userTxt.Text = "Usuario:";
            // 
            // passwrdTxt
            // 
            this.passwrdTxt.AutoSize = true;
            this.passwrdTxt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdTxt.Location = new System.Drawing.Point(244, 362);
            this.passwrdTxt.Name = "passwrdTxt";
            this.passwrdTxt.Size = new System.Drawing.Size(114, 21);
            this.passwrdTxt.TabIndex = 4;
            this.passwrdTxt.Text = "Contraseña:";
            // 
            // tableUsers
            // 
            this.tableUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUsers.Location = new System.Drawing.Point(72, 29);
            this.tableUsers.Margin = new System.Windows.Forms.Padding(2);
            this.tableUsers.Name = "tableUsers";
            this.tableUsers.ReadOnly = true;
            this.tableUsers.RowHeadersWidth = 62;
            this.tableUsers.RowTemplate.Height = 28;
            this.tableUsers.Size = new System.Drawing.Size(655, 255);
            this.tableUsers.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 476);
            this.Controls.Add(this.tableUsers);
            this.Controls.Add(this.passwrdTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.userInp);
            this.Controls.Add(this.passwrdInp);
            this.Controls.Add(this.loginBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwrdInp;
        private System.Windows.Forms.TextBox userInp;
        private System.Windows.Forms.Label userTxt;
        private System.Windows.Forms.Label passwrdTxt;
        private System.Windows.Forms.DataGridView tableUsers;
    }
}