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
            this.tableItems.Location = new System.Drawing.Point(87, 11);
            this.tableItems.Margin = new System.Windows.Forms.Padding(2);
            this.tableItems.Name = "tableItems";
            this.tableItems.ReadOnly = true;
            this.tableItems.RowHeadersWidth = 62;
            this.tableItems.RowTemplate.Height = 28;
            this.tableItems.Size = new System.Drawing.Size(655, 255);
            this.tableItems.TabIndex = 1;
            this.tableItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableItems_CellClick);
            // 
            // AltaBtn
            // 
            this.AltaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaBtn.Location = new System.Drawing.Point(207, 453);
            this.AltaBtn.Name = "AltaBtn";
            this.AltaBtn.Size = new System.Drawing.Size(112, 39);
            this.AltaBtn.TabIndex = 2;
            this.AltaBtn.Text = "Alta";
            this.AltaBtn.UseVisualStyleBackColor = true;
            // 
            // BajaBtn
            // 
            this.BajaBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaBtn.Location = new System.Drawing.Point(341, 453);
            this.BajaBtn.Name = "BajaBtn";
            this.BajaBtn.Size = new System.Drawing.Size(112, 39);
            this.BajaBtn.TabIndex = 3;
            this.BajaBtn.Text = "Baja";
            this.BajaBtn.UseVisualStyleBackColor = true;
            // 
            // ModBtn
            // 
            this.ModBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModBtn.Location = new System.Drawing.Point(478, 453);
            this.ModBtn.Name = "ModBtn";
            this.ModBtn.Size = new System.Drawing.Size(112, 39);
            this.ModBtn.TabIndex = 4;
            this.ModBtn.Text = "Modificación";
            this.ModBtn.UseVisualStyleBackColor = true;
            // 
            // IdItemTxt
            // 
            this.IdItemTxt.AutoSize = true;
            this.IdItemTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdItemTxt.Location = new System.Drawing.Point(308, 296);
            this.IdItemTxt.Name = "IdItemTxt";
            this.IdItemTxt.Size = new System.Drawing.Size(31, 21);
            this.IdItemTxt.TabIndex = 5;
            this.IdItemTxt.Text = "ID:";
            // 
            // IdInp
            // 
            this.IdInp.AcceptsTab = true;
            this.IdInp.Location = new System.Drawing.Point(345, 296);
            this.IdInp.Name = "IdInp";
            this.IdInp.ReadOnly = true;
            this.IdInp.Size = new System.Drawing.Size(100, 20);
            this.IdInp.TabIndex = 6;
            // 
            // descripInp
            // 
            this.descripInp.AcceptsTab = true;
            this.descripInp.Location = new System.Drawing.Point(345, 325);
            this.descripInp.Name = "descripInp";
            this.descripInp.ReadOnly = true;
            this.descripInp.Size = new System.Drawing.Size(100, 20);
            this.descripInp.TabIndex = 8;
            // 
            // descripTxt
            // 
            this.descripTxt.AutoSize = true;
            this.descripTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripTxt.Location = new System.Drawing.Point(235, 322);
            this.descripTxt.Name = "descripTxt";
            this.descripTxt.Size = new System.Drawing.Size(104, 21);
            this.descripTxt.TabIndex = 7;
            this.descripTxt.Text = "Descripción:";
            // 
            // precioInp
            // 
            this.precioInp.AcceptsTab = true;
            this.precioInp.Location = new System.Drawing.Point(345, 351);
            this.precioInp.Name = "precioInp";
            this.precioInp.ReadOnly = true;
            this.precioInp.Size = new System.Drawing.Size(100, 20);
            this.precioInp.TabIndex = 10;
            // 
            // precioTxt
            // 
            this.precioTxt.AutoSize = true;
            this.precioTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTxt.Location = new System.Drawing.Point(279, 348);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(61, 21);
            this.precioTxt.TabIndex = 9;
            this.precioTxt.Text = "Precio:";
            // 
            // stockInp
            // 
            this.stockInp.AcceptsTab = true;
            this.stockInp.Location = new System.Drawing.Point(345, 377);
            this.stockInp.Name = "stockInp";
            this.stockInp.ReadOnly = true;
            this.stockInp.Size = new System.Drawing.Size(100, 20);
            this.stockInp.TabIndex = 12;
            // 
            // stockTxt
            // 
            this.stockTxt.AutoSize = true;
            this.stockTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTxt.Location = new System.Drawing.Point(282, 374);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(57, 21);
            this.stockTxt.TabIndex = 11;
            this.stockTxt.Text = "Stock:";
            // 
            // idProvInp
            // 
            this.idProvInp.AcceptsTab = true;
            this.idProvInp.Location = new System.Drawing.Point(345, 406);
            this.idProvInp.Name = "idProvInp";
            this.idProvInp.ReadOnly = true;
            this.idProvInp.Size = new System.Drawing.Size(100, 20);
            this.idProvInp.TabIndex = 14;
            // 
            // IdProvTxt
            // 
            this.IdProvTxt.AutoSize = true;
            this.IdProvTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProvTxt.Location = new System.Drawing.Point(214, 403);
            this.IdProvTxt.Name = "IdProvTxt";
            this.IdProvTxt.Size = new System.Drawing.Size(127, 21);
            this.IdProvTxt.TabIndex = 13;
            this.IdProvTxt.Text = "ID (Proveedor):";
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 541);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión 2025 - Ítems";
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