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
            this.tableItems = new System.Windows.Forms.DataGridView();
            this.AltaBtn = new System.Windows.Forms.Button();
            this.BajaBtn = new System.Windows.Forms.Button();
            this.ModBtn = new System.Windows.Forms.Button();
            this.IdItemTxt = new System.Windows.Forms.Label();
            this.IdInp = new System.Windows.Forms.TextBox();
            this.descripInp = new System.Windows.Forms.TextBox();
            this.descripTxt = new System.Windows.Forms.Label();
            this.precioInp = new System.Windows.Forms.TextBox();
            this.precioTxt = new System.Windows.Forms.Label();
            this.stockInp = new System.Windows.Forms.TextBox();
            this.stockTxt = new System.Windows.Forms.Label();
            this.idProvInp = new System.Windows.Forms.TextBox();
            this.IdProvTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tableItems
            // 
            this.tableItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableItems.Location = new System.Drawing.Point(130, 17);
            this.tableItems.Name = "tableItems";
            this.tableItems.ReadOnly = true;
            this.tableItems.RowHeadersWidth = 62;
            this.tableItems.RowTemplate.Height = 28;
            this.tableItems.Size = new System.Drawing.Size(982, 392);
            this.tableItems.TabIndex = 1;
            this.tableItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableItems_CellClick);
            // 
            // AltaBtn
            // 
            this.AltaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaBtn.Location = new System.Drawing.Point(310, 697);
            this.AltaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AltaBtn.Name = "AltaBtn";
            this.AltaBtn.Size = new System.Drawing.Size(168, 60);
            this.AltaBtn.TabIndex = 2;
            this.AltaBtn.Text = "Alta";
            this.AltaBtn.UseVisualStyleBackColor = true;
            this.AltaBtn.Click += new System.EventHandler(this.AltaBtn_Click);
            // 
            // BajaBtn
            // 
            this.BajaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaBtn.Location = new System.Drawing.Point(512, 697);
            this.BajaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BajaBtn.Name = "BajaBtn";
            this.BajaBtn.Size = new System.Drawing.Size(168, 60);
            this.BajaBtn.TabIndex = 3;
            this.BajaBtn.Text = "Baja";
            this.BajaBtn.UseVisualStyleBackColor = true;
            this.BajaBtn.Click += new System.EventHandler(this.BajaBtn_Click);
            // 
            // ModBtn
            // 
            this.ModBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModBtn.Location = new System.Drawing.Point(717, 697);
            this.ModBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModBtn.Name = "ModBtn";
            this.ModBtn.Size = new System.Drawing.Size(168, 60);
            this.ModBtn.TabIndex = 4;
            this.ModBtn.Text = "Modificación";
            this.ModBtn.UseVisualStyleBackColor = true;
            this.ModBtn.Click += new System.EventHandler(this.ModBtn_Click);
            // 
            // IdItemTxt
            // 
            this.IdItemTxt.AutoSize = true;
            this.IdItemTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdItemTxt.Location = new System.Drawing.Point(462, 455);
            this.IdItemTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdItemTxt.Name = "IdItemTxt";
            this.IdItemTxt.Size = new System.Drawing.Size(44, 30);
            this.IdItemTxt.TabIndex = 5;
            this.IdItemTxt.Text = "ID:";
            // 
            // IdInp
            // 
            this.IdInp.AcceptsTab = true;
            this.IdInp.Location = new System.Drawing.Point(518, 455);
            this.IdInp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IdInp.Name = "IdInp";
            this.IdInp.Size = new System.Drawing.Size(148, 26);
            this.IdInp.TabIndex = 6;
            // 
            // descripInp
            // 
            this.descripInp.AcceptsTab = true;
            this.descripInp.Location = new System.Drawing.Point(518, 500);
            this.descripInp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripInp.Name = "descripInp";
            this.descripInp.Size = new System.Drawing.Size(148, 26);
            this.descripInp.TabIndex = 8;
            // 
            // descripTxt
            // 
            this.descripTxt.AutoSize = true;
            this.descripTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripTxt.Location = new System.Drawing.Point(352, 495);
            this.descripTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descripTxt.Name = "descripTxt";
            this.descripTxt.Size = new System.Drawing.Size(162, 30);
            this.descripTxt.TabIndex = 7;
            this.descripTxt.Text = "Descripción:";
            // 
            // precioInp
            // 
            this.precioInp.AcceptsTab = true;
            this.precioInp.Location = new System.Drawing.Point(518, 540);
            this.precioInp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.precioInp.Name = "precioInp";
            this.precioInp.Size = new System.Drawing.Size(148, 26);
            this.precioInp.TabIndex = 10;
            // 
            // precioTxt
            // 
            this.precioTxt.AutoSize = true;
            this.precioTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTxt.Location = new System.Drawing.Point(418, 535);
            this.precioTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(95, 30);
            this.precioTxt.TabIndex = 9;
            this.precioTxt.Text = "Precio:";
            // 
            // stockInp
            // 
            this.stockInp.AcceptsTab = true;
            this.stockInp.Location = new System.Drawing.Point(518, 580);
            this.stockInp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stockInp.Name = "stockInp";
            this.stockInp.Size = new System.Drawing.Size(148, 26);
            this.stockInp.TabIndex = 12;
            // 
            // stockTxt
            // 
            this.stockTxt.AutoSize = true;
            this.stockTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTxt.Location = new System.Drawing.Point(423, 575);
            this.stockTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(84, 30);
            this.stockTxt.TabIndex = 11;
            this.stockTxt.Text = "Stock:";
            // 
            // idProvInp
            // 
            this.idProvInp.AcceptsTab = true;
            this.idProvInp.Location = new System.Drawing.Point(518, 625);
            this.idProvInp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idProvInp.Name = "idProvInp";
            this.idProvInp.Size = new System.Drawing.Size(148, 26);
            this.idProvInp.TabIndex = 14;
            // 
            // IdProvTxt
            // 
            this.IdProvTxt.AutoSize = true;
            this.IdProvTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProvTxt.Location = new System.Drawing.Point(321, 620);
            this.IdProvTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdProvTxt.Name = "IdProvTxt";
            this.IdProvTxt.Size = new System.Drawing.Size(191, 30);
            this.IdProvTxt.TabIndex = 13;
            this.IdProvTxt.Text = "ID (Proveedor):";
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 832);
            this.Controls.Add(this.idProvInp);
            this.Controls.Add(this.IdProvTxt);
            this.Controls.Add(this.stockInp);
            this.Controls.Add(this.stockTxt);
            this.Controls.Add(this.precioInp);
            this.Controls.Add(this.precioTxt);
            this.Controls.Add(this.descripInp);
            this.Controls.Add(this.descripTxt);
            this.Controls.Add(this.IdInp);
            this.Controls.Add(this.IdItemTxt);
            this.Controls.Add(this.ModBtn);
            this.Controls.Add(this.BajaBtn);
            this.Controls.Add(this.AltaBtn);
            this.Controls.Add(this.tableItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión 2025 - Ítems";
            this.Load += new System.EventHandler(this.frmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableItems;
        private System.Windows.Forms.Button AltaBtn;
        private System.Windows.Forms.Button BajaBtn;
        private System.Windows.Forms.Button ModBtn;
        private System.Windows.Forms.Label IdItemTxt;
        private System.Windows.Forms.TextBox IdInp;
        private System.Windows.Forms.TextBox descripInp;
        private System.Windows.Forms.Label descripTxt;
        private System.Windows.Forms.TextBox precioInp;
        private System.Windows.Forms.Label precioTxt;
        private System.Windows.Forms.TextBox stockInp;
        private System.Windows.Forms.Label stockTxt;
        private System.Windows.Forms.TextBox idProvInp;
        private System.Windows.Forms.Label IdProvTxt;
    }
}