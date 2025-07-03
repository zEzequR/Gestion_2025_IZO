using Gestión_2025.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_2025
{
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
            MostrarItems(null, null);
        }

        //public void frmItems_Load(object sender, EventArgs e)
        //{
        //    Procedures procedure = new Procedures();
        //    procedure.MostrarDatos("EXEC spu_mostrar_items", tableItems, new List<string> { "ID", "Descripción", "Precio", "Precio", "Stock", "ID (Proveedor)" });
        //}

        private void MostrarItems(object sender, EventArgs e)
        {
            List<string> Items = new List<string>();
            Items.Add("ID");
            Items.Add("Descripción");
            Items.Add("Precio");
            Items.Add("Stock");
            Items.Add("ID (Proveedor)");
            Conexion conexion = new Conexion();
            var da = new SqlDataAdapter("EXEC spu_mostrar_items", conexion.Connect());
            var dt = new DataTable();
            da.Fill(dt);
            System.Diagnostics.Debug.WriteLine(dt);
            tableItems.DataSource = dt;

            foreach (DataGridViewColumn column in tableItems.Columns)
            {
                tableItems.Columns[column.Index].HeaderText = Items[column.Index];
            }
        }

        private void tableItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdInp.Text = tableItems.Rows[e.RowIndex].Cells[0].Value.ToString();
            descripInp.Text = tableItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            precioInp.Text = tableItems.Rows[e.RowIndex].Cells[2].Value.ToString();
            stockInp.Text = tableItems.Rows[e.RowIndex].Cells[3].Value.ToString();
            idProvInp.Text = tableItems.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
