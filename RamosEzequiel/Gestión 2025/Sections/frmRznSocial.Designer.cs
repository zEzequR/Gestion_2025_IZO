namespace Gestión_2025
{
    partial class frmRznSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRznSocial));
            this.tableProveedores = new System.Windows.Forms.DataGridView();
            this.rznSocialInp = new System.Windows.Forms.TextBox();
            this.rznSocialTxt = new System.Windows.Forms.Label();
            this.IdInp = new System.Windows.Forms.TextBox();
            this.IdTxt = new System.Windows.Forms.Label();
            this.ModBtn = new System.Windows.Forms.Button();
            this.BajaBtn = new System.Windows.Forms.Button();
            this.AltaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tableProveedores
            // 
            this.tableProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableProveedores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableProveedores.Location = new System.Drawing.Point(74, 11);
            this.tableProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.tableProveedores.Name = "tableProveedores";
            this.tableProveedores.ReadOnly = true;
            this.tableProveedores.RowHeadersWidth = 62;
            this.tableProveedores.RowTemplate.Height = 28;
            this.tableProveedores.Size = new System.Drawing.Size(780, 304);
            this.tableProveedores.TabIndex = 0;
            this.tableProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableProveedores_CellClick);
            // 
            // rznSocialInp
            // 
            this.rznSocialInp.AcceptsTab = true;
            this.rznSocialInp.Location = new System.Drawing.Point(412, 386);
            this.rznSocialInp.Name = "rznSocialInp";
            this.rznSocialInp.Size = new System.Drawing.Size(100, 20);
            this.rznSocialInp.TabIndex = 21;
            // 
            // rznSocialTxt
            // 
            this.rznSocialTxt.AutoSize = true;
            this.rznSocialTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rznSocialTxt.Location = new System.Drawing.Point(291, 386);
            this.rznSocialTxt.Name = "rznSocialTxt";
            this.rznSocialTxt.Size = new System.Drawing.Size(115, 21);
            this.rznSocialTxt.TabIndex = 20;
            this.rznSocialTxt.Text = "Razón Social: ";
            // 
            // IdInp
            // 
            this.IdInp.AcceptsTab = true;
            this.IdInp.Location = new System.Drawing.Point(412, 357);
            this.IdInp.Name = "IdInp";
            this.IdInp.Size = new System.Drawing.Size(100, 20);
            this.IdInp.TabIndex = 19;
            // 
            // IdTxt
            // 
            this.IdTxt.AutoSize = true;
            this.IdTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTxt.Location = new System.Drawing.Point(369, 357);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(31, 21);
            this.IdTxt.TabIndex = 18;
            this.IdTxt.Text = "ID:";
            // 
            // ModBtn
            // 
            this.ModBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModBtn.Location = new System.Drawing.Point(541, 435);
            this.ModBtn.Name = "ModBtn";
            this.ModBtn.Size = new System.Drawing.Size(112, 39);
            this.ModBtn.TabIndex = 17;
            this.ModBtn.Text = "Modificación";
            this.ModBtn.UseVisualStyleBackColor = true;
            this.ModBtn.Click += new System.EventHandler(this.ModBtn_Click);
            // 
            // BajaBtn
            // 
            this.BajaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaBtn.Location = new System.Drawing.Point(404, 435);
            this.BajaBtn.Name = "BajaBtn";
            this.BajaBtn.Size = new System.Drawing.Size(112, 39);
            this.BajaBtn.TabIndex = 16;
            this.BajaBtn.Text = "Baja";
            this.BajaBtn.UseVisualStyleBackColor = true;
            this.BajaBtn.Click += new System.EventHandler(this.BajaBtn_Click);
            // 
            // AltaBtn
            // 
            this.AltaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaBtn.Location = new System.Drawing.Point(270, 435);
            this.AltaBtn.Name = "AltaBtn";
            this.AltaBtn.Size = new System.Drawing.Size(112, 39);
            this.AltaBtn.TabIndex = 15;
            this.AltaBtn.Text = "Alta";
            this.AltaBtn.UseVisualStyleBackColor = true;
            this.AltaBtn.Click += new System.EventHandler(this.AltaBtn_Click);
            // 
            // frmRznSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 574);
            this.Controls.Add(this.rznSocialInp);
            this.Controls.Add(this.rznSocialTxt);
            this.Controls.Add(this.IdInp);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.ModBtn);
            this.Controls.Add(this.BajaBtn);
            this.Controls.Add(this.AltaBtn);
            this.Controls.Add(this.tableProveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRznSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión 2025 - Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.tableProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableProveedores;
        private System.Windows.Forms.TextBox rznSocialInp;
        private System.Windows.Forms.Label rznSocialTxt;
        private System.Windows.Forms.TextBox IdInp;
        private System.Windows.Forms.Label IdTxt;
        private System.Windows.Forms.Button ModBtn;
        private System.Windows.Forms.Button BajaBtn;
        private System.Windows.Forms.Button AltaBtn;
    }
}