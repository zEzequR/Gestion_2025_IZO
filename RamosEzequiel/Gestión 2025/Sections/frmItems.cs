using Gestión_2025.Classes;
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
            Procedures procedure = new Procedures();
            procedure.MostrarDatos("spu_mostrar_items", tableItems, new List<string> { "ID", "Descripción", "Precio", "Stock", "ID (Proveedor)" });
        }

        //public void frmItems_Load(object sender, EventArgs e)
        //{
        //    Procedures procedure = new Procedures();
        //    procedure.MostrarDatos("EXEC spu_mostrar_items", tableItems, new List<string> { "ID", "Descripción", "Precio", "Precio", "Stock", "ID (Proveedor)" });
        //}

        //private void MostrarItems(object sender, EventArgs e)
        //{
            
        //    List<string> Items = new List<string>();
        //    Items.Add("ID");
        //    Items.Add("Descripción");
        //    Items.Add("Precio");
        //    Items.Add("Stock");
        //    Items.Add("ID (Proveedor)");
        //    Conexion conexion = new Conexion();
        //    var da = new SqlDataAdapter("EXEC spu_mostrar_items", conexion.Connect());
        //    var dt = new DataTable();
        //    da.Fill(dt);
        //    System.Diagnostics.Debug.WriteLine(dt);
        //    tableItems.DataSource = dt;

        //    foreach (DataGridViewColumn column in tableItems.Columns)
        //    {
        //        tableItems.Columns[column.Index].HeaderText = Items[column.Index];
        //    }
        //}

        private void tableItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdInp.Text = tableItems.Rows[e.RowIndex].Cells[0].Value.ToString();
            descripInp.Text = tableItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            precioInp.Text = tableItems.Rows[e.RowIndex].Cells[2].Value.ToString();
            stockInp.Text = tableItems.Rows[e.RowIndex].Cells[3].Value.ToString();
            idProvInp.Text = tableItems.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void AltaBtn_Click(object sender, EventArgs e)
        {
            Item items = new Item
            {
                id_items = Convert.ToInt32(IdInp.Text.Trim()),
                descripcion = descripInp.Text.Trim(),
                precio = Convert.ToDecimal(precioInp.Text.Trim()),
                stock = Convert.ToDecimal(stockInp.Text.Trim()),
                id_proveedor = Convert.ToInt32(idProvInp.Text.Trim())
            };

            List<object> parametros = new List<object>();
            List<string> sqlParameters = new List<string>();
            sqlParameters.Add("@id_items");
            sqlParameters.Add("@descipcion");
            sqlParameters.Add("@precio");
            sqlParameters.Add("@stock");
            sqlParameters.Add("@id_proveedor");
            parametros.Add(items.id_items);
            parametros.Add(items.descripcion);
            parametros.Add(items.precio);
            parametros.Add(items.stock);
            parametros.Add(items.id_proveedor);
            Procedures procedures = new Procedures();
            procedures.AgregarDatos("spu_alta_items", sqlParameters, parametros);
        }

        private void BajaBtn_Click(object sender, EventArgs e)
        {
            Item items = new Item
            {
                id_items = Convert.ToInt32(IdInp.Text.Trim()),
                descripcion = descripInp.Text.Trim(),
                precio = Convert.ToDecimal(precioInp.Text.Trim()),
                stock = Convert.ToDecimal(stockInp.Text.Trim()),
                id_proveedor = Convert.ToInt32(idProvInp.Text.Trim())
            };

            List<object> parametros = new List<object>();
            List<string> sqlParameters = new List<string>();
            sqlParameters.Add("@id_item");
            parametros.Add(items.id_items);
            Procedures procedures = new Procedures();
            procedures.EliminarDatos("spu_baja_items", sqlParameters, parametros);

        }

        private void ModBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
