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
            this.divRznSocial = new System.Windows.Forms.TableLayoutPanel();
            this.idImg = new System.Windows.Forms.PictureBox();
            this.rznSocialImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableProveedores)).BeginInit();
            this.divRznSocial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rznSocialImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tableProveedores
            // 
            this.tableProveedores.AllowUserToAddRows = false;
            this.tableProveedores.AllowUserToDeleteRows = false;
            this.tableProveedores.AllowUserToResizeColumns = false;
            this.tableProveedores.AllowUserToResizeRows = false;
            this.tableProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableProveedores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divRznSocial.SetColumnSpan(this.tableProveedores, 4);
            this.tableProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableProveedores.Location = new System.Drawing.Point(166, 2);
            this.tableProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.tableProveedores.Name = "tableProveedores";
            this.tableProveedores.ReadOnly = true;
            this.tableProveedores.RowHeadersWidth = 62;
            this.tableProveedores.RowTemplate.Height = 28;
            this.tableProveedores.Size = new System.Drawing.Size(618, 269);
            this.tableProveedores.TabIndex = 0;
            this.tableProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableProveedores_CellClick);
            // 
            // rznSocialInp
            // 
            this.rznSocialInp.AcceptsTab = true;
            this.rznSocialInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rznSocialInp.Location = new System.Drawing.Point(671, 416);
            this.rznSocialInp.Name = "rznSocialInp";
            this.rznSocialInp.Size = new System.Drawing.Size(109, 20);
            this.rznSocialInp.TabIndex = 21;
            // 
            // rznSocialTxt
            // 
            this.rznSocialTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rznSocialTxt.AutoSize = true;
            this.divRznSocial.SetColumnSpan(this.rznSocialTxt, 2);
            this.rznSocialTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rznSocialTxt.Location = new System.Drawing.Point(413, 416);
            this.rznSocialTxt.Name = "rznSocialTxt";
            this.rznSocialTxt.Size = new System.Drawing.Size(115, 21);
            this.rznSocialTxt.TabIndex = 20;
            this.rznSocialTxt.Text = "Razón Social: ";
            // 
            // IdInp
            // 
            this.IdInp.AcceptsTab = true;
            this.IdInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdInp.Location = new System.Drawing.Point(671, 317);
            this.IdInp.Name = "IdInp";
            this.IdInp.Size = new System.Drawing.Size(109, 20);
            this.IdInp.TabIndex = 19;
            // 
            // IdTxt
            // 
            this.IdTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdTxt.AutoSize = true;
            this.divRznSocial.SetColumnSpan(this.IdTxt, 2);
            this.IdTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTxt.Location = new System.Drawing.Point(455, 317);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(31, 21);
            this.IdTxt.TabIndex = 18;
            this.IdTxt.Text = "ID:";
            // 
            // ModBtn
            // 
            this.ModBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divRznSocial.SetColumnSpan(this.ModBtn, 2);
            this.ModBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModBtn.Location = new System.Drawing.Point(751, 474);
            this.ModBtn.Name = "ModBtn";
            this.ModBtn.Size = new System.Drawing.Size(112, 37);
            this.ModBtn.TabIndex = 17;
            this.ModBtn.Text = "Modificación";
            this.ModBtn.UseVisualStyleBackColor = true;
            this.ModBtn.Click += new System.EventHandler(this.ModBtn_Click);
            // 
            // BajaBtn
            // 
            this.BajaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divRznSocial.SetColumnSpan(this.BajaBtn, 2);
            this.BajaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaBtn.Location = new System.Drawing.Point(415, 474);
            this.BajaBtn.Name = "BajaBtn";
            this.BajaBtn.Size = new System.Drawing.Size(112, 37);
            this.BajaBtn.TabIndex = 16;
            this.BajaBtn.Text = "Baja";
            this.BajaBtn.UseVisualStyleBackColor = true;
            this.BajaBtn.Click += new System.EventHandler(this.BajaBtn_Click);
            // 
            // AltaBtn
            // 
            this.AltaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divRznSocial.SetColumnSpan(this.AltaBtn, 2);
            this.AltaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaBtn.Location = new System.Drawing.Point(90, 474);
            this.AltaBtn.Name = "AltaBtn";
            this.AltaBtn.Size = new System.Drawing.Size(97, 37);
            this.AltaBtn.TabIndex = 15;
            this.AltaBtn.Text = "Alta";
            this.AltaBtn.UseVisualStyleBackColor = true;
            this.AltaBtn.Click += new System.EventHandler(this.AltaBtn_Click);
            // 
            // divRznSocial
            // 
            this.divRznSocial.ColumnCount = 6;
            this.divRznSocial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.26316F));
            this.divRznSocial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.89474F));
            this.divRznSocial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.21053F));
            this.divRznSocial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.73684F));
            this.divRznSocial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.8421F));
            this.divRznSocial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.05263F));
            this.divRznSocial.Controls.Add(this.IdInp, 4, 1);
            this.divRznSocial.Controls.Add(this.rznSocialInp, 4, 2);
            this.divRznSocial.Controls.Add(this.BajaBtn, 2, 3);
            this.divRznSocial.Controls.Add(this.tableProveedores, 1, 0);
            this.divRznSocial.Controls.Add(this.rznSocialTxt, 2, 2);
            this.divRznSocial.Controls.Add(this.IdTxt, 2, 1);
            this.divRznSocial.Controls.Add(this.idImg, 1, 1);
            this.divRznSocial.Controls.Add(this.rznSocialImg, 1, 2);
            this.divRznSocial.Controls.Add(this.AltaBtn, 0, 3);
            this.divRznSocial.Controls.Add(this.ModBtn, 4, 3);
            this.divRznSocial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divRznSocial.Location = new System.Drawing.Point(0, 0);
            this.divRznSocial.Name = "divRznSocial";
            this.divRznSocial.RowCount = 5;
            this.divRznSocial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.46597F));
            this.divRznSocial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.53403F));
            this.divRznSocial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.divRznSocial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.divRznSocial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.divRznSocial.Size = new System.Drawing.Size(950, 574);
            this.divRznSocial.TabIndex = 22;
            // 
            // idImg
            // 
            this.idImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idImg.Image = ((System.Drawing.Image)(resources.GetObject("idImg.Image")));
            this.idImg.Location = new System.Drawing.Point(167, 276);
            this.idImg.Name = "idImg";
            this.idImg.Size = new System.Drawing.Size(107, 103);
            this.idImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.idImg.TabIndex = 22;
            this.idImg.TabStop = false;
            // 
            // rznSocialImg
            // 
            this.rznSocialImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rznSocialImg.Image = ((System.Drawing.Image)(resources.GetObject("rznSocialImg.Image")));
            this.rznSocialImg.Location = new System.Drawing.Point(167, 385);
            this.rznSocialImg.Name = "rznSocialImg";
            this.rznSocialImg.Size = new System.Drawing.Size(107, 83);
            this.rznSocialImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rznSocialImg.TabIndex = 23;
            this.rznSocialImg.TabStop = false;
            // 
            // frmRznSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 574);
            this.Controls.Add(this.divRznSocial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRznSocial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión 2025 - Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.tableProveedores)).EndInit();
            this.divRznSocial.ResumeLayout(false);
            this.divRznSocial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rznSocialImg)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel divRznSocial;
        private System.Windows.Forms.PictureBox idImg;
        private System.Windows.Forms.PictureBox rznSocialImg;
    }
}