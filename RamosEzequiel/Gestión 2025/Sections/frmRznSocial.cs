using Gestión_2025.Classes;
using Gestión_2025.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_2025
{
    public partial class frmRznSocial : Form
    {
        public frmRznSocial()
        {
            InitializeComponent();
            Procedures procedure = new Procedures();
            procedure.MostrarDatos("spu_mostrar_prov", tableProveedores, new List<string> { "ID", "Razón Social" });
        }

        //public void frmRznSocial_Load(object sender, EventArgs e)
        //{
        //    Procedures procedure = new Procedures();
        //    procedure.MostrarDatos("EXEC spu_mostrar_prov", tableProveedores, new List<string> { "ID", "Razón Social" });
        //}

        //private void MostrarProveedores(object sender, EventArgs e)
        //{
        //    List<string> proveedores = new List<string>();
        //    proveedores.Add("ID");
        //    proveedores.Add("Razón Social");
        //    Conexion conexion = new Conexion();
        //    var da = new SqlDataAdapter("EXEC spu_mostrar_prov", conexion.Connect());
        //    var dt = new DataTable();
        //    da.Fill(dt);
        //    System.Diagnostics.Debug.WriteLine(dt);
        //    tableProveedores.DataSource = dt;

        //    foreach (DataGridViewColumn column in tableProveedores.Columns)
        //    {
        //        tableProveedores.Columns[column.Index].HeaderText = proveedores[column.Index];
        //    }
        //}

        private void tableProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdInp.Text = tableProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            rznSocialInp.Text = tableProveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BajaBtn_Click(object sender, EventArgs e)
        {

            Proveedor proveedor = new Proveedor
            {
                id_proveedor = Convert.ToInt32(IdInp.Text.Trim())
            };
            List<object> parametros = new List<object>();
            List<string> sqlParameters = new List<string>();
            sqlParameters.Add("@id_proveedor");
            parametros.Add(proveedor.id_proveedor);
            Procedures procedures = new Procedures();
            procedures.EliminarDatos("spu_baja_prov", sqlParameters, parametros);


            //Proveedor proveedor = new Proveedor
            //{
            //    id_proveedor = Convert.ToInt32(IdInp.Text.Trim())
            //};
            //SqlCommand cmd = new SqlCommand("spu_baja_prov", new Conexion().Connect());
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@id_proveedor", proveedor.id_proveedor);
            //cmd.ExecuteReader();
        }

        private void ModBtn_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor
            {
                id_proveedor = Convert.ToInt32(IdInp.Text.Trim()),
                rzn_social = rznSocialInp.Text.Trim()
            };
            List<object> parametros = new List<object>();
            List<string> sqlParameters = new List<string>();
            sqlParameters.Add("@id_rznsocial");
            sqlParameters.Add("@nombre_rznsocial");
            parametros.Add(proveedor.id_proveedor);
            parametros.Add(proveedor.rzn_social);
            Procedures procedures = new Procedures();
            procedures.ActualizarDatos("spu_modificar_rznsocial", sqlParameters, parametros);


            //Proveedor proveedor = new Proveedor
            //{
            //    id_proveedor = Convert.ToInt32(IdInp.Text.Trim()),
            //    rzn_social = rznSocialInp.Text.Trim()
            //};
            //SqlCommand cmd = new SqlCommand("spu_cambiar_prov", new Conexion().Connect());
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@idprov", proveedor.id_proveedor);
            //cmd.Parameters.AddWithValue("@rzn_social", proveedor.rzn_social);
            //cmd.ExecuteReader();
        }

        private void AltaBtn_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor
            {
                id_proveedor = Convert.ToInt32(IdInp.Text.Trim()),
                rzn_social = rznSocialInp.Text.Trim()
            };
            List<object> parametros = new List<object>();
            List<string> sqlParameters = new List<string>();
            sqlParameters.Add("@id_proveedor");
            sqlParameters.Add("@razon_social");
            parametros.Add(proveedor.id_proveedor);
            parametros.Add(proveedor.rzn_social);

            Procedures procedures = new Procedures();
            procedures.AgregarDatos("spu_alta_prov", sqlParameters, parametros);


            //Proveedor proveedor = new Proveedor
            //{
            //    id_proveedor = Convert.ToInt32(IdInp.Text.Trim()),
            //    rzn_social = rznSocialInp.Text.Trim()
            //};
            //SqlCommand cmd = new SqlCommand("spu_alta_prov", new Conexion().Connect());
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@id_proveedor", proveedor.id_proveedor);
            //cmd.Parameters.AddWithValue("@razon_social", proveedor.rzn_social);
            //cmd.ExecuteReader();
        }
    }
}