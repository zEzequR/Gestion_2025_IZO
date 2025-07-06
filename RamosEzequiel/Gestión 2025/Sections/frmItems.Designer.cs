namespace Gestión_2025
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            this.idProvImg = new System.Windows.Forms.PictureBox();
            this.stockImg = new System.Windows.Forms.PictureBox();
            this.precioImg = new System.Windows.Forms.PictureBox();
            this.prodImg = new System.Windows.Forms.PictureBox();
            this.idImg = new System.Windows.Forms.PictureBox();
            this.BajaBtn = new System.Windows.Forms.Button();
            this.IdProvTxt = new System.Windows.Forms.Label();
            this.stockTxt = new System.Windows.Forms.Label();
            this.precioTxt = new System.Windows.Forms.Label();
            this.descripTxt = new System.Windows.Forms.Label();
            this.IdItemTxt = new System.Windows.Forms.Label();
            this.idProvInp = new System.Windows.Forms.TextBox();
            this.stockInp = new System.Windows.Forms.TextBox();
            this.precioInp = new System.Windows.Forms.TextBox();
            this.descripInp = new System.Windows.Forms.TextBox();
            this.IdInp = new System.Windows.Forms.TextBox();
            this.tableItems = new System.Windows.Forms.DataGridView();
            this.AltaBtn = new System.Windows.Forms.Button();
            this.ModBtn = new System.Windows.Forms.Button();
            this.divItems = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.idProvImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableItems)).BeginInit();
            this.divItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // idProvImg
            // 
            this.idProvImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idProvImg.Image = ((System.Drawing.Image)(resources.GetObject("idProvImg.Image")));
            this.idProvImg.Location = new System.Drawing.Point(49, 471);
            this.idProvImg.Name = "idProvImg";
            this.idProvImg.Size = new System.Drawing.Size(65, 52);
            this.idProvImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.idProvImg.TabIndex = 19;
            this.idProvImg.TabStop = false;
            // 
            // stockImg
            // 
            this.stockImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockImg.Image = ((System.Drawing.Image)(resources.GetObject("stockImg.Image")));
            this.stockImg.Location = new System.Drawing.Point(49, 420);
            this.stockImg.Name = "stockImg";
            this.stockImg.Size = new System.Drawing.Size(65, 45);
            this.stockImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stockImg.TabIndex = 18;
            this.stockImg.TabStop = false;
            // 
            // precioImg
            // 
            this.precioImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.precioImg.Image = ((System.Drawing.Image)(resources.GetObject("precioImg.Image")));
            this.precioImg.Location = new System.Drawing.Point(49, 367);
            this.precioImg.Name = "precioImg";
            this.precioImg.Size = new System.Drawing.Size(65, 47);
            this.precioImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.precioImg.TabIndex = 17;
            this.precioImg.TabStop = false;
            // 
            // prodImg
            // 
            this.prodImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodImg.Image = ((System.Drawing.Image)(resources.GetObject("prodImg.Image")));
            this.prodImg.Location = new System.Drawing.Point(49, 303);
            this.prodImg.Name = "prodImg";
            this.prodImg.Size = new System.Drawing.Size(65, 58);
            this.prodImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prodImg.TabIndex = 16;
            this.prodImg.TabStop = false;
            // 
            // idImg
            // 
            this.idImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idImg.Image = ((System.Drawing.Image)(resources.GetObject("idImg.Image")));
            this.idImg.Location = new System.Drawing.Point(49, 238);
            this.idImg.Name = "idImg";
            this.idImg.Size = new System.Drawing.Size(65, 59);
            this.idImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.idImg.TabIndex = 15;
            this.idImg.TabStop = false;
            // 
            // BajaBtn
            // 
            this.BajaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BajaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaBtn.Location = new System.Drawing.Point(338, 530);
            this.BajaBtn.Name = "BajaBtn";
            this.BajaBtn.Size = new System.Drawing.Size(79, 27);
            this.BajaBtn.TabIndex = 3;
            this.BajaBtn.Text = "Baja";
            this.BajaBtn.UseVisualStyleBackColor = true;
            this.BajaBtn.Click += new System.EventHandler(this.BajaBtn_Click);
            // 
            // IdProvTxt
            // 
            this.IdProvTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdProvTxt.AutoSize = true;
            this.IdProvTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProvTxt.Location = new System.Drawing.Point(314, 486);
            this.IdProvTxt.Name = "IdProvTxt";
            this.IdProvTxt.Size = new System.Drawing.Size(127, 21);
            this.IdProvTxt.TabIndex = 13;
            this.IdProvTxt.Text = "ID (Proveedor):";
            // 
            // stockTxt
            // 
            this.stockTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockTxt.AutoSize = true;
            this.stockTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTxt.Location = new System.Drawing.Point(349, 432);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(57, 21);
            this.stockTxt.TabIndex = 11;
            this.stockTxt.Text = "Stock:";
            // 
            // precioTxt
            // 
            this.precioTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.precioTxt.AutoSize = true;
            this.precioTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTxt.Location = new System.Drawing.Point(347, 380);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(61, 21);
            this.precioTxt.TabIndex = 9;
            this.precioTxt.Text = "Precio:";
            // 
            // descripTxt
            // 
            this.descripTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descripTxt.AutoSize = true;
            this.descripTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripTxt.Location = new System.Drawing.Point(325, 321);
            this.descripTxt.Name = "descripTxt";
            this.descripTxt.Size = new System.Drawing.Size(104, 21);
            this.descripTxt.TabIndex = 7;
            this.descripTxt.Text = "Descripción:";
            // 
            // IdItemTxt
            // 
            this.IdItemTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdItemTxt.AutoSize = true;
            this.IdItemTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdItemTxt.Location = new System.Drawing.Point(362, 257);
            this.IdItemTxt.Name = "IdItemTxt";
            this.IdItemTxt.Size = new System.Drawing.Size(31, 21);
            this.IdItemTxt.TabIndex = 5;
            this.IdItemTxt.Text = "ID:";
            // 
            // idProvInp
            // 
            this.idProvInp.AcceptsTab = true;
            this.idProvInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idProvInp.Location = new System.Drawing.Point(674, 487);
            this.idProvInp.Name = "idProvInp";
            this.idProvInp.Size = new System.Drawing.Size(100, 20);
            this.idProvInp.TabIndex = 14;
            // 
            // stockInp
            // 
            this.stockInp.AcceptsTab = true;
            this.stockInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockInp.Location = new System.Drawing.Point(674, 432);
            this.stockInp.Name = "stockInp";
            this.stockInp.Size = new System.Drawing.Size(100, 20);
            this.stockInp.TabIndex = 12;
            // 
            // precioInp
            // 
            this.precioInp.AcceptsTab = true;
            this.precioInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.precioInp.Location = new System.Drawing.Point(674, 380);
            this.precioInp.Name = "precioInp";
            this.precioInp.Size = new System.Drawing.Size(100, 20);
            this.precioInp.TabIndex = 10;
            // 
            // descripInp
            // 
            this.descripInp.AcceptsTab = true;
            this.descripInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descripInp.Location = new System.Drawing.Point(674, 322);
            this.descripInp.Name = "descripInp";
            this.descripInp.Size = new System.Drawing.Size(100, 20);
            this.descripInp.TabIndex = 8;
            // 
            // IdInp
            // 
            this.IdInp.AcceptsTab = true;
            this.IdInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdInp.Location = new System.Drawing.Point(674, 257);
            this.IdInp.Name = "IdInp";
            this.IdInp.Size = new System.Drawing.Size(100, 20);
            this.IdInp.TabIndex = 6;
            // 
            // tableItems
            // 
            this.tableItems.AllowUserToAddRows = false;
            this.tableItems.AllowUserToDeleteRows = false;
            this.tableItems.AllowUserToResizeColumns = false;
            this.tableItems.AllowUserToResizeRows = false;
            this.tableItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divItems.SetColumnSpan(this.tableItems, 3);
            this.tableItems.Location = new System.Drawing.Point(48, 2);
            this.tableItems.Margin = new System.Windows.Forms.Padding(2);
            this.tableItems.Name = "tableItems";
            this.tableItems.ReadOnly = true;
            this.tableItems.RowHeadersWidth = 62;
            this.tableItems.RowTemplate.Height = 28;
            this.tableItems.Size = new System.Drawing.Size(761, 231);
            this.tableItems.TabIndex = 1;
            this.tableItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableItems_CellClick);
            // 
            // AltaBtn
            // 
            this.AltaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AltaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaBtn.Location = new System.Drawing.Point(52, 530);
            this.AltaBtn.Name = "AltaBtn";
            this.AltaBtn.Size = new System.Drawing.Size(59, 27);
            this.AltaBtn.TabIndex = 2;
            this.AltaBtn.Text = "Alta";
            this.AltaBtn.UseVisualStyleBackColor = true;
            this.AltaBtn.Click += new System.EventHandler(this.AltaBtn_Click);
            // 
            // ModBtn
            // 
            this.ModBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModBtn.Location = new System.Drawing.Point(673, 530);
            this.ModBtn.Name = "ModBtn";
            this.ModBtn.Size = new System.Drawing.Size(103, 27);
            this.ModBtn.TabIndex = 4;
            this.ModBtn.Text = "Modificación";
            this.ModBtn.UseVisualStyleBackColor = true;
            this.ModBtn.Click += new System.EventHandler(this.ModBtn_Click);
            // 
            // divItems
            // 
            this.divItems.ColumnCount = 5;
            this.divItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.79592F));
            this.divItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.20408F));
            this.divItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 521F));
            this.divItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.divItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.divItems.Controls.Add(this.ModBtn, 3, 6);
            this.divItems.Controls.Add(this.AltaBtn, 1, 6);
            this.divItems.Controls.Add(this.tableItems, 1, 0);
            this.divItems.Controls.Add(this.IdInp, 3, 1);
            this.divItems.Controls.Add(this.descripInp, 3, 2);
            this.divItems.Controls.Add(this.precioInp, 3, 3);
            this.divItems.Controls.Add(this.stockInp, 3, 4);
            this.divItems.Controls.Add(this.idProvInp, 3, 5);
            this.divItems.Controls.Add(this.IdItemTxt, 2, 1);
            this.divItems.Controls.Add(this.descripTxt, 2, 2);
            this.divItems.Controls.Add(this.precioTxt, 2, 3);
            this.divItems.Controls.Add(this.stockTxt, 2, 4);
            this.divItems.Controls.Add(this.IdProvTxt, 2, 5);
            this.divItems.Controls.Add(this.BajaBtn, 2, 6);
            this.divItems.Controls.Add(this.idImg, 1, 1);
            this.divItems.Controls.Add(this.prodImg, 1, 2);
            this.divItems.Controls.Add(this.precioImg, 1, 3);
            this.divItems.Controls.Add(this.stockImg, 1, 4);
            this.divItems.Controls.Add(this.idProvImg, 1, 5);
            this.divItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divItems.Location = new System.Drawing.Point(0, 0);
            this.divItems.Name = "divItems";
            this.divItems.RowCount = 8;
            this.divItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.1457F));
            this.divItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.85431F));
            this.divItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.divItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.divItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.divItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.divItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.divItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.divItems.Size = new System.Drawing.Size(856, 580);
            this.divItems.TabIndex = 15;
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 580);
            this.Controls.Add(this.divItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión 2025 - Ítems";
            ((System.ComponentModel.ISupportInitialize)(this.idProvImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableItems)).EndInit();
            this.divItems.ResumeLayout(false);
            this.divItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox idProvImg;
        private System.Windows.Forms.PictureBox stockImg;
        private System.Windows.Forms.PictureBox precioImg;
        private System.Windows.Forms.PictureBox prodImg;
        private System.Windows.Forms.PictureBox idImg;
        private System.Windows.Forms.Button BajaBtn;
        private System.Windows.Forms.Label IdProvTxt;
        private System.Windows.Forms.Label stockTxt;
        private System.Windows.Forms.Label precioTxt;
        private System.Windows.Forms.Label descripTxt;
        private System.Windows.Forms.Label IdItemTxt;
        private System.Windows.Forms.TextBox idProvInp;
        private System.Windows.Forms.TextBox stockInp;
        private System.Windows.Forms.TextBox precioInp;
        private System.Windows.Forms.TextBox descripInp;
        private System.Windows.Forms.TextBox IdInp;
        private System.Windows.Forms.DataGridView tableItems;
        private System.Windows.Forms.TableLayoutPanel divItems;
        private System.Windows.Forms.Button ModBtn;
        private System.Windows.Forms.Button AltaBtn;
    }
}